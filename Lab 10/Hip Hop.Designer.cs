namespace Lab_10
{
    partial class Hip_Hop
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
            this.rdH80 = new System.Windows.Forms.RadioButton();
            this.rdH90 = new System.Windows.Forms.RadioButton();
            this.rdHToday = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lstSummary = new System.Windows.Forms.ListBox();
            this.lstBought = new System.Windows.Forms.ListBox();
            this.btnBackTo = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnTotal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdH80
            // 
            this.rdH80.AutoSize = true;
            this.rdH80.Location = new System.Drawing.Point(14, 9);
            this.rdH80.Name = "rdH80";
            this.rdH80.Size = new System.Drawing.Size(44, 17);
            this.rdH80.TabIndex = 0;
            this.rdH80.TabStop = true;
            this.rdH80.Text = "80\'s";
            this.rdH80.UseVisualStyleBackColor = true;
            this.rdH80.CheckedChanged += new System.EventHandler(this.rdH80_CheckedChanged);
            // 
            // rdH90
            // 
            this.rdH90.AutoSize = true;
            this.rdH90.Location = new System.Drawing.Point(14, 46);
            this.rdH90.Name = "rdH90";
            this.rdH90.Size = new System.Drawing.Size(44, 17);
            this.rdH90.TabIndex = 1;
            this.rdH90.TabStop = true;
            this.rdH90.Text = "90\'s";
            this.rdH90.UseVisualStyleBackColor = true;
            this.rdH90.CheckedChanged += new System.EventHandler(this.rdH90_CheckedChanged);
            // 
            // rdHToday
            // 
            this.rdHToday.AutoSize = true;
            this.rdHToday.Location = new System.Drawing.Point(14, 81);
            this.rdHToday.Name = "rdHToday";
            this.rdHToday.Size = new System.Drawing.Size(55, 17);
            this.rdHToday.TabIndex = 2;
            this.rdHToday.TabStop = true;
            this.rdHToday.Text = "Today";
            this.rdHToday.UseVisualStyleBackColor = true;
            this.rdHToday.CheckedChanged += new System.EventHandler(this.rdHToday_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdHToday);
            this.panel1.Controls.Add(this.rdH90);
            this.panel1.Controls.Add(this.rdH80);
            this.panel1.Location = new System.Drawing.Point(18, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 118);
            this.panel1.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(176, 209);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(374, 209);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Delete";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // lstSummary
            // 
            this.lstSummary.FormattingEnabled = true;
            this.lstSummary.Location = new System.Drawing.Point(176, 37);
            this.lstSummary.Name = "lstSummary";
            this.lstSummary.Size = new System.Drawing.Size(322, 147);
            this.lstSummary.TabIndex = 9;
            this.lstSummary.TabStop = false;
            // 
            // lstBought
            // 
            this.lstBought.FormattingEnabled = true;
            this.lstBought.Location = new System.Drawing.Point(522, 18);
            this.lstBought.Name = "lstBought";
            this.lstBought.Size = new System.Drawing.Size(348, 186);
            this.lstBought.TabIndex = 10;
            this.lstBought.TabStop = false;
            // 
            // btnBackTo
            // 
            this.btnBackTo.Location = new System.Drawing.Point(313, 299);
            this.btnBackTo.Name = "btnBackTo";
            this.btnBackTo.Size = new System.Drawing.Size(172, 23);
            this.btnBackTo.TabIndex = 7;
            this.btnBackTo.Text = "Back To Menu";
            this.btnBackTo.UseVisualStyleBackColor = true;
            this.btnBackTo.Click += new System.EventHandler(this.btnBackTo_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(535, 219);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 12;
            this.txtTotal.TabStop = false;
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(535, 256);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(75, 23);
            this.btnTotal.TabIndex = 4;
            this.btnTotal.Text = "total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Year";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(795, 256);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Hip_Hop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 357);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnBackTo);
            this.Controls.Add(this.lstBought);
            this.Controls.Add(this.lstSummary);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel1);
            this.Name = "Hip_Hop";
            this.Text = "Hip_Hop";
            this.Load += new System.EventHandler(this.Hip_Hop_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdH80;
        private System.Windows.Forms.RadioButton rdH90;
        private System.Windows.Forms.RadioButton rdHToday;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox lstSummary;
        private System.Windows.Forms.ListBox lstBought;
        private System.Windows.Forms.Button btnBackTo;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
    }
}