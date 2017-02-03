using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FileDetective
{
    public partial class advanced : Form
    {
        public advanced()
        {
            InitializeComponent();
        }

        private void advanced_Load(object sender, EventArgs e)
        {
            _tbextension.Enabled = false;
            _tbfileName.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            _tbfileName.Text = "";
            _tbfileName.Enabled = false;
            _tbextension.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            _tbextension.Text = "";
            _tbextension.Enabled = false;
            _tbfileName.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selection = "";
            if (_tbfileName.Text != "")
                selection = _tbfileName.Text.Trim();

            else if (_tbextension.Text != "")
                selection = _tbextension.Text.Trim();

            else
                MessageBox.Show("Please enter file extension or file name to search", "FileDetective");

            Form1 obj = new Form1();
            obj.getFromAdvanceForm(selection);
            if(selection != "")
            this.Close();
        }
    }
}
