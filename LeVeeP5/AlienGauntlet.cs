using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeVeeP5
{
    class AlienGauntlet:Weapon
    {
        /// <summary>
        /// Programmer: Angela LeVee (alevee@cnm.edu)
        /// File: AlienGauntlet
        /// Date: 4/9/2015
        /// </summary>

        #region Overrides

        override public string Name { get; set; }

        override public double ProbabilityOfHits()
        {
            switch (Range) //Range is in yards
            {
                case 5:
                    return .70;
                case 25:
                    return .90;
                case 50:
                    return .90;
                case 100:
                    return .85;
                case 500:
                    return .80;
                case 1000:
                    return .70;
                default:
                    return .70;
            }
        }

        #endregion

        #region Constructors

        public AlienGauntlet(string range, string rounds, int visibility, string wind)
        {
            string[] myArray; //Used to split text from comboboxes to get numbers w/out needing switch statement
            myArray = range.Split(' ');
            Range = Convert.ToInt32(myArray[0]);
            myArray = rounds.Split(' ');
            Rounds = Convert.ToInt32(myArray[0]);
            Visibility = visibility;
            myArray = wind.Split(' ');
            Wind = Convert.ToInt32(myArray[0]);
            Name = "Alien Gauntlet";
        }

        #endregion
    }
}
