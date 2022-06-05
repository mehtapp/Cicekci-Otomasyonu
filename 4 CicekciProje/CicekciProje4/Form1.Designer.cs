namespace CicekciProje4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_rapor = new System.Windows.Forms.Button();
            this.btn_sip = new System.Windows.Forms.Button();
            this.btn_musteri = new System.Windows.Forms.Button();
            this.btn_urun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_rapor
            // 
            this.btn_rapor.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_rapor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rapor.FlatAppearance.BorderSize = 0;
            this.btn_rapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rapor.Font = new System.Drawing.Font("Montserrat Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rapor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_rapor.Location = new System.Drawing.Point(775, 107);
            this.btn_rapor.Margin = new System.Windows.Forms.Padding(4);
            this.btn_rapor.Name = "btn_rapor";
            this.btn_rapor.Size = new System.Drawing.Size(180, 230);
            this.btn_rapor.TabIndex = 6;
            this.btn_rapor.Text = "Raporlar";
            this.btn_rapor.UseVisualStyleBackColor = false;
            this.btn_rapor.Click += new System.EventHandler(this.btn_rapor_Click);
            // 
            // btn_sip
            // 
            this.btn_sip.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_sip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sip.FlatAppearance.BorderSize = 0;
            this.btn_sip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sip.Font = new System.Drawing.Font("Montserrat Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sip.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sip.Location = new System.Drawing.Point(542, 107);
            this.btn_sip.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sip.Name = "btn_sip";
            this.btn_sip.Size = new System.Drawing.Size(180, 230);
            this.btn_sip.TabIndex = 7;
            this.btn_sip.Text = "Siparişler";
            this.btn_sip.UseVisualStyleBackColor = false;
            this.btn_sip.Click += new System.EventHandler(this.btn_sip_Click);
            // 
            // btn_musteri
            // 
            this.btn_musteri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_musteri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_musteri.FlatAppearance.BorderSize = 0;
            this.btn_musteri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_musteri.Font = new System.Drawing.Font("Montserrat Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_musteri.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_musteri.Location = new System.Drawing.Point(312, 107);
            this.btn_musteri.Margin = new System.Windows.Forms.Padding(4);
            this.btn_musteri.Name = "btn_musteri";
            this.btn_musteri.Size = new System.Drawing.Size(180, 230);
            this.btn_musteri.TabIndex = 8;
            this.btn_musteri.Text = "Müşteriler";
            this.btn_musteri.UseVisualStyleBackColor = false;
            this.btn_musteri.Click += new System.EventHandler(this.btn_musteri_Click);
            // 
            // btn_urun
            // 
            this.btn_urun.BackColor = System.Drawing.Color.Orange;
            this.btn_urun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_urun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_urun.FlatAppearance.BorderSize = 0;
            this.btn_urun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_urun.Font = new System.Drawing.Font("Montserrat Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_urun.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_urun.Location = new System.Drawing.Point(83, 107);
            this.btn_urun.Margin = new System.Windows.Forms.Padding(4);
            this.btn_urun.Name = "btn_urun";
            this.btn_urun.Size = new System.Drawing.Size(180, 230);
            this.btn_urun.TabIndex = 9;
            this.btn_urun.Text = "Ürünler";
            this.btn_urun.UseVisualStyleBackColor = false;
            this.btn_urun.Click += new System.EventHandler(this.btn_urun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 460);
            this.Controls.Add(this.btn_rapor);
            this.Controls.Add(this.btn_sip);
            this.Controls.Add(this.btn_musteri);
            this.Controls.Add(this.btn_urun);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_rapor;
        private System.Windows.Forms.Button btn_sip;
        private System.Windows.Forms.Button btn_musteri;
        private System.Windows.Forms.Button btn_urun;
    }
}

