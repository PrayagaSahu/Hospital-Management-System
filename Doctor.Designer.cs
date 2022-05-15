namespace Hospital
{
    partial class Doctor
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.docname = new System.Windows.Forms.Label();
            this.docexp = new System.Windows.Forms.Label();
            this.docmob = new System.Windows.Forms.Label();
            this.docspe = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtSpe = new System.Windows.Forms.TextBox();
            this.TxtMob = new System.Windows.Forms.TextBox();
            this.TxtExp = new System.Windows.Forms.TextBox();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.docpass = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.docemail = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnUdt = new System.Windows.Forms.Button();
            this.BtnDel = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.hospitalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DoctorView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorView)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1331, 114);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "DOCTOR";
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
            // docname
            // 
            this.docname.AutoSize = true;
            this.docname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docname.Location = new System.Drawing.Point(27, 143);
            this.docname.Name = "docname";
            this.docname.Size = new System.Drawing.Size(184, 29);
            this.docname.TabIndex = 1;
            this.docname.Text = "Doctor\'s Name";
            // 
            // docexp
            // 
            this.docexp.AutoSize = true;
            this.docexp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docexp.Location = new System.Drawing.Point(27, 227);
            this.docexp.Name = "docexp";
            this.docexp.Size = new System.Drawing.Size(153, 29);
            this.docexp.TabIndex = 2;
            this.docexp.Text = "Year Of Exp";
            // 
            // docmob
            // 
            this.docmob.AutoSize = true;
            this.docmob.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docmob.Location = new System.Drawing.Point(27, 277);
            this.docmob.Name = "docmob";
            this.docmob.Size = new System.Drawing.Size(134, 29);
            this.docmob.TabIndex = 3;
            this.docmob.Text = "Mobile No";
            // 
            // docspe
            // 
            this.docspe.AutoSize = true;
            this.docspe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docspe.Location = new System.Drawing.Point(27, 185);
            this.docspe.Name = "docspe";
            this.docspe.Size = new System.Drawing.Size(128, 29);
            this.docspe.TabIndex = 4;
            this.docspe.Text = "Specialist";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(241, 149);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(230, 22);
            this.TxtName.TabIndex = 5;
            // 
            // TxtSpe
            // 
            this.TxtSpe.Location = new System.Drawing.Point(241, 192);
            this.TxtSpe.Name = "TxtSpe";
            this.TxtSpe.Size = new System.Drawing.Size(230, 22);
            this.TxtSpe.TabIndex = 6;
            // 
            // TxtMob
            // 
            this.TxtMob.Location = new System.Drawing.Point(241, 281);
            this.TxtMob.MaxLength = 10;
            this.TxtMob.Name = "TxtMob";
            this.TxtMob.Size = new System.Drawing.Size(230, 22);
            this.TxtMob.TabIndex = 8;
            this.TxtMob.TextChanged += new System.EventHandler(this.TxtMob_TextChanged);
            // 
            // TxtExp
            // 
            this.TxtExp.Location = new System.Drawing.Point(241, 234);
            this.TxtExp.Name = "TxtExp";
            this.TxtExp.Size = new System.Drawing.Size(230, 22);
            this.TxtExp.TabIndex = 7;
            // 
            // TxtPass
            // 
            this.TxtPass.Location = new System.Drawing.Point(241, 376);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(230, 22);
            this.TxtPass.TabIndex = 11;
            // 
            // docpass
            // 
            this.docpass.AutoSize = true;
            this.docpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docpass.Location = new System.Drawing.Point(27, 376);
            this.docpass.Name = "docpass";
            this.docpass.Size = new System.Drawing.Size(128, 29);
            this.docpass.TabIndex = 10;
            this.docpass.Text = "Password";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(241, 326);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(230, 22);
            this.TxtEmail.TabIndex = 13;
            this.TxtEmail.TextChanged += new System.EventHandler(this.TxtEmail_TextChanged);
            // 
            // docemail
            // 
            this.docemail.AutoSize = true;
            this.docemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docemail.Location = new System.Drawing.Point(27, 326);
            this.docemail.Name = "docemail";
            this.docemail.Size = new System.Drawing.Size(108, 29);
            this.docemail.TabIndex = 12;
            this.docemail.Text = "Email Id";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(23, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 52);
            this.button1.TabIndex = 14;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnUdt
            // 
            this.BtnUdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUdt.Location = new System.Drawing.Point(188, 451);
            this.BtnUdt.Name = "BtnUdt";
            this.BtnUdt.Size = new System.Drawing.Size(134, 52);
            this.BtnUdt.TabIndex = 15;
            this.BtnUdt.Text = "Update";
            this.BtnUdt.UseVisualStyleBackColor = true;
            this.BtnUdt.Click += new System.EventHandler(this.BtnUdt_Click_1);
            // 
            // BtnDel
            // 
            this.BtnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDel.Location = new System.Drawing.Point(352, 451);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(136, 52);
            this.BtnDel.TabIndex = 16;
            this.BtnDel.Text = "Delete";
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(129, 532);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(250, 91);
            this.button4.TabIndex = 17;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // DoctorView
            // 
            this.DoctorView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DoctorView.Location = new System.Drawing.Point(499, 143);
            this.DoctorView.Name = "DoctorView";
            this.DoctorView.RowHeadersWidth = 51;
            this.DoctorView.RowTemplate.Height = 24;
            this.DoctorView.Size = new System.Drawing.Size(820, 424);
            this.DoctorView.TabIndex = 18;
            this.DoctorView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DoctorView_CellContentClick_1);
            this.DoctorView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DoctorView_CellDoubleClick);
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 717);
            this.Controls.Add(this.DoctorView);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.BtnUdt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.docemail);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.docpass);
            this.Controls.Add(this.TxtMob);
            this.Controls.Add(this.TxtExp);
            this.Controls.Add(this.TxtSpe);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.docspe);
            this.Controls.Add(this.docmob);
            this.Controls.Add(this.docexp);
            this.Controls.Add(this.docname);
            this.Controls.Add(this.panel1);
            this.Name = "Doctor";
            this.Text = "Doctor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label docname;
        private System.Windows.Forms.Label docexp;
        private System.Windows.Forms.Label docmob;
        private System.Windows.Forms.Label docspe;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtSpe;
        private System.Windows.Forms.TextBox TxtMob;
        private System.Windows.Forms.TextBox TxtExp;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.Label docpass;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label docemail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnUdt;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private System.Windows.Forms.BindingSource hospitalDataSetBindingSource;
        private System.Windows.Forms.DataGridView DoctorView;
    }
}