/*
 * Date: 6/2/2020
 * Time: 8:01 PM
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
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace point_of_sales_v3
{
	public partial class CtrlProdA : UserControl
	{
		ComponentResourceManager resources = new ComponentResourceManager(typeof(CtrlProdA));
		
		CtrlProdB [] cpb = new CtrlProdB[400];
		
		RadioButton obj;
		
		DataGridView dtgrid;
		
		public CtrlProdA()
		{
			InitializeComponent();
			Load += CtrlProdA_Load;
		}
		
		void CtrlProdA_Load(object sender, EventArgs e)
		{
			int index = 0;
			MySqlCon msc = new MySqlCon();
			msc.Query = "SELECT * FROM tbl_tables";
			foreach (var items in msc.BtnOnly) {
				cpb[index] = new CtrlProdB();
				cpb[index].btnBack.Click += btnBack_Click;
				cpb[index].btnCharge.Click += btnSend_Click;
				cpb[index].btnPrint.Click += btnPay_Click;
				cpb[index].dataItms.RowsAdded += Mark_Yellow;
				cpb[index].dataItms.RowsRemoved += Mark_Yellow;
				items.Image = ((Image)(resources.GetObject("icons8-table-80")));
				items.Name = index.ToString();
				items.Click += items_Click;
				pTbl.Controls.Add(items);
				index++;
			}
			RBtnCustom btnTakeOut = new RBtnCustom(((Image)(resources.GetObject("icons8-shopping-bag-80"))), ContentAlignment.MiddleCenter, new Padding(5, 5, 5, 5), new Size(100, 100), "Take-Out", ContentAlignment.BottomCenter);
			pTbl.Controls.Add(btnTakeOut);
			btnTakeOut.Click += btnTakeOut_Click;
		}

		void items_Click(object sender, EventArgs e)
		{
			pBody.Controls.Clear();
			RadioButton b = (RadioButton)sender;
			int index = Convert.ToInt32(b.Name);
			cpb[index].Dock = DockStyle.Fill;
			pBody.Controls.Add(cpb[index]);
			obj = b;
		}

		void btnBack_Click(object sender, EventArgs e) 
		{
			if (dtgrid.Rows.Count > 0) {
				obj.BackColor = Color.FromArgb(247, 242, 83);
				toolTip1.SetToolTip(obj, "Transaction is in process");
			}
			else {
				obj.BackColor = Color.White;
				toolTip1.SetToolTip(obj, "");
			}
		}
		
		void btnSend_Click(object sender, EventArgs e)
		{
			obj.BackColor = Color.FromArgb(175, 255, 175);
			toolTip1.SetToolTip(obj, "Waiting for payment");
		}

		void btnPay_Click(object sender, EventArgs e)
		{
			if (cpb[Convert.ToInt32(obj.Name)].Paid) {
				obj.BackColor = Color.White;
				toolTip1.SetToolTip(obj, "");
			}
		}

		void Mark_Yellow(object sender, EventArgs e)
		{
			dtgrid = (DataGridView)sender;
			if (dtgrid.Rows.Count > 0) {
				obj.BackColor = Color.FromArgb(247, 242, 83);
				toolTip1.SetToolTip(obj, "Transaction is in process");
			}
			else {
				obj.BackColor = Color.White;
				toolTip1.SetToolTip(obj, "");
			}
		}
		
		void btnTakeOut_Click(object sender, EventArgs e)
		{
		}
	}
}
