using System;
using System.Linq;

namespace XWorm;

public class GClass20
{
	public static byte[] smethod_0(byte[] bytes_0, int int_0)
	{
		byte[] second = new byte[1] { (byte)int_0 };
		bytes_0 = bytes_0.Concat(second).ToArray();
		int num = smethod_2(bytes_0);
		int num2 = smethod_1(bytes_0);
		int num3 = 0;
		uint num4 = 1u;
		byte[] array = new byte[num];
		int[] array2 = new int[4096];
		byte[] array3 = new byte[4096];
		int num5 = num - 6 - 4 - 1;
		int num6 = -1;
		uint num7 = 0u;
		int num8 = (bytes_0[0] >> 2) & 3;
		if (num8 != 1)
		{
		}
		if ((bytes_0[0] & 1) == 1)
		{
			while (true)
			{
				if (num4 == 1)
				{
					num4 = (uint)(bytes_0[num2] | (bytes_0[num2 + 1] << 8) | (bytes_0[num2 + 2] << 16) | (bytes_0[num2 + 3] << 24));
					num2 += 4;
					if (num3 <= num5)
					{
						num7 = (uint)((num8 == 1) ? (bytes_0[num2] | (bytes_0[num2 + 1] << 8) | (bytes_0[num2 + 2] << 16)) : (bytes_0[num2] | (bytes_0[num2 + 1] << 8) | (bytes_0[num2 + 2] << 16) | (bytes_0[num2 + 3] << 24)));
					}
				}
				if ((num4 & 1) == 1)
				{
					num4 >>= 1;
					uint num10;
					uint num11;
					if (num8 != 1)
					{
						uint num9;
						if ((num7 & 3) == 0)
						{
							num9 = (num7 & 0xFF) >> 2;
							num10 = 3u;
							num2++;
						}
						else if ((num7 & 2u) != 0)
						{
							if ((num7 & 1) == 0)
							{
								num9 = (num7 & 0xFFFF) >> 6;
								num10 = ((num7 >> 2) & 0xF) + 3;
								num2 += 2;
							}
							else if ((num7 & 0x7F) != 3)
							{
								num9 = (num7 >> 7) & 0x1FFFFu;
								num10 = ((num7 >> 2) & 0x1F) + 2;
								num2 += 3;
							}
							else
							{
								num9 = num7 >> 15;
								num10 = ((num7 >> 7) & 0xFF) + 3;
								num2 += 4;
							}
						}
						else
						{
							num9 = (num7 & 0xFFFF) >> 2;
							num10 = 3u;
							num2 += 2;
						}
						num11 = (uint)(num3 - num9);
					}
					else
					{
						int num12 = ((int)num7 >> 4) & 0xFFF;
						num11 = (uint)array2[num12];
						if ((num7 & 0xF) == 0)
						{
							num10 = bytes_0[num2 + 2];
							num2 += 3;
						}
						else
						{
							num10 = (num7 & 0xF) + 2;
							num2 += 2;
						}
					}
					array[num3] = array[num11];
					array[num3 + 1] = array[num11 + 1];
					array[num3 + 2] = array[num11 + 2];
					for (int i = 3; i < num10; i++)
					{
						array[num3 + i] = array[num11 + i];
					}
					num3 += (int)num10;
					if (num8 == 1)
					{
						num7 = (uint)(array[num6 + 1] | (array[num6 + 2] << 8) | (array[num6 + 3] << 16));
						while (num6 < num3 - num10)
						{
							num6++;
							int num12 = (int)(((num7 >> 12) ^ num7) & 0xFFF);
							array2[num12] = num6;
							array3[num12] = 1;
							num7 = (uint)(((num7 >> 8) & 0xFFFFu) | (array[num6 + 3] << 16));
						}
						num7 = (uint)(bytes_0[num2] | (bytes_0[num2 + 1] << 8) | (bytes_0[num2 + 2] << 16));
					}
					else
					{
						num7 = (uint)(bytes_0[num2] | (bytes_0[num2 + 1] << 8) | (bytes_0[num2 + 2] << 16) | (bytes_0[num2 + 3] << 24));
					}
					num6 = num3 - 1;
					continue;
				}
				if (num3 > num5)
				{
					break;
				}
				array[num3] = bytes_0[num2];
				num3++;
				num2++;
				num4 >>= 1;
				if (num8 != 1)
				{
					num7 = (uint)(((num7 >> 8) & 0xFFFFu) | (bytes_0[num2 + 2] << 16) | (bytes_0[num2 + 3] << 24));
					continue;
				}
				while (num6 < num3 - 3)
				{
					num6++;
					int num13 = array[num6] | (array[num6 + 1] << 8) | (array[num6 + 2] << 16);
					int num12 = ((num13 >> 12) ^ num13) & 0xFFF;
					array2[num12] = num6;
					array3[num12] = 1;
				}
				num7 = (uint)(((num7 >> 8) & 0xFFFFu) | (bytes_0[num2 + 2] << 16));
			}
			while (num3 <= num - 1)
			{
				if (num4 == 1)
				{
					num2 += 4;
					num4 = 2147483648u;
				}
				array[num3] = bytes_0[num2];
				num3++;
				num2++;
				num4 >>= 1;
			}
			return array;
		}
		byte[] array4 = new byte[num];
		Array.Copy(bytes_0, smethod_1(bytes_0), array4, 0, num);
		return array4;
	}

	public static int smethod_1(byte[] bytes_0)
	{
		if ((bytes_0[0] & 2) != 2)
		{
			return 3;
		}
		return 9;
	}

	public static int smethod_2(byte[] bytes_0)
	{
		if (smethod_1(bytes_0) == 9)
		{
			return bytes_0[5] | (bytes_0[6] << 8) | (bytes_0[7] << 16) | (bytes_0[8] << 24);
		}
		return bytes_0[2];
	}
}