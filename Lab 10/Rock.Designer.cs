namespace Lab_10
{
    partial class Rock
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
            this.rdR80 = new System.Windows.Forms.RadioButton();
            this.rdR90 = new System.Windows.Forms.RadioButton();
            this.rdRToday = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRPrice = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstRSummary = new System.Windows.Forms.ListBox();
            this.lstRBought = new System.Windows.Forms.ListBox();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBackTo = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdR80
            // 
            this.rdR80.AutoSize = true;
            this.rdR80.Location = new System.Drawing.Point(10, 10);
            this.rdR80.Name = "rdR80";
            this.rdR80.Size = new System.Drawing.Size(44, 17);
            this.rdR80.TabIndex = 0;
            this.rdR80.TabStop = true;
            this.rdR80.Text = "80\'s";
            this.rdR80.UseVisualStyleBackColor = true;
            this.rdR80.CheckedChanged += new System.EventHandler(this.rdR80_CheckedChanged);
            // 
            // rdR90
            // 
            this.rdR90.AutoSize = true;
            this.rdR90.Location = new System.Drawing.Point(10, 54);
            this.rdR90.Name = "rdR90";
            this.rdR90.Size = new System.Drawing.Size(44, 17);
            this.rdR90.TabIndex = 1;
            this.rdR90.TabStop = true;
            this.rdR90.Text = "90\'s";
            this.rdR90.UseVisualStyleBackColor = true;
            this.rdR90.CheckedChanged += new System.EventHandler(this.rdR90_CheckedChanged);
            // 
            // rdRToday
            // 
            this.rdRToday.AutoSize = true;
            this.rdRToday.Location = new System.Drawing.Point(10, 98);
            this.rdRToday.Name = "rdRToday";
            this.rdRToday.Size = new System.Drawing.Size(55, 17);
            this.rdRToday.TabIndex = 2;
            this.rdRToday.TabStop = true;
            this.rdRToday.Text = "Today";
            this.rdRToday.UseVisualStyleBackColor = true;
            this.rdRToday.CheckedChanged += new System.EventHandler(this.rdRToday_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdRToday);
            this.panel1.Controls.Add(this.rdR90);
            this.panel1.Controls.Add(this.rdR80);
            this.panel1.Location = new System.Drawing.Point(23, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 130);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Year";
            // 
            // txtRPrice
            // 
            this.txtRPrice.Location = new System.Drawing.Point(522, 334);
            this.txtRPrice.Name = "txtRPrice";
            this.txtRPrice.ReadOnly = true;
            this.txtRPrice.Size = new System.Drawing.Size(100, 20);
            this.txtRPrice.TabIndex = 6;
            this.txtRPrice.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(170, 272);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstRSummary
            // 
            this.lstRSummary.FormattingEnabled = true;
            this.lstRSummary.Location = new System.Drawing.Point(160, 42);
            this.lstRSummary.Name = "lstRSummary";
            this.lstRSummary.Size = new System.Drawing.Size(335, 212);
            this.lstRSummary.TabIndex = 9;
            this.lstRSummary.TabStop = false;
            // 
            // lstRBought
            // 
            this.lstRBought.FormattingEnabled = true;
            this.lstRBought.Location = new System.Drawing.Point(522, 42);
            this.lstRBought.Name = "lstRBought";
            this.lstRBought.Size = new System.Drawing.Size(358, 277);
            this.lstRBought.TabIndex = 10;
            this.lstRBought.TabStop = false;
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(522, 360);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(75, 23);
            this.btnTotal.TabIndex = 5;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(777, 332);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBackTo
            // 
            this.btnBackTo.Location = new System.Drawing.Point(248, 360);
            this.btnBackTo.Name = "btnBackTo";
            this.btnBackTo.Size = new System.Drawing.Size(168, 23);
            this.btnBackTo.TabIndex = 7;
            this.btnBackTo.Text = "Back To Menu";
            this.btnBackTo.UseVisualStyleBackColor = true;
            this.btnBackTo.Click += new System.EventHandler(this.btnBackTo_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(397, 272);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Rock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 430);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBackTo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.lstRBought);
            this.Controls.Add(this.lstRSummary);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtRPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Rock";
            this.Text = "Rock";
            this.Load += new System.EventHandler(this.Rock_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdR80;
        private System.Windows.Forms.RadioButton rdR90;
        private System.Windows.Forms.RadioButton rdRToday;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstRSummary;
        private System.Windows.Forms.ListBox lstRBought;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBackTo;
        private System.Windows.Forms.Button btnDelete;
    }
}