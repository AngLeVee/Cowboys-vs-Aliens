using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeVeeP5
{
    public abstract class Weapon
    {
        /// <summary>
        /// Programmer: Angela LeVee (alevee@cnm.edu)
        /// File: Weapon
        /// Date: 4/9/2015
        /// </summary>

        #region Fields

        public abstract double ProbabilityOfHits();
        public abstract string Name { get; set; }
        public int Range { get; set; }
        public int Wind { get; set; }
        public int Visibility { get; set; }
        public int Rounds { get; set; }

        #endregion

        #region Methods

        public int ComputeHits()
        {
            return (int)Math.Round(Rounds * ProbabilityOfHits() * ComputeWind() * ComputeVis());
        }

        public double ComputeVis()
        {
            switch (Visibility) //visibility is in yards
            {
                case 0:
                    return 1;
                case 1:
                    return .9;
                case 2:
                    return .6;
                case 3:
                    return .5;
                case 4:
                    return .7;
                default:
                    return 1;
            }
        }

        public double ComputeWind()
        {
            switch (Wind) //wind is in mph
            {
                case 0:
                    return 1;
                case 5:
                    return .9;
                case 10:
                    return .8;
                case 15:
                    return .75;
                case 20:
                    return .7;
                case 25:
                    return .65;
                default:
                    return 1;
            }
        }

        #endregion
    }
}
