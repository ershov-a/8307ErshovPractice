namespace _8307Ershov
{
    partial class MainMenuForm
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
            this.ShopInfo = new System.Windows.Forms.Button();
            this.Sellers = new System.Windows.Forms.Button();
            this.CatalogButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShopInfo
            // 
            this.ShopInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShopInfo.Location = new System.Drawing.Point(658, 44);
            this.ShopInfo.Name = "ShopInfo";
            this.ShopInfo.Size = new System.Drawing.Size(200, 254);
            this.ShopInfo.TabIndex = 2;
            this.ShopInfo.Text = "Shop Info";
            this.ShopInfo.UseVisualStyleBackColor = true;
            this.ShopInfo.Click += new System.EventHandler(this.ShopInfo_Click);
            // 
            // Sellers
            // 
            this.Sellers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Sellers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sellers.Location = new System.Drawing.Point(355, 44);
            this.Sellers.Name = "Sellers";
            this.Sellers.Size = new System.Drawing.Size(200, 254);
            this.Sellers.TabIndex = 4;
            this.Sellers.Text = "Sellers";
            this.Sellers.UseVisualStyleBackColor = true;
            this.Sellers.Click += new System.EventHandler(this.Sellers_Click);
            // 
            // CatalogButton
            // 
            this.CatalogButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CatalogButton.Location = new System.Drawing.Point(37, 44);
            this.CatalogButton.Name = "CatalogButton";
            this.CatalogButton.Size = new System.Drawing.Size(200, 254);
            this.CatalogButton.TabIndex = 5;
            this.CatalogButton.Text = "Catalog";
            this.CatalogButton.UseVisualStyleBackColor = true;
            this.CatalogButton.Click += new System.EventHandler(this.Catalog_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 357);
            this.Controls.Add(this.CatalogButton);
            this.Controls.Add(this.Sellers);
            this.Controls.Add(this.ShopInfo);
            this.Name = "MainMenuForm";
            this.Text = "Shop administrator";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ShopInfo;
        private System.Windows.Forms.Button Sellers;
        private System.Windows.Forms.Button CatalogButton;
    }
}

