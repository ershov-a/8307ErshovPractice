namespace _8307Ershov
{
    partial class SellersForm
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
            this.dgvSellers = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bttAdd = new System.Windows.Forms.Button();
            this.tbDateOfBirth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbDeleteSellerID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bttDeleteSeller = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbModifySellerFullName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMofidySellerDOB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbModifySellerID = new System.Windows.Forms.TextBox();
            this.bttLoadSellerData = new System.Windows.Forms.Button();
            this.bttModifySellerSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSellers
            // 
            this.dgvSellers.AllowUserToDeleteRows = false;
            this.dgvSellers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSellers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FullName,
            this.DateOfBirth});
            this.dgvSellers.Enabled = false;
            this.dgvSellers.Location = new System.Drawing.Point(13, 13);
            this.dgvSellers.Name = "dgvSellers";
            this.dgvSellers.RowHeadersWidth = 51;
            this.dgvSellers.RowTemplate.Height = 24;
            this.dgvSellers.Size = new System.Drawing.Size(546, 519);
            this.dgvSellers.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Full Name";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.Width = 125;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.HeaderText = "Date of birth";
            this.DateOfBirth.MinimumWidth = 6;
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bttAdd);
            this.groupBox1.Controls.Add(this.tbDateOfBirth);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbFullName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(590, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 161);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add new seller";
            // 
            // bttAdd
            // 
            this.bttAdd.Location = new System.Drawing.Point(298, 30);
            this.bttAdd.Name = "bttAdd";
            this.bttAdd.Size = new System.Drawing.Size(149, 114);
            this.bttAdd.TabIndex = 4;
            this.bttAdd.Text = "Add";
            this.bttAdd.UseVisualStyleBackColor = true;
            this.bttAdd.Click += new System.EventHandler(this.bttAdd_Click);
            // 
            // tbDateOfBirth
            // 
            this.tbDateOfBirth.Location = new System.Drawing.Point(11, 114);
            this.tbDateOfBirth.Name = "tbDateOfBirth";
            this.tbDateOfBirth.Size = new System.Drawing.Size(144, 30);
            this.tbDateOfBirth.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date of Birth (YYYY-MM-DD)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Full name";
            // 
            // tbFullName
            // 
            this.tbFullName.Location = new System.Drawing.Point(11, 53);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(269, 30);
            this.tbFullName.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bttDeleteSeller);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbDeleteSellerID);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(590, 451);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 81);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete seller";
            // 
            // tbDeleteSellerID
            // 
            this.tbDeleteSellerID.Location = new System.Drawing.Point(11, 45);
            this.tbDeleteSellerID.MaxLength = 1000;
            this.tbDeleteSellerID.Name = "tbDeleteSellerID";
            this.tbDeleteSellerID.Size = new System.Drawing.Size(144, 30);
            this.tbDeleteSellerID.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Seller ID";
            // 
            // bttDeleteSeller
            // 
            this.bttDeleteSeller.Location = new System.Drawing.Point(298, 23);
            this.bttDeleteSeller.Name = "bttDeleteSeller";
            this.bttDeleteSeller.Size = new System.Drawing.Size(149, 45);
            this.bttDeleteSeller.TabIndex = 2;
            this.bttDeleteSeller.Text = "Delete";
            this.bttDeleteSeller.UseVisualStyleBackColor = true;
            this.bttDeleteSeller.Click += new System.EventHandler(this.bttDeleteSeller_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bttModifySellerSave);
            this.groupBox3.Controls.Add(this.bttLoadSellerData);
            this.groupBox3.Controls.Add(this.tbModifySellerID);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tbMofidySellerDOB);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tbModifySellerFullName);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(590, 196);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(465, 229);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Modify exisiting seller";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(7, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Full name";
            // 
            // tbModifySellerFullName
            // 
            this.tbModifySellerFullName.Location = new System.Drawing.Point(11, 104);
            this.tbModifySellerFullName.Name = "tbModifySellerFullName";
            this.tbModifySellerFullName.Size = new System.Drawing.Size(269, 30);
            this.tbModifySellerFullName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(7, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Date of Birth (YYYY-MM-DD)";
            // 
            // tbMofidySellerDOB
            // 
            this.tbMofidySellerDOB.Location = new System.Drawing.Point(11, 171);
            this.tbMofidySellerDOB.Name = "tbMofidySellerDOB";
            this.tbMofidySellerDOB.Size = new System.Drawing.Size(144, 30);
            this.tbMofidySellerDOB.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(7, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Seller ID";
            // 
            // tbModifySellerID
            // 
            this.tbModifySellerID.Location = new System.Drawing.Point(11, 48);
            this.tbModifySellerID.Name = "tbModifySellerID";
            this.tbModifySellerID.Size = new System.Drawing.Size(144, 30);
            this.tbModifySellerID.TabIndex = 5;
            // 
            // bttLoadSellerData
            // 
            this.bttLoadSellerData.Location = new System.Drawing.Point(298, 21);
            this.bttLoadSellerData.Name = "bttLoadSellerData";
            this.bttLoadSellerData.Size = new System.Drawing.Size(149, 80);
            this.bttLoadSellerData.TabIndex = 6;
            this.bttLoadSellerData.Text = "Load";
            this.bttLoadSellerData.UseVisualStyleBackColor = true;
            this.bttLoadSellerData.Click += new System.EventHandler(this.bttLoadSellerData_Click);
            // 
            // bttModifySellerSave
            // 
            this.bttModifySellerSave.Location = new System.Drawing.Point(298, 135);
            this.bttModifySellerSave.Name = "bttModifySellerSave";
            this.bttModifySellerSave.Size = new System.Drawing.Size(149, 79);
            this.bttModifySellerSave.TabIndex = 7;
            this.bttModifySellerSave.Text = "Save";
            this.bttModifySellerSave.UseVisualStyleBackColor = true;
            this.bttModifySellerSave.Click += new System.EventHandler(this.bttModifySellerSave_Click);
            // 
            // SellersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvSellers);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SellersForm";
            this.Text = "Sellers";
            this.Load += new System.EventHandler(this.SellersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSellers;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.Button bttAdd;
        private System.Windows.Forms.TextBox tbDateOfBirth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbDeleteSellerID;
        private System.Windows.Forms.Button bttDeleteSeller;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbModifySellerFullName;
        private System.Windows.Forms.TextBox tbMofidySellerDOB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bttModifySellerSave;
        private System.Windows.Forms.Button bttLoadSellerData;
        private System.Windows.Forms.TextBox tbModifySellerID;
        private System.Windows.Forms.Label label6;
    }
}