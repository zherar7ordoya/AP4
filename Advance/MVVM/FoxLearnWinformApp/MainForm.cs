using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoxLearnWinformApp
{
    public partial class MainForm : Form
    {
        private CustomerViewModel vm;

        public MainForm()
        {
            InitializeComponent();
            vm = new CustomerViewModel();
            vm.CustomerBindingSource = customerBindingSource;
            this.Load += delegate { vm.Load(); };
            btnDelete.Click += delegate { vm.Delete(); };
            btnNew.Click += delegate { vm.New(); };
            btnSave.Click+=delegate { vm.Save(); };
            this.FormClosing += delegate { vm.Dispose(); };
        }
    }
}
