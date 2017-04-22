using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeVeeP5
{
    public abstract class Location
    {
        /// <summary>
        /// Programmer: Angela LeVee (alevee@cnm.edu)
        /// File: Location
        /// Date: 4/9/2015
        /// </summary>

        public struct HidingPlaceStruct
        {
            public bool hasAlien;
            public int alienNum;
            public RadioButton alienBox;
        }

        #region Fields

        private string name;
        private string description;

        #endregion

        #region Properties

        public string Name { get { return name; } }
        public virtual string Description { get { return description; } set { description = value; } }
        public virtual HidingPlaceStruct[] AlienPlaces { get; set; }

        #endregion

        #region Constructors

        public Location(string name)
        {
            this.name = name;
        }

        #endregion

        #region Methods

        virtual public bool Search(ref int alienNum, Alien[] aliens, int locationNum, ref bool firstSearch)
        {
            return true;
        }

        #endregion
    }
}
