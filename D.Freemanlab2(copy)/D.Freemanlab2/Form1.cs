using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D.Freemanlab2
{
    /*Daemon Freeman
     * Sept. 30, 2023
     * This program takes 2 numbers and displays the sum and product of them.
     * This program also displays a picture of me and some brief information about myself.
     * When you click on the image of me, it displays a messagebox detailing what the picture is of.*/
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            //This closes the form.
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            picMe.Visible = true; 
            //This displays a picture. 
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            picMe.Visible=false;
            lblInfo.Hide();
            //This hides picture and info label.
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBox1.Clear();
            txtBox2.Clear();
            lblSum.ResetText();
            lblProduct.ResetText();
            txtBox1.Select();
            /*This clears txtBox1, txtBox2
             * lblSum and lblProduct.
             * Also moves cursor to txtBox1.*/
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            lblInfo.Visible = true;
            lblInfo.Text = "My name is Daemon Freeman." + "\n" +
                "\n I am 26, I recently got married on August 19th, 2023. My wifes name is Alicia." + "\n" +
                "\n I enjoy working out, playing video games and golfing.";
            /*This makes the lblInfo visible
             * and displays the text for lblInfo.*/
        }

        private void picMe_Click(object sender, EventArgs e)
        {
            string message = "Me with my groomsmen on the day of my wedding!";
            string title = "Daemon Freeman";
            MessageBox.Show(message, title);
            /*Displays a message box after
             *clicking on the image.*/
        }

        private void btnMath_Click(object sender, EventArgs e)
        {
            int number1;
            int number2;
            int sum;
            int product;
            number1 = Convert.ToInt32(txtBox1.Text);
            number2 = Convert.ToInt32(txtBox2.Text);
            sum = number1 + number2;
            product = number1 * number2;
            lblSum.Text = sum.ToString();
            lblProduct.Text = product.ToString();
            /*Calculates the sum of 2 numbers
             * and displays it in the sum label. It also calculates
             * the product of 2 numbers and displays it in the product label.*/
        }
    }
}
