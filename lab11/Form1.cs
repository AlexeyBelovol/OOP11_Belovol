using System;
using System.Data;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;

namespace lab11
{
    public partial class Form1 : Form
    {
        private string excelFilePath = @"C:\Users\Алексей\Desktop\OOP\transport_company.xlsx";
        private OleDbConnection connection;

        public Form1()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
        }

        private void InitializeDatabaseConnection()
        {
            string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={excelFilePath};Extended Properties='Excel 12.0 Xml;HDR=YES;'";
            connection = new OleDbConnection(connectionString);
        }

        private void buttonAddCar_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO [Cars$] ([Model], [Year], [Mileage], [Status]) VALUES (@Model, @Year, @Mileage, @Status)";
            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Model", textBoxModel.Text);
                command.Parameters.AddWithValue("@Year", textBoxYear.Text);
                command.Parameters.AddWithValue("@Mileage", textBoxMileage.Text);
                command.Parameters.AddWithValue("@Status", textBoxStatus.Text);

                ExecuteQuery(command);
            }
            LoadCars();
        }

        private void buttonAddDriver_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO [Drivers$] ([Name], [LicenseNumber], [PhoneNumber], [AssignedCarID]) VALUES (@Name, @LicenseNumber, @PhoneNumber, @AssignedCarID)";
            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Name", textBoxName.Text);
                command.Parameters.AddWithValue("@LicenseNumber", textBoxLicenseNumber.Text);
                command.Parameters.AddWithValue("@PhoneNumber", textBoxPhoneNumber.Text);
                command.Parameters.AddWithValue("@AssignedCarID", textBoxAssignedCarID.Text);
                ExecuteQuery(command);
            }
            LoadDrivers();
        }

        private void ExecuteQuery(OleDbCommand command)
        {
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void buttonSearchCar_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM [Cars$] WHERE [Model] = @Model";
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@Model", textBoxSearchCriterion.Text);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridViewCars.DataSource = dataTable;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCars();
            LoadDrivers();
        }

        private void LoadCars()
        {
            string query = "SELECT * FROM [Cars$]";
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridViewCars.DataSource = dataTable;
        }

        private void LoadDrivers()
        {
            string query = "SELECT * FROM [Drivers$]";
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridViewDrivers.DataSource = dataTable;
        }
    }
}
