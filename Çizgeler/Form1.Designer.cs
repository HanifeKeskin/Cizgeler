namespace Çizgeler
{
    partial class frmGraph
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
            this.grpKose = new System.Windows.Forms.GroupBox();
            this.lblKose = new System.Windows.Forms.Label();
            this.txtKose = new System.Windows.Forms.TextBox();
            this.grpKenar = new System.Windows.Forms.GroupBox();
            this.txtUzaklik = new System.Windows.Forms.TextBox();
            this.txtBitis = new System.Windows.Forms.TextBox();
            this.btnKenarKaydet = new System.Windows.Forms.Button();
            this.txtBaslangic = new System.Windows.Forms.TextBox();
            this.lblUzaklik = new System.Windows.Forms.Label();
            this.lblBitis = new System.Windows.Forms.Label();
            this.lblBaslangic = new System.Windows.Forms.Label();
            this.lblKenar = new System.Windows.Forms.Label();
            this.btnKoseKaydet = new System.Windows.Forms.Button();
            this.grpCizgeİslem = new System.Windows.Forms.GroupBox();
            this.btnCizgeCiz = new System.Windows.Forms.Button();
            this.btnSosyalAg = new System.Windows.Forms.Button();
            this.btnKruskalTabanliAgac = new System.Windows.Forms.Button();
            this.btnEdmondsKarpTabanliAkis = new System.Windows.Forms.Button();
            this.btnFordFulkersonTabanliAkis = new System.Windows.Forms.Button();
            this.btnPrimTabanliAgac = new System.Windows.Forms.Button();
            this.btnSP = new System.Windows.Forms.Button();
            this.btnBFS = new System.Windows.Forms.Button();
            this.grpKoseBilgi = new System.Windows.Forms.GroupBox();
            this.txtKoseNo = new System.Windows.Forms.TextBox();
            this.btnKoseNoKaydet = new System.Windows.Forms.Button();
            this.lstListe = new System.Windows.Forms.ListBox();
            this.lblKoseNo = new System.Windows.Forms.Label();
            this.grpKoseCiftiBilgi = new System.Windows.Forms.GroupBox();
            this.btnKoseCiftiNoKaydet = new System.Windows.Forms.Button();
            this.txtKoseCiftiNo2 = new System.Windows.Forms.TextBox();
            this.txtKoseCiftiNo1 = new System.Windows.Forms.TextBox();
            this.lblKoseCiftiNo = new System.Windows.Forms.Label();
            this.grpKose.SuspendLayout();
            this.grpKenar.SuspendLayout();
            this.grpCizgeİslem.SuspendLayout();
            this.grpKoseBilgi.SuspendLayout();
            this.grpKoseCiftiBilgi.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpKose
            // 
            this.grpKose.Controls.Add(this.lblKose);
            this.grpKose.Controls.Add(this.txtKose);
            this.grpKose.Controls.Add(this.grpKenar);
            this.grpKose.Controls.Add(this.btnKoseKaydet);
            this.grpKose.Location = new System.Drawing.Point(34, 29);
            this.grpKose.Name = "grpKose";
            this.grpKose.Size = new System.Drawing.Size(254, 473);
            this.grpKose.TabIndex = 0;
            this.grpKose.TabStop = false;
            // 
            // lblKose
            // 
            this.lblKose.AutoSize = true;
            this.lblKose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKose.Location = new System.Drawing.Point(6, 30);
            this.lblKose.Name = "lblKose";
            this.lblKose.Size = new System.Drawing.Size(55, 17);
            this.lblKose.TabIndex = 2;
            this.lblKose.Text = "KÖŞE:";
            // 
            // txtKose
            // 
            this.txtKose.BackColor = System.Drawing.SystemColors.Menu;
            this.txtKose.Location = new System.Drawing.Point(67, 30);
            this.txtKose.Name = "txtKose";
            this.txtKose.Size = new System.Drawing.Size(100, 22);
            this.txtKose.TabIndex = 7;
            // 
            // grpKenar
            // 
            this.grpKenar.Controls.Add(this.txtUzaklik);
            this.grpKenar.Controls.Add(this.txtBitis);
            this.grpKenar.Controls.Add(this.btnKenarKaydet);
            this.grpKenar.Controls.Add(this.txtBaslangic);
            this.grpKenar.Controls.Add(this.lblUzaklik);
            this.grpKenar.Controls.Add(this.lblBitis);
            this.grpKenar.Controls.Add(this.lblBaslangic);
            this.grpKenar.Controls.Add(this.lblKenar);
            this.grpKenar.Location = new System.Drawing.Point(6, 127);
            this.grpKenar.Name = "grpKenar";
            this.grpKenar.Size = new System.Drawing.Size(242, 323);
            this.grpKenar.TabIndex = 1;
            this.grpKenar.TabStop = false;
            this.grpKenar.Visible = false;
            // 
            // txtUzaklik
            // 
            this.txtUzaklik.BackColor = System.Drawing.SystemColors.Menu;
            this.txtUzaklik.Location = new System.Drawing.Point(112, 206);
            this.txtUzaklik.Name = "txtUzaklik";
            this.txtUzaklik.Size = new System.Drawing.Size(100, 22);
            this.txtUzaklik.TabIndex = 10;
            // 
            // txtBitis
            // 
            this.txtBitis.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBitis.Location = new System.Drawing.Point(112, 143);
            this.txtBitis.Name = "txtBitis";
            this.txtBitis.Size = new System.Drawing.Size(100, 22);
            this.txtBitis.TabIndex = 9;
            // 
            // btnKenarKaydet
            // 
            this.btnKenarKaydet.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnKenarKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKenarKaydet.Location = new System.Drawing.Point(41, 251);
            this.btnKenarKaydet.Name = "btnKenarKaydet";
            this.btnKenarKaydet.Size = new System.Drawing.Size(125, 38);
            this.btnKenarKaydet.TabIndex = 5;
            this.btnKenarKaydet.Text = "KAYDET";
            this.btnKenarKaydet.UseVisualStyleBackColor = false;
            this.btnKenarKaydet.Click += new System.EventHandler(this.btnKenarKaydet_Click);
            // 
            // txtBaslangic
            // 
            this.txtBaslangic.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBaslangic.Location = new System.Drawing.Point(112, 86);
            this.txtBaslangic.Name = "txtBaslangic";
            this.txtBaslangic.Size = new System.Drawing.Size(100, 22);
            this.txtBaslangic.TabIndex = 8;
            // 
            // lblUzaklik
            // 
            this.lblUzaklik.AutoSize = true;
            this.lblUzaklik.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUzaklik.Location = new System.Drawing.Point(6, 211);
            this.lblUzaklik.Name = "lblUzaklik";
            this.lblUzaklik.Size = new System.Drawing.Size(77, 17);
            this.lblUzaklik.TabIndex = 6;
            this.lblUzaklik.Text = "UZAKLIK:";
            // 
            // lblBitis
            // 
            this.lblBitis.AutoSize = true;
            this.lblBitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBitis.Location = new System.Drawing.Point(6, 148);
            this.lblBitis.Name = "lblBitis";
            this.lblBitis.Size = new System.Drawing.Size(51, 17);
            this.lblBitis.TabIndex = 5;
            this.lblBitis.Text = "BİTİŞ:";
            // 
            // lblBaslangic
            // 
            this.lblBaslangic.AutoSize = true;
            this.lblBaslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslangic.Location = new System.Drawing.Point(6, 89);
            this.lblBaslangic.Name = "lblBaslangic";
            this.lblBaslangic.Size = new System.Drawing.Size(99, 17);
            this.lblBaslangic.TabIndex = 4;
            this.lblBaslangic.Text = "BAŞLANGIÇ:";
            // 
            // lblKenar
            // 
            this.lblKenar.AutoSize = true;
            this.lblKenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKenar.Location = new System.Drawing.Point(6, 43);
            this.lblKenar.Name = "lblKenar";
            this.lblKenar.Size = new System.Drawing.Size(65, 17);
            this.lblKenar.TabIndex = 3;
            this.lblKenar.Text = "KENAR:";
            // 
            // btnKoseKaydet
            // 
            this.btnKoseKaydet.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnKoseKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKoseKaydet.Location = new System.Drawing.Point(25, 72);
            this.btnKoseKaydet.Name = "btnKoseKaydet";
            this.btnKoseKaydet.Size = new System.Drawing.Size(125, 38);
            this.btnKoseKaydet.TabIndex = 4;
            this.btnKoseKaydet.Text = "KAYDET";
            this.btnKoseKaydet.UseVisualStyleBackColor = false;
            this.btnKoseKaydet.Click += new System.EventHandler(this.btnKoseKaydet_Click);
            // 
            // grpCizgeİslem
            // 
            this.grpCizgeİslem.Controls.Add(this.btnCizgeCiz);
            this.grpCizgeİslem.Controls.Add(this.btnSosyalAg);
            this.grpCizgeİslem.Controls.Add(this.btnKruskalTabanliAgac);
            this.grpCizgeİslem.Controls.Add(this.btnEdmondsKarpTabanliAkis);
            this.grpCizgeİslem.Controls.Add(this.btnFordFulkersonTabanliAkis);
            this.grpCizgeİslem.Controls.Add(this.btnPrimTabanliAgac);
            this.grpCizgeİslem.Controls.Add(this.btnSP);
            this.grpCizgeİslem.Controls.Add(this.btnBFS);
            this.grpCizgeİslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpCizgeİslem.Location = new System.Drawing.Point(294, 29);
            this.grpCizgeİslem.Name = "grpCizgeİslem";
            this.grpCizgeİslem.Size = new System.Drawing.Size(257, 473);
            this.grpCizgeİslem.TabIndex = 2;
            this.grpCizgeİslem.TabStop = false;
            this.grpCizgeİslem.Text = "ÇİZGE İŞLEMLERİ:";
            // 
            // btnCizgeCiz
            // 
            this.btnCizgeCiz.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCizgeCiz.Location = new System.Drawing.Point(4, 30);
            this.btnCizgeCiz.Name = "btnCizgeCiz";
            this.btnCizgeCiz.Size = new System.Drawing.Size(247, 33);
            this.btnCizgeCiz.TabIndex = 11;
            this.btnCizgeCiz.Text = "ÇİZGE ÇİZ";
            this.btnCizgeCiz.UseVisualStyleBackColor = false;
            this.btnCizgeCiz.Click += new System.EventHandler(this.btnCizgeCiz_Click);
            // 
            // btnSosyalAg
            // 
            this.btnSosyalAg.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSosyalAg.Location = new System.Drawing.Point(4, 434);
            this.btnSosyalAg.Name = "btnSosyalAg";
            this.btnSosyalAg.Size = new System.Drawing.Size(247, 33);
            this.btnSosyalAg.TabIndex = 10;
            this.btnSosyalAg.Text = "Sosyal Ağ";
            this.btnSosyalAg.UseVisualStyleBackColor = false;
            // 
            // btnKruskalTabanliAgac
            // 
            this.btnKruskalTabanliAgac.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnKruskalTabanliAgac.Location = new System.Drawing.Point(0, 237);
            this.btnKruskalTabanliAgac.Name = "btnKruskalTabanliAgac";
            this.btnKruskalTabanliAgac.Size = new System.Drawing.Size(251, 39);
            this.btnKruskalTabanliAgac.TabIndex = 9;
            this.btnKruskalTabanliAgac.Text = "Prim-MST(Kruskal Algoritma Tabanlı)";
            this.btnKruskalTabanliAgac.UseVisualStyleBackColor = false;
            // 
            // btnEdmondsKarpTabanliAkis
            // 
            this.btnEdmondsKarpTabanliAkis.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnEdmondsKarpTabanliAkis.Location = new System.Drawing.Point(4, 293);
            this.btnEdmondsKarpTabanliAkis.Name = "btnEdmondsKarpTabanliAkis";
            this.btnEdmondsKarpTabanliAkis.Size = new System.Drawing.Size(247, 46);
            this.btnEdmondsKarpTabanliAkis.TabIndex = 7;
            this.btnEdmondsKarpTabanliAkis.Text = "EK-MAX(Edmonds Karp Algoritma Tabanlı";
            this.btnEdmondsKarpTabanliAkis.UseVisualStyleBackColor = false;
            // 
            // btnFordFulkersonTabanliAkis
            // 
            this.btnFordFulkersonTabanliAkis.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnFordFulkersonTabanliAkis.Location = new System.Drawing.Point(4, 361);
            this.btnFordFulkersonTabanliAkis.Name = "btnFordFulkersonTabanliAkis";
            this.btnFordFulkersonTabanliAkis.Size = new System.Drawing.Size(247, 50);
            this.btnFordFulkersonTabanliAkis.TabIndex = 8;
            this.btnFordFulkersonTabanliAkis.Text = "EK-MAX(Ford Fulkerson Algoritma Tabanlı)";
            this.btnFordFulkersonTabanliAkis.UseVisualStyleBackColor = false;
            // 
            // btnPrimTabanliAgac
            // 
            this.btnPrimTabanliAgac.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnPrimTabanliAgac.Location = new System.Drawing.Point(4, 183);
            this.btnPrimTabanliAgac.Name = "btnPrimTabanliAgac";
            this.btnPrimTabanliAgac.Size = new System.Drawing.Size(247, 33);
            this.btnPrimTabanliAgac.TabIndex = 6;
            this.btnPrimTabanliAgac.Text = "Prim-MST(Prim Algoritma Tabanlı)";
            this.btnPrimTabanliAgac.UseVisualStyleBackColor = false;
            this.btnPrimTabanliAgac.Click += new System.EventHandler(this.btnPrimTabanliAgac_Click);
            // 
            // btnSP
            // 
            this.btnSP.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSP.Location = new System.Drawing.Point(4, 77);
            this.btnSP.Name = "btnSP";
            this.btnSP.Size = new System.Drawing.Size(247, 33);
            this.btnSP.TabIndex = 4;
            this.btnSP.Text = "SP";
            this.btnSP.UseVisualStyleBackColor = false;
            this.btnSP.Click += new System.EventHandler(this.btnSP_Click);
            // 
            // btnBFS
            // 
            this.btnBFS.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnBFS.Location = new System.Drawing.Point(4, 133);
            this.btnBFS.Name = "btnBFS";
            this.btnBFS.Size = new System.Drawing.Size(247, 33);
            this.btnBFS.TabIndex = 5;
            this.btnBFS.Text = "BFS";
            this.btnBFS.UseVisualStyleBackColor = false;
            this.btnBFS.Click += new System.EventHandler(this.btnBFS_Click);
            // 
            // grpKoseBilgi
            // 
            this.grpKoseBilgi.Controls.Add(this.txtKoseNo);
            this.grpKoseBilgi.Controls.Add(this.btnKoseNoKaydet);
            this.grpKoseBilgi.Controls.Add(this.lstListe);
            this.grpKoseBilgi.Controls.Add(this.lblKoseNo);
            this.grpKoseBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpKoseBilgi.Location = new System.Drawing.Point(557, 29);
            this.grpKoseBilgi.Name = "grpKoseBilgi";
            this.grpKoseBilgi.Size = new System.Drawing.Size(505, 198);
            this.grpKoseBilgi.TabIndex = 3;
            this.grpKoseBilgi.TabStop = false;
            this.grpKoseBilgi.Visible = false;
            // 
            // txtKoseNo
            // 
            this.txtKoseNo.BackColor = System.Drawing.SystemColors.Menu;
            this.txtKoseNo.Location = new System.Drawing.Point(236, 18);
            this.txtKoseNo.Name = "txtKoseNo";
            this.txtKoseNo.Size = new System.Drawing.Size(100, 22);
            this.txtKoseNo.TabIndex = 4;
            // 
            // btnKoseNoKaydet
            // 
            this.btnKoseNoKaydet.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnKoseNoKaydet.Location = new System.Drawing.Point(192, 72);
            this.btnKoseNoKaydet.Name = "btnKoseNoKaydet";
            this.btnKoseNoKaydet.Size = new System.Drawing.Size(125, 38);
            this.btnKoseNoKaydet.TabIndex = 6;
            this.btnKoseNoKaydet.Text = "KAYDET";
            this.btnKoseNoKaydet.UseVisualStyleBackColor = false;
            this.btnKoseNoKaydet.Click += new System.EventHandler(this.btnKoseNoKaydet_Click);
            // 
            // lstListe
            // 
            this.lstListe.BackColor = System.Drawing.SystemColors.Menu;
            this.lstListe.FormattingEnabled = true;
            this.lstListe.ItemHeight = 16;
            this.lstListe.Location = new System.Drawing.Point(342, 7);
            this.lstListe.Name = "lstListe";
            this.lstListe.Size = new System.Drawing.Size(156, 180);
            this.lstListe.TabIndex = 4;
            this.lstListe.Visible = false;
            // 
            // lblKoseNo
            // 
            this.lblKoseNo.AutoSize = true;
            this.lblKoseNo.Location = new System.Drawing.Point(6, 18);
            this.lblKoseNo.Name = "lblKoseNo";
            this.lblKoseNo.Size = new System.Drawing.Size(215, 17);
            this.lblKoseNo.TabIndex = 4;
            this.lblKoseNo.Text = "KÖŞE NUMARASINI GİRİNİZ:";
            // 
            // grpKoseCiftiBilgi
            // 
            this.grpKoseCiftiBilgi.BackColor = System.Drawing.Color.Gainsboro;
            this.grpKoseCiftiBilgi.Controls.Add(this.btnKoseCiftiNoKaydet);
            this.grpKoseCiftiBilgi.Controls.Add(this.txtKoseCiftiNo2);
            this.grpKoseCiftiBilgi.Controls.Add(this.txtKoseCiftiNo1);
            this.grpKoseCiftiBilgi.Controls.Add(this.lblKoseCiftiNo);
            this.grpKoseCiftiBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpKoseCiftiBilgi.Location = new System.Drawing.Point(557, 233);
            this.grpKoseCiftiBilgi.Name = "grpKoseCiftiBilgi";
            this.grpKoseCiftiBilgi.Size = new System.Drawing.Size(317, 154);
            this.grpKoseCiftiBilgi.TabIndex = 3;
            this.grpKoseCiftiBilgi.TabStop = false;
            this.grpKoseCiftiBilgi.Visible = false;
            // 
            // btnKoseCiftiNoKaydet
            // 
            this.btnKoseCiftiNoKaydet.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnKoseCiftiNoKaydet.Location = new System.Drawing.Point(157, 60);
            this.btnKoseCiftiNoKaydet.Name = "btnKoseCiftiNoKaydet";
            this.btnKoseCiftiNoKaydet.Size = new System.Drawing.Size(125, 38);
            this.btnKoseCiftiNoKaydet.TabIndex = 7;
            this.btnKoseCiftiNoKaydet.Text = "KAYDET";
            this.btnKoseCiftiNoKaydet.UseVisualStyleBackColor = false;
            this.btnKoseCiftiNoKaydet.Click += new System.EventHandler(this.btnKoseCiftiNoKaydet_Click);
            // 
            // txtKoseCiftiNo2
            // 
            this.txtKoseCiftiNo2.BackColor = System.Drawing.SystemColors.Menu;
            this.txtKoseCiftiNo2.Location = new System.Drawing.Point(30, 99);
            this.txtKoseCiftiNo2.Name = "txtKoseCiftiNo2";
            this.txtKoseCiftiNo2.Size = new System.Drawing.Size(100, 22);
            this.txtKoseCiftiNo2.TabIndex = 6;
            // 
            // txtKoseCiftiNo1
            // 
            this.txtKoseCiftiNo1.BackColor = System.Drawing.SystemColors.Menu;
            this.txtKoseCiftiNo1.Location = new System.Drawing.Point(30, 45);
            this.txtKoseCiftiNo1.Name = "txtKoseCiftiNo1";
            this.txtKoseCiftiNo1.Size = new System.Drawing.Size(100, 22);
            this.txtKoseCiftiNo1.TabIndex = 5;
            // 
            // lblKoseCiftiNo
            // 
            this.lblKoseCiftiNo.AutoSize = true;
            this.lblKoseCiftiNo.Location = new System.Drawing.Point(6, 18);
            this.lblKoseCiftiNo.Name = "lblKoseCiftiNo";
            this.lblKoseCiftiNo.Size = new System.Drawing.Size(312, 17);
            this.lblKoseCiftiNo.TabIndex = 5;
            this.lblKoseCiftiNo.Text = "KÖŞE ÇİFTLERİNİN NUMALARINI GİRİNİZ:";
            // 
            // frmGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1067, 541);
            this.Controls.Add(this.grpKoseBilgi);
            this.Controls.Add(this.grpCizgeİslem);
            this.Controls.Add(this.grpKose);
            this.Controls.Add(this.grpKoseCiftiBilgi);
            this.Name = "frmGraph";
            this.Text = "GRAPH";
            this.grpKose.ResumeLayout(false);
            this.grpKose.PerformLayout();
            this.grpKenar.ResumeLayout(false);
            this.grpKenar.PerformLayout();
            this.grpCizgeİslem.ResumeLayout(false);
            this.grpKoseBilgi.ResumeLayout(false);
            this.grpKoseBilgi.PerformLayout();
            this.grpKoseCiftiBilgi.ResumeLayout(false);
            this.grpKoseCiftiBilgi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpKose;
        private System.Windows.Forms.Label lblKose;
        private System.Windows.Forms.TextBox txtKose;
        private System.Windows.Forms.GroupBox grpKenar;
        private System.Windows.Forms.TextBox txtUzaklik;
        private System.Windows.Forms.TextBox txtBitis;
        private System.Windows.Forms.Button btnKenarKaydet;
        private System.Windows.Forms.TextBox txtBaslangic;
        private System.Windows.Forms.Label lblUzaklik;
        private System.Windows.Forms.Label lblBitis;
        private System.Windows.Forms.Label lblBaslangic;
        private System.Windows.Forms.Label lblKenar;
        private System.Windows.Forms.Button btnKoseKaydet;
        private System.Windows.Forms.GroupBox grpCizgeİslem;
        private System.Windows.Forms.GroupBox grpKoseBilgi;
        private System.Windows.Forms.TextBox txtKoseNo;
        private System.Windows.Forms.Button btnKoseNoKaydet;
        private System.Windows.Forms.ListBox lstListe;
        private System.Windows.Forms.Label lblKoseNo;
        private System.Windows.Forms.GroupBox grpKoseCiftiBilgi;
        private System.Windows.Forms.Button btnKoseCiftiNoKaydet;
        private System.Windows.Forms.TextBox txtKoseCiftiNo2;
        private System.Windows.Forms.TextBox txtKoseCiftiNo1;
        private System.Windows.Forms.Label lblKoseCiftiNo;
        private System.Windows.Forms.Button btnCizgeCiz;
        private System.Windows.Forms.Button btnSosyalAg;
        private System.Windows.Forms.Button btnKruskalTabanliAgac;
        private System.Windows.Forms.Button btnEdmondsKarpTabanliAkis;
        private System.Windows.Forms.Button btnFordFulkersonTabanliAkis;
        private System.Windows.Forms.Button btnPrimTabanliAgac;
        private System.Windows.Forms.Button btnSP;
        private System.Windows.Forms.Button btnBFS;
    }
}

