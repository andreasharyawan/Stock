namespace Stock
{
    partial class Products
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tambah = new System.Windows.Forms.Button();
            this.hapus = new System.Windows.Forms.Button();
            this.kodeproduk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaproduk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupproduk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kemasan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargajual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargabeli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargarata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(190, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 26);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(521, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 26);
            this.textBox2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodeproduk,
            this.namaproduk,
            this.grupproduk,
            this.kemasan,
            this.qty,
            this.hargajual,
            this.hargabeli,
            this.hargarata,
            this.expired});
            this.dataGridView1.Location = new System.Drawing.Point(12, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1147, 426);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kode Produk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(369, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nama Produk";
            // 
            // tambah
            // 
            this.tambah.Location = new System.Drawing.Point(760, 47);
            this.tambah.Name = "tambah";
            this.tambah.Size = new System.Drawing.Size(82, 33);
            this.tambah.TabIndex = 5;
            this.tambah.Text = "Tambah";
            this.tambah.UseVisualStyleBackColor = true;
            // 
            // hapus
            // 
            this.hapus.Location = new System.Drawing.Point(883, 47);
            this.hapus.Name = "hapus";
            this.hapus.Size = new System.Drawing.Size(82, 33);
            this.hapus.TabIndex = 6;
            this.hapus.Text = "Hapus";
            this.hapus.UseVisualStyleBackColor = true;
            // 
            // kodeproduk
            // 
            this.kodeproduk.HeaderText = "Kode Produk";
            this.kodeproduk.Name = "kodeproduk";
            this.kodeproduk.Width = 356;
            // 
            // namaproduk
            // 
            this.namaproduk.HeaderText = "Nama Produk";
            this.namaproduk.Name = "namaproduk";
            // 
            // grupproduk
            // 
            this.grupproduk.HeaderText = "Grup Produk";
            this.grupproduk.Name = "grupproduk";
            // 
            // kemasan
            // 
            this.kemasan.HeaderText = "Kemasan";
            this.kemasan.Name = "kemasan";
            // 
            // qty
            // 
            this.qty.HeaderText = "Quantity";
            this.qty.Name = "qty";
            // 
            // hargajual
            // 
            this.hargajual.HeaderText = "Harga Jual";
            this.hargajual.Name = "hargajual";
            // 
            // hargabeli
            // 
            this.hargabeli.HeaderText = "Harga Beli";
            this.hargabeli.Name = "hargabeli";
            // 
            // hargarata
            // 
            this.hargarata.HeaderText = "Harga Rata-Rata";
            this.hargarata.Name = "hargarata";
            // 
            // expired
            // 
            this.expired.HeaderText = "Tanggal Expired";
            this.expired.Name = "expired";
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 577);
            this.Controls.Add(this.hapus);
            this.Controls.Add(this.tambah);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Products";
            this.Text = "Products";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button tambah;
        private System.Windows.Forms.Button hapus;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeproduk;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaproduk;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupproduk;
        private System.Windows.Forms.DataGridViewTextBoxColumn kemasan;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargajual;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargabeli;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargarata;
        private System.Windows.Forms.DataGridViewTextBoxColumn expired;
    }
}