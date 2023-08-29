using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pwm_v1
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        //Report form load Event
        private void Report_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();

            ReportDataSource Emails_Info = new ReportDataSource("DataSetEmail", EmailsInfo());
            ReportDataSource Website_Info = new ReportDataSource("DataSetWeb", WebsiteInfo());
            ReportDataSource Application_Info = new ReportDataSource("DataSetApplication", ApplicationInfo());
            ReportDataSource BankCards_Info = new ReportDataSource("DataSetBankCard", BankCardsInfo());

            reportViewer1.LocalReport.ReportPath = @"Report.rdlc";

            reportViewer1.LocalReport.DataSources.Add(Emails_Info);
            reportViewer1.LocalReport.DataSources.Add(Website_Info);
            reportViewer1.LocalReport.DataSources.Add(Application_Info);
            reportViewer1.LocalReport.DataSources.Add(BankCards_Info);

            reportViewer1.RefreshReport();
        }

        //For Email Details
        private DataTable EmailsInfo()
        {
            DataTable dataTable = new DataTable();

            //Create ConnectionString
            string ConnectionString = @"Data Source=DESKTOP-5JC6HTG\SQLEXPRESS;Initial Catalog=THIRDEYE_PASSWORD_MANAGER;User Id=yasiru;password=123456789";

            //Create SqlConnection with Connection class
            SqlConnection Con = new SqlConnection(ConnectionString);

            //Open the Connection
            Con.Open();

            //Sql Statement
            string sql = "Select * from EMAILS";

            //Create Command Class Object
            SqlCommand command = new SqlCommand(sql, Con);

            //Create DataReader Class Object
            SqlDataReader dataReader = command.ExecuteReader();

            //Load the dataReader data to data table
            dataTable.Load(dataReader);

            //return 
            return dataTable;
        }

        //For Websites Details
        private DataTable WebsiteInfo()
        {
            DataTable dataTable = new DataTable();

            //Create ConnectionString
            string ConnectionString = @"Data Source=DESKTOP-5JC6HTG\SQLEXPRESS;Initial Catalog=THIRDEYE_PASSWORD_MANAGER;User Id=yasiru;password=123456789";

            //Create SqlConnection with Connection class
            SqlConnection Con = new SqlConnection(ConnectionString);

            //Open the Connection
            Con.Open();

            //Sql Statement
            string sql = "Select * from WEBSITES";

            //Create Command Class Object
            SqlCommand command = new SqlCommand(sql, Con);

            //Create DataReader Class Object
            SqlDataReader dataReader = command.ExecuteReader();

            //Load the dataReader data to data table
            dataTable.Load(dataReader);

            //return 
            return dataTable;
        }

        //For Application Details
        private DataTable ApplicationInfo()
        {
            DataTable dataTable = new DataTable();

            //Create ConnectionString
            string ConnectionString = @"Data Source=DESKTOP-5JC6HTG\SQLEXPRESS;Initial Catalog=THIRDEYE_PASSWORD_MANAGER;User Id=yasiru;password=123456789";

            //Create SqlConnection with Connection class
            SqlConnection Con = new SqlConnection(ConnectionString);

            //Open the Connection
            Con.Open();

            //Sql Statement
            string sql = "Select * from APPLICATIONS";

            //Create Command Class Object
            SqlCommand command = new SqlCommand(sql, Con);

            //Create DataReader Class Object
            SqlDataReader dataReader = command.ExecuteReader();

            //Load the dataReader data to data table
            dataTable.Load(dataReader);

            //return 
            return dataTable;
        }


        //For BankCards Details
        private DataTable BankCardsInfo()
        {
            DataTable dataTable = new DataTable();

            //Create ConnectionString
            string ConnectionString = @"Data Source=DESKTOP-5JC6HTG\SQLEXPRESS;Initial Catalog=THIRDEYE_PASSWORD_MANAGER;User Id=yasiru;password=123456789";

            //Create SqlConnection with Connection class
            SqlConnection Con = new SqlConnection(ConnectionString);

            //Open the Connection
            Con.Open();

            //Sql Statement
            string sql = "Select * from BANKCARDS";

            //Create Command Class Object
            SqlCommand command = new SqlCommand(sql, Con);

            //Create DataReader Class Object
            SqlDataReader dataReader = command.ExecuteReader();

            //Load the dataReader data to data table
            dataTable.Load(dataReader);

            //return 
            return dataTable;
        }
    }
}
