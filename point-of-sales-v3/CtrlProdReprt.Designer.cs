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
namespace point_of_sales_v3
{
	partial class CtrlProdReprt
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dataItms;
		
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dataItms = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataItms)).BeginInit();
			this.SuspendLayout();
			// 
			// dataItms
			// 
			this.dataItms.AllowUserToAddRows = false;
			this.dataItms.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
			this.dataItms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataItms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.dataItms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataItms.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataItms.BackgroundColor = System.Drawing.Color.White;
			this.dataItms.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataItms.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dataItms.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataItms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataItms.ColumnHeadersHeight = 35;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataItms.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataItms.EnableHeadersVisualStyles = false;
			this.dataItms.Location = new System.Drawing.Point(3, 0);
			this.dataItms.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this.dataItms.MultiSelect = false;
			this.dataItms.Name = "dataItms";
			this.dataItms.ReadOnly = true;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataItms.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dataItms.RowHeadersVisible = false;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
			this.dataItms.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.dataItms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataItms.Size = new System.Drawing.Size(916, 494);
			this.dataItms.TabIndex = 28;
			// 
			// CtrlProdReprt
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.dataItms);
			this.Name = "CtrlProdReprt";
			this.Size = new System.Drawing.Size(919, 494);
			((System.ComponentModel.ISupportInitialize)(this.dataItms)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
