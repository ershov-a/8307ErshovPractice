namespace _8307Ershov
{
    partial class CatalogForm
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
            this.dgvCatalog = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bttClose = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbModifyComment = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.bttModifySave = new System.Windows.Forms.Button();
            this.bttLoadProductData = new System.Windows.Forms.Button();
            this.tbModifyID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbModifyStock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbModifyProduct = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bttDeleteProduct = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbDeleteID = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbAddComment = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bttAdd = new System.Windows.Forms.Button();
            this.tbAddStock = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbAddProduct = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalog)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCatalog
            // 
            this.dgvCatalog.AllowUserToAddRows = false;
            this.dgvCatalog.AllowUserToDeleteRows = false;
            this.dgvCatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatalog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Product,
            this.StockBalance,
            this.Comment});
            this.dgvCatalog.Location = new System.Drawing.Point(13, 13);
            this.dgvCatalog.Name = "dgvCatalog";
            this.dgvCatalog.RowHeadersWidth = 51;
            this.dgvCatalog.RowTemplate.Height = 24;
            this.dgvCatalog.Size = new System.Drawing.Size(498, 454);
            this.dgvCatalog.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // Product
            // 
            this.Product.HeaderText = "Product";
            this.Product.MinimumWidth = 6;
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            this.Product.Width = 125;
            // 
            // StockBalance
            // 
            this.StockBalance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.StockBalance.HeaderText = "Stock balance";
            this.StockBalance.MinimumWidth = 6;
            this.StockBalance.Name = "StockBalance";
            this.StockBalance.ReadOnly = true;
            this.StockBalance.Width = 126;
            // 
            // Comment
            // 
            this.Comment.HeaderText = "Comment";
            this.Comment.MinimumWidth = 6;
            this.Comment.Name = "Comment";
            this.Comment.ReadOnly = true;
            this.Comment.Width = 125;
            // 
            // bttClose
            // 
            this.bttClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bttClose.Location = new System.Drawing.Point(13, 473);
            this.bttClose.Name = "bttClose";
            this.bttClose.Size = new System.Drawing.Size(144, 32);
            this.bttClose.TabIndex = 3;
            this.bttClose.Text = "Close";
            this.bttClose.UseVisualStyleBackColor = true;
            this.bttClose.Click += new System.EventHandler(this.bttClose_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbModifyComment);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.bttModifySave);
            this.groupBox3.Controls.Add(this.bttLoadProductData);
            this.groupBox3.Controls.Add(this.tbModifyID);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tbModifyStock);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tbModifyProduct);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(535, 165);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(465, 249);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Modify exisiting product";
            // 
            // tbModifyComment
            // 
            this.tbModifyComment.Location = new System.Drawing.Point(11, 204);
            this.tbModifyComment.Name = "tbModifyComment";
            this.tbModifyComment.Size = new System.Drawing.Size(269, 30);
            this.tbModifyComment.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(7, 185);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 20);
            this.label12.TabIndex = 8;
            this.label12.Text = "Comment";
            // 
            // bttModifySave
            // 
            this.bttModifySave.Location = new System.Drawing.Point(318, 25);
            this.bttModifySave.Name = "bttModifySave";
            this.bttModifySave.Size = new System.Drawing.Size(141, 204);
            this.bttModifySave.TabIndex = 7;
            this.bttModifySave.Text = "Save";
            this.bttModifySave.UseVisualStyleBackColor = true;
            this.bttModifySave.Click += new System.EventHandler(this.bttModifySave_Click);
            // 
            // bttLoadProductData
            // 
            this.bttLoadProductData.Location = new System.Drawing.Point(105, 48);
            this.bttLoadProductData.Name = "bttLoadProductData";
            this.bttLoadProductData.Size = new System.Drawing.Size(106, 30);
            this.bttLoadProductData.TabIndex = 6;
            this.bttLoadProductData.Text = "Load";
            this.bttLoadProductData.UseVisualStyleBackColor = true;
            this.bttLoadProductData.Click += new System.EventHandler(this.bttLoadProductData_Click);
            // 
            // tbModifyID
            // 
            this.tbModifyID.Location = new System.Drawing.Point(11, 48);
            this.tbModifyID.Name = "tbModifyID";
            this.tbModifyID.Size = new System.Drawing.Size(88, 30);
            this.tbModifyID.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(7, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "ID";
            // 
            // tbModifyStock
            // 
            this.tbModifyStock.Location = new System.Drawing.Point(11, 152);
            this.tbModifyStock.Name = "tbModifyStock";
            this.tbModifyStock.Size = new System.Drawing.Size(144, 30);
            this.tbModifyStock.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(7, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Stock balance";
            // 
            // tbModifyProduct
            // 
            this.tbModifyProduct.Location = new System.Drawing.Point(11, 100);
            this.tbModifyProduct.Name = "tbModifyProduct";
            this.tbModifyProduct.Size = new System.Drawing.Size(269, 30);
            this.tbModifyProduct.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(7, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Product";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bttDeleteProduct);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbDeleteID);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(535, 418);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 81);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete product";
            // 
            // bttDeleteProduct
            // 
            this.bttDeleteProduct.Location = new System.Drawing.Point(318, 22);
            this.bttDeleteProduct.Name = "bttDeleteProduct";
            this.bttDeleteProduct.Size = new System.Drawing.Size(141, 45);
            this.bttDeleteProduct.TabIndex = 2;
            this.bttDeleteProduct.Text = "Delete";
            this.bttDeleteProduct.UseVisualStyleBackColor = true;
            this.bttDeleteProduct.Click += new System.EventHandler(this.bttDeleteProduct_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(7, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "ID";
            // 
            // tbDeleteID
            // 
            this.tbDeleteID.Location = new System.Drawing.Point(11, 45);
            this.tbDeleteID.MaxLength = 1000;
            this.tbDeleteID.Name = "tbDeleteID";
            this.tbDeleteID.Size = new System.Drawing.Size(144, 30);
            this.tbDeleteID.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbAddComment);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.bttAdd);
            this.groupBox4.Controls.Add(this.tbAddStock);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.tbAddProduct);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(535, 1);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(465, 158);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Add new product";
            // 
            // tbAddComment
            // 
            this.tbAddComment.Location = new System.Drawing.Point(170, 114);
            this.tbAddComment.Name = "tbAddComment";
            this.tbAddComment.Size = new System.Drawing.Size(144, 30);
            this.tbAddComment.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(166, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "Comment";
            // 
            // bttAdd
            // 
            this.bttAdd.Location = new System.Drawing.Point(318, 41);
            this.bttAdd.Name = "bttAdd";
            this.bttAdd.Size = new System.Drawing.Size(141, 112);
            this.bttAdd.TabIndex = 4;
            this.bttAdd.Text = "Add";
            this.bttAdd.UseVisualStyleBackColor = true;
            this.bttAdd.Click += new System.EventHandler(this.bttAdd_Click);
            // 
            // tbAddStock
            // 
            this.tbAddStock.Location = new System.Drawing.Point(11, 114);
            this.tbAddStock.Name = "tbAddStock";
            this.tbAddStock.Size = new System.Drawing.Size(144, 30);
            this.tbAddStock.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(6, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Stock balance";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(7, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Product";
            // 
            // tbAddProduct
            // 
            this.tbAddProduct.Location = new System.Drawing.Point(11, 53);
            this.tbAddProduct.Name = "tbAddProduct";
            this.tbAddProduct.Size = new System.Drawing.Size(303, 30);
            this.tbAddProduct.TabIndex = 0;
            // 
            // CatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 506);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.bttClose);
            this.Controls.Add(this.dgvCatalog);
            this.Name = "CatalogForm";
            this.Text = "Catalog form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CatalogForm_FormClosing);
            this.Load += new System.EventHandler(this.CatalogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalog)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCatalog;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.Windows.Forms.Button bttClose;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bttModifySave;
        private System.Windows.Forms.Button bttLoadProductData;
        private System.Windows.Forms.TextBox tbModifyID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbModifyStock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbModifyProduct;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bttDeleteProduct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbDeleteID;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bttAdd;
        private System.Windows.Forms.TextBox tbAddStock;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbAddProduct;
        private System.Windows.Forms.TextBox tbModifyComment;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbAddComment;
        private System.Windows.Forms.Label label11;
    }
}