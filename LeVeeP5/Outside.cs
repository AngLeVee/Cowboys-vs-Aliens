using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeVeeP5
{
    partial class Outside:Location
    {
        /// <summary>
        /// Programmer: Angela LeVee (alevee@cnm.edu)
        /// File: Outside
        /// Date: 4/9/2015
        /// </summary>

        #region Fields

        HidingPlaceStruct[] alienPlaces = new HidingPlaceStruct[1];
        string name;
        string description;

        #endregion

        #region Overrides

        override public HidingPlaceStruct[] AlienPlaces { get { return alienPlaces; } set { alienPlaces = value; } }

        override public string Description
        {
            get { return description; }
            set { description = value; }
        }

        #endregion

        #region Constructors

        public Outside(string name):base (name)
        {
            this.name = name;

            #region Alien Places
            alienPlaces[0].alienBox = new RadioButton();
            alienPlaces[0].alienBox.AutoSize = true;
            alienPlaces[0].alienBox.ForeColor = System.Drawing.Color.Green;
            alienPlaces[0].alienBox.Location = new System.Drawing.Point(Form1.RandomNum(20, 378), Form1.RandomNum(20, 226));
            alienPlaces[0].alienBox.Name = "rbuttonAlien1";
            alienPlaces[0].alienBox.Text = "Alien | |";
            alienPlaces[0].hasAlien = true; //Automatically contains one alien and no hiding places
            alienPlaces[0].alienNum = 1;
            #endregion
        }

        #endregion
    }
}
