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
namespace point_of_sales_v3
{
	partial class CtrlProdA
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.FlowLayoutPanel pTbl;
		private point_of_sales_v3.CtrlProdB ctrlProdB1;
		private System.Windows.Forms.Panel pBody;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ToolTip toolTip1;
		
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlProdA));
			this.pTbl = new System.Windows.Forms.FlowLayoutPanel();
			this.ctrlProdB1 = new point_of_sales_v3.CtrlProdB();
			this.pBody = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.pBody.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pTbl
			// 
			this.pTbl.AutoScroll = true;
			this.pTbl.BackColor = System.Drawing.Color.White;
			this.pTbl.Dock = System.Windows.Forms.DockStyle.Left;
			this.pTbl.Location = new System.Drawing.Point(0, 0);
			this.pTbl.Margin = new System.Windows.Forms.Padding(0);
			this.pTbl.Name = "pTbl";
			this.pTbl.Size = new System.Drawing.Size(128, 406);
			this.pTbl.TabIndex = 0;
			// 
			// ctrlProdB1
			// 
			this.ctrlProdB1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ctrlProdB1.Location = new System.Drawing.Point(128, 0);
			this.ctrlProdB1.Margin = new System.Windows.Forms.Padding(0);
			this.ctrlProdB1.Name = "ctrlProdB1";
			this.ctrlProdB1.Size = new System.Drawing.Size(570, 406);
			this.ctrlProdB1.TabIndex = 1;
			this.ctrlProdB1.Visible = false;
			// 
			// pBody
			// 
			this.pBody.BackColor = System.Drawing.Color.White;
			this.pBody.Controls.Add(this.pictureBox1);
			this.pBody.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pBody.Location = new System.Drawing.Point(128, 0);
			this.pBody.Name = "pBody";
			this.pBody.Size = new System.Drawing.Size(570, 406);
			this.pBody.TabIndex = 2;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(113, 31);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(344, 344);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 28;
			this.pictureBox1.TabStop = false;
			// 
			// CtrlProdA
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.pBody);
			this.Controls.Add(this.ctrlProdB1);
			this.Controls.Add(this.pTbl);
			this.Name = "CtrlProdA";
			this.Size = new System.Drawing.Size(698, 406);
			this.pBody.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
