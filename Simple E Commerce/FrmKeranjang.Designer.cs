﻿namespace Simple_E_Commerce
{
    partial class FrmKeranjang
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
            this.dgvDataOrder = new System.Windows.Forms.DataGridView();
            this.clmNoOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTglOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmKodeBrg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNamaBrg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNamaPembeli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHargaBrg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmJumlahBrg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDataOrder
            // 
            this.dgvDataOrder.AllowUserToAddRows = false;
            this.dgvDataOrder.AllowUserToDeleteRows = false;
            this.dgvDataOrder.AllowUserToResizeColumns = false;
            this.dgvDataOrder.AllowUserToResizeRows = false;
            this.dgvDataOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDataOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNoOrder,
            this.clmTglOrder,
            this.clmKodeBrg,
            this.clmNamaBrg,
            this.clmNamaPembeli,
            this.clmHargaBrg,
            this.clmJumlahBrg,
            this.clmTotal});
            this.dgvDataOrder.Location = new System.Drawing.Point(11, 86);
            this.dgvDataOrder.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDataOrder.Name = "dgvDataOrder";
            this.dgvDataOrder.ReadOnly = true;
            this.dgvDataOrder.RowHeadersVisible = false;
            this.dgvDataOrder.RowTemplate.Height = 33;
            this.dgvDataOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDataOrder.Size = new System.Drawing.Size(1041, 410);
            this.dgvDataOrder.TabIndex = 1;
            // 
            // clmNoOrder
            // 
            this.clmNoOrder.HeaderText = "No Order";
            this.clmNoOrder.Name = "clmNoOrder";
            this.clmNoOrder.ReadOnly = true;
            // 
            // clmTglOrder
            // 
            this.clmTglOrder.HeaderText = "Tgl Order";
            this.clmTglOrder.Name = "clmTglOrder";
            this.clmTglOrder.ReadOnly = true;
            // 
            // clmKodeBrg
            // 
            this.clmKodeBrg.HeaderText = "Kode Barang";
            this.clmKodeBrg.Name = "clmKodeBrg";
            this.clmKodeBrg.ReadOnly = true;
            // 
            // clmNamaBrg
            // 
            this.clmNamaBrg.HeaderText = "Nama Barang";
            this.clmNamaBrg.Name = "clmNamaBrg";
            this.clmNamaBrg.ReadOnly = true;
            // 
            // clmNamaPembeli
            // 
            this.clmNamaPembeli.HeaderText = "Nama Pembeli";
            this.clmNamaPembeli.Name = "clmNamaPembeli";
            this.clmNamaPembeli.ReadOnly = true;
            // 
            // clmHargaBrg
            // 
            this.clmHargaBrg.HeaderText = "Harga";
            this.clmHargaBrg.Name = "clmHargaBrg";
            this.clmHargaBrg.ReadOnly = true;
            // 
            // clmJumlahBrg
            // 
            this.clmJumlahBrg.HeaderText = "Jumlah";
            this.clmJumlahBrg.Name = "clmJumlahBrg";
            this.clmJumlahBrg.ReadOnly = true;
            // 
            // clmTotal
            // 
            this.clmTotal.HeaderText = "Total";
            this.clmTotal.Name = "clmTotal";
            this.clmTotal.ReadOnly = true;
            // 
            // FrmKeranjang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 574);
            this.Controls.Add(this.dgvDataOrder);
            this.Name = "FrmKeranjang";
            this.Text = "FrmKeranjang";
            this.Load += new System.EventHandler(this.FrmKeranjang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDataOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNoOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTglOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKodeBrg;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNamaBrg;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNamaPembeli;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHargaBrg;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmJumlahBrg;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotal;
    }
}