namespace hospital1
{
    partial class Patient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label11;
            this.exitBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            label1.Location = new System.Drawing.Point(128, 50);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(181, 36);
            label1.TabIndex = 26;
            label1.Text = "PatientPage";
            // 
            // label6
            // 
            label6.AllowDrop = true;
            label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            label6.Location = new System.Drawing.Point(12, 291);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(117, 28);
            label6.TabIndex = 27;
            label6.Text = "P Address";
            // 
            // label2
            // 
            label2.AllowDrop = true;
            label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            label2.Location = new System.Drawing.Point(12, 181);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(118, 28);
            label2.TabIndex = 28;
            label2.Text = "Patient ID";
            // 
            // label3
            // 
            label3.AllowDrop = true;
            label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            label3.Location = new System.Drawing.Point(12, 240);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(95, 28);
            label3.TabIndex = 29;
            label3.Text = "P Name";
            // 
            // label4
            // 
            label4.AllowDrop = true;
            label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            label4.Location = new System.Drawing.Point(529, 181);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(100, 28);
            label4.TabIndex = 30;
            label4.Text = "P Phone";
            label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            label5.AllowDrop = true;
            label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            label5.Location = new System.Drawing.Point(527, 338);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(91, 28);
            label5.TabIndex = 31;
            label5.Text = "Disease";
            label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            label7.AllowDrop = true;
            label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            label7.Location = new System.Drawing.Point(529, 291);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(141, 28);
            label7.TabIndex = 32;
            label7.Text = "bloodGroup";
            // 
            // label8
            // 
            label8.AllowDrop = true;
            label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            label8.Location = new System.Drawing.Point(12, 338);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(74, 28);
            label8.TabIndex = 33;
            label8.Text = "P Age";
            // 
            // label9
            // 
            label9.AllowDrop = true;
            label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            label9.Location = new System.Drawing.Point(899, 236);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(116, 28);
            label9.TabIndex = 34;
            label9.Text = "Doctor ID";
            // 
            // label11
            // 
            label11.AllowDrop = true;
            label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label11.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            label11.Location = new System.Drawing.Point(529, 239);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(89, 28);
            label11.TabIndex = 36;
            label11.Text = "Gender";
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exitBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(1264, -1);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(50, 45);
            this.exitBtn.TabIndex = 24;
            this.exitBtn.Text = "x";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(195, 180);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 29);
            this.textBox1.TabIndex = 37;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(195, 236);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(146, 29);
            this.textBox2.TabIndex = 38;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(195, 290);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(146, 29);
            this.textBox3.TabIndex = 39;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(195, 338);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(146, 29);
            this.textBox4.TabIndex = 41;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(691, 181);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(127, 29);
            this.textBox5.TabIndex = 42;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "A+",
            "B+",
            "O+",
            "A-",
            "B-",
            "O-",
            "AB+",
            "AB-"});
            this.comboBox2.Location = new System.Drawing.Point(691, 291);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(127, 28);
            this.comboBox2.TabIndex = 43;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox1.Location = new System.Drawing.Point(691, 243);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(127, 28);
            this.comboBox1.TabIndex = 44;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(691, 337);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(127, 29);
            this.textBox6.TabIndex = 45;
            // 
            // addBtn
            // 
            this.addBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(1124, 460);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(142, 45);
            this.addBtn.TabIndex = 47;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 438);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1091, 448);
            this.dataGridView1.TabIndex = 48;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DockChanged += new System.EventHandler(this.dataGridView1_DockChanged);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1124, 631);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 45);
            this.button1.TabIndex = 49;
            this.button1.Text = "DELETE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1124, 715);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 45);
            this.button2.TabIndex = 50;
            this.button2.Text = "RESET";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1124, 543);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 45);
            this.button3.TabIndex = 51;
            this.button3.Text = "UPDATE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1124, 793);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 45);
            this.button4.TabIndex = 52;
            this.button4.Text = "HOME";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::hospital1.Properties.Resources.examination;
            this.pictureBox2.Location = new System.Drawing.Point(0, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(122, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "A+",
            "B+",
            "O+",
            "A-",
            "B-",
            "O-",
            "AB+",
            "AB-"});
            this.comboBox3.Location = new System.Drawing.Point(1073, 236);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(127, 28);
            this.comboBox3.TabIndex = 53;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            this.comboBox3.SelectionChangeCommitted += new System.EventHandler(this.comboBox3_SelectionChangeCommitted);
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1316, 898);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(label11);
            this.Controls.Add(label9);
            this.Controls.Add(label8);
            this.Controls.Add(label7);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label6);
            this.Controls.Add(label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.exitBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Patient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient";
            this.Load += new System.EventHandler(this.Patient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}