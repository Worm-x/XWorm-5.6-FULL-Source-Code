using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace XWorm;

public class GListView0 : ListView
{
	public class clsListviewSorter : IComparer
	{
		private int m_ColumnNumber;

		private SortOrder m_SortOrder;

		public clsListviewSorter(int column_number, SortOrder sort_order)
		{
			m_ColumnNumber = column_number;
			m_SortOrder = sort_order;
		}

		public int Compare(object x, object y)
		{
			ListViewItem listViewItem = (ListViewItem)x;
			ListViewItem listViewItem2 = (ListViewItem)y;
			string text = ((listViewItem.SubItems.Count > m_ColumnNumber) ? listViewItem.SubItems[m_ColumnNumber].Text : "");
			string text2 = ((listViewItem2.SubItems.Count > m_ColumnNumber) ? listViewItem2.SubItems[m_ColumnNumber].Text : "");
			if (m_SortOrder == SortOrder.Ascending)
			{
				if (Versioned.IsNumeric(text) & Versioned.IsNumeric(text2))
				{
					return Conversion.Val(text).CompareTo(Conversion.Val(text2));
				}
				if (Information.IsDate(text) & Information.IsDate(text2))
				{
					return DateTime.Parse(text).CompareTo(DateTime.Parse(text2));
				}
				return string.Compare(text, text2);
			}
			if (Versioned.IsNumeric(text) & Versioned.IsNumeric(text2))
			{
				return Conversion.Val(text2).CompareTo(Conversion.Val(text));
			}
			if (Information.IsDate(text) & Information.IsDate(text2))
			{
				return DateTime.Parse(text2).CompareTo(DateTime.Parse(text));
			}
			return string.Compare(text2, text);
		}
	}

	internal object object_0;

	private ColumnHeader columnHeader_0;

	public GListView0()
	{
		base.ColumnClick += GListView0_ColumnClick;
		AllowDrop = false;
		Font = new Font("arial", 8f, FontStyle.Bold);
		Dock = DockStyle.Fill;
		base.FullRowSelect = true;
		base.View = View.Details;
		SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value: true);
		SetStyle(ControlStyles.EnableNotifyMessage, value: true);
	}

	protected override void OnNotifyMessage(Message m)
	{
	}

	public void GListView0_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		ColumnHeader columnHeader = (ColumnHeader)NewLateBinding.LateGet(sender, null, "Columns", new object[1] { e.Column }, null, null, null);
		SortOrder sortOrder;
		if (columnHeader_0 == null)
		{
			sortOrder = SortOrder.Ascending;
		}
		else
		{
			sortOrder = ((!columnHeader.Equals(columnHeader_0)) ? SortOrder.Ascending : ((!columnHeader_0.Text.StartsWith("+")) ? SortOrder.Ascending : SortOrder.Descending));
			columnHeader_0.Text = columnHeader_0.Text.Substring(1);
		}
		columnHeader_0 = columnHeader;
		if (sortOrder == SortOrder.Ascending)
		{
			columnHeader_0.Text = "+" + columnHeader_0.Text;
		}
		else
		{
			columnHeader_0.Text = "-" + columnHeader_0.Text;
		}
		if (sender != null)
		{
			NewLateBinding.LateSet(sender, null, "ListViewItemSorter", new object[1]
			{
				new clsListviewSorter(e.Column, sortOrder)
			}, null, null);
			NewLateBinding.LateCall(sender, null, "Sort", new object[0], null, null, null, IgnoreReturn: true);
			NewLateBinding.LateSet(sender, null, "ListViewItemSorter", new object[1], null, null);
		}
	}
}