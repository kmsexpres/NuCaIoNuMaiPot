using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NuCaIoMaSinucid.UI
{
    public partial class ErrorScreen : Form
    {
        public ErrorScreen()
        {
            InitializeComponent();
        }

        public ErrorScreen(string errorMessage) : this()
        {
            this.boxErrorMEssage.Text = errorMessage;
        }
    }
}
