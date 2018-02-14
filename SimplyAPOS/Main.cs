using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplyAPOS
{
    public partial class Main : MaterialSkin.Controls.MaterialForm
    {
        //Some declarations
        Button[,] abu;
        //Will work with multithreading for better performance later
        Thread th;
        

        public Main()
        {
            InitializeComponent();
        }

        //This method just fucked me up but I finally nailed it (Mostly :P)
        //Planning to add multithreading later for better performance
        public void showButtons(int numOfItems)
        {
            //This will clean the buttons in order to rearrange them, maybe needs a better coding will think of a better way later
            //Added try since at first the array will be empty so that it does not send an error, so this is normal, will check what the catch do later
            try
            {
                //Will just clean the buttons
                //First it will check if the length > 0 which if true then it means there are buttons inside the tab view
                if (abu.Length > 0)
                {
                    for (int i = 0; i < abu.GetLength(0); i++)
                    {
                        for (int j = 0; j < abu.GetLength(1); j++)
                        {
                            //Will remove each button maybe will try using for each
                            //Will also check Dispose function if better but for now this is a working code :D
                            tab_buy.Controls.Remove(abu[i, j]);
                        }
                    }
                }
            }
            catch { }
            
            //Stepepr is actually my fav variable :P
            //It represents the spacing between each button, did not try changin the value to check if it will work with other values
            //maybe later, at least it worked right?...right ;-;
            int stepper = 6;

            //Default stuff blah, blah, blahhh
            int defWidth = 120;
            int defHeight = 120;

            //Represents the next position for each coords for each button
            int nextPosX = 0;
            int nextPosY = 6;

            //Default used colors will optimize it later
            Color defColor = Color.Aquamarine;
            Color nextColor = Color.Lime;
            Color ChosenColor = defColor;

            //not sure where I used this but will keep it for now
            int n = 0;

            //this took most of my time to calculate but finally nailed it :D
            //it column count represents how many columns are used
            //row count is calculated by dividing how many items we have by the column count then ceiling it
            //for example if we have 12 items and the window width is  577
            //column count would be 4
            //then row count will be 12/4 = 3
            int columnCount = tab_buy.Width / (defWidth + (stepper * 2));
            double rowCount = Math.Ceiling((double)numOfItems / columnCount);
            //this will help in stopping at the last item in the last row
            int itemsCount = 0;

            //added try since it is giving an error when we resize the window too much
            //will check why later
            try
            {
                abu = new Button[(int)rowCount, columnCount];
                for (int i = 0; i < rowCount; i++)
                {
                    for (int j = 0; j < columnCount && itemsCount != numOfItems; j++)
                    {
                        abu[i, j] = new Button
                        {
                            Location = new Point(nextPosX + stepper, nextPosY),
                            Size = new Size(defWidth, defHeight),
                            Font = new Font("Montserrat", 11.25f, FontStyle.Bold),

                            FlatStyle = FlatStyle.Flat,
                            BackColor = ChosenColor



                        };
                        abu[i, j].FlatAppearance.BorderSize = 0;
                        abu[i, j].Text = "" + abu[i, j].Location;
                        nextPosX += defWidth + stepper;
                        tab_buy.Controls.Add(abu[i, j]);
                        itemsCount++;

                    }
                    nextPosY += (defHeight + stepper);
                    nextPosX = 0;
                    if (n == 1)
                    {
                        ChosenColor = defColor;
                        n = 0;
                    }
                    else
                    {
                        ChosenColor = nextColor;
                        n = 1;
                    }

                }
            }
            catch
            {

            }
            

        }

        private void Main_Load(object sender, EventArgs e)
        {
            showButtons(120);
        }

        private void Main_ResizeEnd(object sender, EventArgs e)
        {
            showButtons(120);
        }
        private void Main_Resized(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                showButtons(120);
            }
        }

        private void tab_sell_Click(object sender, EventArgs e)
        {

        }
    }
}
