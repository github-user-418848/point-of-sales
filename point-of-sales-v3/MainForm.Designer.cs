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
namespace point_of_sales_v3
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel pHead;
		private System.Windows.Forms.Panel pBody;
		private System.Windows.Forms.Label lblDateTime;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Timer tmr;
		private System.Windows.Forms.Button btnLogout;
		private System.Windows.Forms.RadioButton rReports;
		private System.Windows.Forms.RadioButton rAdmin;
		private System.Windows.Forms.RadioButton rPos;
		
		/// <summary>
		/// Disposes resources used by the form.
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pHead = new System.Windows.Forms.Panel();
			this.rReports = new System.Windows.Forms.RadioButton();
			this.rAdmin = new System.Windows.Forms.RadioButton();
			this.rPos = new System.Windows.Forms.RadioButton();
			this.btnLogout = new System.Windows.Forms.Button();
			this.lblDateTime = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pBody = new System.Windows.Forms.Panel();
			this.tmr = new System.Windows.Forms.Timer(this.components);
			this.pHead.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pHead
			// 
			this.pHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
			this.pHead.Controls.Add(this.rReports);
			this.pHead.Controls.Add(this.rAdmin);
			this.pHead.Controls.Add(this.rPos);
			this.pHead.Controls.Add(this.btnLogout);
			this.pHead.Controls.Add(this.lblDateTime);
			this.pHead.Controls.Add(this.pictureBox1);
			this.pHead.Dock = System.Windows.Forms.DockStyle.Top;
			this.pHead.Location = new System.Drawing.Point(0, 0);
			this.pHead.Margin = new System.Windows.Forms.Padding(0);
			this.pHead.Name = "pHead";
			this.pHead.Size = new System.Drawing.Size(1115, 70);
			this.pHead.TabIndex = 0;
			// 
			// rReports
			// 
			this.rReports.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.rReports.Appearance = System.Windows.Forms.Appearance.Button;
			this.rReports.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.rReports.FlatAppearance.BorderSize = 0;
			this.rReports.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(34)))));
			this.rReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(34)))));
			this.rReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rReports.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rReports.ForeColor = System.Drawing.Color.White;
			this.rReports.Location = new System.Drawing.Point(924, 0);
			this.rReports.Margin = new System.Windows.Forms.Padding(0);
			this.rReports.Name = "rReports";
			this.rReports.Size = new System.Drawing.Size(104, 70);
			this.rReports.TabIndex = 24;
			this.rReports.Text = "Reports";
			this.rReports.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.rReports.UseVisualStyleBackColor = true;
			// 
			// rAdmin
			// 
			this.rAdmin.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.rAdmin.Appearance = System.Windows.Forms.Appearance.Button;
			this.rAdmin.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.rAdmin.FlatAppearance.BorderSize = 0;
			this.rAdmin.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(34)))));
			this.rAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(34)))));
			this.rAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rAdmin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rAdmin.ForeColor = System.Drawing.Color.White;
			this.rAdmin.Location = new System.Drawing.Point(820, 0);
			this.rAdmin.Margin = new System.Windows.Forms.Padding(0);
			this.rAdmin.Name = "rAdmin";
			this.rAdmin.Size = new System.Drawing.Size(104, 70);
			this.rAdmin.TabIndex = 23;
			this.rAdmin.Text = "Admin";
			this.rAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.rAdmin.UseVisualStyleBackColor = true;
			// 
			// rPos
			// 
			this.rPos.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.rPos.Appearance = System.Windows.Forms.Appearance.Button;
			this.rPos.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.rPos.Checked = true;
			this.rPos.FlatAppearance.BorderSize = 0;
			this.rPos.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(34)))));
			this.rPos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(34)))));
			this.rPos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rPos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rPos.ForeColor = System.Drawing.Color.White;
			this.rPos.Location = new System.Drawing.Point(716, 0);
			this.rPos.Margin = new System.Windows.Forms.Padding(0);
			this.rPos.Name = "rPos";
			this.rPos.Size = new System.Drawing.Size(104, 70);
			this.rPos.TabIndex = 23;
			this.rPos.TabStop = true;
			this.rPos.Text = "POS";
			this.rPos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.rPos.UseVisualStyleBackColor = true;
			// 
			// btnLogout
			// 
			this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btnLogout.AutoSize = true;
			this.btnLogout.BackColor = System.Drawing.Color.Transparent;
			this.btnLogout.FlatAppearance.BorderSize = 0;
			this.btnLogout.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(34)))));
			this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
			this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(34)))));
			this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogout.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
			this.btnLogout.ForeColor = System.Drawing.Color.White;
			this.btnLogout.Location = new System.Drawing.Point(1028, 1);
			this.btnLogout.Margin = new System.Windows.Forms.Padding(0);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(86, 69);
			this.btnLogout.TabIndex = 22;
			this.btnLogout.Text = "Logout";
			this.btnLogout.UseVisualStyleBackColor = false;
			this.btnLogout.Visible = false;
			// 
			// lblDateTime
			// 
			this.lblDateTime.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblDateTime.AutoSize = true;
			this.lblDateTime.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDateTime.ForeColor = System.Drawing.Color.White;
			this.lblDateTime.Location = new System.Drawing.Point(438, 25);
			this.lblDateTime.Name = "lblDateTime";
			this.lblDateTime.Size = new System.Drawing.Size(238, 19);
			this.lblDateTime.TabIndex = 1;
			this.lblDateTime.Text = "Tuesday, January 1, 2010 11:30pm";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(87, 7);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(225, 55);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// pBody
			// 
			this.pBody.BackColor = System.Drawing.Color.White;
			this.pBody.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pBody.Location = new System.Drawing.Point(0, 70);
			this.pBody.Margin = new System.Windows.Forms.Padding(0);
			this.pBody.Name = "pBody";
			this.pBody.Size = new System.Drawing.Size(1115, 471);
			this.pBody.TabIndex = 0;
			// 
			// tmr
			// 
			this.tmr.Enabled = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1115, 541);
			this.Controls.Add(this.pBody);
			this.Controls.Add(this.pHead);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "point-of-sales-v3";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.pHead.ResumeLayout(false);
			this.pHead.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
