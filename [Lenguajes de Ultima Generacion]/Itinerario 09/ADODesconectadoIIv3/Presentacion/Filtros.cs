using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//libreria para que tome el Process
using System.Diagnostics;

namespace Presentacion
{
    public partial class Filtros : Form
    {
        public Filtros()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void Filtros_Load(object sender, EventArgs e)
        {
            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "https://www.csharp-examples.net/dataview-rowfilter/";
            linkLabel1.Links.Add(link);
        }
    }
}
