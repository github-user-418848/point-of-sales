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
	partial class CtrlSalesReprt
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblBack;
		private System.Windows.Forms.Label lblTitle2;
		private System.Windows.Forms.FlowLayoutPanel flpBody;
		private System.Windows.Forms.Button btnYrInc;
		private System.Windows.Forms.Label lblM;
		private System.Windows.Forms.Button btnMDec;
		private System.Windows.Forms.RadioButton rYrly;
		private System.Windows.Forms.Label lblYr;
		private System.Windows.Forms.RadioButton rMonthly;
		private System.Windows.Forms.Panel pBody2;
		public System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnPrnt;
		private System.Windows.Forms.DataGridView dataItms;
		private System.Windows.Forms.Button btnYrDec;
		private System.Windows.Forms.Panel pBody;
		private System.Windows.Forms.RadioButton rDaily;
		private System.Windows.Forms.Button btnMInc;
		private System.Windows.Forms.Label lblRepo;
		private System.Windows.Forms.Label lblSearch;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Button btnShow;
		private System.Windows.Forms.DataGridView dataBill;
		private System.Windows.Forms.Label lblBack2;
		public System.Windows.Forms.Button btnBack2;
		private System.Windows.Forms.Label lblOrNum;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlSalesReprt));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
			this.pBody = new System.Windows.Forms.Panel();
			this.flpBody = new System.Windows.Forms.FlowLayoutPanel();
			this.btnYrInc = new System.Windows.Forms.Button();
			this.lblM = new System.Windows.Forms.Label();
			this.btnMDec = new System.Windows.Forms.Button();
			this.rYrly = new System.Windows.Forms.RadioButton();
			this.lblYr = new System.Windows.Forms.Label();
			this.rMonthly = new System.Windows.Forms.RadioButton();
			this.btnYrDec = new System.Windows.Forms.Button();
			this.rDaily = new System.Windows.Forms.RadioButton();
			this.btnMInc = new System.Windows.Forms.Button();
			this.lblRepo = new System.Windows.Forms.Label();
			this.pBody2 = new System.Windows.Forms.Panel();
			this.lblBack = new System.Windows.Forms.Label();
			this.btnBack = new System.Windows.Forms.Button();
			this.lblTitle2 = new System.Windows.Forms.Label();
			this.btnShow = new System.Windows.Forms.Button();
			this.btnPrnt = new System.Windows.Forms.Button();
			this.dataItms = new System.Windows.Forms.DataGridView();
			this.lblSearch = new System.Windows.Forms.Label();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.dataBill = new System.Windows.Forms.DataGridView();
			this.lblBack2 = new System.Windows.Forms.Label();
			this.btnBack2 = new System.Windows.Forms.Button();
			this.lblOrNum = new System.Windows.Forms.Label();
			this.pBody.SuspendLayout();
			this.pBody2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataItms)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataBill)).BeginInit();
			this.SuspendLayout();
			// 
			// pBody
			// 
			this.pBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.pBody.Controls.Add(this.flpBody);
			this.pBody.Controls.Add(this.btnYrInc);
			this.pBody.Controls.Add(this.lblM);
			this.pBody.Controls.Add(this.btnMDec);
			this.pBody.Controls.Add(this.rYrly);
			this.pBody.Controls.Add(this.lblYr);
			this.pBody.Controls.Add(this.rMonthly);
			this.pBody.Controls.Add(this.btnYrDec);
			this.pBody.Controls.Add(this.rDaily);
			this.pBody.Controls.Add(this.btnMInc);
			this.pBody.Controls.Add(this.lblRepo);
			this.pBody.Location = new System.Drawing.Point(0, 0);
			this.pBody.Name = "pBody";
			this.pBody.Size = new System.Drawing.Size(1211, 574);
			this.pBody.TabIndex = 27;
			// 
			// flpBody
			// 
			this.flpBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.flpBody.AutoScroll = true;
			this.flpBody.Location = new System.Drawing.Point(19, 67);
			this.flpBody.Name = "flpBody";
			this.flpBody.Size = new System.Drawing.Size(1174, 487);
			this.flpBody.TabIndex = 19;
			// 
			// btnYrInc
			// 
			this.btnYrInc.AutoSize = true;
			this.btnYrInc.BackColor = System.Drawing.Color.White;
			this.btnYrInc.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
			this.btnYrInc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnYrInc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnYrInc.ForeColor = System.Drawing.SystemColors.WindowText;
			this.btnYrInc.Location = new System.Drawing.Point(481, 20);
			this.btnYrInc.Name = "btnYrInc";
			this.btnYrInc.Size = new System.Drawing.Size(53, 31);
			this.btnYrInc.TabIndex = 5;
			this.btnYrInc.Text = "+";
			this.btnYrInc.UseVisualStyleBackColor = false;
			// 
			// lblM
			// 
			this.lblM.AutoSize = true;
			this.lblM.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblM.Location = new System.Drawing.Point(609, 26);
			this.lblM.Name = "lblM";
			this.lblM.Size = new System.Drawing.Size(31, 19);
			this.lblM.TabIndex = 9;
			this.lblM.Text = "Jan";
			// 
			// btnMDec
			// 
			this.btnMDec.AutoSize = true;
			this.btnMDec.BackColor = System.Drawing.Color.White;
			this.btnMDec.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
			this.btnMDec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMDec.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMDec.ForeColor = System.Drawing.SystemColors.WindowText;
			this.btnMDec.Location = new System.Drawing.Point(550, 20);
			this.btnMDec.Name = "btnMDec";
			this.btnMDec.Size = new System.Drawing.Size(52, 31);
			this.btnMDec.TabIndex = 6;
			this.btnMDec.Text = "-";
			this.btnMDec.UseVisualStyleBackColor = false;
			// 
			// rYrly
			// 
			this.rYrly.AutoSize = true;
			this.rYrly.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rYrly.Location = new System.Drawing.Point(294, 24);
			this.rYrly.Name = "rYrly";
			this.rYrly.Size = new System.Drawing.Size(68, 23);
			this.rYrly.TabIndex = 3;
			this.rYrly.Text = "Yearly";
			this.rYrly.UseVisualStyleBackColor = true;
			// 
			// lblYr
			// 
			this.lblYr.AutoSize = true;
			this.lblYr.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblYr.Location = new System.Drawing.Point(434, 26);
			this.lblYr.Name = "lblYr";
			this.lblYr.Size = new System.Drawing.Size(41, 19);
			this.lblYr.TabIndex = 9;
			this.lblYr.Text = "2020";
			// 
			// rMonthly
			// 
			this.rMonthly.AutoSize = true;
			this.rMonthly.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rMonthly.Location = new System.Drawing.Point(202, 24);
			this.rMonthly.Name = "rMonthly";
			this.rMonthly.Size = new System.Drawing.Size(86, 23);
			this.rMonthly.TabIndex = 2;
			this.rMonthly.Text = "Monthly";
			this.rMonthly.UseVisualStyleBackColor = true;
			// 
			// btnYrDec
			// 
			this.btnYrDec.AutoSize = true;
			this.btnYrDec.BackColor = System.Drawing.Color.White;
			this.btnYrDec.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
			this.btnYrDec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnYrDec.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnYrDec.ForeColor = System.Drawing.SystemColors.WindowText;
			this.btnYrDec.Location = new System.Drawing.Point(376, 20);
			this.btnYrDec.Name = "btnYrDec";
			this.btnYrDec.Size = new System.Drawing.Size(52, 31);
			this.btnYrDec.TabIndex = 4;
			this.btnYrDec.Text = "-";
			this.btnYrDec.UseVisualStyleBackColor = false;
			// 
			// rDaily
			// 
			this.rDaily.AutoSize = true;
			this.rDaily.Checked = true;
			this.rDaily.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rDaily.Location = new System.Drawing.Point(135, 24);
			this.rDaily.Name = "rDaily";
			this.rDaily.Size = new System.Drawing.Size(61, 23);
			this.rDaily.TabIndex = 1;
			this.rDaily.TabStop = true;
			this.rDaily.Text = "Daily";
			this.rDaily.UseVisualStyleBackColor = true;
			// 
			// btnMInc
			// 
			this.btnMInc.AutoSize = true;
			this.btnMInc.BackColor = System.Drawing.Color.White;
			this.btnMInc.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
			this.btnMInc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMInc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMInc.ForeColor = System.Drawing.SystemColors.WindowText;
			this.btnMInc.Location = new System.Drawing.Point(651, 20);
			this.btnMInc.Name = "btnMInc";
			this.btnMInc.Size = new System.Drawing.Size(53, 31);
			this.btnMInc.TabIndex = 7;
			this.btnMInc.Text = "+";
			this.btnMInc.UseVisualStyleBackColor = false;
			// 
			// lblRepo
			// 
			this.lblRepo.AutoSize = true;
			this.lblRepo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRepo.Location = new System.Drawing.Point(23, 26);
			this.lblRepo.Name = "lblRepo";
			this.lblRepo.Size = new System.Drawing.Size(94, 19);
			this.lblRepo.TabIndex = 0;
			this.lblRepo.Text = "Sales Report";
			// 
			// pBody2
			// 
			this.pBody2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.pBody2.BackColor = System.Drawing.Color.White;
			this.pBody2.Controls.Add(this.pBody);
			this.pBody2.Controls.Add(this.lblBack);
			this.pBody2.Controls.Add(this.btnBack);
			this.pBody2.Controls.Add(this.lblTitle2);
			this.pBody2.Controls.Add(this.btnShow);
			this.pBody2.Controls.Add(this.btnPrnt);
			this.pBody2.Controls.Add(this.dataItms);
			this.pBody2.Controls.Add(this.lblSearch);
			this.pBody2.Controls.Add(this.txtSearch);
			this.pBody2.Location = new System.Drawing.Point(0, 3);
			this.pBody2.Name = "pBody2";
			this.pBody2.Size = new System.Drawing.Size(1211, 571);
			this.pBody2.TabIndex = 28;
			// 
			// lblBack
			// 
			this.lblBack.AutoSize = true;
			this.lblBack.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
			this.lblBack.ForeColor = System.Drawing.Color.Black;
			this.lblBack.Location = new System.Drawing.Point(63, 15);
			this.lblBack.Name = "lblBack";
			this.lblBack.Size = new System.Drawing.Size(41, 19);
			this.lblBack.TabIndex = 32;
			this.lblBack.Text = "Back";
			this.lblBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnBack
			// 
			this.btnBack.AutoSize = true;
			this.btnBack.BackColor = System.Drawing.Color.White;
			this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
			this.btnBack.FlatAppearance.BorderSize = 0;
			this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBack.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBack.ForeColor = System.Drawing.SystemColors.WindowText;
			this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
			this.btnBack.Location = new System.Drawing.Point(1, 0);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(56, 48);
			this.btnBack.TabIndex = 31;
			this.btnBack.UseVisualStyleBackColor = false;
			// 
			// lblTitle2
			// 
			this.lblTitle2.AutoSize = true;
			this.lblTitle2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
			this.lblTitle2.ForeColor = System.Drawing.Color.LimeGreen;
			this.lblTitle2.Location = new System.Drawing.Point(23, 51);
			this.lblTitle2.Name = "lblTitle2";
			this.lblTitle2.Size = new System.Drawing.Size(110, 23);
			this.lblTitle2.TabIndex = 9;
			this.lblTitle2.Text = "Sales Report";
			this.lblTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnShow
			// 
			this.btnShow.AutoSize = true;
			this.btnShow.BackColor = System.Drawing.Color.White;
			this.btnShow.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
			this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnShow.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnShow.ForeColor = System.Drawing.SystemColors.WindowText;
			this.btnShow.Location = new System.Drawing.Point(467, 84);
			this.btnShow.Name = "btnShow";
			this.btnShow.Size = new System.Drawing.Size(106, 31);
			this.btnShow.TabIndex = 28;
			this.btnShow.Text = "Show Bill";
			this.btnShow.UseVisualStyleBackColor = false;
			// 
			// btnPrnt
			// 
			this.btnPrnt.AutoSize = true;
			this.btnPrnt.BackColor = System.Drawing.Color.White;
			this.btnPrnt.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
			this.btnPrnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPrnt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPrnt.ForeColor = System.Drawing.SystemColors.WindowText;
			this.btnPrnt.Location = new System.Drawing.Point(355, 84);
			this.btnPrnt.Name = "btnPrnt";
			this.btnPrnt.Size = new System.Drawing.Size(106, 31);
			this.btnPrnt.TabIndex = 28;
			this.btnPrnt.Text = "Print Report";
			this.btnPrnt.UseVisualStyleBackColor = false;
			// 
			// dataItms
			// 
			this.dataItms.AllowUserToAddRows = false;
			this.dataItms.AllowUserToDeleteRows = false;
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(3);
			this.dataItms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
			this.dataItms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.dataItms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataItms.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataItms.BackgroundColor = System.Drawing.Color.White;
			this.dataItms.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataItms.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dataItms.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(3);
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataItms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
			this.dataItms.ColumnHeadersHeight = 35;
			dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataItms.DefaultCellStyle = dataGridViewCellStyle13;
			this.dataItms.EnableHeadersVisualStyles = false;
			this.dataItms.Location = new System.Drawing.Point(29, 128);
			this.dataItms.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this.dataItms.MultiSelect = false;
			this.dataItms.Name = "dataItms";
			this.dataItms.ReadOnly = true;
			dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle14.Padding = new System.Windows.Forms.Padding(5);
			dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataItms.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
			this.dataItms.RowHeadersVisible = false;
			dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle15.Padding = new System.Windows.Forms.Padding(5);
			this.dataItms.RowsDefaultCellStyle = dataGridViewCellStyle15;
			this.dataItms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataItms.Size = new System.Drawing.Size(1153, 422);
			this.dataItms.TabIndex = 27;
			// 
			// lblSearch
			// 
			this.lblSearch.AutoSize = true;
			this.lblSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSearch.Location = new System.Drawing.Point(23, 90);
			this.lblSearch.Name = "lblSearch";
			this.lblSearch.Size = new System.Drawing.Size(59, 19);
			this.lblSearch.TabIndex = 34;
			this.lblSearch.Text = "Search:";
			// 
			// txtSearch
			// 
			this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearch.Location = new System.Drawing.Point(88, 87);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(248, 27);
			this.txtSearch.TabIndex = 33;
			// 
			// dataBill
			// 
			this.dataBill.AllowUserToAddRows = false;
			this.dataBill.AllowUserToDeleteRows = false;
			dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle16.Padding = new System.Windows.Forms.Padding(3);
			this.dataBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
			this.dataBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.dataBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataBill.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataBill.BackgroundColor = System.Drawing.Color.White;
			this.dataBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataBill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dataBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle17.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle17.Padding = new System.Windows.Forms.Padding(3);
			dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
			this.dataBill.ColumnHeadersHeight = 35;
			dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle18.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataBill.DefaultCellStyle = dataGridViewCellStyle18;
			this.dataBill.EnableHeadersVisualStyles = false;
			this.dataBill.Location = new System.Drawing.Point(29, 99);
			this.dataBill.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this.dataBill.MultiSelect = false;
			this.dataBill.Name = "dataBill";
			this.dataBill.ReadOnly = true;
			dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle19.Padding = new System.Windows.Forms.Padding(5);
			dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
			this.dataBill.RowHeadersVisible = false;
			dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle20.Padding = new System.Windows.Forms.Padding(5);
			this.dataBill.RowsDefaultCellStyle = dataGridViewCellStyle20;
			this.dataBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataBill.Size = new System.Drawing.Size(1153, 402);
			this.dataBill.TabIndex = 29;
			// 
			// lblBack2
			// 
			this.lblBack2.AutoSize = true;
			this.lblBack2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
			this.lblBack2.ForeColor = System.Drawing.Color.Black;
			this.lblBack2.Location = new System.Drawing.Point(65, 18);
			this.lblBack2.Name = "lblBack2";
			this.lblBack2.Size = new System.Drawing.Size(41, 19);
			this.lblBack2.TabIndex = 34;
			this.lblBack2.Text = "Back";
			this.lblBack2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnBack2
			// 
			this.btnBack2.AutoSize = true;
			this.btnBack2.BackColor = System.Drawing.Color.White;
			this.btnBack2.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
			this.btnBack2.FlatAppearance.BorderSize = 0;
			this.btnBack2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBack2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBack2.ForeColor = System.Drawing.SystemColors.WindowText;
			this.btnBack2.Image = ((System.Drawing.Image)(resources.GetObject("btnBack2.Image")));
			this.btnBack2.Location = new System.Drawing.Point(3, 3);
			this.btnBack2.Name = "btnBack2";
			this.btnBack2.Size = new System.Drawing.Size(56, 48);
			this.btnBack2.TabIndex = 33;
			this.btnBack2.UseVisualStyleBackColor = false;
			// 
			// lblOrNum
			// 
			this.lblOrNum.AutoSize = true;
			this.lblOrNum.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOrNum.Location = new System.Drawing.Point(23, 54);
			this.lblOrNum.Name = "lblOrNum";
			this.lblOrNum.Size = new System.Drawing.Size(0, 19);
			this.lblOrNum.TabIndex = 35;
			// 
			// CtrlSalesReprt
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.pBody2);
			this.Controls.Add(this.dataBill);
			this.Controls.Add(this.lblBack2);
			this.Controls.Add(this.btnBack2);
			this.Controls.Add(this.lblOrNum);
			this.Name = "CtrlSalesReprt";
			this.Size = new System.Drawing.Size(1211, 577);
			this.pBody.ResumeLayout(false);
			this.pBody.PerformLayout();
			this.pBody2.ResumeLayout(false);
			this.pBody2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataItms)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataBill)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
