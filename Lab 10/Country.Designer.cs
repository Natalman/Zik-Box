namespace Lab_10
{
    partial class Country
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
            this.rdC80 = new System.Windows.Forms.RadioButton();
            this.rdC90 = new System.Windows.Forms.RadioButton();
            this.rdCToday = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCPrice = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lstCSummary = new System.Windows.Forms.ListBox();
            this.lstCBought = new System.Windows.Forms.ListBox();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBackTo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdC80
            // 
            this.rdC80.AutoSize = true;
            this.rdC80.Location = new System.Drawing.Point(17, 14);
            this.rdC80.Name = "rdC80";
            this.rdC80.Size = new System.Drawing.Size(44, 17);
            this.rdC80.TabIndex = 0;
            this.rdC80.TabStop = true;
            this.rdC80.Text = "80\'s";
            this.rdC80.UseVisualStyleBackColor = true;
            this.rdC80.CheckedChanged += new System.EventHandler(this.rdC80_CheckedChanged);
            // 
            // rdC90
            // 
            this.rdC90.AutoSize = true;
            this.rdC90.Location = new System.Drawing.Point(17, 55);
            this.rdC90.Name = "rdC90";
            this.rdC90.Size = new System.Drawing.Size(44, 17);
            this.rdC90.TabIndex = 1;
            this.rdC90.TabStop = true;
            this.rdC90.Text = "90\'s";
            this.rdC90.UseVisualStyleBackColor = true;
            this.rdC90.CheckedChanged += new System.EventHandler(this.rdC90_CheckedChanged);
            // 
            // rdCToday
            // 
            this.rdCToday.AutoSize = true;
            this.rdCToday.Location = new System.Drawing.Point(17, 96);
            this.rdCToday.Name = "rdCToday";
            this.rdCToday.Size = new System.Drawing.Size(55, 17);
            this.rdCToday.TabIndex = 2;
            this.rdCToday.TabStop = true;
            this.rdCToday.Text = "Today";
            this.rdCToday.UseVisualStyleBackColor = true;
            this.rdCToday.CheckedChanged += new System.EventHandler(this.rdCToday_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdCToday);
            this.panel1.Controls.Add(this.rdC90);
            this.panel1.Controls.Add(this.rdC80);
            this.panel1.Location = new System.Drawing.Point(24, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 152);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Year";
            // 
            // txtCPrice
            // 
            this.txtCPrice.Location = new System.Drawing.Point(530, 293);
            this.txtCPrice.Name = "txtCPrice";
            this.txtCPrice.ReadOnly = true;
            this.txtCPrice.Size = new System.Drawing.Size(100, 20);
            this.txtCPrice.TabIndex = 6;
            this.txtCPrice.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(182, 253);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(414, 253);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lstCSummary
            // 
            this.lstCSummary.FormattingEnabled = true;
            this.lstCSummary.Location = new System.Drawing.Point(182, 35);
            this.lstCSummary.Name = "lstCSummary";
            this.lstCSummary.Size = new System.Drawing.Size(307, 212);
            this.lstCSummary.TabIndex = 9;
            this.lstCSummary.TabStop = false;
            // 
            // lstCBought
            // 
            this.lstCBought.FormattingEnabled = true;
            this.lstCBought.Location = new System.Drawing.Point(530, 23);
            this.lstCBought.Name = "lstCBought";
            this.lstCBought.Size = new System.Drawing.Size(338, 264);
            this.lstCBought.TabIndex = 10;
            this.lstCBought.TabStop = false;
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(530, 319);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(75, 23);
            this.btnTotal.TabIndex = 6;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(793, 293);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBackTo
            // 
            this.btnBackTo.Location = new System.Drawing.Point(265, 348);
            this.btnBackTo.Name = "btnBackTo";
            this.btnBackTo.Size = new System.Drawing.Size(163, 23);
            this.btnBackTo.TabIndex = 7;
            this.btnBackTo.Text = "Back To Menu";
            this.btnBackTo.UseVisualStyleBackColor = true;
            this.btnBackTo.Click += new System.EventHandler(this.btnBackTo_Click);
            // 
            // Country
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 403);
            this.Controls.Add(this.btnBackTo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.lstCBought);
            this.Controls.Add(this.lstCSummary);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Country";
            this.Text = "Country";
            this.Load += new System.EventHandler(this.Country_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdC80;
        private System.Windows.Forms.RadioButton rdC90;
        private System.Windows.Forms.RadioButton rdCToday;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox lstCSummary;
        private System.Windows.Forms.ListBox lstCBought;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBackTo;
    }
}