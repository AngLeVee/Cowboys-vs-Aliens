using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeVeeP5
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Programmer: Angela LeVee (alevee@cnm.edu)
        /// File: Form1
        /// Date: 4/9/2015
        /// </summary>

        #region Fields

        Location[] places = new Location[8];
        Alien[] aliens = new Alien[7];
        Weapon[] weapons = new Weapon[4];
        Label[] HP = new Label[10];
        static Random location = new Random(); //Used mainly for radiobutton locations
        int currentArea;
        int alienNum;
        int playerHP;
        int hitsTaken;
        int aliensHit;
        int a;

        #endregion

        #region Constructors

        public Form1()
        {
            InitializeComponent();
            SetDefault(); //Set all beginning values

            //Set tooltip for reposition button so user knows what it's for
            ttipReposition.SetToolTip(butRepos, "Use this button to reposition hiding places for the current area.");
        }

        #endregion

        #region Methods

        /// <summary>
        /// Method to return random numbers for RadioButton locations
        /// </summary>
        /// <param name="max"></param>
        /// <returns></returns>
        static public int RandomNum(int min, int max)
        {
            return location.Next(min, max);
        }

        /// <summary>
        /// To be called when a hiding spot contains an alien.
        /// </summary>
        /// <param name="alienNum"></param>
        /// <param name="i"></param>
        /// <param name="alienPlaces"></param>
        static public void setAlien(int alienNum, int i, Location.HidingPlaceStruct[] alienPlaces)
        {
            alienPlaces[i].hasAlien = true;
            alienPlaces[i].alienNum = alienNum;
            alienPlaces[i].alienBox.Text = "Alien | |";
            alienPlaces[i].alienBox.ForeColor = System.Drawing.Color.Green;
        }

        /// <summary>
        /// Returns index of RadioButton selected
        /// </summary>
        /// <param name="gbox"></param>
        /// <returns></returns>
        private int ButtonSelected(GroupBox gbox)
        {
            for (int i = 0; i < gbox.Controls.Count; i++)
            {
                if (((RadioButton)gbox.Controls[i]).Checked)
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Used to set original values and reset the form
        /// </summary>
        void SetDefault()
        {
            tcontrolAliens.SelectedTab = tpageMission;

            #region Locations
            places[0] = new Outside("Empty Field");
            places[1] = new Building("Factory", "Barrel ");
            places[2] = new OutsideWithHidingPlace("Abandoned Junkyard", "Trash pile ");
            places[3] = new OutsideWithHidingPlace("Wheat Field", "Hay Bundle ");
            places[4] = new Building("Church", "Pew ");
            places[5] = new Building("Home", "Chair ");
            places[6] = new OutsideWithHidingPlace("Parking Lot", "Car ");
            places[7] = new OutsideWithHidingPlace("Street", "Lamppost ");
            #endregion

            for (int i = 0; i < 7; i++)
            {
                aliens[i] = new Alien();
            }

            currentArea = 1;
            alienNum = 2;
            playerHP = 10;
            hitsTaken = 0;
            aliensHit = 0;
            a = -1;

            #region ComboBoxes
            cboxWeapons.ResetText();
            cboxWeapons.SelectedIndex = -1;
            cboxRounds.ResetText();
            cboxRounds.SelectedIndex = -1;
            cboxRange.ResetText();
            cboxRange.SelectedIndex = -1;
            cboxCondit.ResetText();
            cboxCondit.SelectedIndex = -1;
            cboxWinds.ResetText();
            cboxWinds.SelectedIndex = -1;
            #endregion

            #region GroupBox
            for (int i = 9; i >= 0; i--)
            {
                tpageGame.Controls.Remove(HP[i]);
                HP[i] = new Label();
                HP[i].Text = "|";
                HP[i].ForeColor = System.Drawing.Color.Green;
                HP[i].AutoSize = true;
                HP[i].Location = new System.Drawing.Point(30 + (i * 8), 8);
                HP[i].Name = "lblHP";
            }

            tpageGame.Controls.AddRange(HP);

            lblAreaName.Text = places[currentArea - 1].Name;
            gboxArea.Controls.Add(places[0].AlienPlaces[0].alienBox);
            gboxArea.Text = "Area " + currentArea;
            tboxInfo.Text = "Press search to find all aliens in the area, select an alien and all the options for your weapon, and Shoot!";
            #endregion

            #region Labels
            lblError.Visible = false;
            lblNoAlien.Visible = false;
            lblShootWarn.Visible = false;
            lblCBox.Visible = false;
            lblAreasnum.Text = "1";
            lblAliensNum.Text = "7";
            lblAliensNum.ForeColor = System.Drawing.Color.Red;
            lblAliensTotal.ForeColor = System.Drawing.Color.Red;
            lblHPnum.Text = "10";
            lblHPnum.ForeColor = System.Drawing.Color.Green;
            lblHPtotal.ForeColor = System.Drawing.Color.Green;

            for (int i = 0; i < 10; i++)
            {
                HP[i].Visible = true;
            }
            #endregion

            #region Buttons
            butShoot.Enabled = true;
            butNext.Enabled = true;
            butPrevious.Enabled = true;
            butSearch.Enabled = true;
            butRepos.Enabled = true;
            #endregion
        }

        /// <summary>
        /// Set choices into weapons and then compute shots that hit
        /// </summary>
        void WeaponSet()
        {
            switch (cboxWeapons.Items[cboxWeapons.SelectedIndex].ToString())
            {
                case "Six-Shooter":
                    weapons[0] = new SixShooter(cboxRange.Items[cboxRange.SelectedIndex].ToString(),
                        cboxRounds.Items[cboxRounds.SelectedIndex].ToString(), cboxCondit.SelectedIndex,
                        cboxWinds.Items[cboxWinds.SelectedIndex].ToString());
                    aliensHit = weapons[0].ComputeHits();
                    break;
                case "Rifle":
                    weapons[1] = new Rifle(cboxRange.Items[cboxRange.SelectedIndex].ToString(),
                        cboxRounds.Items[cboxRounds.SelectedIndex].ToString(), cboxCondit.SelectedIndex,
                        cboxWinds.Items[cboxWinds.SelectedIndex].ToString());
                    aliensHit = weapons[1].ComputeHits();
                    break;
                case "Spear":
                    weapons[2] = new Spear(cboxRange.Items[cboxRange.SelectedIndex].ToString(),
                        cboxRounds.Items[cboxRounds.SelectedIndex].ToString(), cboxCondit.SelectedIndex,
                        cboxWinds.Items[cboxWinds.SelectedIndex].ToString());
                    aliensHit = weapons[2].ComputeHits();
                    break;
                case "Alien Gauntlet":
                    weapons[3] = new AlienGauntlet(cboxRange.Items[cboxRange.SelectedIndex].ToString(),
                        cboxRounds.Items[cboxRounds.SelectedIndex].ToString(), cboxCondit.SelectedIndex,
                        cboxWinds.Items[cboxWinds.SelectedIndex].ToString());
                    aliensHit = weapons[3].ComputeHits();
                    break;
            }
        }

        /// <summary>
        /// Display results of shot on targeted Alien
        /// </summary>
        void AlienDamage()
        {
            bool missed = false;

            #region Shoot Aliens Switch
            switch (aliensHit)
            {
                case 0:
                    tboxInfo.AppendText("\r\nYou missed!");
                    missed = true;
                    break;
                case 1:
                    aliens[places[currentArea - 1].AlienPlaces[a].alienNum - 1].AlienHP -= 1;
                    break;
                default:
                    aliens[places[currentArea - 1].AlienPlaces[a].alienNum - 1].AlienHP -= 1;
                    break;
            }
            #endregion

            #region Results
            if (aliens[places[currentArea - 1].AlienPlaces[a].alienNum-1].AlienHP == 1 && missed == false)
            {
                tboxInfo.AppendText("\r\nYou hit 1 time!");
                places[currentArea - 1].AlienPlaces[a].alienBox.Text = "Alien |";
                places[currentArea - 1].AlienPlaces[a].alienBox.ForeColor = System.Drawing.Color.Orange;
            }
            else if (aliens[places[currentArea - 1].AlienPlaces[a].alienNum - 1].AlienHP < 1 && missed == false)
            {
                tboxInfo.AppendText("\r\nYou killed it!");
                places[currentArea - 1].AlienPlaces[a].alienBox.Text = "Alien";
                places[currentArea - 1].AlienPlaces[a].alienBox.ForeColor = System.Drawing.Color.Red;
                lblAliensNum.Text = string.Format("{0}", Convert.ToInt32(lblAliensNum.Text) - 1);
                places[currentArea - 1].AlienPlaces[a].hasAlien = false;
            }
            #endregion
        }

        /// <summary>
        /// Used to calculate if player was hit
        /// </summary>
        void Hit()
        {
            bool hit = false; //initialize boolean to determine if player was hit.

            #region Hit Switch
            switch (cboxRounds.SelectedIndex) //Chance of hit changes with amount of rounds
            {
                case 0: //1 round fired
                    if (RandomNum(1,20) == 1) // 1/20 = 5%
                    {
                        playerHP -= 1;
                        hitsTaken += 1;
                        hit = true;
                    }
                    break;
                case 1: //2 rounds fired
                    if (RandomNum(1, 10) == 1) // 1/10 = 10%
                    {
                        playerHP -= 1;
                        hitsTaken += 1;
                        hit = true;
                    }
                    break;
                case 2: //3 rounds fired
                    if (RandomNum(1, 20) <= 3) // 3/20 = 15%
                    {
                        playerHP -= 1;
                        hitsTaken += 1;
                        hit = true;
                    }
                    break;
                case 3: //4 rounds fired
                    if (RandomNum(1, 4) == 1) // 1/4 = 25%
                    {
                        playerHP -= 1;
                        hitsTaken += 1;
                        hit = true;
                    }
                    break;
                case 4: //5 rounds fired
                    if (RandomNum(1, 50) <= 20) // 20/50 = 40%
                    {
                        playerHP -= 1;
                        hitsTaken += 1;
                        hit = true;
                    }
                    break;
            }
            #endregion

            #region If Hit
            if (hit == true)
            {
                tboxInfo.AppendText("\r\nYou've been hit!");
                lblHPnum.Text = playerHP.ToString();
                HP[playerHP].Visible = false; //Decrease HP gauge

                if (playerHP == 0) //When HP hits 0, you lose.
                {
                    Lost();
                }
                if (playerHP == 3) //When HP hits 3 HP color changes to Red
                {
                    for (int i = 0; i < playerHP; i++)
                    {
                        HP[i].ForeColor = System.Drawing.Color.Red;
                    }
                    lblHPnum.ForeColor = System.Drawing.Color.Red;
                    lblHPtotal.ForeColor = System.Drawing.Color.Red;
                }
                else if (playerHP == 7) //When HP hits 7 HP color changes to Orange
                {
                    for (int i = 0; i < playerHP; i++)
                    {
                        HP[i].ForeColor = System.Drawing.Color.Orange;
                    }
                    lblHPnum.ForeColor = System.Drawing.Color.Orange;
                    lblHPtotal.ForeColor = System.Drawing.Color.Orange;
                }
            }
            #endregion
        }

        /// <summary>
        /// Used when HP reaches 0
        /// </summary>
        void Lost()
        {
            tboxInfo.Text = "You Lost!";

            //Disable all buttons except for Reset
            butShoot.Enabled = false;
            butNext.Enabled = false;
            butPrevious.Enabled = false;
            butSearch.Enabled = false;
            butRepos.Enabled = false;
        }

        /// <summary>
        /// Used when Aliens are all dead
        /// </summary>
        void Won()
        {
            tboxInfo.Text = "You Won!";

            //Disable all buttons except for Reset
            butShoot.Enabled = false;
            butNext.Enabled = false;
            butPrevious.Enabled = false;
            butSearch.Enabled = false;
            butRepos.Enabled = false;
        }

        #endregion

        #region Buttons

        private void butGo_Click(object sender, EventArgs e)
        {
            tcontrolAliens.SelectedTab = tpageGame;
        }

        private void butNext_Click(object sender, EventArgs e)
        {
            if (currentArea == 8)
            {
                lblError.Visible = true; //Show error message because there are no more areas
            }
            else
            {
                currentArea += 1;

                gboxArea.Controls.Clear();
                gboxArea.Text = "Area " + currentArea;
                lblAreaName.Text = places[currentArea - 1].Name;

                for (int i = 0; i < places[currentArea - 1].AlienPlaces.Length; i++)
                {
                    gboxArea.Controls.Add(places[currentArea - 1].AlienPlaces[i].alienBox);
                }
            }

            //Hide error messages
            lblNoAlien.Visible = false;
            lblShootWarn.Visible = false;
            lblCBox.Visible = false;
        }

        private void butPrevious_Click(object sender, EventArgs e)
        {
            gboxArea.Controls.Clear();
            currentArea -= 1;

            for (int i = 0; i < places[currentArea - 1].AlienPlaces.Length; i++)
            {
                gboxArea.Controls.Add(places[currentArea - 1].AlienPlaces[i].alienBox);
            }

            gboxArea.Text = "Area " + currentArea;
            lblAreaName.Text = places[currentArea - 1].Name;

            //Hide error messages
            lblNoAlien.Visible = false;
            lblError.Visible = false;
            lblCBox.Visible = false;
        }

        private void butReset_Click(object sender, EventArgs e)
        {
            gboxArea.Controls.Clear();
            SetDefault();
        }
        
        private void butSearch_Click(object sender, EventArgs e)
        {
            if (places[currentArea - 1] is IHidingPlace)
            {
                bool firstSearch = false;

                if (places[currentArea - 1].Search(ref alienNum, aliens, currentArea, ref firstSearch) == false)
                {
                    lblNoAlien.Visible = true; //If there are no aliens, show label
                }

                if (firstSearch == true) //If it's the first time it's been searched, add to amount searched
                {
                    lblAreasnum.Text = string.Format("{0}", Convert.ToInt32(lblAreasnum.Text) + 1);
                }
            }
        }

        private void butRepos_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < places[currentArea - 1].AlienPlaces.Length; i++)
            {
                places[currentArea - 1].AlienPlaces[i].alienBox.Location = new System.Drawing.Point(RandomNum(20, 378),
                    RandomNum(20, 226));
            }
        }

        private void butShoot_Click(object sender, EventArgs e)
        {
            a = ButtonSelected(gboxArea);

            #region Shoot
            if (a > -1)
            {
                lblShootWarn.Visible = false;

                if (places[currentArea - 1].AlienPlaces[a].hasAlien == true)
                {
                    if (cboxWeapons.SelectedIndex > -1 && cboxRounds.SelectedIndex > -1 && cboxRange.SelectedIndex > -1
                    && cboxCondit.SelectedIndex > -1 && cboxWinds.SelectedIndex > -1) //If every combobox has selection
                    {
                        lblCBox.Visible = false; //Hide warning
                        WeaponSet();
                        AlienDamage();
                        Hit();
                    }
                    else //Otherwise show warning to select something for each
                    {
                        lblCBox.Visible = true;
                    }
                }
                else //If no alien, show warning to select one
                {
                    lblShootWarn.Visible = true;
                }
            }
            else
            {
                lblShootWarn.Visible = true;
            }
            #endregion

            #region Alien Damage Results
            if (Convert.ToInt32(lblAliensNum.Text) == 0) //If all aliens are dead, you win
            {
                Won();
            }
            else if (Convert.ToInt32(lblAliensNum.Text) == 2) //When aliens left hits 2, change color to green
            {
                lblAliensNum.ForeColor = System.Drawing.Color.Green;
                lblAliensTotal.ForeColor = System.Drawing.Color.Green;
            }
            else if (Convert.ToInt32(lblAliensNum.Text) == 4) //When aliens left hits 4, change color to orange
            {
                lblAliensNum.ForeColor = System.Drawing.Color.Orange;
                lblAliensTotal.ForeColor = System.Drawing.Color.Orange;
            }
            #endregion
        }

        #endregion
    }
}
