namespace Lab_10
{
    partial class Pop
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
            this.rdP80 = new System.Windows.Forms.RadioButton();
            this.rdP90 = new System.Windows.Forms.RadioButton();
            this.rdPToday = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPPrice = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lstPSummary = new System.Windows.Forms.ListBox();
            this.lstPBought = new System.Windows.Forms.ListBox();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBackTo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdP80
            // 
            this.rdP80.AutoSize = true;
            this.rdP80.Location = new System.Drawing.Point(22, 20);
            this.rdP80.Name = "rdP80";
            this.rdP80.Size = new System.Drawing.Size(44, 17);
            this.rdP80.TabIndex = 0;
            this.rdP80.TabStop = true;
            this.rdP80.Text = "80\'s";
            this.rdP80.UseVisualStyleBackColor = true;
            this.rdP80.CheckedChanged += new System.EventHandler(this.rdP80_CheckedChanged);
            // 
            // rdP90
            // 
            this.rdP90.AutoSize = true;
            this.rdP90.Location = new System.Drawing.Point(22, 61);
            this.rdP90.Name = "rdP90";
            this.rdP90.Size = new System.Drawing.Size(44, 17);
            this.rdP90.TabIndex = 1;
            this.rdP90.TabStop = true;
            this.rdP90.Text = "90\'s";
            this.rdP90.UseVisualStyleBackColor = true;
            this.rdP90.CheckedChanged += new System.EventHandler(this.rdP90_CheckedChanged);
            // 
            // rdPToday
            // 
            this.rdPToday.AutoSize = true;
            this.rdPToday.Location = new System.Drawing.Point(22, 102);
            this.rdPToday.Name = "rdPToday";
            this.rdPToday.Size = new System.Drawing.Size(55, 17);
            this.rdPToday.TabIndex = 2;
            this.rdPToday.TabStop = true;
            this.rdPToday.Text = "Today";
            this.rdPToday.UseVisualStyleBackColor = true;
            this.rdPToday.CheckedChanged += new System.EventHandler(this.rdPToday_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdPToday);
            this.panel1.Controls.Add(this.rdP90);
            this.panel1.Controls.Add(this.rdP80);
            this.panel1.Location = new System.Drawing.Point(18, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 140);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Year";
            // 
            // txtPPrice
            // 
            this.txtPPrice.Location = new System.Drawing.Point(522, 276);
            this.txtPPrice.Name = "txtPPrice";
            this.txtPPrice.ReadOnly = true;
            this.txtPPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPPrice.TabIndex = 6;
            this.txtPPrice.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(182, 222);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(385, 222);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lstPSummary
            // 
            this.lstPSummary.FormattingEnabled = true;
            this.lstPSummary.Location = new System.Drawing.Point(182, 32);
            this.lstPSummary.Name = "lstPSummary";
            this.lstPSummary.Size = new System.Drawing.Size(313, 173);
            this.lstPSummary.TabIndex = 9;
            this.lstPSummary.TabStop = false;
            // 
            // lstPBought
            // 
            this.lstPBought.FormattingEnabled = true;
            this.lstPBought.Location = new System.Drawing.Point(522, 32);
            this.lstPBought.Name = "lstPBought";
            this.lstPBought.Size = new System.Drawing.Size(335, 225);
            this.lstPBought.TabIndex = 10;
            this.lstPBought.TabStop = false;
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(522, 312);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(75, 23);
            this.btnTotal.TabIndex = 6;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(766, 276);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBackTo
            // 
            this.btnBackTo.Location = new System.Drawing.Point(255, 312);
            this.btnBackTo.Name = "btnBackTo";
            this.btnBackTo.Size = new System.Drawing.Size(176, 23);
            this.btnBackTo.TabIndex = 7;
            this.btnBackTo.Text = "Back To Menu";
            this.btnBackTo.UseVisualStyleBackColor = true;
            this.btnBackTo.Click += new System.EventHandler(this.btnBackTo_Click);
            // 
            // Pop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 387);
            this.Controls.Add(this.btnBackTo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.lstPBought);
            this.Controls.Add(this.lstPSummary);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Pop";
            this.Text = "Pop";
            this.Load += new System.EventHandler(this.Pop_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdP80;
        private System.Windows.Forms.RadioButton rdP90;
        private System.Windows.Forms.RadioButton rdPToday;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox lstPSummary;
        private System.Windows.Forms.ListBox lstPBought;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBackTo;
    }
}