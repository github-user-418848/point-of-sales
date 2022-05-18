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
namespace point_of_sales_v3
{
	partial class CtrlLogin
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblPasswd;
		private System.Windows.Forms.Label lblUser;
		private System.Windows.Forms.TextBox txtPasswd;
		private System.Windows.Forms.TextBox txtUser;
		public System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblError;
		
		/// <summary>
		/// Disposes resources used by the control.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlLogin));
			this.lblPasswd = new System.Windows.Forms.Label();
			this.lblUser = new System.Windows.Forms.Label();
			this.txtPasswd = new System.Windows.Forms.TextBox();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblError = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblPasswd
			// 
			this.lblPasswd.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblPasswd.AutoSize = true;
			this.lblPasswd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPasswd.Location = new System.Drawing.Point(107, 255);
			this.lblPasswd.Name = "lblPasswd";
			this.lblPasswd.Size = new System.Drawing.Size(74, 19);
			this.lblPasswd.TabIndex = 26;
			this.lblPasswd.Text = "Password";
			// 
			// lblUser
			// 
			this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblUser.AutoSize = true;
			this.lblUser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUser.Location = new System.Drawing.Point(107, 207);
			this.lblUser.Name = "lblUser";
			this.lblUser.Size = new System.Drawing.Size(77, 19);
			this.lblUser.TabIndex = 25;
			this.lblUser.Text = "Username";
			// 
			// txtPasswd
			// 
			this.txtPasswd.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtPasswd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPasswd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPasswd.Location = new System.Drawing.Point(195, 255);
			this.txtPasswd.Name = "txtPasswd";
			this.txtPasswd.Size = new System.Drawing.Size(248, 27);
			this.txtPasswd.TabIndex = 23;
			this.txtPasswd.UseSystemPasswordChar = true;
			// 
			// txtUser
			// 
			this.txtUser.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtUser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUser.Location = new System.Drawing.Point(195, 207);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(248, 27);
			this.txtUser.TabIndex = 22;
			// 
			// btnLogin
			// 
			this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnLogin.AutoSize = true;
			this.btnLogin.BackColor = System.Drawing.Color.White;
			this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.ForeColor = System.Drawing.SystemColors.WindowText;
			this.btnLogin.Location = new System.Drawing.Point(214, 327);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(122, 48);
			this.btnLogin.TabIndex = 24;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = false;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
			this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
			this.label1.Location = new System.Drawing.Point(125, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(246, 136);
			this.label1.TabIndex = 28;
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.groupBox1.Controls.Add(this.lblError);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(27, 15);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(497, 416);
			this.groupBox1.TabIndex = 29;
			this.groupBox1.TabStop = false;
			// 
			// lblError
			// 
			this.lblError.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblError.AutoSize = true;
			this.lblError.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
			this.lblError.Location = new System.Drawing.Point(141, 277);
			this.lblError.Name = "lblError";
			this.lblError.Size = new System.Drawing.Size(214, 19);
			this.lblError.TabIndex = 29;
			this.lblError.Text = "Invalid username or password";
			this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblError.Visible = false;
			// 
			// CtrlLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lblPasswd);
			this.Controls.Add(this.lblUser);
			this.Controls.Add(this.txtPasswd);
			this.Controls.Add(this.txtUser);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.groupBox1);
			this.Name = "CtrlLogin";
			this.Size = new System.Drawing.Size(551, 450);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
