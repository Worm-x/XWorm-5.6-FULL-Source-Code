using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;

namespace XWorm;

public class GClass1
{
	[SuppressUnmanagedCodeSecurity]
	private class NativeMethods
	{
		[DllImport("kernel32")]
		public static extern IntPtr BeginUpdateResource(string fileName, [MarshalAs(UnmanagedType.Bool)] bool deleteExistingResources);

		[DllImport("kernel32")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool UpdateResource(IntPtr hUpdate, IntPtr type, IntPtr name, short language, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] byte[] data, int dataSize);

		[DllImport("kernel32")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool EndUpdateResource(IntPtr hUpdate, [MarshalAs(UnmanagedType.Bool)] bool discard);
	}

	private struct ICONDIR
	{
		public ushort Reserved;

		public ushort Type;

		public ushort Count;
	}

	private struct ICONDIRENTRY
	{
		public byte Width;

		public byte Height;

		public byte ColorCount;

		public byte Reserved;

		public ushort Planes;

		public ushort BitCount;

		public int BytesInRes;

		public int ImageOffset;
	}

	private struct BITMAPINFOHEADER
	{
		public uint Size;

		public int Width;

		public int Height;

		public ushort Planes;

		public ushort BitCount;

		public uint Compression;

		public uint SizeImage;

		public int XPelsPerMeter;

		public int YPelsPerMeter;

		public uint ClrUsed;

		public uint ClrImportant;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	private struct GRPICONDIRENTRY
	{
		public byte Width;

		public byte Height;

		public byte ColorCount;

		public byte Reserved;

		public ushort Planes;

		public ushort BitCount;

		public int BytesInRes;

		public ushort ID;
	}

	private class IconFile
	{
		private ICONDIR iconDir;

		private ICONDIRENTRY[] iconEntry;

		private byte[][] iconImage;

		public int ImageCount => iconDir.Count;

		public byte[] ImageData(int index)
		{
			if (index >= 0 && index < iconImage.Length)
			{
				return iconImage[index];
			}
			else
			{
				throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
			}
		}

		private IconFile()
		{
			iconDir = default(ICONDIR);
		}

		public static IconFile FromFile(string filename)
		{
			IconFile iconFile = new IconFile();
			byte[] array = File.ReadAllBytes(filename);
			GCHandle gCHandle = GCHandle.Alloc(array, GCHandleType.Pinned);
			iconFile.iconDir = (ICONDIR)Marshal.PtrToStructure(gCHandle.AddrOfPinnedObject(), typeof(ICONDIR));
			checked
			{
				iconFile.iconEntry = new ICONDIRENTRY[iconFile.iconDir.Count - 1 + 1];
				iconFile.iconImage = new byte[iconFile.iconDir.Count - 1 + 1][];
				int num = Marshal.SizeOf((object)iconFile.iconDir);
				Type typeFromHandle = typeof(ICONDIRENTRY);
				int num2 = Marshal.SizeOf(typeFromHandle);
				int num3 = iconFile.iconDir.Count - 1;
				for (int i = 0; i <= num3; i++)
				{
					ICONDIRENTRY iCONDIRENTRY = (ICONDIRENTRY)Marshal.PtrToStructure(new IntPtr(gCHandle.AddrOfPinnedObject().ToInt64() + num), typeFromHandle);
					iconFile.iconEntry[i] = iCONDIRENTRY;
					iconFile.iconImage[i] = new byte[iCONDIRENTRY.BytesInRes - 1 + 1];
					Buffer.BlockCopy(array, iCONDIRENTRY.ImageOffset, iconFile.iconImage[i], 0, iCONDIRENTRY.BytesInRes);
					num += num2;
				}
				gCHandle.Free();
				return iconFile;
			}
		}

		public byte[] CreateIconGroupData(uint iconBaseID)
		{
			checked
			{
				byte[] array = new byte[Marshal.SizeOf(typeof(ICONDIR)) + Marshal.SizeOf(typeof(GRPICONDIRENTRY)) * ImageCount - 1 + 1];
				GCHandle gCHandle = GCHandle.Alloc(array, GCHandleType.Pinned);
				Marshal.StructureToPtr((object)iconDir, gCHandle.AddrOfPinnedObject(), fDeleteOld: false);
				int num = Marshal.SizeOf((object)iconDir);
				int num2 = ImageCount - 1;
				for (int i = 0; i <= num2; i++)
				{
					GRPICONDIRENTRY gRPICONDIRENTRY = default(GRPICONDIRENTRY);
					BITMAPINFOHEADER bITMAPINFOHEADER = default(BITMAPINFOHEADER);
					GCHandle gCHandle2 = GCHandle.Alloc(bITMAPINFOHEADER, GCHandleType.Pinned);
					Marshal.Copy(ImageData(i), 0, gCHandle2.AddrOfPinnedObject(), Marshal.SizeOf(typeof(BITMAPINFOHEADER)));
					gCHandle2.Free();
					gRPICONDIRENTRY.Width = iconEntry[i].Width;
					gRPICONDIRENTRY.Height = iconEntry[i].Height;
					gRPICONDIRENTRY.ColorCount = iconEntry[i].ColorCount;
					gRPICONDIRENTRY.Reserved = iconEntry[i].Reserved;
					gRPICONDIRENTRY.Planes = bITMAPINFOHEADER.Planes;
					gRPICONDIRENTRY.BitCount = bITMAPINFOHEADER.BitCount;
					gRPICONDIRENTRY.BytesInRes = iconEntry[i].BytesInRes;
					gRPICONDIRENTRY.ID = (ushort)(iconBaseID + i);
					Marshal.StructureToPtr((object)gRPICONDIRENTRY, new IntPtr(gCHandle.AddrOfPinnedObject().ToInt64() + num), fDeleteOld: false);
					num += Marshal.SizeOf(typeof(GRPICONDIRENTRY));
				}
				gCHandle.Free();
				return array;
			}
		}
	}

	public static void smethod_0(string exeFileName, string iconFileName)
	{
		smethod_1(exeFileName, iconFileName, 1u, 1u);
	}

	public static void smethod_1(string exeFileName, string iconFileName, uint iconGroupID, uint iconBaseID)
	{
		IconFile iconFile = IconFile.FromFile(iconFileName);
		IntPtr hUpdate = NativeMethods.BeginUpdateResource(exeFileName, deleteExistingResources: false);
		byte[] array = iconFile.CreateIconGroupData(iconBaseID);
		NativeMethods.UpdateResource(hUpdate, new IntPtr(14L), new IntPtr(iconGroupID), 0, array, array.Length);
		checked
		{
			int num = iconFile.ImageCount - 1;
			for (int i = 0; i <= num; i++)
			{
				byte[] array2 = iconFile.ImageData(i);
				NativeMethods.UpdateResource(hUpdate, new IntPtr(3L), new IntPtr(iconBaseID + i), 0, array2, array2.Length);
			}
			NativeMethods.EndUpdateResource(hUpdate, discard: false);
		}
	}
}