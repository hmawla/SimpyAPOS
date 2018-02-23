using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.OleDb;

namespace SimplyAPOS
{
    public partial class Main : MaterialSkin.Controls.MaterialForm
    {
        //Some declarations
        Button[,] abu;
        //Will work with multithreading for better performance later
        Thread th;

        //Declare the OleDb shits, needs a connection to get to the db file, and needs a reader to access its records
        public OleDbConnection oLEConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|/SPOSDB.accdb");
        public OleDbDataReader theReader = null;

        public Main()
        {
            InitializeComponent();
        }

        //This method just fucked me up but I finally nailed it (Mostly :P)
        //Planning to add multithreading later for better performance
        public void FillButtons(Int32 theCatID, SPOSDBDataSet.ItemsDataTable theTable)
        {
            //needed to determine the number of items, (may get ommitted later for memory purposes)
            int numOfItems = 0;
            

            //OleDb commands needed to send queries via OleDbConnection
            OleDbCommand theCmd = new OleDbCommand
            {
                CommandText = "SELECT COUNT(*) FROM Items WHERE CatID = " + theCatID,
                CommandType = CommandType.Text,
                CommandTimeout = 2,
                Connection = oLEConnection
            };
            OleDbCommand theCmd2 = new OleDbCommand
            {
                CommandText = "SELECT ItemID, ItemName FROM Items where CatID = " + theCatID,
                CommandType = CommandType.Text,
                CommandTimeout = 2,
                Connection = oLEConnection
            };

            try
            {
                //This will return the first value in first column and colses the reader by it self
                //numOfItems may not get ommitted after all
                numOfItems = (int)theCmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            
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
            catch(Exception ex) {
                MessageBox.Show("" + ex);
            }
            
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
                //declare the array of buttons objects with the first dimension being the rowCount and the second dimension columnCount
                abu = new Button[(int)rowCount, columnCount];
                

                try
                {
                    //This is where most of the db magic happens, this makes a link to the db using the query in theCmd2
                    //Needs a .Read() to get to the first and next elements
                    theReader = theCmd2.ExecuteReader();

                }
                catch(Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
                //start showing the buttons
                for (int i = 0; i < rowCount; i++)
                {
                    

                    //show buttons for each row
                    for (int j = 0; j < columnCount && itemsCount != numOfItems; j++)
                    {
                        theReader.Read();

                        //give the new button its characteristics
                        //location is calculated according to a variable stepper which is the distance between each button
                        //and a nextPos(X/Y) with nextPosX is the X position of the button
                        //nextPosY is the Y position of the button
                        //Colors needs a revamp and will be based on the selected theme with themes becoming customizable
                        abu[i, j] = new Button
                        {
                            Location = new Point(nextPosX, nextPosY),
                            Size = new Size(defWidth, defHeight),
                            Font = new Font("Montserrat", 11.25f, FontStyle.Bold),
                            //This one will contain the ID of the Item, needed a lot to access the ID of the Item from the button
                            Name = "" + theReader.GetInt32(0),
                            FlatStyle = FlatStyle.Flat,
                            BackColor = ChosenColor,
                            //Gets the name of the Item
                            Text = theReader.GetString(1)
                            



                        };
                        
                        //could not be used inside the button's characteristics had to use it outside, not sure why yet
                        abu[i, j].FlatAppearance.BorderSize = 0;
                        //nextPosX increasing by button's width and the stepper
                        nextPosX += (defWidth + stepper);
                        //add the charactirized button
                        tab_buy.Controls.Add(abu[i, j]);
                        abu[i, j].Click += new System.EventHandler(this.AButtonClicked);
                        //increase the sum of items
                        itemsCount++;

                    }
                    //nextPosY increasing by button's height and the stepper
                    nextPosY += (defHeight + stepper);
                    nextPosX = 0;

                    //color switcher for each n, will be changed for sure later...
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
            //Used for error reporting
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            

        }

        //Currently working on this, it took me a while to figure it out, and FINALLY!!
        private void AButtonClicked(Object sender, EventArgs e)
        {
            Button theClickedButton = (Button)sender;

        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sPOSDBDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.sPOSDBDataSet.Category);

            // TODO: This line of code loads data into the 'sPOSDBDataSet.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.sPOSDBDataSet.Items);


            
            oLEConnection.Open();

            // Data is accessible through the DataReader object here.
            //FillButtons("this", sPOSDBDataSet.Items);
            FillButtons(1, sPOSDBDataSet.Items);
            FillCategories(sPOSDBDataSet.Category);
            

           
        }

        private void Main_Closed(object sender, EventArgs e)
        {
            oLEConnection.Close();
        }

        public void FillCategories(SPOSDBDataSet.CategoryDataTable theTable)
        {
            for (int i = 0 ; i < theTable.Count ; i++)
            {
                CBox_Cat.Items.Add(theTable.Rows[i][1]);
            }
            CBox_Cat.SelectedIndex = 0 ;
        }

        private void Main_ResizeEnd(object sender, EventArgs e)
        {
            FillButtons(1, sPOSDBDataSet.Items);
        }
        private void Main_Resized(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                FillButtons(1, sPOSDBDataSet.Items);
            }
        }

        private void Tab_sell_Click(object sender, EventArgs e)
        {

        }


        //This is a work in progress
        //private void MaterialRaisedButton2_Click(object sender, EventArgs e)
        //{
        //    WindowState = FormWindowState.Maximized;
        //}

        //private void MaterialRaisedButton1_Click(object sender, EventArgs e)
        //{
        //    WindowState = FormWindowState.Normal;
                
        //}
        
    }
}
