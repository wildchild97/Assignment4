using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class SelectForm : Form
    {
        public StartForm previousForm;

        //PRIVTAE INSTANCE VARIABLES

        //CONSTRUCTOR++++++++++++++++++++++
        public SelectForm()
        {
            InitializeComponent();
        }

        ////PRIVATE METHODS++++++++++++++++++++

        /// <summary>
        /// this method closes the program when the cancel button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// when the next button is pressed the select form is hidden and the productinfo form is opened
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _nextButton_Click(object sender, EventArgs e)
        {
            // Instantiate the next form
            ProductInfoForm productInfoForm = new ProductInfoForm();

            // pass a reference from the current form to the next form
            productInfoForm.previousForm = this;

            productInfoForm.Show();
            this.Hide();
        }
    }
}
