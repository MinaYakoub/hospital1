using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace hospital1
{
    public partial class Search : Form
    {
        readonly SqlConnection con =
        new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Mena Yakoub\Documents\Hospital MS.mdf"";Integrated Security=True;Connect Timeout=30");
        private void displayDoctorDetails()
        {
            try
            {
                
                con.Open();
                string Query = "select* from Doctor where DocId='"+textBox1.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder();
                var ds = new DataSet();
                sda.Fill(ds);         
           dataGridView1.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public Search()
        {
            InitializeComponent();
        }
        private void displayPatientDetails()
        {
            try
            {
                con.Open();
                string Query = "select* from Patient where PId='" + textBox2.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder();
                var ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void displayDiagnosisDetails()
        {
            try
            {
                con.Open();
                string Query = "select* from Diagnosis where DId='" + textBox3.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder();
                var ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


        private void Search_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospital_MSDataSet.Doctor' table. You can move, or remove it, as needed.
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                displayDoctorDetails();
            }
            else if (textBox2.Text != string.Empty)
            {
                displayPatientDetails();
            }
            else if (textBox3.Text != String.Empty) {
                displayDiagnosisDetails();
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Close();
        }
    }
}
