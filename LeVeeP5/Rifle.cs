﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeVeeP5
{
    class Rifle:Weapon
    {
        /// <summary>
        /// Programmer: Angela LeVee (alevee@cnm.edu)
        /// File: Rifle
        /// Date: 4/9/2015
        /// </summary>

        #region Overrides

        override public string Name { get; set; }

        override public double ProbabilityOfHits()
        {
            switch (Range) //Range is in yards
            {
                case 5:
                    return .99;
                case 25:
                    return .80;
                case 50:
                    return .70;
                case 100:
                    return .60;
                case 500:
                    return .50;
                case 1000:
                    return .40;
                default:
                    return .99;
            }
        }

        #endregion

        #region Constructors

        public Rifle(string range, string rounds, int visibility, string wind)
        {
            string[] myArray; //Used to split text from comboboxes to get numbers w/out needing switch statement
            myArray = range.Split(' ');
            Range = Convert.ToInt32(myArray[0]);
            myArray = rounds.Split(' ');
            Rounds = Convert.ToInt32(myArray[0]);
            Visibility = visibility;
            myArray = wind.Split(' ');
            Wind = Convert.ToInt32(myArray[0]);
            Name = "Rifle";
        }

        #endregion
    }
}
