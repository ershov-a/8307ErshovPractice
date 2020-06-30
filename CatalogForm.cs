using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        /*private LinkedList GetByID(LinkedList head, int ID)
        {
            LinkedList temp = head;
            while (temp != null)
            {
                if (temp.GetID() == ID)
                {
                    return temp;
                }
                else
                {
                    temp = temp.GetNext();
                }
            }
            return null;
        }*/

        /*private void DeleteByID(LinkedList headNode, int ID)
        {
            //LinkedList temp = GetByID(headNode, ID);
            LinkedList prev = new LinkedList();
            LinkedList temp = new LinkedList();

            if (headNode.GetID() == ID)
            {
                myList.SetHead(headNode.GetNext());
                myList.DecrementCount();
            }
            else
            {
                temp = headNode;
                while (temp != null && temp.GetID() != ID)
                {
                    prev = temp;
                    temp = temp.GetNext(); 
                }
                if (temp != null)
                {
                    prev.SetNext(temp.GetNext());
                    myList.DecrementCount();
                }
            }
        }*/

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

        private void bttAdd_Click(object sender, EventArgs e)
        {
            string cellDataConcat = "";
            cellDataConcat += tbProduct.Text + delimeter + tbStock.Text + delimeter + tbComment.Text;
            myList.GetTail().InsertNext(cellDataConcat);
            tbProduct.Text = "";
            tbStock.Text = "";
            tbComment.Text = "";
            UpdateDGV(myList.GetHead());
        }

        private void bttLoad_Click(object sender, EventArgs e)
        {
            int ID;
            bool checkNumber = int.TryParse(tbID.Text, out ID);
            if (checkNumber == true)
            {
                LinkedList tempNode = myList.GetByID(ID);
                if (tempNode != null)
                {
                    String temp = myList.GetByID(ID).GetData();
                    tbID.ReadOnly = true;
                    bttAdd.Enabled = false;
                    string[] words = temp.Split(delimeter);
                    tbProduct.Text = words[0];
                    tbStock.Text = words[1];
                    tbComment.Text = words[2];

                    bttApplyChanges.Enabled = true;
                    //bttAdd.Enabled = true;
                    tbProduct.Enabled = true;
                    tbStock.Enabled = true;
                    tbComment.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Product with ID = " + tbID.Text + " doesn't exist. Try again.");
                }
            }
            else
            {
                MessageBox.Show("ID is invalid. Try again.");
            }
            
            
        }

        private void bttApplyChanges_Click(object sender, EventArgs e)
        {
            if (tbID.Text != "")
            {
                myList.GetByID(Int32.Parse(tbID.Text)).SetData(tbProduct.Text + delimeter + tbStock.Text + delimeter + tbComment.Text);
                tbID.ReadOnly = false;
                tbID.Text = "";
                tbProduct.Text = "";
                tbStock.Text = "";
                tbComment.Text = "";

                UpdateDGV(myList.GetHead());
            }
            else
            {
                MessageBox.Show("ID is invalid. Enter ID, click load and modify data.");
            }
            

        }

        private void tbID_TextChanged(object sender, EventArgs e)
        {
            if (tbID.Text == "")
            {
                bttApplyChanges.Enabled = true;
                bttAdd.Enabled = true;
                tbProduct.Enabled = true;
                tbStock.Enabled = true;
                tbComment.Enabled = true;
            }
            else
            {
                bttApplyChanges.Enabled = false;
                bttAdd.Enabled = false;
                tbProduct.Enabled = false;
                tbStock.Enabled = false;
                tbComment.Enabled = false;
            }
            
        }

        private void tbProduct_TextChanged(object sender, EventArgs e)
        {
            if (tbProduct.Text == "")
            {
                tbID.ReadOnly = false;
                bttLoad.Enabled = true;
                bttDelete.Enabled = true;
                bttApplyChanges.Enabled = true;
            }
            else
            {
                tbID.ReadOnly = true;
                bttLoad.Enabled = false;
                bttDelete.Enabled = false;
                if (tbID.ReadOnly == true)
                {
                    bttApplyChanges.Enabled = true;
                }
                else
                {
                    bttApplyChanges.Enabled = false;
                }
                
            }
        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            int ID;
            bool checkNumber = int.TryParse(tbID.Text, out ID);
            if (checkNumber == true)
            {
                if (myList.GetByID(ID) != null)
                {
                    myList.DeleteByID(ID);
                    UpdateDGV(myList.GetHead());
                    tbID.Text = "";
                }
                else
                {
                    MessageBox.Show("Product with ID = " + tbID.Text + " doesn't exist. Try again.");
                }
            }
            else
            {
                MessageBox.Show("ID is invalid. Try again.");
            }
        }

        private void tbStock_TextChanged(object sender, EventArgs e)
        {
            if (tbStock.Text == "")
            {
                tbID.ReadOnly = false;
                bttLoad.Enabled = true;
                bttDelete.Enabled = true;
                bttApplyChanges.Enabled = true;
            }
            else
            {
                tbID.ReadOnly = true;
                bttLoad.Enabled = false;
                bttDelete.Enabled = false;
                if (tbID.ReadOnly == true)
                {
                    bttApplyChanges.Enabled = true;
                }
                else
                {
                    bttApplyChanges.Enabled = false;
                }
            }
        }

        private void tbComment_TextChanged(object sender, EventArgs e)
        {
            if (tbComment.Text == "")
            {
                tbID.ReadOnly = false;
                bttLoad.Enabled = true;
                bttDelete.Enabled = true;
                bttApplyChanges.Enabled = true;
            }
            else
            {
                tbID.ReadOnly = true;
                bttLoad.Enabled = false;
                bttDelete.Enabled = false;
                if (tbID.ReadOnly == true)
                {
                    bttApplyChanges.Enabled = true;
                }
                else
                {
                    bttApplyChanges.Enabled = false;
                }
            }
        }

        private void bttClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
