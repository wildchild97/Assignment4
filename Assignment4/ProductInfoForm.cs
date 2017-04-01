using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// App name: Dollar Computers
// Author's name: Caitlin Foster	        Student	ID: 200311158
// App Creation	Date: March 12th 2017  
// App description: This application allows a user to select a computer, be notifed of it's specifications, price and be able to purchase said computer. Or save the order for a later time. 

namespace Assignment4
{
    public partial class ProductInfoForm : Form
    {
        public StartForm previousForm;

        //PRIVTAE INSTANCE VARIABLES
        private StreamReader _reader;

        public ProductInfoForm()
        {
            InitializeComponent();
        }

        ////PRIVATE METHODS++++++++++++++++++++

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _nextButton_Click(object sender, EventArgs e)
        {
            // Instantiate the next form
            OrderForm orderForm = new OrderForm();

            // pass a reference from the current form to the next form
            orderForm.previousForm = this;

            orderForm.Show();
            this.Hide();
        }

        private void _openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string filename;

            OpenComputerFileDialog.Filter = "Text Files (*.txt)|*.txt*";
            OpenComputerFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            result = OpenComputerFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                filename = OpenComputerFileDialog.FileName;

                try
                {
                    this._reader = new StreamReader(filename);

                    // check if we haven't arrived at end of file 
                    if (this._reader.Peek() != -1)
                    {


                    }
                    else
                    {
                        MessageBox.Show("File Empty - No data to Read", "Error Reading File",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    this._reader.Close();
                }
                catch (Exception exception)
                {

                    Debug.WriteLine(exception.Message);
                    MessageBox.Show("Error  Reading File", "File Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
