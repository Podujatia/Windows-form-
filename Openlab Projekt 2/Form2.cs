using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace Openlab_Projekt_2
{
    public partial class Form2 : Form
    {
        public Form2(string mesto, string typ,string den1,string mesiac1,string rok1, string den2, string mesiac2, string rok2)
        {
            InitializeComponent();
            label1.Text = mesto+ typ + den1 + mesiac1 + rok1 +den2 + mesiac2 +rok2;
        }

        
    }
}
