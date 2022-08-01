using System;
using static System.Environment;
using System.Windows.Forms;
using static System.Windows.Forms.Application;

namespace UIL
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {
            BLL.Employee BllEmployee = new BLL.Employee(new DAL.Employee());
            BEL.Employee BelEmployee = BllEmployee.GetEmployeeDetails(1);

            textBox1.Text =
                $"        ID: {BelEmployee.ID}" + NewLine +
                $"      Name: {BelEmployee.Name}" + NewLine +
                $"Department: {BelEmployee.Department}" + NewLine +
                $"    Salary: " + string.Format($"{BelEmployee.Salary:C}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Exit();
        }
    }
}
