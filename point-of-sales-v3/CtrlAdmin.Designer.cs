/*
 * Date: 6/2/2020
 * Time: 11:57 PM
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
	partial class CtrlAdmin
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		public System.Windows.Forms.DataGridView dataTbl;
		private System.Windows.Forms.Panel pHead;
		private System.Windows.Forms.Panel pBody;
		private System.Windows.Forms.Label lblTbl;
		private System.Windows.Forms.Label lblSearch;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Button btnClr;
		private System.Windows.Forms.RadioButton rbtnCtgry;
		private System.Windows.Forms.RadioButton rbtnProd;
		private System.Windows.Forms.RadioButton rbtnTbl;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlAdmin));
			this.dataTbl = new System.Windows.Forms.DataGridView();
			this.pHead = new System.Windows.Forms.Panel();
			this.rbtnCtgry = new System.Windows.Forms.RadioButton();
			this.rbtnProd = new System.Windows.Forms.RadioButton();
			this.rbtnTbl = new System.Windows.Forms.RadioButton();
			this.lblSearch = new System.Windows.Forms.Label();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.lblTbl = new System.Windows.Forms.Label();
			this.btnClr = new System.Windows.Forms.Button();
			this.pBody = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataTbl)).BeginInit();
			this.pHead.SuspendLayout();
			this.pBody.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataTbl
			// 
			this.dataTbl.AllowUserToAddRows = false;
			this.dataTbl.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
			this.dataTbl.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataTbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataTbl.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataTbl.BackgroundColor = System.Drawing.Color.White;
			this.dataTbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataTbl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dataTbl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataTbl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataTbl.ColumnHeadersHeight = 35;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataTbl.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataTbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataTbl.EnableHeadersVisualStyles = false;
			this.dataTbl.Location = new System.Drawing.Point(0, 0);
			this.dataTbl.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this.dataTbl.MultiSelect = false;
			this.dataTbl.Name = "dataTbl";
			this.dataTbl.ReadOnly = true;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataTbl.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dataTbl.RowHeadersVisible = false;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
			this.dataTbl.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.dataTbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataTbl.Size = new System.Drawing.Size(1078, 340);
			this.dataTbl.TabIndex = 0;
			// 
			// pHead
			// 
			this.pHead.Controls.Add(this.rbtnCtgry);
			this.pHead.Controls.Add(this.rbtnProd);
			this.pHead.Controls.Add(this.rbtnTbl);
			this.pHead.Controls.Add(this.lblSearch);
			this.pHead.Controls.Add(this.txtSearch);
			this.pHead.Controls.Add(this.lblTbl);
			this.pHead.Controls.Add(this.button3);
			this.pHead.Controls.Add(this.button1);
			this.pHead.Controls.Add(this.button2);
			this.pHead.Controls.Add(this.btnClr);
			this.pHead.Dock = System.Windows.Forms.DockStyle.Top;
			this.pHead.Location = new System.Drawing.Point(0, 0);
			this.pHead.Name = "pHead";
			this.pHead.Size = new System.Drawing.Size(1078, 72);
			this.pHead.TabIndex = 6;
			// 
			// rbtnCtgry
			// 
			this.rbtnCtgry.Appearance = System.Windows.Forms.Appearance.Button;
			this.rbtnCtgry.BackColor = System.Drawing.Color.White;
			this.rbtnCtgry.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
			this.rbtnCtgry.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
			this.rbtnCtgry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rbtnCtgry.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtnCtgry.Location = new System.Drawing.Point(193, 15);
			this.rbtnCtgry.Name = "rbtnCtgry";
			this.rbtnCtgry.Size = new System.Drawing.Size(86, 43);
			this.rbtnCtgry.TabIndex = 11;
			this.rbtnCtgry.Text = "Category";
			this.rbtnCtgry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.rbtnCtgry.UseVisualStyleBackColor = false;
			// 
			// rbtnProd
			// 
			this.rbtnProd.Appearance = System.Windows.Forms.Appearance.Button;
			this.rbtnProd.BackColor = System.Drawing.Color.White;
			this.rbtnProd.Checked = true;
			this.rbtnProd.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
			this.rbtnProd.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
			this.rbtnProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rbtnProd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtnProd.Location = new System.Drawing.Point(101, 15);
			this.rbtnProd.Name = "rbtnProd";
			this.rbtnProd.Size = new System.Drawing.Size(86, 43);
			this.rbtnProd.TabIndex = 11;
			this.rbtnProd.TabStop = true;
			this.rbtnProd.Text = "Products";
			this.rbtnProd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.rbtnProd.UseVisualStyleBackColor = false;
			// 
			// rbtnTbl
			// 
			this.rbtnTbl.Appearance = System.Windows.Forms.Appearance.Button;
			this.rbtnTbl.BackColor = System.Drawing.Color.White;
			this.rbtnTbl.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
			this.rbtnTbl.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
			this.rbtnTbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rbtnTbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtnTbl.Location = new System.Drawing.Point(285, 15);
			this.rbtnTbl.Name = "rbtnTbl";
			this.rbtnTbl.Size = new System.Drawing.Size(86, 43);
			this.rbtnTbl.TabIndex = 11;
			this.rbtnTbl.Text = "Tables";
			this.rbtnTbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.rbtnTbl.UseVisualStyleBackColor = false;
			// 
			// lblSearch
			// 
			this.lblSearch.AutoSize = true;
			this.lblSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSearch.Location = new System.Drawing.Point(399, 27);
			this.lblSearch.Name = "lblSearch";
			this.lblSearch.Size = new System.Drawing.Size(59, 19);
			this.lblSearch.TabIndex = 10;
			this.lblSearch.Text = "Search:";
			// 
			// txtSearch
			// 
			this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearch.Location = new System.Drawing.Point(464, 23);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(248, 27);
			this.txtSearch.TabIndex = 3;
			// 
			// lblTbl
			// 
			this.lblTbl.AutoSize = true;
			this.lblTbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTbl.Location = new System.Drawing.Point(8, 27);
			this.lblTbl.Name = "lblTbl";
			this.lblTbl.Size = new System.Drawing.Size(87, 19);
			this.lblTbl.TabIndex = 8;
			this.lblTbl.Text = "DataTables:";
			// 
			// btnClr
			// 
			this.btnClr.AutoSize = true;
			this.btnClr.BackColor = System.Drawing.Color.White;
			this.btnClr.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
			this.btnClr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClr.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClr.ForeColor = System.Drawing.SystemColors.WindowText;
			this.btnClr.Location = new System.Drawing.Point(718, 21);
			this.btnClr.Name = "btnClr";
			this.btnClr.Size = new System.Drawing.Size(86, 31);
			this.btnClr.TabIndex = 4;
			this.btnClr.Text = "Clear";
			this.btnClr.UseVisualStyleBackColor = false;
			// 
			// pBody
			// 
			this.pBody.Controls.Add(this.dataTbl);
			this.pBody.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pBody.Location = new System.Drawing.Point(0, 72);
			this.pBody.Name = "pBody";
			this.pBody.Size = new System.Drawing.Size(1078, 340);
			this.pBody.TabIndex = 7;
			// 
			// button1
			// 
			this.button1.AutoSize = true;
			this.button1.BackColor = System.Drawing.Color.White;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(828, 17);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(60, 38);
			this.button1.TabIndex = 4;
			this.button1.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			this.button2.AutoSize = true;
			this.button2.BackColor = System.Drawing.Color.White;
			this.button2.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.SystemColors.WindowText;
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.Location = new System.Drawing.Point(894, 17);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(60, 38);
			this.button2.TabIndex = 4;
			this.button2.UseVisualStyleBackColor = false;
			// 
			// button3
			// 
			this.button3.AutoSize = true;
			this.button3.BackColor = System.Drawing.Color.White;
			this.button3.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.SystemColors.WindowText;
			this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
			this.button3.Location = new System.Drawing.Point(960, 17);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(60, 38);
			this.button3.TabIndex = 4;
			this.button3.UseVisualStyleBackColor = false;
			// 
			// CtrlAdmin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pBody);
			this.Controls.Add(this.pHead);
			this.Name = "CtrlAdmin";
			this.Size = new System.Drawing.Size(1078, 412);
			((System.ComponentModel.ISupportInitialize)(this.dataTbl)).EndInit();
			this.pHead.ResumeLayout(false);
			this.pHead.PerformLayout();
			this.pBody.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
