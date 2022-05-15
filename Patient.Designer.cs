namespace Hospital
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnPatHome = new System.Windows.Forms.Button();
            this.BtnPatDel = new System.Windows.Forms.Button();
            this.BtnPatUdt = new System.Windows.Forms.Button();
            this.BtnPatAdd = new System.Windows.Forms.Button();
            this.PAtDis = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PatMob = new System.Windows.Forms.TextBox();
            this.PatAge = new System.Windows.Forms.TextBox();
            this.PAtAddr = new System.Windows.Forms.TextBox();
            this.PatName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PAtSex = new System.Windows.Forms.ComboBox();
            this.PatBG = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1288, 114);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "PATIENT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(594, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOSPITAL MANAGEMENT SYSTEM";
            // 
            // BtnPatHome
            // 
            this.BtnPatHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPatHome.Location = new System.Drawing.Point(137, 598);
            this.BtnPatHome.Name = "BtnPatHome";
            this.BtnPatHome.Size = new System.Drawing.Size(250, 91);
            this.BtnPatHome.TabIndex = 33;
            this.BtnPatHome.Text = "Home";
            this.BtnPatHome.UseVisualStyleBackColor = true;
            this.BtnPatHome.Click += new System.EventHandler(this.button4_Click);
            // 
            // BtnPatDel
            // 
            this.BtnPatDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPatDel.Location = new System.Drawing.Point(360, 517);
            this.BtnPatDel.Name = "BtnPatDel";
            this.BtnPatDel.Size = new System.Drawing.Size(136, 52);
            this.BtnPatDel.TabIndex = 32;
            this.BtnPatDel.Text = "Delete";
            this.BtnPatDel.UseVisualStyleBackColor = true;
            this.BtnPatDel.Click += new System.EventHandler(this.BtnPatDel_Click);
            // 
            // BtnPatUdt
            // 
            this.BtnPatUdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPatUdt.Location = new System.Drawing.Point(196, 517);
            this.BtnPatUdt.Name = "BtnPatUdt";
            this.BtnPatUdt.Size = new System.Drawing.Size(134, 52);
            this.BtnPatUdt.TabIndex = 31;
            this.BtnPatUdt.Text = "Update";
            this.BtnPatUdt.UseVisualStyleBackColor = true;
            this.BtnPatUdt.Click += new System.EventHandler(this.BtnPatUdt_Click);
            // 
            // BtnPatAdd
            // 
            this.BtnPatAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPatAdd.Location = new System.Drawing.Point(31, 517);
            this.BtnPatAdd.Name = "BtnPatAdd";
            this.BtnPatAdd.Size = new System.Drawing.Size(138, 52);
            this.BtnPatAdd.TabIndex = 30;
            this.BtnPatAdd.Text = "Add";
            this.BtnPatAdd.UseVisualStyleBackColor = true;
            this.BtnPatAdd.Click += new System.EventHandler(this.BtnPatAdd_Click);
            // 
            // PAtDis
            // 
            this.PAtDis.Location = new System.Drawing.Point(240, 428);
            this.PAtDis.Name = "PAtDis";
            this.PAtDis.Size = new System.Drawing.Size(230, 22);
            this.PAtDis.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 428);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 29);
            this.label8.TabIndex = 28;
            this.label8.Text = "Disease";
            // 
            // PatMob
            // 
            this.PatMob.Location = new System.Drawing.Point(240, 379);
            this.PatMob.MaxLength = 10;
            this.PatMob.Name = "PatMob";
            this.PatMob.Size = new System.Drawing.Size(230, 22);
            this.PatMob.TabIndex = 25;
            this.PatMob.TextChanged += new System.EventHandler(this.PatMob_TextChanged);
            // 
            // PatAge
            // 
            this.PatAge.Location = new System.Drawing.Point(240, 228);
            this.PatAge.Name = "PatAge";
            this.PatAge.Size = new System.Drawing.Size(230, 22);
            this.PatAge.TabIndex = 24;
            // 
            // PAtAddr
            // 
            this.PAtAddr.Location = new System.Drawing.Point(240, 186);
            this.PAtAddr.Name = "PAtAddr";
            this.PAtAddr.Size = new System.Drawing.Size(230, 22);
            this.PAtAddr.TabIndex = 23;
            // 
            // PatName
            // 
            this.PatName.Location = new System.Drawing.Point(240, 143);
            this.PatName.Name = "PatName";
            this.PatName.Size = new System.Drawing.Size(230, 22);
            this.PatName.TabIndex = 22;
            this.PatName.TextChanged += new System.EventHandler(this.PatName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 29);
            this.label6.TabIndex = 21;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 29);
            this.label5.TabIndex = 20;
            this.label5.Text = "Mobile No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 29);
            this.label4.TabIndex = 19;
            this.label4.Text = "Age";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "Patient\'s Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 29);
            this.label7.TabIndex = 34;
            this.label7.Text = "Gender";
            // 
            // PAtSex
            // 
            this.PAtSex.FormattingEnabled = true;
            this.PAtSex.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Transgender"});
            this.PAtSex.Location = new System.Drawing.Point(240, 271);
            this.PAtSex.Name = "PAtSex";
            this.PAtSex.Size = new System.Drawing.Size(230, 24);
            this.PAtSex.TabIndex = 35;
            // 
            // PatBG
            // 
            this.PatBG.FormattingEnabled = true;
            this.PatBG.Items.AddRange(new object[] {
            "A(+ve)",
            "A(-ve)",
            "B(+ve)",
            "B(-ve)",
            "AB(+ve)",
            "AB(-ve)",
            "O(+ve)",
            "O(-ve)"});
            this.PatBG.Location = new System.Drawing.Point(240, 330);
            this.PatBG.Name = "PatBG";
            this.PatBG.Size = new System.Drawing.Size(230, 24);
            this.PatBG.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 29);
            this.label9.TabIndex = 36;
            this.label9.Text = "Blood Group";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(517, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(759, 473);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 709);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PatBG);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PAtSex);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnPatHome);
            this.Controls.Add(this.BtnPatDel);
            this.Controls.Add(this.BtnPatUdt);
            this.Controls.Add(this.BtnPatAdd);
            this.Controls.Add(this.PAtDis);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PatMob);
            this.Controls.Add(this.PatAge);
            this.Controls.Add(this.PAtAddr);
            this.Controls.Add(this.PatName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "Patient";
            this.Text = "Patient";
            this.Load += new System.EventHandler(this.Patient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnPatHome;
        private System.Windows.Forms.Button BtnPatDel;
        private System.Windows.Forms.Button BtnPatUdt;
        private System.Windows.Forms.Button BtnPatAdd;
        private System.Windows.Forms.TextBox PAtDis;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PatMob;
        private System.Windows.Forms.TextBox PatAge;
        private System.Windows.Forms.TextBox PAtAddr;
        private System.Windows.Forms.TextBox PatName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox PAtSex;
        private System.Windows.Forms.ComboBox PatBG;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}