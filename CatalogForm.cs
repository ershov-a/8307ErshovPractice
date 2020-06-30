using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace _8307Ershov
{
    // TODO Empty input file handling
    public partial class CatalogForm : Form
    {
        public CatalogForm()
        {
            InitializeComponent();
        }
        LinkedList myList = new LinkedList();
        
        private void UpdateDGV(LinkedList head)
        {
            //LinkedList tempNode = head;
            LinkedList tempNode = myList.GetHead();
            //Console.WriteLine("Head count = " + head.GetCount());
            dgvCatalog.Rows.Clear();
            //Console.WriteLine("\n------");
            for (int i = 1; i <= myList.GetCount(); i++)
            {
                string[] words = (tempNode.GetID() + "," + tempNode.GetData()).Split(',');
                dgvCatalog.Rows.Add(words);
                tempNode = tempNode.GetNext();
            }
        }

        private LinkedList GetByID(LinkedList head, int ID)
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
        }

        private void DeleteByID(LinkedList headNode, int ID)
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
            var lineCounter = 0L;
            using (var file = new System.IO.StreamReader(@"Catalog.csv"))
            {
                while (file.ReadLine() != null)
                {
                    lineCounter++;
                }

            }
            // Read file and fill LinkedList
            using (System.IO.StreamReader file = new System.IO.StreamReader(@"Catalog.csv"))
            {
                string line;
                line = file.ReadLine();
                if (line != "")
                {
                    myList = new LinkedList(line);
                    for (int i = 2; i <= lineCounter; i++)
                    {
                        line = file.ReadLine();
                        myList.GetTail().InsertNext(line);
                    }
                }
                file.Close();
            }
            UpdateDGV(myList.GetHead());
        }

        private void CatalogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            WriteDlinkedListToFile(myList.GetHead());
        }

        private void bttAdd_Click(object sender, EventArgs e)
        {
            string cellDataConcat = "";
            cellDataConcat += tbProduct.Text + "," + tbStock.Text + "," + tbComment.Text;
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
                    string[] words = temp.Split(',');
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
            myList.GetByID(Int32.Parse(tbID.Text)).SetData(tbProduct.Text + "," + tbStock.Text + "," + tbComment.Text);
            tbID.ReadOnly = false;
            tbID.Text = "";
            tbProduct.Text = "";
            tbStock.Text = "";
            tbComment.Text = "";
            
            UpdateDGV(myList.GetHead());

        }

        private void tbEditID_TextChanged(object sender, EventArgs e)
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

        private void tbAddProduct_TextChanged(object sender, EventArgs e)
        {

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
    }
}
