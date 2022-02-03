using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core;
using DatabaseContext;
using DatabaseModels;
using Microsoft.EntityFrameworkCore;

namespace Presentation
{
    public partial class Form1 : Form
    {
        public DataContext DbContext { get; set; }
        private Facade _actions;

        public Form1()
        {
            InitializeComponent();
            DbContext = new DataContext();
            _actions = new Facade(DbContext);
        }

        private void button_View_Click(object sender, EventArgs e)
        {
            VisualSpec();
            VisualDoctors();
            VisualCertifs();
        }

        #region Visual
        private void VisualSpec()
        {
            dataGridViewSpec.DataSource = _actions.EditsSpec();
            dataGridViewSpec.Columns["Id"].ReadOnly = true;
            dataGridViewSpec.Columns["Doctors"].Visible = false;
            dataGridViewSpec.MultiSelect = true;
        }
        private void VisualDoctors()
        {
            dataGridViewDocs.DataSource = _actions.EditsDocs();
            dataGridViewDocs.Columns["Id"].ReadOnly = true;
            dataGridViewDocs.Columns["Specialization"].Visible = false;
            dataGridViewDocs.Columns["Certificates"].Visible = false;
            dataGridViewDocs.MultiSelect = true;
        }
        private void VisualCertifs()
        {
            dataGridViewCert.DataSource = _actions.EditsCertifs(); 
            dataGridViewCert.Columns["Id"].ReadOnly = true;
            dataGridViewCert.Columns["Doctor"].Visible = false;
            dataGridViewCert.MultiSelect = true;
        }
        #endregion

        #region Add
        private void button_AddSpecialization_Click(object sender, EventArgs e)
        {
            try
            {
                _actions.AddSepcialization(textBox_SpecName.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            _actions.Save();
            VisualSpec();
        }
        private void button_AddCertificate_Click(object sender, EventArgs e)
        {
            try
            {
                _actions.AddCertificate(textBox_CertificateDescription.Text, textBox_CertDoctorName.Text, DateTime.Now);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            _actions.Save();
            VisualCertifs();
        }

        private void button_AddDoctor_Click(object sender, EventArgs e)
        {
            try
            {
                _actions.AddDoctor(textBox_DoctorName.Text, textBox_DoctorSpecialization.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            _actions.Save();
            VisualDoctors();
        }
        #endregion

        #region Delete
        private void button_DeleteDoctor_Click(object sender, EventArgs e)
        {
            int id=0;
            try
            {
                id = Convert.ToInt32(textBox_DoctorId.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Неверное ID");
            }
            try
            {
                _actions.DeleteDoctor(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            _actions.Save();
            VisualDoctors();
        }
        private void button_DeleteSpecialization_Click(object sender, EventArgs e)
        {
            int id = 0;
            try
            {
                id = Convert.ToInt32(textBox_SpecializationId.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Неверное ID");
            }
            try
            {
                _actions.DeleteSpecialization(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            _actions.Save();
            VisualSpec();
        }

        private void button_DeleteCertificate_Click(object sender, EventArgs e)
        {
            int id = 0;
            try
            {
                id = Convert.ToInt32(textBox_CertificateId.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Неверное ID");
            }
            try
            {
                _actions.DeleteCertificate(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            _actions.Save();
            VisualCertifs();
        }

        #endregion
        private void button_SaveSpec_Click(object sender, EventArgs e)
        {
            bool t = true;
            try
            {
                _actions.Save();
            }
            catch (Exception)
            {
                t = false;
                MessageBox.Show("Данные не сохранены");
            }
            if (t)
                MessageBox.Show("Данные сохранены");
        }

        #region Functions
        private void button1_Click(object sender, EventArgs e)
        {
            int id = -1;
            int k = 0;
            try
            {
                id = Convert.ToInt32(textBox_SpecializationId.Text);
                k = _actions.AmountDoctors(id);
            }
            catch(Exception)
            {
                MessageBox.Show("Неверное ID");
            }
            if (id != -1)
                MessageBox.Show($"Кол-во врачей по заданной спецификации = {k}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = -1;
            bool rc = true;
            string k="";
            try
            {
                id = Convert.ToInt32(textBox_CertificateId.Text);
            }
            catch (Exception)
            {
                rc = false;
                MessageBox.Show("Неверное ID");
            }
            if (rc)
            {
                try
                {
                    k = _actions.Specialization(id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    rc = false;
                }
                if (id != -1 && rc)
                    MessageBox.Show($"Название специализации: {k}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            int id = -1;
            bool rc = true;
            try
            {
                id = Convert.ToInt32(textBox_DoctorId.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Неверное ID");
                rc = false;
            }
            if(rc)
            {
                try
                {
                    date = _actions.Certificate(id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    rc = false;
                }
                if (id != -1 && rc)
                    MessageBox.Show(Convert.ToString(date));
            }
        }
        #endregion
    }
}
