namespace andi1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nilai1 = new System.Windows.Forms.TextBox();
            this.btnHitung_Click = new System.Windows.Forms.Button();
            this.nilai2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lstHasil = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmboperasi = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operasi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nilai A";
            // 
            // nilai1
            // 
            this.nilai1.Location = new System.Drawing.Point(61, 129);
            this.nilai1.Name = "nilai1";
            this.nilai1.Size = new System.Drawing.Size(121, 20);
            this.nilai1.TabIndex = 1;
            // 
            // btnHitung_Click
            // 
            this.btnHitung_Click.Location = new System.Drawing.Point(276, 288);
            this.btnHitung_Click.Name = "btnHitung_Click";
            this.btnHitung_Click.Size = new System.Drawing.Size(75, 23);
            this.btnHitung_Click.TabIndex = 2;
            this.btnHitung_Click.Text = "Hitung";
            this.btnHitung_Click.UseVisualStyleBackColor = true;
            this.btnHitung_Click.Click += new System.EventHandler(this.label1_Click);
            // 
            // nilai2
            // 
            this.nilai2.Location = new System.Drawing.Point(61, 185);
            this.nilai2.Name = "nilai2";
            this.nilai2.Size = new System.Drawing.Size(121, 20);
            this.nilai2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(408, 363);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lstHasil
            // 
            this.lstHasil.Location = new System.Drawing.Point(61, 234);
            this.lstHasil.Name = "lstHasil";
            this.lstHasil.Size = new System.Drawing.Size(121, 20);
            this.lstHasil.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(408, 389);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nilai B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hasil";
            // 
            // cmboperasi
            // 
            this.cmboperasi.FormattingEnabled = true;
            this.cmboperasi.Items.AddRange(new object[] {
            "Penambahan",
            "Pengurangan",
            "Perkalian",
            "Pembagian"});
            this.cmboperasi.Location = new System.Drawing.Point(61, 67);
            this.cmboperasi.Name = "cmboperasi";
            this.cmboperasi.Size = new System.Drawing.Size(121, 21);
            this.cmboperasi.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 323);
            this.Controls.Add(this.cmboperasi);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lstHasil);
            this.Controls.Add(this.nilai2);
            this.Controls.Add(this.btnHitung_Click);
            this.Controls.Add(this.nilai1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Aplikasi Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nilai1;
        private System.Windows.Forms.Button btnHitung_Click;
        private System.Windows.Forms.TextBox nilai2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox lstHasil;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmboperasi;
    }
}

