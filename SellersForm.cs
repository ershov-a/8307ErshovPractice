using System;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace _8307Ershov
{
    public partial class SellersForm : Form
    {
        public SellersForm()
        {
            InitializeComponent();
        }

        LinkedList myList = new LinkedList();
        char delimeter = ';';

        private void UpdateDGV(LinkedList head)
        {
            LinkedList tempNode = myList.GetHead();
            dgvSellers.Rows.Clear();
            for (int i = 1; i <= myList.GetCount(); i++)
            {
                string[] words = (tempNode.GetID() + ';'.ToString() + tempNode.GetData()).Split(delimeter);
                dgvSellers.Rows.Add(words);
                tempNode = tempNode.GetNext();
            }
        }

        private void SellersForm_Load(object sender, EventArgs e)
        {
            dgvSellers.RowHeadersVisible = false;
            tbModifyFullName.Enabled = false;
            tbModifyDOB.Enabled = false;
            if (!File.Exists(@"Sellers.csv"))
            {
                using (var catalog = File.CreateText(@"Sellers.csv"))
                {
                    catalog.Close();
                }
            }
            string[] lines = System.IO.File.ReadAllLines(@"Sellers.csv");

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

        private void bttAdd_Click(object sender, EventArgs e)
        {
            string pattern = @"^[0-9]{4}-[0-1][0-9]-[0-3][0-9]$";
            Match match = Regex.Match(tbAddDateOfBirth.Text, pattern);
            if (match.Success)
            {
                string cellDataConcat = "";
                cellDataConcat += tbAddFullName.Text + delimeter + tbAddDateOfBirth.Text;
                myList.GetTail().InsertNext(cellDataConcat);
                tbAddFullName.Text = "";
                tbAddDateOfBirth.Text = "";
                UpdateDGV(myList.GetHead());
            }
            else
            {
                MessageBox.Show("Date of birth is invalid. Check it and try again.");
            }
                       
        }

        private void bttDeleteSeller_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Seller with ID = " + tbDeleteID.Text + " doesn't exist. Try again.");
                }
            }
            else
            {
                MessageBox.Show("ID is invalid. Try again.");
            }
        }

        private void bttLoadSellerData_Click(object sender, EventArgs e)
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
                    tbModifyFullName.Text = words[0];
                    tbModifyDOB.Text = words[1];
                    
                    tbModifyFullName.Enabled = true;
                    tbModifyDOB.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Seller with ID = " + tbModifyID.Text + " doesn't exist. Try again.");
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
                string pattern = @"^[0-9]{4}-[0-1][0-9]-[0-3][0-9]$";
                Match match = Regex.Match(tbModifyDOB.Text, pattern);
                if (match.Success)
                {
                    myList.GetByID(Int32.Parse(tbModifyID.Text)).SetData(tbModifyFullName.Text + delimeter + tbModifyDOB.Text);
                    tbModifyID.ReadOnly = false;
                    tbModifyID.Text = "";
                    tbModifyFullName.Text = "";
                    tbModifyDOB.Text = "";
                    tbModifyFullName.Enabled = false;
                    tbModifyDOB.Enabled = false;

                    UpdateDGV(myList.GetHead());
                }
                else
                {
                    MessageBox.Show("Date of birth is invalid. Check it and try again.");
                }
            }
            else
            {
                MessageBox.Show("ID is invalid. Enter ID, click load and modify data.");
            }
        }

        private void bttClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WriteDlinkedListToFile(LinkedList head)
        {
            LinkedList tempNode = myList.GetHead();
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"Sellers.csv"))
            {
                for (int i = 1; i <= myList.GetCount(); i++)
                {
                    file.WriteLine(tempNode.GetData());
                    tempNode = tempNode.GetNext();
                }
            }
        }

        private void SellersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            WriteDlinkedListToFile(myList.GetHead());
        }
    }
}
