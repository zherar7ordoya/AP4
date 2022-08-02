using BEL;
using BLL;
using DAL;
using System;
using static System.Environment;
using System.Windows.Forms;
using static System.Windows.Forms.Application;

namespace UIL
{
    // EmployeeService class.
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {
            // Todo: aquí hay un NEW.
            BllEmployee bllEmployee = new BllEmployee(new DalEmployee());
            BelEmployee belEmployee = bllEmployee.GetEmployeeDetails(1);

            textBox1.Text =
                $"        ID: {belEmployee.ID}" + NewLine +
                $"      Name: {belEmployee.Name}" + NewLine +
                $"Department: {belEmployee.Department}" + NewLine +
                $"    Salary: " + string.Format($"{belEmployee.Salary:C}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Exit();
        }
    }
}
