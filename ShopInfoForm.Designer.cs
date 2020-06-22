namespace _8307Ershov
{
    partial class ShopInfo
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
            this.Address = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.Specialization = new System.Windows.Forms.Label();
            this.Director = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Address.Location = new System.Drawing.Point(29, 21);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(406, 22);
            this.Address.TabIndex = 1;
            this.Address.Text = "Address: 198000, Saint Petersburg, Popova str, 5";
            this.Address.Click += new System.EventHandler(this.label1_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(713, 415);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 2;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Specialization
            // 
            this.Specialization.AutoSize = true;
            this.Specialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Specialization.Location = new System.Drawing.Point(29, 50);
            this.Specialization.Name = "Specialization";
            this.Specialization.Size = new System.Drawing.Size(342, 22);
            this.Specialization.TabIndex = 3;
            this.Specialization.Text = "Specialization: computers and peripherals";
            // 
            // Director
            // 
            this.Director.AutoSize = true;
            this.Director.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Director.Location = new System.Drawing.Point(29, 82);
            this.Director.Name = "Director";
            this.Director.Size = new System.Drawing.Size(183, 22);
            this.Director.TabIndex = 4;
            this.Director.Text = "Director: Ershov A. S.";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(33, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 60);
            this.button1.TabIndex = 5;
            this.button1.Text = "Balance report";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ShopInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Director);
            this.Controls.Add(this.Specialization);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Address);
            this.Name = "ShopInfo";
            this.Text = "Shop information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label Specialization;
        private System.Windows.Forms.Label Director;
        private System.Windows.Forms.Button button1;
    }
}