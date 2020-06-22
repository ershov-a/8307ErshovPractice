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
    public partial class SellersForm : Form
    {
        private readonly SQLiteConnection _dbConnection;
        private readonly SQLiteDataAdapter _dbDataAdapter;
        private readonly DataSet _dsParticipants;

        public SellersForm()
        {
            InitializeComponent();

            _dbConnection = new SQLiteConnection("Data Source = database.db");
            _dsParticipants = new DataSet();

            _dbDataAdapter = new SQLiteDataAdapter();

            var selectCommand = new SQLiteCommand("SELECT Id, LastName, FirstName, BirthDate FROM Participant", _dbConnection);
            _dbDataAdapter.SelectCommand = selectCommand;

            var deleteCommand = new SQLiteCommand("DELETE FROM Participant WHERE Id = @Id", _dbConnection);
            deleteCommand.Parameters.Add(new SQLiteParameter("@Id", DbType.Int64, "Id"));
            _dbDataAdapter.DeleteCommand = deleteCommand;

            var insertCommand = new SQLiteCommand("INSERT INTO Participant (LastName, FirstName, BirthDate) VALUES (@LastName, @FirstName, @BirthDate);", _dbConnection);
            insertCommand.Parameters.Add(
                new SQLiteParameter("@LastName", DbType.String, "LastName"));
            insertCommand.Parameters.Add(
                new SQLiteParameter("@FirstName", DbType.String, "FirstName"));
            insertCommand.Parameters.Add(
                new SQLiteParameter("@BirthDate", DbType.String, "BirthDate"));
            _dbDataAdapter.InsertCommand = insertCommand;

            var updateCommand = new SQLiteCommand("UPDATE Participant SET LastName = @LastName, FirstName=@FirstName, BirthDate = @BirthDate WHERE Id = @Id", _dbConnection);
            updateCommand.Parameters.Add(
                new SQLiteParameter("@LastName", DbType.String, "LastName"));
            updateCommand.Parameters.Add(
                new SQLiteParameter("@FirstName", DbType.String, "FirstName"));
            updateCommand.Parameters.Add(
                new SQLiteParameter("@BirthDate", DbType.String, "BirthDate"));
            updateCommand.Parameters.Add(
                new SQLiteParameter("@Id", DbType.Int64, "Id"));
            _dbDataAdapter.UpdateCommand = updateCommand;

            _dbDataAdapter.RowUpdated += _dbDataAdapter_RowUpdated;
        }

        private void SellersForm_Load(object sender, EventArgs e)
        {
            try
            {
                _dbDataAdapter.Fill(_dsParticipants, "Participant");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //dgvParticipants.DataSource = _dsParticipants.Tables["Participant"];
        }

        private void _dbDataAdapter_RowUpdated(object sender, System.Data.Common.RowUpdatedEventArgs e)
        {
            //https://msdn.microsoft.com/en-us/library/ks9f57t0%28v=vs.110%29.aspx
            if (e.StatementType == StatementType.Insert)
            {
                var getIdCommand = new SQLiteCommand("SELECT last_insert_rowid()", _dbConnection);
                e.Row["Id"] = (long)getIdCommand.ExecuteScalar();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvParticipants_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
