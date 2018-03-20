//part 2. Write pseudocode, (not a flowchart), for the following problem:
/*The user is to enter their name.The program will welcome them and 
then ask the user if they would like to play a "number guess" game.
If they select "no" the program ends.If they select yes the program picks a random number out of 100 
and asks the user to guess what it is.  The user is to continue guessing until they get it correct,
at which point the program will congratulate them and then end.*/

//  Begin Program
//    Enter name
//    output "welcome, would you like to play a number guess game?"
//    would you like to continue?
//       if no end program
//    pick a random number out of 100
//    output "guess the number."
//       if guessed right output "congratulations"
//    end program

//part 3
//aizlea sharp
//march 19th 2018
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace flowchartcode_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //make screen black
            Graphics g = this.CreateGraphics();
            g.Clear(Color.Black);
            Thread.Sleep(500);
            //say hello world
            
            Font drawFont = new Font("Arial", 16, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.White);
            g.DrawString("Hello world!", drawFont, drawBrush, 100, 70);
            //wait 3 seconds
            Thread.Sleep(3000);
            //flash
            g.Clear(Color.Red);
            g.DrawString("Hello world!", drawFont, drawBrush, 100, 70);
            Thread.Sleep(300);
            g.Clear(Color.Black);
            g.DrawString("Hello world!", drawFont, drawBrush, 100, 70);
            Thread.Sleep(300);
            g.Clear(Color.Red);
            g.DrawString("Hello world!", drawFont, drawBrush, 100, 70);
            Thread.Sleep(300);
            g.Clear(Color.Black);
            g.DrawString("Hello world!", drawFont, drawBrush, 100, 70);
            Thread.Sleep(300);
            //tell user to press exit
            g.DrawString("press exit button", drawFont, drawBrush, 100, 90);
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.Black);
            Font drawFont = new Font("Arial", 16, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.White);
            g.DrawString("good bye!", drawFont, drawBrush, 100, 90);
            Thread.Sleep(2500);
            Application.Exit();
        }
    }
}
