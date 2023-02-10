namespace AileSagligiHekimleriIcinMuayeneBilgiYönetimSistemi_MBYS_
{
    partial class MBYS
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hastalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listelemelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeleVeAraToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaİlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.birIlacınHastalarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muayenelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listeleVeAraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.receteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeleVeAraToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaclarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.listeleVeAraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pencereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programıKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Bisque;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastalarToolStripMenuItem,
            this.muayenelerToolStripMenuItem,
            this.receteToolStripMenuItem,
            this.ilaclarToolStripMenuItem,
            this.pencereToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(774, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // hastalarToolStripMenuItem
            // 
            this.hastalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.listelemelerToolStripMenuItem,
            this.güncelleToolStripMenuItem,
            this.silToolStripMenuItem});
            this.hastalarToolStripMenuItem.Name = "hastalarToolStripMenuItem";
            this.hastalarToolStripMenuItem.Size = new System.Drawing.Size(81, 25);
            this.hastalarToolStripMenuItem.Text = "Hastalar";
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.ekleToolStripMenuItem.Text = "Ekle";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // listelemelerToolStripMenuItem
            // 
            this.listelemelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeleVeAraToolStripMenuItem3,
            this.hastaİlToolStripMenuItem,
            this.birIlacınHastalarıToolStripMenuItem});
            this.listelemelerToolStripMenuItem.Name = "listelemelerToolStripMenuItem";
            this.listelemelerToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.listelemelerToolStripMenuItem.Text = "Listelemeler Ve Aramalar";
            // 
            // listeleVeAraToolStripMenuItem3
            // 
            this.listeleVeAraToolStripMenuItem3.Name = "listeleVeAraToolStripMenuItem3";
            this.listeleVeAraToolStripMenuItem3.Size = new System.Drawing.Size(318, 26);
            this.listeleVeAraToolStripMenuItem3.Text = "Hasta";
            this.listeleVeAraToolStripMenuItem3.Click += new System.EventHandler(this.listeleVeAraToolStripMenuItem3_Click);
            // 
            // hastaİlToolStripMenuItem
            // 
            this.hastaİlToolStripMenuItem.Name = "hastaİlToolStripMenuItem";
            this.hastaİlToolStripMenuItem.Size = new System.Drawing.Size(318, 26);
            this.hastaİlToolStripMenuItem.Text = "Bir Hastaya Recete Edilen ilaclar";
            this.hastaİlToolStripMenuItem.Click += new System.EventHandler(this.hastaİlToolStripMenuItem_Click);
            // 
            // birIlacınHastalarıToolStripMenuItem
            // 
            this.birIlacınHastalarıToolStripMenuItem.Name = "birIlacınHastalarıToolStripMenuItem";
            this.birIlacınHastalarıToolStripMenuItem.Size = new System.Drawing.Size(318, 26);
            this.birIlacınHastalarıToolStripMenuItem.Text = "Bir Ilacın Recete Edildigi Hastalar";
            this.birIlacınHastalarıToolStripMenuItem.Click += new System.EventHandler(this.birIlacınHastalarıToolStripMenuItem_Click);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // muayenelerToolStripMenuItem
            // 
            this.muayenelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem1,
            this.listeleVeAraToolStripMenuItem,
            this.silToolStripMenuItem1});
            this.muayenelerToolStripMenuItem.Name = "muayenelerToolStripMenuItem";
            this.muayenelerToolStripMenuItem.Size = new System.Drawing.Size(108, 25);
            this.muayenelerToolStripMenuItem.Text = "Muayeneler";
            // 
            // ekleToolStripMenuItem1
            // 
            this.ekleToolStripMenuItem1.Name = "ekleToolStripMenuItem1";
            this.ekleToolStripMenuItem1.Size = new System.Drawing.Size(178, 26);
            this.ekleToolStripMenuItem1.Text = "Ekle";
            this.ekleToolStripMenuItem1.Click += new System.EventHandler(this.ekleToolStripMenuItem1_Click);
            // 
            // listeleVeAraToolStripMenuItem
            // 
            this.listeleVeAraToolStripMenuItem.Name = "listeleVeAraToolStripMenuItem";
            this.listeleVeAraToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.listeleVeAraToolStripMenuItem.Text = "Listele Ve Ara";
            this.listeleVeAraToolStripMenuItem.Click += new System.EventHandler(this.listeleVeAraToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem1
            // 
            this.silToolStripMenuItem1.Name = "silToolStripMenuItem1";
            this.silToolStripMenuItem1.Size = new System.Drawing.Size(178, 26);
            this.silToolStripMenuItem1.Text = "Sil ";
            this.silToolStripMenuItem1.Click += new System.EventHandler(this.silToolStripMenuItem1_Click);
            // 
            // receteToolStripMenuItem
            // 
            this.receteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeleVeAraToolStripMenuItem2});
            this.receteToolStripMenuItem.Name = "receteToolStripMenuItem";
            this.receteToolStripMenuItem.Size = new System.Drawing.Size(92, 25);
            this.receteToolStripMenuItem.Text = "Receteler";
            // 
            // listeleVeAraToolStripMenuItem2
            // 
            this.listeleVeAraToolStripMenuItem2.Name = "listeleVeAraToolStripMenuItem2";
            this.listeleVeAraToolStripMenuItem2.Size = new System.Drawing.Size(178, 26);
            this.listeleVeAraToolStripMenuItem2.Text = "Listele Ve Ara";
            this.listeleVeAraToolStripMenuItem2.Click += new System.EventHandler(this.listeleVeAraToolStripMenuItem2_Click);
            // 
            // ilaclarToolStripMenuItem
            // 
            this.ilaclarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem2,
            this.listeleVeAraToolStripMenuItem1,
            this.silToolStripMenuItem2});
            this.ilaclarToolStripMenuItem.Name = "ilaclarToolStripMenuItem";
            this.ilaclarToolStripMenuItem.Size = new System.Drawing.Size(65, 25);
            this.ilaclarToolStripMenuItem.Text = "İlaclar";
            // 
            // ekleToolStripMenuItem2
            // 
            this.ekleToolStripMenuItem2.Name = "ekleToolStripMenuItem2";
            this.ekleToolStripMenuItem2.Size = new System.Drawing.Size(178, 26);
            this.ekleToolStripMenuItem2.Text = "Ekle";
            this.ekleToolStripMenuItem2.Click += new System.EventHandler(this.ekleToolStripMenuItem2_Click);
            // 
            // listeleVeAraToolStripMenuItem1
            // 
            this.listeleVeAraToolStripMenuItem1.Name = "listeleVeAraToolStripMenuItem1";
            this.listeleVeAraToolStripMenuItem1.Size = new System.Drawing.Size(178, 26);
            this.listeleVeAraToolStripMenuItem1.Text = "Listele Ve Ara";
            this.listeleVeAraToolStripMenuItem1.Click += new System.EventHandler(this.listeleVeAraToolStripMenuItem1_Click);
            // 
            // silToolStripMenuItem2
            // 
            this.silToolStripMenuItem2.Name = "silToolStripMenuItem2";
            this.silToolStripMenuItem2.Size = new System.Drawing.Size(178, 26);
            this.silToolStripMenuItem2.Text = "Sil";
            this.silToolStripMenuItem2.Click += new System.EventHandler(this.silToolStripMenuItem2_Click);
            // 
            // pencereToolStripMenuItem
            // 
            this.pencereToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programıKapatToolStripMenuItem});
            this.pencereToolStripMenuItem.Name = "pencereToolStripMenuItem";
            this.pencereToolStripMenuItem.Size = new System.Drawing.Size(80, 25);
            this.pencereToolStripMenuItem.Text = "Pencere";
            // 
            // programıKapatToolStripMenuItem
            // 
            this.programıKapatToolStripMenuItem.Name = "programıKapatToolStripMenuItem";
            this.programıKapatToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.programıKapatToolStripMenuItem.Text = "Programı Kapat";
            this.programıKapatToolStripMenuItem.Click += new System.EventHandler(this.programıKapatToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 314);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AileSagligiHekimleriIcinMuayeneBilgiYönetimSistemi_MBYS_.Properties.Resources.AİLESAGLIK12;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(766, 314);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MBYS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 346);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MBYS";
            this.Text = "MBYS";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hastalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muayenelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listeleVeAraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ilaclarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem listeleVeAraToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem pencereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programıKapatToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem listelemelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeleVeAraToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem hastaİlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem birIlacınHastalarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeleVeAraToolStripMenuItem2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

