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
        public SelectForm previousForm;

        //PRIVTAE INSTANCE VARIABLES
        private StreamReader _reader;
        private StreamWriter _writer;
        private const char _DELIMETER = ',';
        private Computer _computer;

        //CONSTRUCTOR++++++++++++++++++++++
        public ProductInfoForm()
        {
            InitializeComponent();
            loadTextBoxes();
        }

        /// <summary>
        /// this method loads the product data into the textboxes
        /// </summary>
        private void loadTextBoxes()
        {
            ProductIDTextBox.Text = Convert.ToString(this._computer.ProductId);
            ConditionTextBox.Text = this._computer.Condition;
            CostTextBox.Text = Convert.ToString(this._computer.Cost);
            PlatformTextBox.Text = this._computer.Platform;
            OSTextBox.Text = this._computer.OS;
            ManufacturerTextBox.Text = this._computer.Manufacturer;
            ModelTextBox.Text = this._computer.Model;
            MemoryTextBox.Text = this._computer.Ram;
            CPUBrandTextBox.Text = this._computer.CPUBrand;
            CPUTypeTextBox.Text = this._computer.CPUType;
            LCDTextBox.Text = this._computer.ScreenSize;
            GPUTypeTextBox.Text = this._computer.GPUType;
            CPUNumberTextBox.Text = this._computer.CPUNumber;
            CPUSpeedTextBox.Text = this._computer.CPUSpeed;
            HDDTextBox.Text = this._computer.HDDSize;
            WebCamTextBox.Text = this._computer.Webcam;
        }
        ////PRIVATE METHODS++++++++++++++++++++

        /// <summary>
        /// this method closes the program when the cancel button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// this method opens the order form and hides this form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _nextButton_Click(object sender, EventArgs e)
        {
            // Instantiate the next form
            OrderForm orderForm = new OrderForm();

            // pass a reference from the current form to the next form
            orderForm.previousForm = this;

            orderForm.Show();
            this.Hide();
        }

        /// <summary>
        /// this method allows the user to open a previously saved order file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

                string ComputerInfoString = "";

                try
                {
                    this._reader = new StreamReader(filename);

                    // check if we haven't arrived at end of file 
                    if (this._reader.Peek() != -1)
                    {
                        ComputerInfoString = this._reader.ReadLine();

                        this._computer.ProductId = int.Parse(ComputerInfoString.Split(_DELIMETER)[0]); 
                        this._computer.Condition = ComputerInfoString.Split(_DELIMETER)[1];
                        this._computer.Cost = double.Parse(ComputerInfoString.Split(_DELIMETER)[3]);
                        this._computer.Platform = ComputerInfoString.Split(_DELIMETER)[4];
                        this._computer.OS = ComputerInfoString.Split(_DELIMETER)[5];
                        this._computer.Manufacturer = ComputerInfoString.Split(_DELIMETER)[6];
                        this._computer.Model = ComputerInfoString.Split(_DELIMETER)[7];
                        this._computer.Ram = ComputerInfoString.Split(_DELIMETER)[8];
                        this._computer.CPUBrand = ComputerInfoString.Split(_DELIMETER)[9];
                        this._computer.CPUType = ComputerInfoString.Split(_DELIMETER)[10];
                        this._computer.ScreenSize = ComputerInfoString.Split(_DELIMETER)[11];
                        this._computer.GPUType = ComputerInfoString.Split(_DELIMETER)[12];
                        this._computer.CPUNumber = ComputerInfoString.Split(_DELIMETER)[13];
                        this._computer.CPUSpeed = ComputerInfoString.Split(_DELIMETER)[14];
                        this._computer.HDDSize = ComputerInfoString.Split(_DELIMETER)[15];
                        this._computer.Webcam = ComputerInfoString.Split(_DELIMETER)[16];

                        ProductIDTextBox.Text = Convert.ToString(this._computer.ProductId);
                        ConditionTextBox.Text = this._computer.Condition;
                        CostTextBox.Text = Convert.ToString(this._computer.Cost);
                        PlatformTextBox.Text = this._computer.Platform;
                        OSTextBox.Text = this._computer.OS;
                        ManufacturerTextBox.Text = this._computer.Manufacturer;
                        ModelTextBox.Text = this._computer.Model;
                        MemoryTextBox.Text = this._computer.Ram;
                        CPUBrandTextBox.Text = this._computer.CPUBrand;
                        CPUTypeTextBox.Text = this._computer.CPUType;
                        LCDTextBox.Text = this._computer.ScreenSize;
                        GPUTypeTextBox.Text = this._computer.GPUType;
                        CPUNumberTextBox.Text = this._computer.CPUNumber;
                        CPUSpeedTextBox.Text = this._computer.CPUSpeed;
                        HDDTextBox.Text = this._computer.HDDSize;
                        WebCamTextBox.Text = this._computer.Webcam;
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
        /// this method opens the previous select form and hides this form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _productButton_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Hide();
        }

        /// <summary>
        /// this method saves the users order into a txt file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string filename;

            SaveComputerFileDialog.Filter = "Text Files (*.txt)|*.txt*";
            SaveComputerFileDialog.FileName = "computer.txt";
            SaveComputerFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            result = SaveComputerFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {

                filename = SaveComputerFileDialog.FileName;

                try
                {
                    this._writer = new StreamWriter(filename, true);

                    this._writer.Write(ProductIDTextBox.Text);
                    this._writer.Write(_DELIMETER);

                    this._writer.WriteLine(ConditionTextBox.Text);
                    this._writer.Write(_DELIMETER);

                    this._writer.Write(CostTextBox.Text);
                    this._writer.Write(_DELIMETER);

                    this._writer.WriteLine(PlatformTextBox.Text);
                    this._writer.Write(_DELIMETER);

                    this._writer.Write(OSTextBox.Text);
                    this._writer.Write(_DELIMETER);

                    this._writer.WriteLine(ManufacturerTextBox.Text);
                    this._writer.Write(_DELIMETER);

                    this._writer.Write(ModelTextBox.Text);
                    this._writer.Write(_DELIMETER);

                    this._writer.WriteLine(MemoryTextBox.Text);
                    this._writer.Write(_DELIMETER);

                    this._writer.Write(CPUBrandTextBox.Text);
                    this._writer.Write(_DELIMETER);

                    this._writer.WriteLine(CPUTypeTextBox.Text);
                    this._writer.Write(_DELIMETER);

                    this._writer.Write(LCDTextBox.Text);
                    this._writer.Write(_DELIMETER);

                    this._writer.WriteLine(GPUTypeTextBox.Text);
                    this._writer.Write(_DELIMETER);

                    this._writer.Write(CPUNumberTextBox.Text);
                    this._writer.Write(_DELIMETER);

                    this._writer.WriteLine(CPUSpeedTextBox.Text);
                    this._writer.Write(_DELIMETER);

                    this._writer.Write(HDDTextBox.Text);
                    this._writer.Write(_DELIMETER);

                    this._writer.WriteLine(WebCamTextBox.Text);

                    this._writer.Close(); // flushes the buffer and writes to the file

                    MessageBox.Show("File Written Successfully", "File Status",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exception)
                {

                    Debug.WriteLine(exception.Message);
                    MessageBox.Show("Error  Writing File", "File Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
