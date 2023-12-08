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
    public partial class Diagnosis : Form
    {
        readonly SqlConnection con =
        new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Mena Yakoub\Documents\Hospital MS.mdf"";Integrated Security=True;Connect Timeout=30");
        private void displayDiagnosis()
        {
            try
            {
                con.Open();
                string Query = "select * from Diagnosis ";
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
        void displayPatientId()
        {
            string sql = "select * from Patient";
            SqlCommand cmd = new SqlCommand(sql,con);
            SqlDataReader sqlDataReader;
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("PId", typeof(int));
                sqlDataReader = cmd.ExecuteReader();
                dt.Load(sqlDataReader);
                comboBox1.ValueMember = "Pid";
                comboBox1.DataSource=dt;
                con.Close();

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public Diagnosis()
        {
            InitializeComponent();
            displayDiagnosis();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" ||comboBox1.Text==""|| comboBox2.Text == "" )
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    con.Open();
                    string query = "insert into Diagnosis Values('" + textBox1.Text + "','" + comboBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "' , '" + textBox4.Text + "','" + textBox5.Text + "','" + comboBox2.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("successfully inserted !!!");
                    displayDiagnosis();
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

        private void Diagnosis_Load(object sender, EventArgs e)
        {
            displayPatientId();
            displayDiagnosis();
            displayDocId();
            displayPatientName();
        }

        private void button1_Click(object sender, EventArgs e)
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
                    string query = "update Diagnosis Set PatientId = @PatientId , PatientName= @PatientName, Symptoms=@Symptoms,DiagnosisTest = @DiagnosisTest , Medicines=@Medicines ,DocId=@DocId where DId= @DId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("PatientId", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@PatientName", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Symptoms", textBox3.Text);
                    cmd.Parameters.AddWithValue("@DiagnosisTest", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Medicines", textBox5.Text);
                    cmd.Parameters.AddWithValue("@DocId", comboBox2.Text);
                    cmd.Parameters.AddWithValue("@DId", textBox1.Text);



                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("successfully updated ");
                    displayDiagnosis();



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
            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Diagnosis ID required !!");

                }
                else
                {
                    con.Open();
                    string query = "delete from Diagnosis where DId='" + textBox1.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("deleted succ !!");
                    displayDiagnosis();
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

        private void button3_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                comboBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();


                textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                comboBox2.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();


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
            try
            {
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                comboBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();


                textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                comboBox2.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();


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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        string pname;
        void displayPatientName()
        {
            try
            {
                con.Open();
                string ss = "select * from Patient where PId =" + comboBox1.SelectedValue.ToString();
                SqlCommand cmd  = new SqlCommand(ss, con);
                DataTable dt =  new DataTable();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    pname = dr["PName"].ToString();
                    textBox2.Text = pname;
                }
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

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            displayPatientName();
            displayPatientId();
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
                comboBox2.ValueMember = "DocId";
                comboBox2.DataSource = dt;
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

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            displayDocId();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
