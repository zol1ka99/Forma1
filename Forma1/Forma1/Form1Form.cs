using Forma1projekt.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forma1projekt
{
    public partial class Form1Form : Form
    {
        F1Controller f1c;
        public Form1Form()
        {
            InitializeComponent();
            f1c = new F1Controller();
        }

        
    }
}
