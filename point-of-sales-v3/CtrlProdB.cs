/*
 * Date: 6/2/2020
 * Time: 8:02 PM
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
using System.Drawing.Printing;
using System.Windows.Forms;

namespace point_of_sales_v3
{
	public partial class CtrlProdB : UserControl
	{
		
		public bool Paid ;
		
		string category = string.Empty;
		
		int ornum;
		
		public CtrlProdB()
		{
			InitializeComponent();
			Load += CtrlProdB_Load;
			txtSearch.TextChanged += txtSearch_TextChanged;
			txtAmt.TextChanged += txtAmt_TextChanged;
			btnClr.Click += btnClr_Click;
			btnBack.Click += btnBack_Click;
			btnCharge.Click += btnSend_Click;
			btnPrint.Click += btnPay_Click;
			dataItms.CellContentClick += dataItms_CellContentClick;
			dataItms.CellValueChanged += dataItms_CellValueChanged;
		}

		void CtrlProdB_Load(object sender, EventArgs e)
		{
			MySqlCon msc = new MySqlCon();
			pCtgry.Controls.Clear();
			msc.Query = "SELECT * FROM tbl_category";
			foreach (var catgry in msc.BtnOnly) {
				catgry.TextAlign = ContentAlignment.MiddleCenter;
				pCtgry.Controls.Add(catgry);
				if (pCtgry.Controls.Count == 1) {
					category = catgry.Text;
				}
				catgry.Click += catgry_Click;
			}
			pItms.Controls.Clear();
			msc = new MySqlCon();
			msc.Query = string.Format("SELECT * FROM tbl_product WHERE Category='{0}'", category);
			foreach (var items in msc.BtnWithImg) {
				items.Click += items_Click;
				pItms.Controls.Add(items);
			}
		}

		void items_Click(object sender, EventArgs e)
		{
			bool Found = false;
			Button b = (Button)sender;
			string [] arr = b.Text.Split('\n');
			if (dataItms.Rows.Count > 0) {
				foreach(DataGridViewRow row in dataItms.Rows) {
					if(Convert.ToString(row.Cells[1].Value).Equals(arr[0])) {
						Found = true;
//						QTY
						row.Cells[3].Value = Convert.ToString(1 + Convert.ToInt32(row.Cells[3].Value));
//						SUBTOTAL
						row.Cells[6].Value = string.Format("{0:N}", Convert.ToDouble(row.Cells[3].Value) * Convert.ToDouble(row.Cells[5].Value));
					}
				}
				if(!Found) {
					dataItms.Rows.Add("X", arr[0], "-", "1", "+", string.Format("{0:N}", GetDigits(arr[1])), string.Format("{0:N}", GetDigits(arr[1])));
				}
			}
			else {
				dataItms.Rows.Add("X", arr[0], "-", "1", "+", string.Format("{0:N}", GetDigits(arr[1])), string.Format("{0:N}", GetDigits(arr[1])));
			}
			double sum = 0;
			int totalitms = 0;
			for(int i = 0; i < dataItms.Rows.Count; ++i) {
				sum += Convert.ToDouble(dataItms.Rows[i].Cells[6].Value);
				totalitms += Convert.ToInt32(dataItms.Rows[i].Cells[3].Value);
			}
			btnCharge.Text = string.Format("Charge P {0:N}", sum);
			lblFinTotalVal.Text = string.Format("P {0:N}", sum);
			lblFinTotalItmsVal.Text = totalitms.ToString();
		}

		void catgry_Click(object sender, EventArgs e)
		{
			RadioButton b = (RadioButton)sender;
			pItms.Controls.Clear();
			MySqlCon msc = new MySqlCon();
			category = b.Text;
			msc.Query = string.Format("SELECT * FROM tbl_product WHERE Name LIKE '%{0}%' AND Category='{1}'", txtSearch.Text, b.Text);
			foreach (var items in msc.BtnWithImg) {
				items.Click += items_Click;
				pItms.Controls.Add(items);
			}
		}
		
		void txtSearch_TextChanged(object sender, EventArgs e)
		{
			pItms.Controls.Clear();
			MySqlCon msc = new MySqlCon();
			msc.Query = string.Format("SELECT * FROM tbl_product WHERE Name LIKE '%{0}%' AND category='{1}'", txtSearch.Text.Replace("'","''"), category);
			foreach (var items in msc.BtnWithImg) {
				items.Click += items_Click;
				pItms.Controls.Add(items);
			}
		}

		void txtAmt_TextChanged(object sender, EventArgs e)
		{
			lblError.Visible = false;
			try {
				double fintotal = GetDigits(lblFinTotalVal.Text);
				double change = Convert.ToDouble(txtAmt.Text) - fintotal;
				if (change >= 0) {
					lblChangeVal.Text = string.Format("P {0:N}", change);
					lblAmtPaidVal.Text = string.Format("P {0:N}", txtAmt.Text);
				}
			} catch (Exception) {
				lblChangeVal.Text = "P 0.00";
				lblAmtPaidVal.Text = "P 0.00";
			}
		}
		
		void btnClr_Click(object sender, EventArgs e)
		{
			txtSearch.Clear();
		}
		
		void btnBack_Click(object sender, EventArgs e)
		{
			txtAmt.Clear();
			lblChangeVal.Text = "P 0.00";
			pPayDialog.Visible = false;
		}
		
		void btnSend_Click(object sender, EventArgs e)
		{
			if (dataItms.Rows.Count > 0) {
				pPayDialog.Visible = true;
			}
			else {
				MessageBox.Show("No items added in table","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		void btnPay_Click(object sender, EventArgs e)
		{
			if (GetDigits(lblChangeVal.Text) < 0 || txtAmt.Text.Equals(string.Empty)) {
				lblError.Visible = true;
				Paid = false;
			}
			else {
				
				PrintReceipt();
			}
		}
		void dataItms_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			switch (e.ColumnIndex) {
				case 0: 
					dataItms.Rows.RemoveAt(dataItms.CurrentRow.Index);
					dataItms_CellValueChanged(sender, e);
					break;
				case 2:
					if (Convert.ToInt32(dataItms.CurrentRow.Cells[3].Value) > 1) {
						dataItms.CurrentRow.Cells[3].Value = Convert.ToInt32(dataItms.CurrentRow.Cells[3].Value) - 1;
					}
					break;
				case 4:
					dataItms.CurrentRow.Cells[3].Value = Convert.ToInt32(dataItms.CurrentRow.Cells[3].Value) + 1;
					break;
			}
		}

		void dataItms_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex != 0) {
				dataItms.CurrentRow.Cells[6].Value = string.Format("{0:N}", Convert.ToDouble(dataItms.CurrentRow.Cells[3].Value) * Convert.ToDouble(dataItms.CurrentRow.Cells[5].Value));
			}
			double sum = 0;
			int totalitms = 0;
			for(int i = 0; i < dataItms.Rows.Count; ++i) {
				sum += Convert.ToDouble(dataItms.Rows[i].Cells[6].Value);
				totalitms += Convert.ToInt32(dataItms.Rows[i].Cells[3].Value);
			}
			btnCharge.Text = string.Format("Charge P {0:N}", sum);
			lblFinTotalVal.Text = string.Format("P {0:N}", sum);
			lblFinTotalItmsVal.Text = totalitms.ToString();
			if (btnCharge.Text.Equals("Charge P 0")) {
				btnCharge.Text = "Charge P 0.00";
				lblFinTotalVal.Text = "P 0.00";
			}
		}
		
		void PrintReceipt() {
			PrintDialog pd = new PrintDialog();
			PrintDocument pdoc = new PrintDocument();
			pd.Document = pdoc;
			pdoc.PrintPage += pdoc_PrintPage;
			DialogResult result = pd.ShowDialog();
			if (result == DialogResult.OK) {
				MySqlCon msc = new MySqlCon();
				ornum = msc.AutoNum();
				pdoc.Print();
				foreach (DataGridViewRow rows in dataItms.Rows) {
					msc.Query = string.Format("INSERT INTO tbl_products_sold (Or_Num,Name,Quantity,Price,Subtotal) VALUES ('{0}','{1}','{2}','{3}','{4}')", ornum, rows.Cells[1].Value, rows.Cells[3].Value, rows.Cells[5].Value, rows.Cells[6].Value);
					msc.Insert();
				}
				msc.Query = string.Format("INSERT INTO tbl_sales (Date,Or_Num,Total_Items,Total_Amount,Amount_Paid,Return_Change) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), ornum, lblFinTotalItmsVal.Text, GetDigits(lblFinTotalVal.Text), GetDigits(lblAmtPaidVal.Text), GetDigits(lblChangeVal.Text));
				msc.Insert();
				txtAmt.Clear();
				dataItms.Rows.Clear();
				btnCharge.Text = "Charge P 0.00";
				lblFinTotalVal.Text = "P 0.00";
				lblAmtPaidVal.Text = "P 0.00";
				lblChangeVal.Text = "P 0.00";
				pPayDialog.Visible = false;
				lblError.Visible = false;
				Paid = true;
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
			g.DrawString(string.Format("O.R.#: {0}", ornum), font, new SolidBrush(Color.Black), startX, startY + offset);
			offset = offset + (int)fontH + 5;
			g.DrawString("Cashier: You", font, new SolidBrush(Color.Black), startX, startY + offset);
			offset = offset + (int)fontH + 5;
			g.DrawString(string.Format("DateTime: {0}", DateTime.Now), font, new SolidBrush(Color.Black), startX, startY + offset);
			offset = offset + (int)fontH + 25;
			g.DrawString(string.Format("{0}{1}{2}{3}", "Name".PadRight(20), "Quantity".PadRight(20), "Price".PadRight(20), "Subtotal".PadRight(20)),
         	font, new SolidBrush(Color.Black), startX, startY + offset);
			offset = offset + (int)fontH + 5;
			foreach (DataGridViewRow rows in dataItms.Rows) {
				g.DrawString(string.Format("{0}{1}{2}{3}", rows.Cells[1].Value.ToString().PadRight(20), rows.Cells[3].Value.ToString().PadRight(20),
                rows.Cells[5].Value.ToString().PadRight(20), rows.Cells[6].Value.ToString().PadRight(20)), font, new SolidBrush(Color.Black), startX, startY + offset);
				offset = offset + (int)fontH + 5;
			}
			offset = offset + 20;
			g.DrawString(string.Format("Total: {0}", lblFinTotalVal.Text), font, new SolidBrush(Color.Black), startX, startY + offset);
			offset = offset + (int)fontH + 5;
			g.DrawString(string.Format("Amount Paid: {0}", lblAmtPaidVal.Text), font, new SolidBrush(Color.Black), startX, startY + offset);
			offset = offset + (int)fontH + 5;
			g.DrawString(string.Format("Change: {0}", lblChangeVal.Text), font, new SolidBrush(Color.Black), startX, startY + offset);
			offset = offset + (int)fontH + 5;
			g.DrawString("--Thank you for purchasing!--", font, new SolidBrush(Color.Black), startX, startY + offset);
		}
		
		double GetDigits(string value) {
			return Convert.ToDouble(value.Replace("P ", ""));
		}
		
		bool isDigitsOnly(double value) {
			bool isTrue;
			try {
				double.Parse(value.ToString());
				isTrue = true;
			} catch (Exception) {
				isTrue = false;
			}
			return isTrue;
		}
	}
}
