using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeLineTool {
    public partial class mainForm : Form {
        public mainForm() {
            InitializeComponent();
        }

        private void fileMenu_exit_Click( object sender, EventArgs e ) {
            Environment.Exit(0);
        }

        private void helpMenu_About_Click( object sender, EventArgs e ) {
            //show about window
        }
    }
}
