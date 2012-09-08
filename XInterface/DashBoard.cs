using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XReactor.XSockets;

namespace XReactor.XInterface
{
    public partial class DashBoard : Form
    {
        public DashBoard(XReactorSockets xrs)
        {
            InitializeComponent();
        }
    }
}
