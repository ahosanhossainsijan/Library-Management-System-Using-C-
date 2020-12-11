namespace project
{
    partial class BorrowHistoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvBorrowHistory = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBorrowHistory = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dtpRDate = new System.Windows.Forms.DateTimePicker();
            this.dtpERDate = new System.Windows.Forms.DateTimePicker();
            this.dtpBDate = new System.Windows.Forms.DateTimePicker();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtLostFine = new System.Windows.Forms.TextBox();
            this.lblLostFine = new System.Windows.Forms.Label();
            this.txtLateFine = new System.Windows.Forms.TextBox();
            this.lblLateFine = new System.Windows.Forms.Label();
            this.lblRDate = new System.Windows.Forms.Label();
            this.lblERDate = new System.Windows.Forms.Label();
            this.lblBDate = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.lblBName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUName = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblUN = new System.Windows.Forms.Label();
            this.lblUBH = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowHistory)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 431F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1282, 653);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvBorrowHistory);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(435, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(843, 645);
            this.panel2.TabIndex = 2;
            // 
            // dgvBorrowHistory
            // 
            this.dgvBorrowHistory.AllowUserToAddRows = false;
            this.dgvBorrowHistory.AllowUserToDeleteRows = false;
            this.dgvBorrowHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrowHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBorrowHistory.Location = new System.Drawing.Point(0, 0);
            this.dgvBorrowHistory.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBorrowHistory.Name = "dgvBorrowHistory";
            this.dgvBorrowHistory.ReadOnly = true;
            this.dgvBorrowHistory.Size = new System.Drawing.Size(843, 645);
            this.dgvBorrowHistory.TabIndex = 0;
            this.dgvBorrowHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBorrowHistory_CellContentClick);
            this.dgvBorrowHistory.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBorrowHistory_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblUBH);
            this.panel1.Controls.Add(this.lblUN);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.lblBorrowHistory);
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Controls.Add(this.dtpRDate);
            this.panel1.Controls.Add(this.dtpERDate);
            this.panel1.Controls.Add(this.dtpBDate);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.txtLostFine);
            this.panel1.Controls.Add(this.lblLostFine);
            this.panel1.Controls.Add(this.txtLateFine);
            this.panel1.Controls.Add(this.lblLateFine);
            this.panel1.Controls.Add(this.lblRDate);
            this.panel1.Controls.Add(this.lblERDate);
            this.panel1.Controls.Add(this.lblBDate);
            this.panel1.Controls.Add(this.txtBookName);
            this.panel1.Controls.Add(this.lblBName);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.lblUName);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 645);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblBorrowHistory
            // 
            this.lblBorrowHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowHistory.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblBorrowHistory.Location = new System.Drawing.Point(134, 61);
            this.lblBorrowHistory.Margin = new System.Windows.Forms.Padding(3);
            this.lblBorrowHistory.Name = "lblBorrowHistory";
            this.lblBorrowHistory.Size = new System.Drawing.Size(187, 64);
            this.lblBorrowHistory.TabIndex = 26;
            this.lblBorrowHistory.Text = "Borrow History";
            this.lblBorrowHistory.Click += new System.EventHandler(this.lblBorrowHistory_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(306, 566);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(100, 39);
            this.btnLoad.TabIndex = 25;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dtpRDate
            // 
            this.dtpRDate.CalendarMonthBackground = System.Drawing.SystemColors.ActiveBorder;
            this.dtpRDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRDate.Location = new System.Drawing.Point(238, 410);
            this.dtpRDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpRDate.Name = "dtpRDate";
            this.dtpRDate.Size = new System.Drawing.Size(132, 22);
            this.dtpRDate.TabIndex = 24;
            // 
            // dtpERDate
            // 
            this.dtpERDate.CalendarMonthBackground = System.Drawing.SystemColors.ActiveBorder;
            this.dtpERDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpERDate.Location = new System.Drawing.Point(238, 371);
            this.dtpERDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpERDate.Name = "dtpERDate";
            this.dtpERDate.Size = new System.Drawing.Size(132, 22);
            this.dtpERDate.TabIndex = 23;
            // 
            // dtpBDate
            // 
            this.dtpBDate.CalendarMonthBackground = System.Drawing.SystemColors.ActiveBorder;
            this.dtpBDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBDate.Location = new System.Drawing.Point(238, 338);
            this.dtpBDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpBDate.Name = "dtpBDate";
            this.dtpBDate.Size = new System.Drawing.Size(132, 22);
            this.dtpBDate.TabIndex = 22;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Orange;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(306, 4);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 39);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(164, 566);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 39);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtLostFine
            // 
            this.txtLostFine.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtLostFine.Location = new System.Drawing.Point(238, 473);
            this.txtLostFine.Margin = new System.Windows.Forms.Padding(4);
            this.txtLostFine.Name = "txtLostFine";
            this.txtLostFine.Size = new System.Drawing.Size(132, 22);
            this.txtLostFine.TabIndex = 15;
            // 
            // lblLostFine
            // 
            this.lblLostFine.AutoSize = true;
            this.lblLostFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLostFine.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblLostFine.Location = new System.Drawing.Point(135, 473);
            this.lblLostFine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLostFine.Name = "lblLostFine";
            this.lblLostFine.Size = new System.Drawing.Size(89, 20);
            this.lblLostFine.TabIndex = 14;
            this.lblLostFine.Text = "Lost Fine :";
            // 
            // txtLateFine
            // 
            this.txtLateFine.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtLateFine.Location = new System.Drawing.Point(238, 443);
            this.txtLateFine.Margin = new System.Windows.Forms.Padding(4);
            this.txtLateFine.Name = "txtLateFine";
            this.txtLateFine.Size = new System.Drawing.Size(132, 22);
            this.txtLateFine.TabIndex = 13;
            // 
            // lblLateFine
            // 
            this.lblLateFine.AutoSize = true;
            this.lblLateFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLateFine.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblLateFine.Location = new System.Drawing.Point(135, 443);
            this.lblLateFine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLateFine.Name = "lblLateFine";
            this.lblLateFine.Size = new System.Drawing.Size(89, 20);
            this.lblLateFine.TabIndex = 12;
            this.lblLateFine.Text = "Late Fine :";
            // 
            // lblRDate
            // 
            this.lblRDate.AutoSize = true;
            this.lblRDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRDate.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblRDate.Location = new System.Drawing.Point(114, 410);
            this.lblRDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRDate.Name = "lblRDate";
            this.lblRDate.Size = new System.Drawing.Size(110, 20);
            this.lblRDate.TabIndex = 10;
            this.lblRDate.Text = "Return Date :";
            // 
            // lblERDate
            // 
            this.lblERDate.AutoSize = true;
            this.lblERDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblERDate.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblERDate.Location = new System.Drawing.Point(40, 371);
            this.lblERDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblERDate.Name = "lblERDate";
            this.lblERDate.Size = new System.Drawing.Size(184, 20);
            this.lblERDate.TabIndex = 8;
            this.lblERDate.Text = "Expected Return Date :";
            this.lblERDate.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblBDate
            // 
            this.lblBDate.AutoSize = true;
            this.lblBDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBDate.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblBDate.Location = new System.Drawing.Point(110, 340);
            this.lblBDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBDate.Name = "lblBDate";
            this.lblBDate.Size = new System.Drawing.Size(114, 20);
            this.lblBDate.TabIndex = 6;
            this.lblBDate.Text = "Borrow Date :";
            this.lblBDate.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtBookName
            // 
            this.txtBookName.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtBookName.Location = new System.Drawing.Point(238, 299);
            this.txtBookName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(132, 22);
            this.txtBookName.TabIndex = 5;
            // 
            // lblBName
            // 
            this.lblBName.AutoSize = true;
            this.lblBName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBName.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblBName.Location = new System.Drawing.Point(118, 299);
            this.lblBName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBName.Name = "lblBName";
            this.lblBName.Size = new System.Drawing.Size(106, 20);
            this.lblBName.TabIndex = 4;
            this.lblBName.Text = "Book Name :";
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtUserName.Location = new System.Drawing.Point(238, 267);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(132, 22);
            this.txtUserName.TabIndex = 3;
            // 
            // lblUName
            // 
            this.lblUName.AutoSize = true;
            this.lblUName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUName.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblUName.Location = new System.Drawing.Point(120, 267);
            this.lblUName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUName.Name = "lblUName";
            this.lblUName.Size = new System.Drawing.Size(104, 20);
            this.lblUName.TabIndex = 2;
            this.lblUName.Text = "User Name :";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtId.Location = new System.Drawing.Point(238, 235);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(132, 22);
            this.txtId.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblId.Location = new System.Drawing.Point(192, 235);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(32, 20);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id :";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtSearch.Location = new System.Drawing.Point(124, 132);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(132, 22);
            this.txtSearch.TabIndex = 27;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.Location = new System.Drawing.Point(264, 128);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(78, 29);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(14, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 39);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblUN
            // 
            this.lblUN.AutoSize = true;
            this.lblUN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUN.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblUN.Location = new System.Drawing.Point(20, 132);
            this.lblUN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUN.Name = "lblUN";
            this.lblUN.Size = new System.Drawing.Size(104, 20);
            this.lblUN.TabIndex = 29;
            this.lblUN.Text = "User Name :";
            // 
            // lblUBH
            // 
            this.lblUBH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUBH.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblUBH.Location = new System.Drawing.Point(98, 187);
            this.lblUBH.Margin = new System.Windows.Forms.Padding(3);
            this.lblUBH.Name = "lblUBH";
            this.lblUBH.Size = new System.Drawing.Size(326, 41);
            this.lblUBH.TabIndex = 30;
            this.lblUBH.Text = "Update Borrow History";
            // 
            // BorrowHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1282, 653);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BorrowHistoryForm";
            this.Text = "BorrowHistoryForm";
            this.Load += new System.EventHandler(this.BorrowHistoryForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowHistory)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvBorrowHistory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpRDate;
        private System.Windows.Forms.DateTimePicker dtpERDate;
        private System.Windows.Forms.DateTimePicker dtpBDate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtLostFine;
        private System.Windows.Forms.Label lblLostFine;
        private System.Windows.Forms.TextBox txtLateFine;
        private System.Windows.Forms.Label lblLateFine;
        private System.Windows.Forms.Label lblRDate;
        private System.Windows.Forms.Label lblERDate;
        private System.Windows.Forms.Label lblBDate;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label lblBName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblBorrowHistory;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblUBH;
        private System.Windows.Forms.Label lblUN;
    }
}