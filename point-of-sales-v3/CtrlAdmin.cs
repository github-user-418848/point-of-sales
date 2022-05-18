/*
 * Date: 6/2/2020
 * Time: 11:57 PM
 *
 * +-----------------+
 * |  Hello friend   |
 * +-----------------+
 *    \                     
 *     \   ,__,             
 *      \  (oo)____  
 *         (__)    )\
 *            ||--|| *
 */
using System;
using System.Data.Odbc;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace point_of_sales_v3
{
	public partial class CtrlAdmin : UserControl
	{
		public CtrlAdmin()
		{
			InitializeComponent();
			Load += CtrlAdmin_Load;
			rbtnCtgry.Click += rbtnCtgry_Click;
			rbtnProd.Click += rbtnProd_Click;
			rbtnTbl.Click += rbtnTbl_Click;
			btnClr.Click += btnClr_Click;
			txtSearch.TextChanged += txtSearch_TextChanged;
		}
		
		string db = string.Empty;

		void CtrlAdmin_Load(object sender, EventArgs e)
		{
			MySqlCon msc = new MySqlCon();
			msc.Query = "SELECT * FROM tbl_product";
			msc.DispTbl(dataTbl);
			db = "tbl_product";
		}

		void rbtnCtgry_Click(object sender, EventArgs e)
		{
			MySqlCon msc = new MySqlCon();
			msc.Query = string.Format("SELECT * FROM tbl_category WHERE Name LIKE '%{0}%'", txtSearch.Text);
			msc.DispTbl(dataTbl);
			db = "tbl_category";
		}

		void rbtnProd_Click(object sender, EventArgs e)
		{
			MySqlCon msc = new MySqlCon();
			msc.Query = string.Format("SELECT * FROM tbl_product WHERE Name LIKE '%{0}%'", txtSearch.Text);
			msc.DispTbl(dataTbl);
			db = "tbl_product";
		}

		void rbtnTbl_Click(object sender, EventArgs e)
		{
			MySqlCon msc = new MySqlCon();
			msc.Query = string.Format("SELECT * FROM tbl_tables WHERE Name LIKE '%{0}%'", txtSearch.Text);
			msc.DispTbl(dataTbl);
			db = "tbl_tables";
		}

		void btnClr_Click(object sender, EventArgs e)
		{
			txtSearch.Clear();
		}
		
		void txtSearch_TextChanged(object sender, EventArgs e)
		{
			MySqlCon msc = new MySqlCon();
			msc.Query = string.Format("SELECT * FROM {0} WHERE Name LIKE '%{1}%'", db, txtSearch.Text);
			msc.DispTbl(dataTbl);
		}
	}
}
