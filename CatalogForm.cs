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
    public partial class CatalogForm : Form
    {
        public CatalogForm()
        {
            InitializeComponent();
        }

        DLinkedList head = new DLinkedList();

        private void UpdateDGV(DLinkedList head)
        {
            DLinkedList tempNode = head;
            dgvCatalog.Rows.Clear();
            for (int i = 1; i <= head.GetCount(); i++)
            {
                string[] words = tempNode.GetData().Split(',');
                //Console.WriteLine(words);
                dgvCatalog.Rows.Add(words);
                tempNode = tempNode.GetNext();
            }
        }

        private void CatalogForm_Load(object sender, EventArgs e)
        {
            var lineCounter = 0L;
            using (var reader = new System.IO.StreamReader(@"Catalog.csv"))
            {
                while (reader.ReadLine() != null)
                {
                    lineCounter++;
                }
            }
            // Read file and fill DLinkedList
            using (System.IO.StreamReader file = new System.IO.StreamReader(@"Catalog.csv"))
            {
                string line;
                line = file.ReadLine();
                head = new DLinkedList(line);
                for (int i = 2; i <= lineCounter; i++)
                {
                    line = file.ReadLine();
                    head.InsertNext(line);
                }
                file.Close();
            }
            UpdateDGV(head);

            /*DLinkedList tempNode = head;
            for (int i = 1; i <= head.GetCount(); i++)
            {
                string[] words = tempNode.GetData().Split(',');
                //Console.WriteLine(words);
                dgvCatalog.Rows.Add(words);
                tempNode = tempNode.GetNext();
            }*/
        }
    }


}
