using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeVeeP5
{
    public class Alien
    {
        /// <summary>
        /// Programmer: Angela LeVee (alevee@cnm.edu)
        /// File: Alien
        /// Date: 4/9/2015
        /// </summary>

        #region Fields and Properties

        int alienHP = 2;

        public int AlienHP { get { return alienHP; } set { alienHP = value; } }

        #endregion

        #region Methods

        /// <summary>
        /// Decides if Alien is in location
        /// </summary>
        /// <returns></returns>
        public bool Check()
        {            
            if (Form1.RandomNum(1,10)%2 == 0) // 50% chance
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion
    }
}
