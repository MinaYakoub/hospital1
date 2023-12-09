using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login login =new Login();
            login.Show();
            this.Hide();    
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void doctorBtn_Click(object sender, EventArgs e)
        {
            Doctor doctor =new Doctor();    
            doctor.Show();
            this.Hide();
        }

        private void patientBtn_Click(object sender, EventArgs e)
        {
            Patient patient =new Patient(); 
            patient.Show();
            this.Hide();
        }

        private void diagnosisBtn_Click(object sender, EventArgs e)
        {
            Diagnosis diagnosis =new Diagnosis();   
            diagnosis.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Search search =new Search();        
            search.Show();
            this.Hide();
        }
    }
}
