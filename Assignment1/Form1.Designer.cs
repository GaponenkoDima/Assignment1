namespace Assignment1
{
    partial class SalesBonus
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.empNameLabel = new System.Windows.Forms.Label();
            this.empIdlabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.hrsWorkedlabel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.totalSalesLabel = new System.Windows.Forms.Label();
            this.slsBonusLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Assignment1.Properties.Resources.google_dragon_logo_100x70;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(32, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 72);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(223, 32);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(153, 72);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(254, 53);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(69, 23);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "English";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(254, 76);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(69, 23);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "French";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(268, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Language";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(223, 142);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 20);
            this.textBox1.TabIndex = 5;
            // 
            // empNameLabel
            // 
            this.empNameLabel.AutoSize = true;
            this.empNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.empNameLabel.Location = new System.Drawing.Point(29, 142);
            this.empNameLabel.Name = "empNameLabel";
            this.empNameLabel.Size = new System.Drawing.Size(126, 19);
            this.empNameLabel.TabIndex = 6;
            this.empNameLabel.Text = "Employee\'s Name :";
            // 
            // empIdlabel
            // 
            this.empIdlabel.AutoSize = true;
            this.empIdlabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.empIdlabel.Location = new System.Drawing.Point(29, 168);
            this.empIdlabel.Name = "empIdlabel";
            this.empIdlabel.Size = new System.Drawing.Size(105, 19);
            this.empIdlabel.TabIndex = 7;
            this.empIdlabel.Text = "Employee\'s ID :";
            this.empIdlabel.Click += new System.EventHandler(this.empIdlabel_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(223, 168);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(153, 20);
            this.textBox2.TabIndex = 8;
            // 
            // hrsWorkedlabel
            // 
            this.hrsWorkedlabel.AutoSize = true;
            this.hrsWorkedlabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hrsWorkedlabel.Location = new System.Drawing.Point(29, 194);
            this.hrsWorkedlabel.Name = "hrsWorkedlabel";
            this.hrsWorkedlabel.Size = new System.Drawing.Size(107, 19);
            this.hrsWorkedlabel.TabIndex = 9;
            this.hrsWorkedlabel.Text = "Hours Worked :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(223, 194);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(153, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(223, 220);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(153, 20);
            this.textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(223, 246);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(153, 20);
            this.textBox5.TabIndex = 12;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // totalSalesLabel
            // 
            this.totalSalesLabel.AutoSize = true;
            this.totalSalesLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalSalesLabel.Location = new System.Drawing.Point(29, 220);
            this.totalSalesLabel.Name = "totalSalesLabel";
            this.totalSalesLabel.Size = new System.Drawing.Size(82, 19);
            this.totalSalesLabel.TabIndex = 13;
            this.totalSalesLabel.Text = "Total Sales :";
            // 
            // slsBonusLabel
            // 
            this.slsBonusLabel.AutoSize = true;
            this.slsBonusLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.slsBonusLabel.Location = new System.Drawing.Point(29, 246);
            this.slsBonusLabel.Name = "slsBonusLabel";
            this.slsBonusLabel.Size = new System.Drawing.Size(90, 19);
            this.slsBonusLabel.TabIndex = 14;
            this.slsBonusLabel.Text = "Sales Bonus :";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculateButton.Location = new System.Drawing.Point(32, 321);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 15;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            // 
            // PrintButton
            // 
            this.PrintButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrintButton.Location = new System.Drawing.Point(162, 321);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(75, 23);
            this.PrintButton.TabIndex = 16;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.Location = new System.Drawing.Point(301, 321);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 17;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // SalesBonus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 364);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.slsBonusLabel);
            this.Controls.Add(this.totalSalesLabel);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.hrsWorkedlabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.empIdlabel);
            this.Controls.Add(this.empNameLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SalesBonus";
            this.Text = "Sales Bonus";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label empNameLabel;
        private System.Windows.Forms.Label empIdlabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label hrsWorkedlabel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label totalSalesLabel;
        private System.Windows.Forms.Label slsBonusLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button ClearButton;
    }
}

