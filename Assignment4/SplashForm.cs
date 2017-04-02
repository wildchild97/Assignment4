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
    public partial class SplashForm : Form
    {
        //CONSTRUCTOR++++++++++++++++++++++
        public SplashForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// this method closes the splash form and opens the starform once the timer is up
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            StartForm startForm = new StartForm();
            startForm.previousForm = this;

            //pass a referance to the current form to the next form
            this.SplashFormTimer.Enabled = false;
            startForm.Show();
            this.Hide();
        }
    }
}
