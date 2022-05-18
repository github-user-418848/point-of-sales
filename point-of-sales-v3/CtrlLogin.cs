/*
 * Date: 6/5/2020
 * Time: 4:59 PM
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
using System.Windows.Forms;

namespace point_of_sales_v3
{
	public partial class CtrlLogin : UserControl
	{
		public bool isLoggedIn;
		
		public CtrlLogin()
		{
			InitializeComponent();
			txtUser.KeyPress += txtUser_KeyPress;
			txtPasswd.KeyPress += txtPasswd_KeyPress;
			btnLogin.Click += btnLogin_Click;
		}

		void txtUser_KeyPress(object sender, KeyPressEventArgs e)
		{
			lblError.Visible = false;
			if (e.KeyChar == (char)13) {
				btnLogin_Click(sender, e);
			}
		}
		
		void txtPasswd_KeyPress(object sender, KeyPressEventArgs e)
		{
			lblError.Visible = false;
			if (e.KeyChar == (char)13) {
				btnLogin_Click(sender, e);
			}
		}

		void btnLogin_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(txtUser.Text) || !string.IsNullOrWhiteSpace(txtPasswd.Text)) {
				isLoggedIn = true;
			}
			else {
				isLoggedIn = false;
				lblError.Visible = true;
			}
		}
	}
}
