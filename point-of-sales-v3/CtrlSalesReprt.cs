/*
 * Date: 6/20/2020
 * Time: 10:57 PM
 *
 *.o88o.                               o8o                .
 *888 `"                               `"'              .o8
 *o888oo   .oooo.o  .ooooo.   .ooooo.  oooo   .ooooo.  .o888oo oooo    ooo
 *888    d88(  "8 d88' `88b d88' `"Y8 `888  d88' `88b   888    `88.  .8'
 *888    `"Y88b.  888   888 888        888  888ooo888   888     `88..8'
 *888    o.  )88b 888   888 888   .o8  888  888    .o   888 .    `888'
 *o888o   8""888P' `Y8bod8P' `Y8bod8P' o888o `Y8bod8P'   "888"      d8'
 *                                                               .o...P'
 *                                                               `XER0'
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace point_of_sales_v3
{
	public partial class CtrlSalesReprt : UserControl
	{
		string [] months = { "", "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sept", "Oct", "Nov", "Dec" };
		
		int indxM = Convert.ToInt32(DateTime.Now.ToString("MM")), indxY = Convert.ToInt32(DateTime.Now.ToString("yyyy"));
		
		public CtrlSalesReprt()
		{
			InitializeComponent();
			Load += CtrlProdSales_Load;
			rDaily.Click += rDaily_Click;
			rMonthly.Click += rMonthly_Click;
			rYrly.Click += rYrly_Click;
			btnMDec.Click += btnMDec_Click;
			btnMInc.Click += btnMInc_Click;
			btnYrDec.Click += btnYrDec_Click;
			btnYrInc.Click += btnYrInc_Click;
			btnBack.Click += btnBack_Click;
			btnPrnt.Click += btnPrnt_Click;
			btnShow.Click += btnShow_Click;
			btnBack2.Click += btnBack2_Click;
		}

		void CtrlProdSales_Load(object sender, EventArgs e)
		{
			lblM.Text = DateTime.Now.ToString("MMM");
			lblYr.Text = DateTime.Now.ToString("yyyy");
			DailySales(lblYr.Text, indxM);
		}

		void rDaily_Click(object sender, EventArgs e)
		{
			btnMDec.Visible = true;
			lblM.Visible = true;
			btnMInc.Visible = true;
			btnYrDec.Visible = true;
			lblYr.Visible = true;
			btnYrInc.Visible = true;
			DailySales(lblYr.Text, indxM);
		}

		void rMonthly_Click(object sender, EventArgs e)
		{
			btnMDec.Visible = false;
			lblM.Visible = false;
			btnMInc.Visible = false;
			btnYrDec.Visible = true;
			lblYr.Visible = true;
			btnYrInc.Visible = true;
			MonthlySales(lblYr.Text);
		}

		void rYrly_Click(object sender, EventArgs e)
		{
			btnMDec.Visible = false;
			lblM.Visible = false;
			btnMInc.Visible = false;
			btnYrDec.Visible = false;
			lblYr.Visible = false;
			btnYrInc.Visible = false;
			YrlySales();
		}

		void btnMDec_Click(object sender, EventArgs e)
		{
			if (indxM >= 2) {
				indxM--;
				lblM.Text = months[indxM];
			}
			else {
				indxM = 12;
				lblM.Text = months[indxM];
			}
			DailySales(lblYr.Text, indxM);
			
		}

		void btnMInc_Click(object sender, EventArgs e)
		{
			if (indxM < 12) {
				indxM++;
				lblM.Text = months[indxM];
			}
			else {
				indxM = 1;
				lblM.Text = months[indxM];
			}
			DailySales(lblYr.Text, indxM);
		}

		void btnYrDec_Click(object sender, EventArgs e)
		{
			indxY--;
			lblYr.Text = indxY.ToString();
			if (rMonthly.Checked) {
				MonthlySales(lblYr.Text);
			}
			if (rDaily.Checked) {
				DailySales(lblYr.Text, indxM);
			}
		}

		void btnYrInc_Click(object sender, EventArgs e)
		{
			indxY++;
			lblYr.Text = indxY.ToString();
			if (rMonthly.Checked) {
				MonthlySales(lblYr.Text);
			}
			if (rDaily.Checked) {
				DailySales(lblYr.Text, indxM);
			}
		}

		void btnBack_Click(object sender, EventArgs e)
		{
			pBody.Visible = true;
		}

		void btnPrnt_Click(object sender, EventArgs e)
		{
			PrintReceipt();
		}
		
		void btnShow_Click(object sender, EventArgs e)
		{
			lblOrNum.Text = "Receipt No.: " + dataItms.CurrentRow.Cells[1].Value;
			pBody2.Visible = false;
			MySqlCon msc = new MySqlCon();
			msc.Query = "SELECT Name,Price,Quantity,Subtotal FROM tbl_products_sold WHERE Or_Num='" + dataItms.CurrentRow.Cells[1].Value + "'";
			msc.DispTbl(dataBill);
		}

		void btnBack2_Click(object sender, EventArgs e)
		{
			pBody2.Visible = true;
		}
		
		void YrlySales() {
			flpBody.Controls.Clear();
			MySqlCon msc = new MySqlCon();
			msc.Query = "SELECT * FROM tbl_products_sold";
			for (int yr = 2020; yr <= 2100; yr++) {
				BtnCustom btn = new BtnCustom(null, ContentAlignment.MiddleCenter, new Padding(4), new Size(179, 100), yr.ToString(), ContentAlignment.MiddleCenter);
				msc.Query = "SELECT * FROM tbl_sales WHERE Date LIKE '%" + yr + "-%'";
				if (msc.GetTotal("Total_Amount") != 0) {
					btn.BackColor = Color.FromArgb(175, 255, 175);
					btn.Text += "\nTotal: P " + msc.GetTotal("Total_Amount");
				}
				btn.Click += btn_Click;
				flpBody.Controls.Add(btn);
			}
		}
		
		void MonthlySales(string yr) {
			flpBody.Controls.Clear();
			MySqlCon msc = new MySqlCon();
			msc.Query = "SELECT * FROM tbl_products_sold";
			for (int m = 1; m <= 12; m++) {
				BtnCustom btn = new BtnCustom(null, ContentAlignment.MiddleCenter, new Padding(4), new Size(181, 100), months[m], ContentAlignment.MiddleCenter);
				msc.Query = "SELECT * FROM tbl_sales WHERE Date LIKE '%" + yr + "-" + GetDayOrMonthFormat(m)  + "-%'";
				if (msc.GetTotal("Total_Amount") != 0) {
					btn.BackColor = Color.FromArgb(175, 255, 175);
					btn.Text += "\nTotal: P " + msc.GetTotal("Total_Amount");
				}
				btn.Name = m.ToString();
				btn.Click += btn_Click;
				flpBody.Controls.Add(btn);
			}
		}
		
		void DailySales(string yr, int m) {
			flpBody.Controls.Clear();
			MySqlCon msc = new MySqlCon();
			msc.Query = "SELECT * FROM tbl_products_sold";
			for (int d = 1; d <= DateTime.DaysInMonth(Convert.ToInt32(yr), Convert.ToInt32(m)); d++) {
				BtnCustom btn = new BtnCustom(null, ContentAlignment.MiddleCenter, new Padding(4), new Size(180, 100), d.ToString(), ContentAlignment.MiddleRight);
				msc.Query = "SELECT * FROM tbl_sales WHERE Date LIKE '%" + yr + "-" + GetDayOrMonthFormat(m) +"-" + GetDayOrMonthFormat(d) + " %'";
				if (msc.GetTotal("Total_Amount") != 0) {
					btn.BackColor = Color.FromArgb(175, 255, 175);
					btn.Text += "\nTotal: P " + msc.GetTotal("Total_Amount");
				}
				btn.Click += btn_Click;
				flpBody.Controls.Add(btn);
			}
		}
		
		void btn_Click(object sender, EventArgs e)
		{
			Button b = (Button)sender;
			if (b.BackColor.Equals(Color.FromArgb(175, 255, 175))) {
				pBody.Visible = false;
				MySqlCon msc = new MySqlCon();
				if (rDaily.Checked) {
					msc.Query = "SELECT Date as 'Date',Or_Num as 'Receipt No.',Total_Items as 'Total Items',Total_Amount as 'Total Price',Amount_Paid as 'Amount',Return_Change as 'Change' FROM tbl_sales WHERE Date LIKE '%" + lblYr.Text + "-" + GetDayOrMonthFormat(indxM) + "-" + GetDayOrMonthFormat(Convert.ToInt32(b.Text.Split('\n')[0])) + " %'";
					lblTitle2.Text = string.Format("Daily Sales - {0}. {1}, {2}", months[indxM], b.Text.Split('\n')[0], indxY);
				}
				if (rMonthly.Checked) {
					msc.Query = "SELECT Date as 'Date',Or_Num as 'Receipt No.',Total_Items as 'Total Items',Total_Amount as 'Total Price',Amount_Paid as 'Amount',Return_Change as 'Change' FROM tbl_sales WHERE Date LIKE '%" + lblYr.Text + "-" + GetDayOrMonthFormat(Convert.ToInt32(b.Name)) + "-%'";
					lblTitle2.Text = string.Format("Monthly Sales - {0}. {1}", b.Text.Split('\n')[0], indxY);
				}
				if (rYrly.Checked) {
					msc.Query = "SELECT Date as 'Date',Or_Num as 'Receipt No.',Total_Items as 'Total Items',Total_Amount as 'Total Price',Amount_Paid as 'Amount',Return_Change as 'Change' FROM tbl_sales WHERE Date LIKE '%" + lblYr.Text + "-%'";
					lblTitle2.Text = string.Format("Yearly Sales - {0}",b.Text.Split('\n')[0]);
				}
				msc.DispTbl(dataItms);
			}
		}
		
		
		void PrintReceipt() {
			PrintDialog pd = new PrintDialog();
			PrintDocument pdoc = new PrintDocument();
			pd.Document = pdoc;
			pdoc.PrintPage += pdoc_PrintPage;
			DialogResult result = pd.ShowDialog();
			if (result == DialogResult.OK) {
				pdoc.Print();
			}
		}

		void pdoc_PrintPage(object sender, PrintPageEventArgs e)
		{
			Graphics g = e.Graphics;
			Font font = new Font("Courier New", 12);
			float fontH = font.GetHeight();
			const int startX = 10;
			const int startY = 10;
			int offset = 40;
			int breakline = offset + (int)fontH + 5;
			g.DrawString("--Cafe Henrico--", new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY);
			g.DrawString("#123 Legarda Rd., Baguio City", font, new SolidBrush(Color.Black), startX, startY + offset);
			offset = offset + (int)fontH + 5;
//			Date Receipt No. total items total price amount change
			offset = offset + (int)fontH + 5;
			g.DrawString(string.Format(lblTitle2.Text), font, new SolidBrush(Color.Black), startX, startY + offset);
			offset = offset + (int)fontH + 25;
			g.DrawString(string.Format("{0}{1}{2}{3}{4}{5}", "Date".PadRight(13), "O.R #".PadRight(12), "Total Items".PadRight(17), "Total Price".PadRight(17), "Amount".PadRight(13), "Change".PadRight(13)),
         	font, new SolidBrush(Color.Black), startX, startY + offset);
			offset = offset + (int)fontH + 5;
			foreach (DataGridViewRow rows in dataItms.Rows) {
				g.DrawString(string.Format("{0}{1}{2}{3}{4}{5}", rows.Cells[0].Value.ToString().PadRight(13), rows.Cells[1].Value.ToString().PadRight(12), rows.Cells[2].Value.ToString().PadRight(17), rows.Cells[3].Value.ToString().PadRight(17), rows.Cells[4].Value.ToString().PadRight(13), rows.Cells[5].Value.ToString().PadRight(13)),
				font, new SolidBrush(Color.Black), startX, startY + offset);
				offset = offset + (int)fontH + 5;
			}
			offset = offset + 20;
		}
		
		string GetDayOrMonthFormat(int value) {
			string output = string.Empty;
			if (value < 10) {
				output = "0" + value;
			}
			else {
				output = value.ToString();
			}
			return output;
		}
	}
}
