/*
 * Date: 6/2/2020
 * Time: 7:38 PM
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
using System.Drawing;
using System.Windows.Forms;

namespace point_of_sales_v3
{
	public partial class MainForm : Form
	{
		CtrlProdA cpa = new CtrlProdA();
		
		public MainForm()
		{
			InitializeComponent();
			tmr.Tick += tmr_Tick;
			Load += MainForm_Load;
			rPos.Click += rPos_Click;
			rAdmin.Click += rAdmin_Click;
			rReports.Click += rReports_Click;
			btnLogout.Click += btnLogout_Click;
		}

		void tmr_Tick(object sender, EventArgs e)
		{
			lblDateTime.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy hh:mm:ss tt");
		}

		void MainForm_Load(object sender, EventArgs e)
		{
//			CtrlLogin fl = new CtrlLogin();
//			fl.btnLogin.Click += btnLogin_Click;
//			CtrlProdSales fl = new CtrlProdSales();
//			fl.Dock = DockStyle.Fill;
//			pBody.Controls.Add(fl);
			rPos_Click(sender, e);
		}

		void rPos_Click(object sender, EventArgs e)
		{
			pBody.Controls.Clear();
			cpa.Dock = DockStyle.Fill;
			pBody.Controls.Add(cpa);
		}

		void rAdmin_Click(object sender, EventArgs e)
		{
			pBody.Controls.Clear();
			CtrlAdmin ca = new CtrlAdmin();
			ca.Dock = DockStyle.Fill;
			pBody.Controls.Add(ca);
		}

		void rReports_Click(object sender, EventArgs e)
		{
			pBody.Controls.Clear();
			CtrlSalesReprt csr = new CtrlSalesReprt();
//			CtrlProdReprt csr = new CtrlProdReprt();
			csr.Dock = DockStyle.Fill;
			pBody.Controls.Add(csr);
		}

		void btnLogout_Click(object sender, EventArgs e)
		{
			
		}
		
		void btnLogin_Click(object sender, EventArgs e)
		{
			pBody.Controls.Clear();
			cpa = new CtrlProdA();
			cpa.Dock = DockStyle.Fill;
			pBody.Controls.Add(cpa);
		}
	}
}
