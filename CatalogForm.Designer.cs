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
            this.bttAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bttDelete = new System.Windows.Forms.Button();
            this.bttApplyChanges = new System.Windows.Forms.Button();
            this.bttLoad = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbComment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbStock = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbProduct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalog)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.dgvCatalog.Size = new System.Drawing.Size(503, 425);
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
            this.StockBalance.HeaderText = "Stock balance";
            this.StockBalance.MinimumWidth = 6;
            this.StockBalance.Name = "StockBalance";
            this.StockBalance.ReadOnly = true;
            this.StockBalance.Width = 125;
            // 
            // Comment
            // 
            this.Comment.HeaderText = "Comment";
            this.Comment.MinimumWidth = 6;
            this.Comment.Name = "Comment";
            this.Comment.ReadOnly = true;
            this.Comment.Width = 125;
            // 
            // bttAdd
            // 
            this.bttAdd.Location = new System.Drawing.Point(22, 240);
            this.bttAdd.Name = "bttAdd";
            this.bttAdd.Size = new System.Drawing.Size(94, 30);
            this.bttAdd.TabIndex = 1;
            this.bttAdd.Text = "Add new";
            this.bttAdd.UseVisualStyleBackColor = true;
            this.bttAdd.Click += new System.EventHandler(this.bttAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bttDelete);
            this.groupBox1.Controls.Add(this.bttApplyChanges);
            this.groupBox1.Controls.Add(this.bttLoad);
            this.groupBox1.Controls.Add(this.tbID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbComment);
            this.groupBox1.Controls.Add(this.bttAdd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbStock);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbProduct);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(536, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 288);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Edit product";
            // 
            // bttDelete
            // 
            this.bttDelete.Location = new System.Drawing.Point(123, 50);
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Size = new System.Drawing.Size(135, 24);
            this.bttDelete.TabIndex = 10;
            this.bttDelete.Text = "Delete";
            this.bttDelete.UseVisualStyleBackColor = true;
            this.bttDelete.Click += new System.EventHandler(this.bttDelete_Click);
            // 
            // bttApplyChanges
            // 
            this.bttApplyChanges.Location = new System.Drawing.Point(133, 232);
            this.bttApplyChanges.Name = "bttApplyChanges";
            this.bttApplyChanges.Size = new System.Drawing.Size(94, 46);
            this.bttApplyChanges.TabIndex = 9;
            this.bttApplyChanges.Text = "Apply changes";
            this.bttApplyChanges.UseVisualStyleBackColor = true;
            this.bttApplyChanges.Click += new System.EventHandler(this.bttApplyChanges_Click);
            // 
            // bttLoad
            // 
            this.bttLoad.Location = new System.Drawing.Point(123, 20);
            this.bttLoad.Name = "bttLoad";
            this.bttLoad.Size = new System.Drawing.Size(135, 24);
            this.bttLoad.TabIndex = 8;
            this.bttLoad.Text = "Load";
            this.bttLoad.UseVisualStyleBackColor = true;
            this.bttLoad.Click += new System.EventHandler(this.bttLoad_Click);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(9, 47);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(107, 22);
            this.tbID.TabIndex = 7;
            this.tbID.TextChanged += new System.EventHandler(this.tbEditID_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "ID";
            // 
            // tbComment
            // 
            this.tbComment.Location = new System.Drawing.Point(9, 203);
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(249, 22);
            this.tbComment.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Comment";
            // 
            // tbStock
            // 
            this.tbStock.Location = new System.Drawing.Point(9, 153);
            this.tbStock.Name = "tbStock";
            this.tbStock.Size = new System.Drawing.Size(249, 22);
            this.tbStock.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stock balance";
            // 
            // tbProduct
            // 
            this.tbProduct.Location = new System.Drawing.Point(9, 104);
            this.tbProduct.Name = "tbProduct";
            this.tbProduct.Size = new System.Drawing.Size(249, 22);
            this.tbProduct.TabIndex = 1;
            this.tbProduct.TextChanged += new System.EventHandler(this.tbAddProduct_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product";
            // 
            // CatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 479);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvCatalog);
            this.Name = "CatalogForm";
            this.Text = "Catalog form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CatalogForm_FormClosing);
            this.Load += new System.EventHandler(this.CatalogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalog)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCatalog;
        private System.Windows.Forms.Button bttAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbComment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.Windows.Forms.Button bttLoad;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bttApplyChanges;
        private System.Windows.Forms.Button bttDelete;
    }
}