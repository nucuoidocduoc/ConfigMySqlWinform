using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["dbMysql"].ConnectionString;
            MySqlConnection connection = new MySqlConnection(connectionString);
            //connection.Open();
            RepositoryContext repositoryContext = new RepositoryContext(connection, false);
            var car = repositoryContext.Cars.FirstOrDefault();
            if (car != null) {
                MessageBox.Show(car.Name);
            }
            else {
                MessageBox.Show("empty");
            }
        }
    }
}