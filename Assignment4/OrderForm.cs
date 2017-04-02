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
    public partial class OrderForm : Form
    {
        public ProductInfoForm previousForm;

        //PRIVTAE INSTANCE VARIABLES

        //CONSTRUCTOR++++++++++++++++++++++
        public OrderForm()
        {
            InitializeComponent();
        }

        ////PRIVATE METHODS++++++++++++++++++++

        /// <summary>
        /// when the exit button is pressed the program will close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// this method shows the user an about box about the program 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create and open a new aboutbox
            AboutBox aboutbox = new AboutBox();
            aboutbox.Show();
        }

        /// <summary>
        /// this method shows the user a message that their order is printing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Order is now Printing.");
            
        }

        /// <summary>
        /// this method allows the user to go back to the previous form with their previously selected item loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _back_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// when the user presses the finish button a message will display thanking them for their business.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _finishButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank  you  for  your  Business!\nYour  Order  should  arrive  in  7 - 10  business  days 	");
        }
    }
}
