using System;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace _8307Ershov
{
    public partial class SellersForm : Form
    {
        private String dbFileName;
        private SQLiteConnection m_dbConn;
        private SQLiteCommand m_sqlCmd;

        public SellersForm()
        {
            InitializeComponent();
        }

        private void RefreshGridView()
        {
            // Read data from file and fill DataGridView
            DataTable dTable = new DataTable();
            String sqlQuery;

            try
            {
                sqlQuery = "SELECT * FROM Sellers";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, m_dbConn);
                adapter.Fill(dTable);

                if (dTable.Rows.Count > 0)
                {
                    dgvSellers.Rows.Clear();

                    for (int i = 0; i < dTable.Rows.Count; i++)
                    {
                        dgvSellers.Rows.Add(dTable.Rows[i].ItemArray);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void SellersForm_Load(object sender, EventArgs e)
        {
            m_dbConn = new SQLiteConnection();
            m_sqlCmd = new SQLiteCommand();

            dbFileName = "database.db";

            // Connect to database.db
            try
            {
                // Connect to database.db
                m_dbConn = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
                m_dbConn.Open();
                m_sqlCmd.Connection = m_dbConn;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            RefreshGridView();
        }

        private void bttAdd_Click(object sender, EventArgs e)
        {
            // TODO Add input check
            string pattern = @"[0-9]{4}-[0-1][0-9]-[0-3][0-9]";
            Match match = Regex.Match(tbDateOfBirth.Text, pattern);
            if (match.Success)
            {
                try
                {
                    m_sqlCmd.CommandText = "INSERT INTO Sellers ('FullName','DateOfBirth') values ('" +
                            tbFullName.Text + "' , '" +
                            tbDateOfBirth.Text + "')";
                    m_sqlCmd.ExecuteNonQuery();
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                // Read data from file and fill DataGridView
                RefreshGridView();
                tbFullName.Text = "";
                tbDateOfBirth.Text = "";
            }
            else
            {
                MessageBox.Show("Date of birth is invalid. Check it and try again.");
            }
                       
        }

        private void bttDeleteSeller_Click(object sender, EventArgs e)
        {
            int rowID = 0;
            bool checkNumber = int.TryParse(tbDeleteSellerID.Text, out rowID);
            if (checkNumber == true)
            {
                try
                {
                    m_sqlCmd.CommandText = "SELECT count(*) FROM Sellers WHERE ID=" + rowID;
                    int count = Convert.ToInt32(m_sqlCmd.ExecuteScalar());
                    if (count == 1)
                    {
                        m_sqlCmd.CommandText = "DELETE FROM Sellers WHERE ID=" + rowID;
                        m_sqlCmd.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("There no seller with ID " + rowID + ". Check ID and try again.");
                    }
                        
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                // Read data from file and fill DataGridView
                RefreshGridView();
                tbDeleteSellerID.Text = "";
            }
        }

        private void bttLoadSellerData_Click(object sender, EventArgs e)
        {
            tbModifySellerFullName.Text = "";
            tbMofidySellerDOB.Text = "";
            int rowID = 0;
            bool checkNumber = int.TryParse(tbModifySellerID.Text, out rowID);

            string ReturnValue = "";
            if (checkNumber == true && tbModifySellerID.Text != "")
            {
                try
                {
                    m_sqlCmd.CommandText = "SELECT count(*) FROM Sellers WHERE ID=" + rowID;
                    int count = Convert.ToInt32(m_sqlCmd.ExecuteScalar());
                    if (count == 1)
                    {
                        tbModifySellerID.ReadOnly = true;
                        m_sqlCmd.CommandText = "SELECT FullName FROM Sellers WHERE ID=" + rowID;
                        object data = m_sqlCmd.ExecuteScalar();
                        ReturnValue = (data != null) ? data.ToString() : "Error";
                        tbModifySellerFullName.Text = ReturnValue;

                        m_sqlCmd.CommandText = "SELECT DateOfBirth FROM Sellers WHERE ID=" + rowID;
                        data = m_sqlCmd.ExecuteScalar();
                        ReturnValue = (data != null) ? data.ToString() : "Error";
                        tbMofidySellerDOB.Text = ReturnValue;
                    }
                    else
                    {
                        MessageBox.Show("There no seller with ID " + rowID + ". Check ID and try again.");
                    }
                    //m_sqlCmd.ExecuteNonQuery();
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("ID is empty. Enter ID and try again.");
            }
        }

        private void bttModifySellerSave_Click(object sender, EventArgs e)
        {
            //TODO Check input (DOB)
            tbModifySellerID.ReadOnly = true;
            string pattern = @"[0-9]{4}-[0-1][0-9]-[0-3][0-9]";
            Match match = Regex.Match(tbMofidySellerDOB.Text, pattern);
            if (match.Success)
            {
                try
                {
                    //m_sqlCmd.CommandText = "UPDATE Sellers SET FullName = " + tbModifySellerFullName.Text + ", DateOfBirth = " + tbMofidySellerDOB.Text + " WHERE ID = " + int.Parse(tbModifySellerID.Text);
                    m_sqlCmd.CommandText = "UPDATE Sellers SET FullName = :FullName, DateOfBirth = :DateOfBirth WHERE ID = :ID";
                    m_sqlCmd.Parameters.Add("FullName", DbType.String).Value = tbModifySellerFullName.Text;
                    m_sqlCmd.Parameters.Add("DateOfBirth", DbType.String).Value = tbMofidySellerDOB.Text;
                    m_sqlCmd.Parameters.Add("ID", DbType.String).Value = tbModifySellerID.Text;
                    //+ int.Parse(tbModifySellerID.Text);
                    m_sqlCmd.ExecuteNonQuery();
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                RefreshGridView();
                tbModifySellerID.ReadOnly = false;
                tbModifySellerID.Text = "";
                tbModifySellerFullName.Text = "";
                tbMofidySellerDOB.Text = "";
            }
            else
            {
                MessageBox.Show("Date of birth is invalid. Check it and try again");
            }
        }
    }
}
