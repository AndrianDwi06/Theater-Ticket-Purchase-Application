namespace Tiket_Teater__c_
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
            this.btncari = new System.Windows.Forms.Button();
            this.txtcari = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelet = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txjumlah = new System.Windows.Forms.TextBox();
            this.txharga = new System.Windows.Forms.TextBox();
            this.txnama = new System.Windows.Forms.TextBox();
            this.txtidtransaksi = new System.Windows.Forms.TextBox();
            this.cmbjenis = new System.Windows.Forms.ComboBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // btncari
            // 
            this.btncari.Location = new System.Drawing.Point(594, 133);
            this.btncari.Name = "btncari";
            this.btncari.Size = new System.Drawing.Size(98, 23);
            this.btncari.TabIndex = 72;
            this.btncari.Text = "Cari";
            this.btncari.UseVisualStyleBackColor = true;
            this.btncari.Click += new System.EventHandler(this.btncari_Click);
            // 
            // txtcari
            // 
            this.txtcari.Location = new System.Drawing.Point(488, 133);
            this.txtcari.Name = "txtcari";
            this.txtcari.Size = new System.Drawing.Size(100, 22);
            this.txtcari.TabIndex = 71;
            this.txtcari.TextChanged += new System.EventHandler(this.txtcari_TextChanged);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(558, 341);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(98, 23);
            this.btnupdate.TabIndex = 69;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelet
            // 
            this.btndelet.Location = new System.Drawing.Point(662, 341);
            this.btndelet.Name = "btndelet";
            this.btndelet.Size = new System.Drawing.Size(98, 23);
            this.btndelet.TabIndex = 68;
            this.btndelet.Text = "Delet";
            this.btndelet.UseVisualStyleBackColor = true;
            this.btndelet.Click += new System.EventHandler(this.btndelet_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(27, 299);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(98, 23);
            this.btnadd.TabIndex = 67;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // DGV1
            // 
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Location = new System.Drawing.Point(488, 161);
            this.DGV1.Name = "DGV1";
            this.DGV1.RowHeadersWidth = 51;
            this.DGV1.RowTemplate.Height = 24;
            this.DGV1.Size = new System.Drawing.Size(269, 174);
            this.DGV1.TabIndex = 66;
            this.DGV1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV1_CellContentClick);
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(368, 251);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(100, 22);
            this.txttotal.TabIndex = 65;
            this.txttotal.TextChanged += new System.EventHandler(this.txttotal_TextChanged);
            // 
            // txjumlah
            // 
            this.txjumlah.Location = new System.Drawing.Point(28, 200);
            this.txjumlah.Name = "txjumlah";
            this.txjumlah.Size = new System.Drawing.Size(64, 22);
            this.txjumlah.TabIndex = 61;
            this.txjumlah.TextChanged += new System.EventHandler(this.txjumlah_TextChanged);
            // 
            // txharga
            // 
            this.txharga.Location = new System.Drawing.Point(292, 198);
            this.txharga.Name = "txharga";
            this.txharga.Size = new System.Drawing.Size(109, 22);
            this.txharga.TabIndex = 59;
            this.txharga.TextChanged += new System.EventHandler(this.txharga_TextChanged);
            // 
            // txnama
            // 
            this.txnama.Location = new System.Drawing.Point(145, 131);
            this.txnama.Name = "txnama";
            this.txnama.Size = new System.Drawing.Size(217, 22);
            this.txnama.TabIndex = 57;
            this.txnama.TextChanged += new System.EventHandler(this.txnama_TextChanged);
            // 
            // txtidtransaksi
            // 
            this.txtidtransaksi.Location = new System.Drawing.Point(27, 131);
            this.txtidtransaksi.Name = "txtidtransaksi";
            this.txtidtransaksi.Size = new System.Drawing.Size(109, 22);
            this.txtidtransaksi.TabIndex = 56;
            this.txtidtransaksi.TextChanged += new System.EventHandler(this.txtidtransaksi_TextChanged);
            // 
            // cmbjenis
            // 
            this.cmbjenis.FormattingEnabled = true;
            this.cmbjenis.Location = new System.Drawing.Point(122, 198);
            this.cmbjenis.Name = "cmbjenis";
            this.cmbjenis.Size = new System.Drawing.Size(150, 24);
            this.cmbjenis.TabIndex = 55;
            this.cmbjenis.SelectedIndexChanged += new System.EventHandler(this.cmbjenis_SelectedIndexChanged);
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(368, 279);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(98, 23);
            this.btnsubmit.TabIndex = 53;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.BackColor = System.Drawing.Color.Transparent;
            this.Label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label13.Location = new System.Drawing.Point(119, 181);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(72, 16);
            this.Label13.TabIndex = 49;
            this.Label13.Text = "Jenis Tiket";
            this.Label13.Click += new System.EventHandler(this.Label13_Click);
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.BackColor = System.Drawing.Color.Transparent;
            this.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label11.Location = new System.Drawing.Point(365, 232);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(71, 16);
            this.Label11.TabIndex = 47;
            this.Label11.Text = "Total Akhir";
            this.Label11.Click += new System.EventHandler(this.Label11_Click);
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.BackColor = System.Drawing.Color.Transparent;
            this.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label10.Location = new System.Drawing.Point(289, 179);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(78, 16);
            this.Label10.TabIndex = 46;
            this.Label10.Text = "Harga Tiket";
            this.Label10.Click += new System.EventHandler(this.Label10_Click);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.BackColor = System.Drawing.Color.Transparent;
            this.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label9.Location = new System.Drawing.Point(142, 113);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(44, 16);
            this.Label9.TabIndex = 45;
            this.Label9.Text = "Nama";
            this.Label9.Click += new System.EventHandler(this.Label9_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label5.Location = new System.Drawing.Point(25, 181);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(50, 16);
            this.Label5.TabIndex = 41;
            this.Label5.Text = "Jumlah";
            this.Label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label2.Location = new System.Drawing.Point(25, 112);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(86, 16);
            this.Label2.TabIndex = 39;
            this.Label2.Text = "ID Transaksi ";
            this.Label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Modern No. 20", 36F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Transparent;
            this.Label1.Location = new System.Drawing.Point(221, 37);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(341, 62);
            this.Label1.TabIndex = 38;
            this.Label1.Text = "Tiket Teater";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncari);
            this.Controls.Add(this.txtcari);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelet);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.DGV1);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txjumlah);
            this.Controls.Add(this.txharga);
            this.Controls.Add(this.txnama);
            this.Controls.Add(this.txtidtransaksi);
            this.Controls.Add(this.cmbjenis);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button btncari;
        protected System.Windows.Forms.TextBox txtcari;
        protected System.Windows.Forms.Button btnupdate;
        protected System.Windows.Forms.Button btndelet;
        protected System.Windows.Forms.Button btnadd;
        protected System.Windows.Forms.DataGridView DGV1;
        protected System.Windows.Forms.TextBox txttotal;
        protected System.Windows.Forms.TextBox txjumlah;
        protected System.Windows.Forms.TextBox txharga;
        protected System.Windows.Forms.TextBox txnama;
        protected System.Windows.Forms.TextBox txtidtransaksi;
        protected System.Windows.Forms.ComboBox cmbjenis;
        protected System.Windows.Forms.Button btnsubmit;
        protected System.Windows.Forms.Label Label13;
        protected System.Windows.Forms.Label Label11;
        protected System.Windows.Forms.Label Label10;
        protected System.Windows.Forms.Label Label9;
        protected System.Windows.Forms.Label Label5;
        protected System.Windows.Forms.Label Label2;
        protected System.Windows.Forms.Label Label1;
    }
}

