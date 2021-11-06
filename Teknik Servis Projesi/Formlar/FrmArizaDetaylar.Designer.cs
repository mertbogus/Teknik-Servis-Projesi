
namespace Teknik_Servis_Projesi.Formlar
{
    partial class FrmArizaDetaylar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArizaDetaylar));
            this.Btnguncelle = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureEdit9 = new DevExpress.XtraEditors.PictureEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Txtserino = new DevExpress.XtraEditors.TextEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Txttarih = new DevExpress.XtraEditors.TextEdit();
            this.Rchariza = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit9.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtserino.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txttarih.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Btnguncelle
            // 
            this.Btnguncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btnguncelle.ImageOptions.Image")));
            this.Btnguncelle.Location = new System.Drawing.Point(168, 422);
            this.Btnguncelle.Name = "Btnguncelle";
            this.Btnguncelle.Size = new System.Drawing.Size(200, 36);
            this.Btnguncelle.TabIndex = 31;
            this.Btnguncelle.Text = "GÜNCELLE";
            this.Btnguncelle.Click += new System.EventHandler(this.Btnguncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 41);
            this.label1.TabIndex = 32;
            this.label1.Text = "Arızalı Ürün Kaydı Açıklama";
            // 
            // pictureEdit9
            // 
            this.pictureEdit9.EditValue = ((object)(resources.GetObject("pictureEdit9.EditValue")));
            this.pictureEdit9.Location = new System.Drawing.Point(443, 5);
            this.pictureEdit9.Name = "pictureEdit9";
            this.pictureEdit9.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit9.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit9.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit9.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit9.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit9.Size = new System.Drawing.Size(61, 56);
            this.pictureEdit9.TabIndex = 46;
            this.pictureEdit9.Click += new System.EventHandler(this.pictureEdit9_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(34, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 3);
            this.panel1.TabIndex = 48;
            // 
            // Txtserino
            // 
            this.Txtserino.EditValue = "Seri No";
            this.Txtserino.Location = new System.Drawing.Point(34, 79);
            this.Txtserino.Name = "Txtserino";
            this.Txtserino.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Txtserino.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtserino.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.Txtserino.Properties.Appearance.Options.UseBackColor = true;
            this.Txtserino.Properties.Appearance.Options.UseFont = true;
            this.Txtserino.Properties.Appearance.Options.UseForeColor = true;
            this.Txtserino.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.Txtserino.Size = new System.Drawing.Size(169, 28);
            this.Txtserino.TabIndex = 47;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(34, 166);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 3);
            this.panel2.TabIndex = 50;
            // 
            // Txttarih
            // 
            this.Txttarih.EditValue = "Tarih";
            this.Txttarih.Location = new System.Drawing.Point(34, 139);
            this.Txttarih.Name = "Txttarih";
            this.Txttarih.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Txttarih.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txttarih.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.Txttarih.Properties.Appearance.Options.UseBackColor = true;
            this.Txttarih.Properties.Appearance.Options.UseFont = true;
            this.Txttarih.Properties.Appearance.Options.UseForeColor = true;
            this.Txttarih.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.Txttarih.Size = new System.Drawing.Size(169, 28);
            this.Txttarih.TabIndex = 49;
            this.Txttarih.Click += new System.EventHandler(this.textEdit1_Click);
            // 
            // Rchariza
            // 
            this.Rchariza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Rchariza.ForeColor = System.Drawing.Color.White;
            this.Rchariza.Location = new System.Drawing.Point(34, 260);
            this.Rchariza.Name = "Rchariza";
            this.Rchariza.Size = new System.Drawing.Size(334, 143);
            this.Rchariza.TabIndex = 33;
            this.Rchariza.Text = "ARIZA DETAYLARI";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ürün Kaydoldu.",
            "Parça Bekleniyor.",
            "Mesaj Bekliyor.",
            "İptal Edildi.",
            "Fiyat Verildi."});
            this.comboBox1.Location = new System.Drawing.Point(34, 199);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(240, 28);
            this.comboBox1.TabIndex = 52;
            // 
            // FrmArizaDetaylar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(506, 502);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Txttarih);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Txtserino);
            this.Controls.Add(this.pictureEdit9);
            this.Controls.Add(this.Rchariza);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btnguncelle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmArizaDetaylar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arıza Detayları";
            this.Load += new System.EventHandler(this.FrmArizaDetaylar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit9.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtserino.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txttarih.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton Btnguncelle;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit9;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit Txtserino;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.TextEdit Txttarih;
        private System.Windows.Forms.RichTextBox Rchariza;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}