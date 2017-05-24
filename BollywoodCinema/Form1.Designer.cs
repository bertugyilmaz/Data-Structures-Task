namespace BollywoodCinema
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.holdButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.seatNumberTextBox = new System.Windows.Forms.TextBox();
            this.nameSurnameTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.fullSeatsButton = new System.Windows.Forms.Button();
            this.removeSeatNumberTextBox = new System.Windows.Forms.TextBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(410, 539);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.fullSeatsButton);
            this.tabPage1.Controls.Add(this.holdButton);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.seatNumberTextBox);
            this.tabPage1.Controls.Add(this.nameSurnameTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(402, 506);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Rezerve Et!";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // holdButton
            // 
            this.holdButton.Location = new System.Drawing.Point(138, 278);
            this.holdButton.Name = "holdButton";
            this.holdButton.Size = new System.Drawing.Size(107, 44);
            this.holdButton.TabIndex = 3;
            this.holdButton.Text = "Rezerve Et";
            this.holdButton.UseVisualStyleBackColor = true;
            this.holdButton.Click += new System.EventHandler(this.holdButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Koltuk Numarası";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ad-Soyad";
            // 
            // seatNumberTextBox
            // 
            this.seatNumberTextBox.Location = new System.Drawing.Point(138, 189);
            this.seatNumberTextBox.Name = "seatNumberTextBox";
            this.seatNumberTextBox.Size = new System.Drawing.Size(258, 26);
            this.seatNumberTextBox.TabIndex = 1;
            // 
            // nameSurnameTextBox
            // 
            this.nameSurnameTextBox.Location = new System.Drawing.Point(138, 140);
            this.nameSurnameTextBox.Name = "nameSurnameTextBox";
            this.nameSurnameTextBox.Size = new System.Drawing.Size(258, 26);
            this.nameSurnameTextBox.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.removeButton);
            this.tabPage2.Controls.Add(this.removeSeatNumberTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(402, 506);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "İptal!";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // fullSeatsButton
            // 
            this.fullSeatsButton.Location = new System.Drawing.Point(89, 427);
            this.fullSeatsButton.Name = "fullSeatsButton";
            this.fullSeatsButton.Size = new System.Drawing.Size(209, 44);
            this.fullSeatsButton.TabIndex = 3;
            this.fullSeatsButton.Text = "Dolu Koltukları Listele";
            this.fullSeatsButton.UseVisualStyleBackColor = true;
            // 
            // removeSeatNumberTextBox
            // 
            this.removeSeatNumberTextBox.Location = new System.Drawing.Point(134, 173);
            this.removeSeatNumberTextBox.Name = "removeSeatNumberTextBox";
            this.removeSeatNumberTextBox.Size = new System.Drawing.Size(251, 26);
            this.removeSeatNumberTextBox.TabIndex = 0;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(134, 262);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 38);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "İptal Et!";
            this.removeButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Koltuk Numarası";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 539);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button holdButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox seatNumberTextBox;
        private System.Windows.Forms.TextBox nameSurnameTextBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button fullSeatsButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.TextBox removeSeatNumberTextBox;
    }
}

