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
    public partial class StartForm : Form
    {
        public SplashForm previousForm;

        //PRIVTAE INSTANCE VARIABLES
        private StreamReader _reader;

        //CONSTRUCTOR++++++++++++++++++++++
        public StartForm()
        {
            InitializeComponent();
        }

        ////PRIVATE METHODS++++++++++++++++++++

        /// <summary>
        /// This method allows a user to choose a previously saved order file, and open it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _loadOrderButton_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string filename;

            OpenOrderFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            OpenOrderFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            result = OpenOrderFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                filename = OpenOrderFileDialog.FileName;

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

        /// <summary>
        /// When exit button is clicked the program will close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// when new order button is clicked this form will close and the select form will open
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _newOrderButton_Click(object sender, EventArgs e)
        {
            // Instantiate the next form
            SelectForm selectForm = new SelectForm();

            // pass a reference from the current form to the next form
            selectForm.previousForm = this;

            selectForm.Show();
            this.Hide();
        }
    }
}
