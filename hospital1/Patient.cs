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
    public partial class Patient : Form
    {
        readonly SqlConnection con =
        new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Mena Yakoub\Documents\Hospital MS.mdf"";Integrated Security=True;Connect Timeout=30");
        private void displayPatient()
        {
            try
            {
                con.Open();
                string Query = "select* from Patient ";
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
        public Patient()
        {
            InitializeComponent();
            displayPatient();
        }

        private void Patient_Load(object sender, EventArgs e)
        {
            displayPatient();
            displayDocId();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || textBox6.Text == "" || comboBox3.Text == "" )
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    con.Open();
                    string query = "insert into Patient Values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "' , '" + textBox5.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox6.Text + "', '" + comboBox3.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("successfully inserted !!!");
                    displayPatient();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
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
                    string query = "update Patient Set PName = @PName , PAddress= @PAddress, PAge=@PAge,PPhone = @PPhone , PGen=@PGen ,BloodGroup=@BloodGroup,MajorDisease=@MajorDisease ,DocId=@DocId where PId= @PId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("PName", textBox2.Text);
                    cmd.Parameters.AddWithValue("@PAddress", textBox3.Text);
                    cmd.Parameters.AddWithValue("@PAge", textBox4.Text);
                    cmd.Parameters.AddWithValue("@PPhone", textBox5.Text);
                    cmd.Parameters.AddWithValue("@PGen", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@BloodGroup", comboBox2.Text);
                    cmd.Parameters.AddWithValue("@MajorDisease", textBox6.Text);
                    cmd.Parameters.AddWithValue("@DocId", comboBox3.Text);
                    cmd.Parameters.AddWithValue("@PId", textBox1.Text);



                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("successfully updated ");
                    displayPatient();



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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Patient ID required !!");

                }
                else
                {
                    con.Open();
                    string query = "delete from Patient where PId='" + textBox1.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("deleted succ !!");
                    displayPatient();
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

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox6.Text = "";
            comboBox3.Text = "";



        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DockChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

                comboBox1.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                comboBox2.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();

                textBox6.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                comboBox3.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();

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
        void displayDocId()
        {

            string sql = "select * from Doctor";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader sqlDataReader;
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("DocId", typeof(int));
                sqlDataReader = cmd.ExecuteReader();
                dt.Load(sqlDataReader);
                comboBox3.ValueMember = "DocId";
                comboBox3.DataSource = dt;
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
       

        private void comboBox4_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            displayDocId();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
               Home home = new Home();      
            home.Show();
            this.Hide();
        }
    }
}
