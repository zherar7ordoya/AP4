using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Domain.Models;
using Domain.ValueObjects;

namespace Presentation.Forms
{
    public partial class FormEmployee : Form
    {
        private EmployeeModel employee = new EmployeeModel();

        public FormEmployee()
        {
            InitializeComponent();
            pnlPanel.Enabled = false;
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            ListEmployees();
        }

        private void ListEmployees()
        {
            try
            {
                dgvEmployees.DataSource = employee.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tboxSearch_TextChanged(object sender, EventArgs e)
        {
            dgvEmployees.DataSource = employee.FindById(tboxSearch.Text);
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            employee.IdNumber = tboxIdentification.Text;
            employee.Name = tboxName.Text;
            employee.Mail = tboxEmail.Text;
            employee.Birthday = dtpBirthday.Value;

            bool valid = new Helpers.DataValidation(employee).Validate();
            if (valid)
            {
                string result = employee.SaveChanges();
                MessageBox.Show(result);
                ListEmployees();
                Restart();
            }
        }

        private void Restart()
        {
            pnlPanel.Enabled = false;
            tboxIdentification.Clear();
            tboxName.Clear();
            tboxEmail.Clear();
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            pnlPanel.Enabled = true;
            employee.State = EntityState.Added;
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count > 0)
            {
                pnlPanel.Enabled = true;
                employee.State = EntityState.Modified;
                employee.IdPK = Convert.ToInt32(dgvEmployees.CurrentRow.Cells[0].Value);
                tboxIdentification.Text = dgvEmployees.CurrentRow.Cells[1].Value.ToString();
                tboxName.Text = dgvEmployees.CurrentRow.Cells[2].Value.ToString();
                tboxEmail.Text= dgvEmployees.CurrentRow.Cells[3].Value.ToString();
                dtpBirthday.Value = Convert.ToDateTime(dgvEmployees.CurrentRow.Cells[4].Value);
            }
            else
            {
                MessageBox.Show("Select a row.");
            }
        }

        private void cmdRemove_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count > 0)
            {
                employee.State = EntityState.Deleted;
                employee.IdPK = Convert.ToInt32(dgvEmployees.CurrentRow.Cells[0].Value);
                string result = employee.SaveChanges();
                MessageBox.Show(result);
                ListEmployees();
            }
            else
            {
                MessageBox.Show("Select a row.");
            }
        }
    }
}
