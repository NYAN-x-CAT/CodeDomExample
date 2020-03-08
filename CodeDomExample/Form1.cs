using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CodeDomExample
{

    /*
     * │ Author       : NYAN CAT
     * │ Name         : Desktop Grabber v0.1
     * │ Contact      : https:github.com/NYAN-x-CAT
     * 
     * This program is distributed for educational purposes only.
     */

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnBuild_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtCountry.Text))
            {
                MessageBox.Show("All fields are required", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            else
            {
                // ..\Resources\Source.cs
                string source = Properties.Resources.Source;

                // replace values
                source = source.Replace("#name", txtName.Text); // search and replace a string "#name" from Resources/Source.cs
                source = source.Replace("#country", txtCountry.Text);

                using (SaveFileDialog saveFile = new SaveFileDialog())
                {
                    saveFile.Filter = "Executable (*.exe)|*.exe";
                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        new Compiler(source, saveFile.FileName);
                    }
                }
            }
        }
    }
}
