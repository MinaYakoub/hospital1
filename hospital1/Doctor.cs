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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
namespace hospital1
{
    public partial class Doctor : Form
    {
        readonly SqlConnection con =
         new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Mena Yakoub\Documents\Hospital MS.mdf"";Integrated Security=True;Connect Timeout=30");
        private void displayDoctor()
        {
            try
            {
                con.Open();
                string Query = "select* from Doctor ";
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
        public Doctor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || comboBox2.Text == ""
    || textBox4.Text == "" || textBox5.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    con.Open();
                    string query = "update Doctor Set DocName = @DocName , DocGen= @DocGen, Experience = @Experience , Licensce=@Licensce where DocId= @DocId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@DocName", textBox4.Text);
                    cmd.Parameters.AddWithValue("@DocGen", comboBox2.Text);
                    cmd.Parameters.AddWithValue("@Experience", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Licensce", textBox5.Text);
                    cmd.Parameters.AddWithValue("@DocId", textBox1.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("successfully updated ");
                    displayDoctor();



                }

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

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || comboBox2.Text == ""
                    || textBox4.Text == "" || textBox5.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    con.Open();
                    string query = "insert into Doctor Values('" + textBox1.Text + "','" + textBox4.Text + "','" + comboBox2.Text + "','" + textBox2.Text + "' , '" + textBox5.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("successfully inserted !!!");
                    displayDoctor();
                }
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

        private void Doctor_Load(object sender, EventArgs e)
        {
            displayDoctor();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox4.Text = "";
            comboBox2.Text = "";
            textBox2.Text = "";
            textBox5.Text = "";


        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("doctor ID required !!");

                }
                else
                {
                    con.Open();
                    string query = "delete from Doctor where DocId='" + textBox1.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("deleted succ !!");
                    displayDoctor();
                }

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

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox4.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                comboBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();




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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void displayDocId()
        {

        }
    }
}
