using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace _8307Ershov
{    
    public partial class CatalogForm : Form
    {
        public CatalogForm()
        {
            InitializeComponent();
        }

        LinkedList myList = new LinkedList();
        char delimeter = ';';

        private void UpdateDGV(LinkedList head)
        { 
            LinkedList tempNode = myList.GetHead();
            dgvCatalog.Rows.Clear();
            for (int i = 1; i <= myList.GetCount(); i++)
            {
                string[] words = (tempNode.GetID() + ';'.ToString() + tempNode.GetData()).Split(delimeter);
                dgvCatalog.Rows.Add(words);
                tempNode = tempNode.GetNext();
            }
        }

        private void WriteDlinkedListToFile(LinkedList head)
        {
            LinkedList tempNode = myList.GetHead();
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"Catalog.csv"))
            {
                for (int i = 1; i <= myList.GetCount(); i++)
                {
                    file.WriteLine(tempNode.GetData());
                    tempNode = tempNode.GetNext();
                }
            }
        }
        private void CatalogForm_Load(object sender, EventArgs e)
        {
            dgvCatalog.RowHeadersVisible = false;
            tbModifyProduct.Enabled = false;
            tbModifyPrice.Enabled = false;
            tbModifyStock.Enabled = false;
            tbModifyComment.Enabled = false;
            if (!File.Exists(@"Catalog.csv"))
            {
                using (var catalog = File.CreateText(@"Catalog.csv"))
                {
                    catalog.Close();
                }
            }
            string[] lines = System.IO.File.ReadAllLines(@"Catalog.csv");

            if ((lines.Count() > 0) && (myList.GetCount() == 0))
            {
                foreach (string line in lines)
                {
                    myList.GetTail().InsertNext(line.ToString());
                }
                UpdateDGV(myList.GetHead());
            }
            else
            {
                UpdateDGV(myList.GetHead());
            }
            
        }

        private void CatalogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            WriteDlinkedListToFile(myList.GetHead());
        }

        private void bttClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttAdd_Click(object sender, EventArgs e)
        {
            string cellDataConcat = "";
            cellDataConcat += tbAddProduct.Text + delimeter + tbAddPrice.Text + delimeter + tbAddStock.Text + delimeter + tbAddComment.Text;
            myList.GetTail().InsertNext(cellDataConcat);
            tbAddProduct.Text = "";
            tbAddPrice.Text = "";
            tbAddStock.Text = "";
            tbAddComment.Text = "";
            UpdateDGV(myList.GetHead());
        }


        private void bttLoadProductData_Click(object sender, EventArgs e)
        {
            int ID;
            bool checkNumber = int.TryParse(tbModifyID.Text, out ID);
            if (checkNumber == true)
            {
                LinkedList tempNode = myList.GetByID(ID);
                if (tempNode != null)
                {
                    String temp = myList.GetByID(ID).GetData();
                    tbModifyID.ReadOnly = true;

                    string[] words = temp.Split(delimeter);
                    tbModifyProduct.Text = words[0];
                    tbModifyPrice.Text = words[1];
                    tbModifyStock.Text = words[2];
                    tbModifyComment.Text = words[3];
                                        
                    tbModifyProduct.Enabled = true;
                    tbModifyPrice.Enabled = true;
                    tbModifyStock.Enabled = true;
                    tbModifyComment.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Product with ID = " + tbModifyID.Text + " doesn't exist. Try again.");
                }
            }
            else
            {
                MessageBox.Show("ID is invalid. Try again.");
            }
        }

        private void bttModifySave_Click(object sender, EventArgs e)
        {
            if (tbModifyID.Text != "")
            {
                myList.GetByID(Int32.Parse(tbModifyID.Text)).SetData(tbModifyProduct.Text + delimeter + tbModifyPrice.Text + delimeter + tbModifyStock.Text + delimeter + tbModifyComment.Text);
                tbModifyID.ReadOnly = false;
                tbModifyID.Text = "";
                tbModifyProduct.Text = "";
                tbModifyPrice.Text = "";
                tbModifyStock.Text = "";
                tbModifyComment.Text = "";
                tbModifyProduct.Enabled = false;
                tbModifyPrice.Enabled = false;
                tbModifyStock.Enabled = false;
                tbModifyComment.Enabled = false;

                UpdateDGV(myList.GetHead());
            }
            else
            {
                MessageBox.Show("ID is invalid. Enter ID, click load and modify data.");
            }

        }

        private void bttDeleteProduct_Click(object sender, EventArgs e)
        {
            int ID;
            bool checkNumber = int.TryParse(tbDeleteID.Text, out ID);
            if (checkNumber == true)
            {
                if (myList.GetByID(ID) != null)
                {
                    myList.DeleteByID(ID);
                    UpdateDGV(myList.GetHead());
                    tbDeleteID.Text = "";
                }
                else
                {
                    MessageBox.Show("Product with ID = " + tbDeleteID.Text + " doesn't exist. Try again.");
                }
            }
            else
            {
                MessageBox.Show("ID is invalid. Try again.");
            }
        }
    }
}
