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
namespace point_of_sales_v3
{
	partial class CtrlProdB
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.FlowLayoutPanel pItms;
		private System.Windows.Forms.FlowLayoutPanel pCtgry;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Label lblItms;
		public System.Windows.Forms.Button btnCharge;
		public System.Windows.Forms.DataGridView dataItms;
		private System.Windows.Forms.DataGridViewButtonColumn colDel;
		private System.Windows.Forms.DataGridViewTextBoxColumn colName;
		private System.Windows.Forms.DataGridViewButtonColumn colDec;
		private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
		private System.Windows.Forms.DataGridViewButtonColumn colInc;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSub;
		private System.Windows.Forms.Label lblSearch;
		private System.Windows.Forms.Button btnClr;
		private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
		private System.Windows.Forms.Panel pMain;
		private System.Windows.Forms.Panel pPayDialog;
		private System.Windows.Forms.Panel pBorder;
		private System.Windows.Forms.Label lblChangeVal;
		private System.Windows.Forms.Label lblAmtPaidVal;
		private System.Windows.Forms.Label lblFinTotalVal;
		private System.Windows.Forms.Label lblBack;
		private System.Windows.Forms.Label lblError;
		private System.Windows.Forms.Label lblTotalAmt;
		public System.Windows.Forms.Button btnPrint;
		private System.Windows.Forms.Label lblAmt;
		private System.Windows.Forms.TextBox txtAmt;
		public System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Label lblAmtPaid;
		private System.Windows.Forms.Label lblChange;
		private System.Windows.Forms.Label lblFinTotalItmsVal;
		private System.Windows.Forms.Label lblFinTotalItms;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlProdB));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
			this.pMain = new System.Windows.Forms.Panel();
			this.pPayDialog = new System.Windows.Forms.Panel();
			this.pBorder = new System.Windows.Forms.Panel();
			this.lblChangeVal = new System.Windows.Forms.Label();
			this.lblAmtPaidVal = new System.Windows.Forms.Label();
			this.lblFinTotalVal = new System.Windows.Forms.Label();
			this.lblBack = new System.Windows.Forms.Label();
			this.lblError = new System.Windows.Forms.Label();
			this.lblTotalAmt = new System.Windows.Forms.Label();
			this.btnPrint = new System.Windows.Forms.Button();
			this.lblAmt = new System.Windows.Forms.Label();
			this.txtAmt = new System.Windows.Forms.TextBox();
			this.btnBack = new System.Windows.Forms.Button();
			this.lblAmtPaid = new System.Windows.Forms.Label();
			this.lblChange = new System.Windows.Forms.Label();
			this.lblFinTotalItmsVal = new System.Windows.Forms.Label();
			this.lblFinTotalItms = new System.Windows.Forms.Label();
			this.dataItms = new System.Windows.Forms.DataGridView();
			this.colDel = new System.Windows.Forms.DataGridViewButtonColumn();
			this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDec = new System.Windows.Forms.DataGridViewButtonColumn();
			this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colInc = new System.Windows.Forms.DataGridViewButtonColumn();
			this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSub = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblSearch = new System.Windows.Forms.Label();
			this.btnClr = new System.Windows.Forms.Button();
			this.btnCharge = new System.Windows.Forms.Button();
			this.lblItms = new System.Windows.Forms.Label();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.pCtgry = new System.Windows.Forms.FlowLayoutPanel();
			this.pItms = new System.Windows.Forms.FlowLayoutPanel();
			this.pMain.SuspendLayout();
			this.pPayDialog.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataItms)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewButtonColumn1
			// 
			this.dataGridViewButtonColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewButtonColumn1.HeaderText = "";
			this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
			this.dataGridViewButtonColumn1.ReadOnly = true;
			// 
			// pMain
			// 
			this.pMain.Controls.Add(this.pPayDialog);
			this.pMain.Controls.Add(this.dataItms);
			this.pMain.Controls.Add(this.lblSearch);
			this.pMain.Controls.Add(this.btnClr);
			this.pMain.Controls.Add(this.btnCharge);
			this.pMain.Controls.Add(this.lblItms);
			this.pMain.Controls.Add(this.txtSearch);
			this.pMain.Controls.Add(this.pCtgry);
			this.pMain.Controls.Add(this.pItms);
			this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pMain.Location = new System.Drawing.Point(0, 0);
			this.pMain.Name = "pMain";
			this.pMain.Size = new System.Drawing.Size(1250, 623);
			this.pMain.TabIndex = 0;
			// 
			// pPayDialog
			// 
			this.pPayDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.pPayDialog.BackColor = System.Drawing.Color.White;
			this.pPayDialog.Controls.Add(this.pBorder);
			this.pPayDialog.Controls.Add(this.lblChangeVal);
			this.pPayDialog.Controls.Add(this.lblAmtPaidVal);
			this.pPayDialog.Controls.Add(this.lblFinTotalVal);
			this.pPayDialog.Controls.Add(this.lblBack);
			this.pPayDialog.Controls.Add(this.lblError);
			this.pPayDialog.Controls.Add(this.lblTotalAmt);
			this.pPayDialog.Controls.Add(this.btnPrint);
			this.pPayDialog.Controls.Add(this.lblAmt);
			this.pPayDialog.Controls.Add(this.txtAmt);
			this.pPayDialog.Controls.Add(this.btnBack);
			this.pPayDialog.Controls.Add(this.lblAmtPaid);
			this.pPayDialog.Controls.Add(this.lblChange);
			this.pPayDialog.Controls.Add(this.lblFinTotalItmsVal);
			this.pPayDialog.Controls.Add(this.lblFinTotalItms);
			this.pPayDialog.Location = new System.Drawing.Point(0, 0);
			this.pPayDialog.Name = "pPayDialog";
			this.pPayDialog.Size = new System.Drawing.Size(1250, 624);
			this.pPayDialog.TabIndex = 24;
			this.pPayDialog.Visible = false;
			// 
			// pBorder
			// 
			this.pBorder.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pBorder.BackColor = System.Drawing.Color.LightGray;
			this.pBorder.Location = new System.Drawing.Point(180, 227);
			this.pBorder.Name = "pBorder";
			this.pBorder.Size = new System.Drawing.Size(891, 1);
			this.pBorder.TabIndex = 27;
			// 
			// lblChangeVal
			// 
			this.lblChangeVal.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblChangeVal.Font = new System.Drawing.Font("Myriad Hebrew", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblChangeVal.Location = new System.Drawing.Point(628, 243);
			this.lblChangeVal.Name = "lblChangeVal";
			this.lblChangeVal.Size = new System.Drawing.Size(380, 79);
			this.lblChangeVal.TabIndex = 26;
			this.lblChangeVal.Text = "P 0.00";
			this.lblChangeVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblAmtPaidVal
			// 
			this.lblAmtPaidVal.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblAmtPaidVal.Font = new System.Drawing.Font("Myriad Hebrew", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAmtPaidVal.Location = new System.Drawing.Point(242, 243);
			this.lblAmtPaidVal.Name = "lblAmtPaidVal";
			this.lblAmtPaidVal.Size = new System.Drawing.Size(380, 79);
			this.lblAmtPaidVal.TabIndex = 26;
			this.lblAmtPaidVal.Text = "P 0.00";
			this.lblAmtPaidVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblFinTotalVal
			// 
			this.lblFinTotalVal.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblFinTotalVal.Font = new System.Drawing.Font("Myriad Hebrew", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFinTotalVal.Location = new System.Drawing.Point(245, 88);
			this.lblFinTotalVal.Name = "lblFinTotalVal";
			this.lblFinTotalVal.Size = new System.Drawing.Size(760, 79);
			this.lblFinTotalVal.TabIndex = 16;
			this.lblFinTotalVal.Text = "P 0.00";
			this.lblFinTotalVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblBack
			// 
			this.lblBack.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblBack.AutoSize = true;
			this.lblBack.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
			this.lblBack.ForeColor = System.Drawing.Color.Black;
			this.lblBack.Location = new System.Drawing.Point(62, 15);
			this.lblBack.Name = "lblBack";
			this.lblBack.Size = new System.Drawing.Size(41, 19);
			this.lblBack.TabIndex = 25;
			this.lblBack.Text = "Back";
			this.lblBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblError
			// 
			this.lblError.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblError.AutoSize = true;
			this.lblError.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
			this.lblError.Location = new System.Drawing.Point(518, 420);
			this.lblError.Name = "lblError";
			this.lblError.Size = new System.Drawing.Size(214, 19);
			this.lblError.TabIndex = 22;
			this.lblError.Text = "Amount value is not accepted";
			this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblError.Visible = false;
			// 
			// lblTotalAmt
			// 
			this.lblTotalAmt.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblTotalAmt.AutoSize = true;
			this.lblTotalAmt.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
			this.lblTotalAmt.ForeColor = System.Drawing.Color.Gray;
			this.lblTotalAmt.Location = new System.Drawing.Point(569, 174);
			this.lblTotalAmt.Name = "lblTotalAmt";
			this.lblTotalAmt.Size = new System.Drawing.Size(112, 22);
			this.lblTotalAmt.TabIndex = 22;
			this.lblTotalAmt.Text = "Total Amount";
			this.lblTotalAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnPrint
			// 
			this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnPrint.AutoSize = true;
			this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(195)))), ((int)(((byte)(46)))));
			this.btnPrint.FlatAppearance.BorderSize = 0;
			this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPrint.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPrint.ForeColor = System.Drawing.Color.White;
			this.btnPrint.Location = new System.Drawing.Point(465, 460);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(320, 58);
			this.btnPrint.TabIndex = 21;
			this.btnPrint.Text = "Print";
			this.btnPrint.UseVisualStyleBackColor = false;
			// 
			// lblAmt
			// 
			this.lblAmt.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblAmt.AutoSize = true;
			this.lblAmt.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
			this.lblAmt.Location = new System.Drawing.Point(457, 381);
			this.lblAmt.Name = "lblAmt";
			this.lblAmt.Size = new System.Drawing.Size(77, 22);
			this.lblAmt.TabIndex = 20;
			this.lblAmt.Text = "Amount:";
			this.lblAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtAmt
			// 
			this.txtAmt.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtAmt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAmt.Location = new System.Drawing.Point(560, 378);
			this.txtAmt.MaxLength = 10;
			this.txtAmt.Name = "txtAmt";
			this.txtAmt.Size = new System.Drawing.Size(233, 27);
			this.txtAmt.TabIndex = 19;
			this.txtAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btnBack
			// 
			this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnBack.AutoSize = true;
			this.btnBack.BackColor = System.Drawing.Color.White;
			this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
			this.btnBack.FlatAppearance.BorderSize = 0;
			this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBack.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBack.ForeColor = System.Drawing.SystemColors.WindowText;
			this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
			this.btnBack.Location = new System.Drawing.Point(0, 0);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(56, 48);
			this.btnBack.TabIndex = 18;
			this.btnBack.UseVisualStyleBackColor = false;
			// 
			// lblAmtPaid
			// 
			this.lblAmtPaid.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblAmtPaid.AutoSize = true;
			this.lblAmtPaid.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
			this.lblAmtPaid.ForeColor = System.Drawing.Color.Gray;
			this.lblAmtPaid.Location = new System.Drawing.Point(380, 322);
			this.lblAmtPaid.Name = "lblAmtPaid";
			this.lblAmtPaid.Size = new System.Drawing.Size(109, 22);
			this.lblAmtPaid.TabIndex = 15;
			this.lblAmtPaid.Text = "Amount Paid";
			this.lblAmtPaid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblChange
			// 
			this.lblChange.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblChange.AutoSize = true;
			this.lblChange.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
			this.lblChange.ForeColor = System.Drawing.Color.Gray;
			this.lblChange.Location = new System.Drawing.Point(784, 322);
			this.lblChange.Name = "lblChange";
			this.lblChange.Size = new System.Drawing.Size(67, 22);
			this.lblChange.TabIndex = 15;
			this.lblChange.Text = "Change";
			this.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblFinTotalItmsVal
			// 
			this.lblFinTotalItmsVal.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblFinTotalItmsVal.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
			this.lblFinTotalItmsVal.Location = new System.Drawing.Point(560, 266);
			this.lblFinTotalItmsVal.Name = "lblFinTotalItmsVal";
			this.lblFinTotalItmsVal.Size = new System.Drawing.Size(233, 22);
			this.lblFinTotalItmsVal.TabIndex = 16;
			this.lblFinTotalItmsVal.Text = "0";
			this.lblFinTotalItmsVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblFinTotalItmsVal.Visible = false;
			// 
			// lblFinTotalItms
			// 
			this.lblFinTotalItms.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblFinTotalItms.AutoSize = true;
			this.lblFinTotalItms.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
			this.lblFinTotalItms.Location = new System.Drawing.Point(457, 266);
			this.lblFinTotalItms.Name = "lblFinTotalItms";
			this.lblFinTotalItms.Size = new System.Drawing.Size(97, 22);
			this.lblFinTotalItms.TabIndex = 15;
			this.lblFinTotalItms.Text = "Total Items:";
			this.lblFinTotalItms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblFinTotalItms.Visible = false;
			// 
			// dataItms
			// 
			this.dataItms.AllowUserToAddRows = false;
			this.dataItms.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
			this.dataItms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
			this.dataItms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.colDel,
			this.colName,
			this.colDec,
			this.colQty,
			this.colInc,
			this.colPrice,
			this.colSub});
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataItms.DefaultCellStyle = dataGridViewCellStyle5;
			this.dataItms.EnableHeadersVisualStyles = false;
			this.dataItms.Location = new System.Drawing.Point(688, 58);
			this.dataItms.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this.dataItms.Name = "dataItms";
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5);
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataItms.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dataItms.RowHeadersVisible = false;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5);
			this.dataItms.RowsDefaultCellStyle = dataGridViewCellStyle7;
			this.dataItms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataItms.Size = new System.Drawing.Size(560, 438);
			this.dataItms.TabIndex = 18;
			// 
			// colDel
			// 
			this.colDel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.colDel.DefaultCellStyle = dataGridViewCellStyle3;
			this.colDel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.colDel.HeaderText = "";
			this.colDel.MinimumWidth = 33;
			this.colDel.Name = "colDel";
			this.colDel.ReadOnly = true;
			this.colDel.Text = "X";
			this.colDel.UseColumnTextForButtonValue = true;
			this.colDel.Width = 33;
			// 
			// colName
			// 
			this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colName.HeaderText = "Name";
			this.colName.Name = "colName";
			this.colName.ReadOnly = true;
			// 
			// colDec
			// 
			this.colDec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colDec.HeaderText = "";
			this.colDec.Name = "colDec";
			this.colDec.ReadOnly = true;
			this.colDec.Width = 7;
			// 
			// colQty
			// 
			this.colQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle4.NullValue = null;
			this.colQty.DefaultCellStyle = dataGridViewCellStyle4;
			this.colQty.HeaderText = "Quantity";
			this.colQty.MaxInputLength = 9;
			this.colQty.Name = "colQty";
			// 
			// colInc
			// 
			this.colInc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colInc.HeaderText = "";
			this.colInc.Name = "colInc";
			this.colInc.ReadOnly = true;
			this.colInc.Width = 7;
			// 
			// colPrice
			// 
			this.colPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colPrice.HeaderText = "Price";
			this.colPrice.Name = "colPrice";
			this.colPrice.ReadOnly = true;
			// 
			// colSub
			// 
			this.colSub.HeaderText = "Subtotal";
			this.colSub.Name = "colSub";
			this.colSub.ReadOnly = true;
			// 
			// lblSearch
			// 
			this.lblSearch.AutoSize = true;
			this.lblSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSearch.Location = new System.Drawing.Point(19, 20);
			this.lblSearch.Name = "lblSearch";
			this.lblSearch.Size = new System.Drawing.Size(59, 19);
			this.lblSearch.TabIndex = 20;
			this.lblSearch.Text = "Search:";
			// 
			// btnClr
			// 
			this.btnClr.AutoSize = true;
			this.btnClr.BackColor = System.Drawing.Color.White;
			this.btnClr.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
			this.btnClr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClr.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClr.ForeColor = System.Drawing.SystemColors.WindowText;
			this.btnClr.Location = new System.Drawing.Point(338, 15);
			this.btnClr.Name = "btnClr";
			this.btnClr.Size = new System.Drawing.Size(78, 31);
			this.btnClr.TabIndex = 19;
			this.btnClr.Text = "Clear";
			this.btnClr.UseVisualStyleBackColor = false;
			// 
			// btnCharge
			// 
			this.btnCharge.AutoSize = true;
			this.btnCharge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(195)))), ((int)(((byte)(46)))));
			this.btnCharge.FlatAppearance.BorderSize = 0;
			this.btnCharge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCharge.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
			this.btnCharge.ForeColor = System.Drawing.Color.White;
			this.btnCharge.Location = new System.Drawing.Point(691, 562);
			this.btnCharge.Name = "btnCharge";
			this.btnCharge.Size = new System.Drawing.Size(556, 58);
			this.btnCharge.TabIndex = 17;
			this.btnCharge.Text = "Charge P 0.00";
			this.btnCharge.UseVisualStyleBackColor = false;
			// 
			// lblItms
			// 
			this.lblItms.BackColor = System.Drawing.Color.White;
			this.lblItms.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblItms.Location = new System.Drawing.Point(688, 0);
			this.lblItms.Name = "lblItms";
			this.lblItms.Size = new System.Drawing.Size(562, 58);
			this.lblItms.TabIndex = 16;
			this.lblItms.Text = "ITEMS";
			this.lblItms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtSearch
			// 
			this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearch.Location = new System.Drawing.Point(84, 17);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(248, 27);
			this.txtSearch.TabIndex = 15;
			// 
			// pCtgry
			// 
			this.pCtgry.AutoScroll = true;
			this.pCtgry.BackColor = System.Drawing.Color.White;
			this.pCtgry.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.pCtgry.Location = new System.Drawing.Point(0, 495);
			this.pCtgry.Margin = new System.Windows.Forms.Padding(0);
			this.pCtgry.Name = "pCtgry";
			this.pCtgry.Size = new System.Drawing.Size(688, 128);
			this.pCtgry.TabIndex = 14;
			// 
			// pItms
			// 
			this.pItms.AutoScroll = true;
			this.pItms.BackColor = System.Drawing.Color.White;
			this.pItms.Location = new System.Drawing.Point(0, 58);
			this.pItms.Margin = new System.Windows.Forms.Padding(0);
			this.pItms.Name = "pItms";
			this.pItms.Size = new System.Drawing.Size(688, 437);
			this.pItms.TabIndex = 13;
			// 
			// CtrlProdB
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pMain);
			this.Name = "CtrlProdB";
			this.Size = new System.Drawing.Size(1250, 623);
			this.pMain.ResumeLayout(false);
			this.pMain.PerformLayout();
			this.pPayDialog.ResumeLayout(false);
			this.pPayDialog.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataItms)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
