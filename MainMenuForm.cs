using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace _8307Ershov
{
    public partial class MainMenuForm : Form
    {

        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void ShopInfo_Click(object sender, EventArgs e)
        {
            ShopInfo newForm = new ShopInfo();
            newForm.Show();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Catalog_Click(object sender, EventArgs e)
        {
            CatalogForm newForm = new CatalogForm();
            newForm.Show();
        }

        private void Sellers_Click(object sender, EventArgs e)
        {
            SellersForm newForm = new SellersForm();
            newForm.Show();
        }
    }
}
