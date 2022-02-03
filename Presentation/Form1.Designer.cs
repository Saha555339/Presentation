namespace Presentation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_View = new System.Windows.Forms.Button();
            this.TabPages = new System.Windows.Forms.TabControl();
            this.Specializations = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_SpecializationId = new System.Windows.Forms.TextBox();
            this.button_DeleteSpecialization = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_SpecName = new System.Windows.Forms.TextBox();
            this.button_AddSpecialization = new System.Windows.Forms.Button();
            this.dataGridViewSpec = new System.Windows.Forms.DataGridView();
            this.Doctors = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_DoctorId = new System.Windows.Forms.TextBox();
            this.button_DeleteDoctor = new System.Windows.Forms.Button();
            this.textBox_DoctorSpecialization = new System.Windows.Forms.TextBox();
            this.textBox_DoctorName = new System.Windows.Forms.TextBox();
            this.button_AddDoctor = new System.Windows.Forms.Button();
            this.dataGridViewDocs = new System.Windows.Forms.DataGridView();
            this.Certificates = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_CertDoctorName = new System.Windows.Forms.TextBox();
            this.textBox_CertificateId = new System.Windows.Forms.TextBox();
            this.textBox_CertificateDescription = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_DeleteCertificate = new System.Windows.Forms.Button();
            this.button_AddCertificate = new System.Windows.Forms.Button();
            this.dataGridViewCert = new System.Windows.Forms.DataGridView();
            this.button_SaveSpec = new System.Windows.Forms.Button();
            this.TabPages.SuspendLayout();
            this.Specializations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpec)).BeginInit();
            this.Doctors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocs)).BeginInit();
            this.Certificates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCert)).BeginInit();
            this.SuspendLayout();
            // 
            // button_View
            // 
            this.button_View.Location = new System.Drawing.Point(12, 523);
            this.button_View.Name = "button_View";
            this.button_View.Size = new System.Drawing.Size(112, 29);
            this.button_View.TabIndex = 0;
            this.button_View.Text = "Отобразить";
            this.button_View.UseVisualStyleBackColor = true;
            this.button_View.Click += new System.EventHandler(this.button_View_Click);
            // 
            // TabPages
            // 
            this.TabPages.Controls.Add(this.Specializations);
            this.TabPages.Controls.Add(this.Doctors);
            this.TabPages.Controls.Add(this.Certificates);
            this.TabPages.Location = new System.Drawing.Point(8, 10);
            this.TabPages.Name = "TabPages";
            this.TabPages.SelectedIndex = 0;
            this.TabPages.Size = new System.Drawing.Size(1135, 488);
            this.TabPages.TabIndex = 1;
            // 
            // Specializations
            // 
            this.Specializations.Controls.Add(this.button1);
            this.Specializations.Controls.Add(this.label2);
            this.Specializations.Controls.Add(this.textBox_SpecializationId);
            this.Specializations.Controls.Add(this.button_DeleteSpecialization);
            this.Specializations.Controls.Add(this.label1);
            this.Specializations.Controls.Add(this.textBox_SpecName);
            this.Specializations.Controls.Add(this.button_AddSpecialization);
            this.Specializations.Controls.Add(this.dataGridViewSpec);
            this.Specializations.Location = new System.Drawing.Point(4, 29);
            this.Specializations.Name = "Specializations";
            this.Specializations.Padding = new System.Windows.Forms.Padding(3);
            this.Specializations.Size = new System.Drawing.Size(1127, 455);
            this.Specializations.TabIndex = 0;
            this.Specializations.Text = "Specializations";
            this.Specializations.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(707, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 49);
            this.button1.TabIndex = 8;
            this.button1.Text = "Вывести\r\nкол-во врачей";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(707, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Id";
            // 
            // textBox_SpecializationId
            // 
            this.textBox_SpecializationId.Location = new System.Drawing.Point(607, 156);
            this.textBox_SpecializationId.Name = "textBox_SpecializationId";
            this.textBox_SpecializationId.Size = new System.Drawing.Size(249, 27);
            this.textBox_SpecializationId.TabIndex = 5;
            // 
            // button_DeleteSpecialization
            // 
            this.button_DeleteSpecialization.Location = new System.Drawing.Point(607, 189);
            this.button_DeleteSpecialization.Name = "button_DeleteSpecialization";
            this.button_DeleteSpecialization.Size = new System.Drawing.Size(94, 49);
            this.button_DeleteSpecialization.TabIndex = 4;
            this.button_DeleteSpecialization.Text = "Удалить";
            this.button_DeleteSpecialization.UseVisualStyleBackColor = true;
            this.button_DeleteSpecialization.Click += new System.EventHandler(this.button_DeleteSpecialization_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(496, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // textBox_SpecName
            // 
            this.textBox_SpecName.Location = new System.Drawing.Point(462, 156);
            this.textBox_SpecName.Name = "textBox_SpecName";
            this.textBox_SpecName.Size = new System.Drawing.Size(125, 27);
            this.textBox_SpecName.TabIndex = 2;
            // 
            // button_AddSpecialization
            // 
            this.button_AddSpecialization.Location = new System.Drawing.Point(476, 189);
            this.button_AddSpecialization.Name = "button_AddSpecialization";
            this.button_AddSpecialization.Size = new System.Drawing.Size(94, 49);
            this.button_AddSpecialization.TabIndex = 1;
            this.button_AddSpecialization.Text = "Добавить";
            this.button_AddSpecialization.UseVisualStyleBackColor = true;
            this.button_AddSpecialization.Click += new System.EventHandler(this.button_AddSpecialization_Click);
            // 
            // dataGridViewSpec
            // 
            this.dataGridViewSpec.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.dataGridViewSpec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSpec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSpec.Location = new System.Drawing.Point(21, 38);
            this.dataGridViewSpec.Name = "dataGridViewSpec";
            this.dataGridViewSpec.RowHeadersWidth = 51;
            this.dataGridViewSpec.RowTemplate.Height = 29;
            this.dataGridViewSpec.Size = new System.Drawing.Size(276, 184);
            this.dataGridViewSpec.TabIndex = 0;
            // 
            // Doctors
            // 
            this.Doctors.Controls.Add(this.button3);
            this.Doctors.Controls.Add(this.label5);
            this.Doctors.Controls.Add(this.label4);
            this.Doctors.Controls.Add(this.label3);
            this.Doctors.Controls.Add(this.textBox_DoctorId);
            this.Doctors.Controls.Add(this.button_DeleteDoctor);
            this.Doctors.Controls.Add(this.textBox_DoctorSpecialization);
            this.Doctors.Controls.Add(this.textBox_DoctorName);
            this.Doctors.Controls.Add(this.button_AddDoctor);
            this.Doctors.Controls.Add(this.dataGridViewDocs);
            this.Doctors.Location = new System.Drawing.Point(4, 29);
            this.Doctors.Name = "Doctors";
            this.Doctors.Padding = new System.Windows.Forms.Padding(3);
            this.Doctors.Size = new System.Drawing.Size(1127, 455);
            this.Doctors.TabIndex = 1;
            this.Doctors.Text = "Doctors";
            this.Doctors.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(263, 346);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 55);
            this.button3.TabIndex = 9;
            this.button3.Text = "Дата последнего\r\nсертификата";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(787, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Specialization";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(687, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Id";
            // 
            // textBox_DoctorId
            // 
            this.textBox_DoctorId.Location = new System.Drawing.Point(163, 313);
            this.textBox_DoctorId.Name = "textBox_DoctorId";
            this.textBox_DoctorId.Size = new System.Drawing.Size(257, 27);
            this.textBox_DoctorId.TabIndex = 5;
            // 
            // button_DeleteDoctor
            // 
            this.button_DeleteDoctor.Location = new System.Drawing.Point(163, 346);
            this.button_DeleteDoctor.Name = "button_DeleteDoctor";
            this.button_DeleteDoctor.Size = new System.Drawing.Size(94, 55);
            this.button_DeleteDoctor.TabIndex = 4;
            this.button_DeleteDoctor.Text = "Удалить";
            this.button_DeleteDoctor.UseVisualStyleBackColor = true;
            this.button_DeleteDoctor.Click += new System.EventHandler(this.button_DeleteDoctor_Click);
            // 
            // textBox_DoctorSpecialization
            // 
            this.textBox_DoctorSpecialization.Location = new System.Drawing.Point(776, 174);
            this.textBox_DoctorSpecialization.Name = "textBox_DoctorSpecialization";
            this.textBox_DoctorSpecialization.Size = new System.Drawing.Size(125, 27);
            this.textBox_DoctorSpecialization.TabIndex = 3;
            // 
            // textBox_DoctorName
            // 
            this.textBox_DoctorName.Location = new System.Drawing.Point(645, 175);
            this.textBox_DoctorName.Name = "textBox_DoctorName";
            this.textBox_DoctorName.Size = new System.Drawing.Size(125, 27);
            this.textBox_DoctorName.TabIndex = 2;
            // 
            // button_AddDoctor
            // 
            this.button_AddDoctor.Location = new System.Drawing.Point(716, 207);
            this.button_AddDoctor.Name = "button_AddDoctor";
            this.button_AddDoctor.Size = new System.Drawing.Size(94, 29);
            this.button_AddDoctor.TabIndex = 1;
            this.button_AddDoctor.Text = "Добавить";
            this.button_AddDoctor.UseVisualStyleBackColor = true;
            this.button_AddDoctor.Click += new System.EventHandler(this.button_AddDoctor_Click);
            // 
            // dataGridViewDocs
            // 
            this.dataGridViewDocs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDocs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDocs.Location = new System.Drawing.Point(41, 48);
            this.dataGridViewDocs.Name = "dataGridViewDocs";
            this.dataGridViewDocs.RowHeadersWidth = 51;
            this.dataGridViewDocs.RowTemplate.Height = 29;
            this.dataGridViewDocs.Size = new System.Drawing.Size(504, 188);
            this.dataGridViewDocs.TabIndex = 0;
            // 
            // Certificates
            // 
            this.Certificates.Controls.Add(this.button2);
            this.Certificates.Controls.Add(this.textBox_CertDoctorName);
            this.Certificates.Controls.Add(this.textBox_CertificateId);
            this.Certificates.Controls.Add(this.textBox_CertificateDescription);
            this.Certificates.Controls.Add(this.label9);
            this.Certificates.Controls.Add(this.label8);
            this.Certificates.Controls.Add(this.label6);
            this.Certificates.Controls.Add(this.button_DeleteCertificate);
            this.Certificates.Controls.Add(this.button_AddCertificate);
            this.Certificates.Controls.Add(this.dataGridViewCert);
            this.Certificates.Location = new System.Drawing.Point(4, 29);
            this.Certificates.Name = "Certificates";
            this.Certificates.Padding = new System.Windows.Forms.Padding(3);
            this.Certificates.Size = new System.Drawing.Size(1127, 455);
            this.Certificates.TabIndex = 2;
            this.Certificates.Text = "Certificates";
            this.Certificates.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(317, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 52);
            this.button2.TabIndex = 10;
            this.button2.Text = "название\r\nспециализации";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_CertDoctorName
            // 
            this.textBox_CertDoctorName.Location = new System.Drawing.Point(829, 163);
            this.textBox_CertDoctorName.Name = "textBox_CertDoctorName";
            this.textBox_CertDoctorName.Size = new System.Drawing.Size(125, 27);
            this.textBox_CertDoctorName.TabIndex = 9;
            // 
            // textBox_CertificateId
            // 
            this.textBox_CertificateId.Location = new System.Drawing.Point(217, 311);
            this.textBox_CertificateId.Name = "textBox_CertificateId";
            this.textBox_CertificateId.Size = new System.Drawing.Size(260, 27);
            this.textBox_CertificateId.TabIndex = 8;
            // 
            // textBox_CertificateDescription
            // 
            this.textBox_CertificateDescription.Location = new System.Drawing.Point(698, 163);
            this.textBox_CertificateDescription.Name = "textBox_CertificateDescription";
            this.textBox_CertificateDescription.Size = new System.Drawing.Size(125, 27);
            this.textBox_CertificateDescription.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(840, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Doctor\'s Id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(719, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Id";
            // 
            // button_DeleteCertificate
            // 
            this.button_DeleteCertificate.Location = new System.Drawing.Point(217, 344);
            this.button_DeleteCertificate.Name = "button_DeleteCertificate";
            this.button_DeleteCertificate.Size = new System.Drawing.Size(94, 52);
            this.button_DeleteCertificate.TabIndex = 2;
            this.button_DeleteCertificate.Text = "Удалить";
            this.button_DeleteCertificate.UseVisualStyleBackColor = true;
            this.button_DeleteCertificate.Click += new System.EventHandler(this.button_DeleteCertificate_Click);
            // 
            // button_AddCertificate
            // 
            this.button_AddCertificate.Location = new System.Drawing.Point(774, 201);
            this.button_AddCertificate.Name = "button_AddCertificate";
            this.button_AddCertificate.Size = new System.Drawing.Size(94, 29);
            this.button_AddCertificate.TabIndex = 1;
            this.button_AddCertificate.Text = "Добавить";
            this.button_AddCertificate.UseVisualStyleBackColor = true;
            this.button_AddCertificate.Click += new System.EventHandler(this.button_AddCertificate_Click);
            // 
            // dataGridViewCert
            // 
            this.dataGridViewCert.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCert.Location = new System.Drawing.Point(36, 42);
            this.dataGridViewCert.Name = "dataGridViewCert";
            this.dataGridViewCert.RowHeadersWidth = 51;
            this.dataGridViewCert.RowTemplate.Height = 29;
            this.dataGridViewCert.Size = new System.Drawing.Size(514, 188);
            this.dataGridViewCert.TabIndex = 0;
            // 
            // button_SaveSpec
            // 
            this.button_SaveSpec.Location = new System.Drawing.Point(166, 523);
            this.button_SaveSpec.Name = "button_SaveSpec";
            this.button_SaveSpec.Size = new System.Drawing.Size(143, 33);
            this.button_SaveSpec.TabIndex = 7;
            this.button_SaveSpec.Text = "Сохранить";
            this.button_SaveSpec.UseVisualStyleBackColor = true;
            this.button_SaveSpec.Click += new System.EventHandler(this.button_SaveSpec_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 620);
            this.Controls.Add(this.button_View);
            this.Controls.Add(this.button_SaveSpec);
            this.Controls.Add(this.TabPages);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TabPages.ResumeLayout(false);
            this.Specializations.ResumeLayout(false);
            this.Specializations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpec)).EndInit();
            this.Doctors.ResumeLayout(false);
            this.Doctors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocs)).EndInit();
            this.Certificates.ResumeLayout(false);
            this.Certificates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCert)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_View;
        private System.Windows.Forms.TabControl TabPages;
        private System.Windows.Forms.TabPage Specializations;
        private System.Windows.Forms.TabPage Doctors;
        private System.Windows.Forms.TabPage Certificates;
        private System.Windows.Forms.DataGridView dataGridViewSpec;
        private System.Windows.Forms.DataGridView dataGridViewDocs;
        private System.Windows.Forms.DataGridView dataGridViewCert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_SpecializationId;
        private System.Windows.Forms.Button button_DeleteSpecialization;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_SpecName;
        private System.Windows.Forms.Button button_AddSpecialization;
        private System.Windows.Forms.TextBox textBox_DoctorSpecialization;
        private System.Windows.Forms.TextBox textBox_DoctorName;
        private System.Windows.Forms.Button button_AddDoctor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_DoctorId;
        private System.Windows.Forms.Button button_DeleteDoctor;
        private System.Windows.Forms.TextBox textBox_CertDoctorName;
        private System.Windows.Forms.TextBox textBox_CertificateId;
        private System.Windows.Forms.TextBox textBox_CertificateDescription;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_DeleteCertificate;
        private System.Windows.Forms.Button button_AddCertificate;
        private System.Windows.Forms.Button button_SaveSpec;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
