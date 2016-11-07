/**

 *

 * Name: Tyler Marten    

 * Teacher: Mr. Hardman

 * Assignment 2, Program ?

 * Date Last Modified: 10/14/16

 *

 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_World_V2
{
    public partial class frmHelloWorldV2 : Form
    {
        private static string previousUserAnswer;

        //creates a new version of the frm can be used to change to robots question
        public frmHelloWorldV2()
        {
            InitializeComponent();
            lblOutput.Text = "Hello there... ummmm whats your name again";
        }
        //puts the new question in the question box (output)
        public frmHelloWorldV2(string answer,string newQuestion)
        {
            InitializeComponent();
            previousUserAnswer = answer;
            lblOutput.Text = newQuestion;
        }

        private void txtOutput_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            string currentUserAnswer = txtInput.Text;
            //checks if the output (the robots question) is still Hello there... ummmm whats your name again
            if ( (lblOutput.Text).Equals("Hello there... ummmm whats your name again") == true)
            {
                //Second Time the frm is used, then gets the users name then closes the frm
                frmHelloWorldV2 secondTime = new frmHelloWorldV2(currentUserAnswer, currentUserAnswer + " Of course, What is the square root of 841. ");
                secondTime.Show();
                this.Hide();
            }

            if ((lblOutput.Text).Equals( previousUserAnswer + " Of course, What is the square root of 841. ") == true) 
            {
                if (currentUserAnswer == 29)
                {
                    frmHelloWorldV2 thirdTime = new frmHelloWorldV2(currentUserAnswer, "Wow your a nerd");

                } else {
                    frmHelloWorldV2 thirdTime = new frmHelloWorldV2(currentUserAnswer, "Not right, so you have a life then -_-");
                    this.Close();
                }


            }

            this.Close();
        }
    }
}
