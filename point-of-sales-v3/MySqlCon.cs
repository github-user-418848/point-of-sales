/*
 * Date: 6/2/2020
 * Time: 7:39 PM
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
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace point_of_sales_v3
{
	public class MySqlCon
	{
		OdbcDataAdapter data = new OdbcDataAdapter();
        
		public OdbcConnection con = new OdbcConnection();
		
		public DataTable dt = new DataTable();

		public OdbcDataReader read;
        
		public OdbcCommand cmd;
        
		public bool Error;
        
		public string Query { get; set; }

		public void Connect()
		{
			try {
				Error = false;
				con.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};Server=localhost;database=cafe-henrico;UID=root;";
				con.Open();
			} catch (Exception) {
				Error = true;
			}
		}
		
		public void Disconnect()
		{
			con.Close();
			con.Dispose();
		}
		
		public Button [] BtnWithImg {
			get {
				Button [] btn = new Button[0];
				int index = 0;
				Connect();
				if (!Error) {
					cmd = new OdbcCommand(Query, con);
					using (read = cmd.ExecuteReader()) {
						btn = new Button[read.RecordsAffected];
						while (read.Read()) {
							btn[index] = new BtnCustom(Image.FromStream(new MemoryStream((byte[])read["image"])), ContentAlignment.MiddleCenter, new Padding(17, 17, 17, 17), new Size(185, 185), string.Format("{0}\nP {1:N}", read["name"], read["price"]), ContentAlignment.BottomCenter);
							index++;
						}
					}
				}
				return btn;
			}
		}
		
		public RadioButton [] BtnOnly {
			get {
				RadioButton [] btn = new RadioButton[0];
				int index = 0;
				Connect();
				if (!Error) {
					cmd = new OdbcCommand(Query, con);
					using (read = cmd.ExecuteReader()) {
						btn = new RadioButton[read.RecordsAffected];
						while (read.Read()) {
							btn[index] = new RBtnCustom(null, ContentAlignment.MiddleCenter, new Padding(5, 5, 5, 5), new Size(100, 100), read["name"].ToString(), ContentAlignment.BottomCenter);
							btn[0].Checked = true;
							btn[0].PerformClick();
							index++;
						}
					}
				}
				return btn;
			}
		}
		
		public void Insert() {
			cmd = new OdbcCommand(Query, con);
			Connect();
			if (!Error) {
				cmd.ExecuteNonQuery();
			} else {
				MessageBox.Show("No connection");
			}
			Disconnect();
		}
		
		public void DispTbl(DataGridView dtbl)
		{
			Connect();
			if (!Error) {
				dt = new DataTable();
				data.SelectCommand = new OdbcCommand(Query, con);
				data.Fill(dt);
				data.Dispose();
				dtbl.DataSource = dt;
			} else {
				MessageBox.Show("No connection");
			}
			Disconnect();
		}
		
		public double GetTotal(string column) {
			double Total = 0;
			Connect();
			if (!Error) {
				cmd = new OdbcCommand(Query, con);
					using (read = cmd.ExecuteReader()) {
						while (read.Read()) {
							Total += Convert.ToDouble(read[column].ToString());
						}
					}
				}
			Disconnect();
			return Total;
		}
		
		public int AutoNum() {
			int num = 0;
			Query = "SELECT * FROM tbl_products_sold";
			Connect();
			if (!Error) {
				cmd = new OdbcCommand(Query, con);
				using (read = cmd.ExecuteReader()) {
					while (read.Read()) {
						num = Convert.ToInt32(read["or_num"]);
					}
				}
			}
			Disconnect();
			return num + 1;
		}
	}
}
