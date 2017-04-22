using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeVeeP5
{
    class Building : Location, IHidingPlace
    {
        /// <summary>
        /// Programmer: Angela LeVee (alevee@cnm.edu)
        /// File: Building
        /// Date: 4/9/2015
        /// </summary>

        #region Fields
        
        HidingPlaceStruct[] alienPlaces = new HidingPlaceStruct[4];
        string name;
        string description;
        bool searched = false;
        bool alien1 = false;
        bool alien2 = false;

        #endregion

        #region Properties

        public string HidingPlaceName { get; set; }

        #endregion

        #region Overrides

        override public HidingPlaceStruct[] AlienPlaces { get { return alienPlaces; } set { alienPlaces = value; } }
        override public string Description { get { return description; } set { description = value; } }

        /// <summary>
        /// Searches area for aliens. Allows maximum two aliens per area.
        /// </summary>
        /// <param name="alienNum"></param>
        /// <param name="aliens"></param>
        /// <param name="locationNum"></param>
        /// <param name="firstSearch"></param>
        /// <returns></returns>
        override public bool Search(ref int alienNum, Alien[] aliens, int locationNum, ref bool firstSearch)
        {
            int a = 0;

            if (searched == false) //If method hasn't been used for this area before
            {
                #region First Alien assignment
                if (alienNum < 8)
                {
                    do
                    {
                        for (int i = 0; i < alienPlaces.Length; i++)
                        {                            
                            if (aliens[alienNum - 1].Check() == true)
                            {
                                a = i + 1; //Second alien will start off after first (to avoid two aliens in same spot)
                                Form1.setAlien(alienNum, i, alienPlaces);
                                alienNum += 1;
                                alien1 = true;
                                break;
                            }
                        }
                    } while (alienNum < locationNum); //If there are already enough aliens, area can lack aliens
                }
                #endregion

                #region Second Alien assignment
                if (alienNum < 8)
                {
                    for (int i = a; i < alienPlaces.Length; i++)
                    {
                        if (aliens[alienNum - 1].Check() == true)
                        {
                            Form1.setAlien(alienNum, i, alienPlaces);
                            alienNum += 1;
                            alien2 = true;
                            break;
                        }
                    }
                }
                #endregion

                firstSearch = true;
                searched = true;
            }
            else
            {
                firstSearch = false;
            }

            if (alien1 == false && alien2 == false) //If no aliens were assigned, return false
            {
                return false;
            }
            return true;
        }

        #endregion

        #region Constructors

        public Building(string name, string hidingPlace)
            : base(name)
        {
            this.name = name;
            HidingPlaceName = hidingPlace;

            for (int i = 0; i < 4; i++)
            {
                alienPlaces[i].alienBox = new RadioButton();
                alienPlaces[i].alienBox.Text = HidingPlaceName + (i + 1);
                alienPlaces[i].alienBox.Location = new System.Drawing.Point(Form1.RandomNum(20, 378), Form1.RandomNum(20, 226));
                alienPlaces[i].alienBox.AutoSize = true;
                alienPlaces[i].alienBox.Name = "rbuttonHiding";
            }
        }

        #endregion
    }    
}
