namespace LeVeeP5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.tcontrolAliens = new System.Windows.Forms.TabControl();
			this.tpageMission = new System.Windows.Forms.TabPage();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tboxHero = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblInvade = new System.Windows.Forms.Label();
			this.lblAccept = new System.Windows.Forms.Label();
			this.butGo = new System.Windows.Forms.Button();
			this.tpageGame = new System.Windows.Forms.TabPage();
			this.tboxInfo = new System.Windows.Forms.TextBox();
			this.lblCBox = new System.Windows.Forms.Label();
			this.butRepos = new System.Windows.Forms.Button();
			this.lblNoAlien = new System.Windows.Forms.Label();
			this.lblShootWarn = new System.Windows.Forms.Label();
			this.lblAreaName = new System.Windows.Forms.Label();
			this.lblError = new System.Windows.Forms.Label();
			this.lblAreasTotal = new System.Windows.Forms.Label();
			this.lblAreasnum = new System.Windows.Forms.Label();
			this.lblAreas = new System.Windows.Forms.Label();
			this.butSearch = new System.Windows.Forms.Button();
			this.gboxArea = new System.Windows.Forms.GroupBox();
			this.lblAliensTotal = new System.Windows.Forms.Label();
			this.lblAliensNum = new System.Windows.Forms.Label();
			this.lblAliens = new System.Windows.Forms.Label();
			this.lblHPtotal = new System.Windows.Forms.Label();
			this.lblHPnum = new System.Windows.Forms.Label();
			this.lblHP = new System.Windows.Forms.Label();
			this.butReset = new System.Windows.Forms.Button();
			this.butShoot = new System.Windows.Forms.Button();
			this.butNext = new System.Windows.Forms.Button();
			this.butPrevious = new System.Windows.Forms.Button();
			this.cboxWinds = new System.Windows.Forms.ComboBox();
			this.cboxCondit = new System.Windows.Forms.ComboBox();
			this.cboxWeapons = new System.Windows.Forms.ComboBox();
			this.cboxRounds = new System.Windows.Forms.ComboBox();
			this.cboxRange = new System.Windows.Forms.ComboBox();
			this.ttipReposition = new System.Windows.Forms.ToolTip(this.components);
			this.tcontrolAliens.SuspendLayout();
			this.tpageMission.SuspendLayout();
			this.tpageGame.SuspendLayout();
			this.SuspendLayout();
			// 
			// tcontrolAliens
			// 
			this.tcontrolAliens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tcontrolAliens.Controls.Add(this.tpageMission);
			this.tcontrolAliens.Controls.Add(this.tpageGame);
			this.tcontrolAliens.Location = new System.Drawing.Point(12, 12);
			this.tcontrolAliens.Name = "tcontrolAliens";
			this.tcontrolAliens.SelectedIndex = 0;
			this.tcontrolAliens.Size = new System.Drawing.Size(483, 437);
			this.tcontrolAliens.TabIndex = 0;
			// 
			// tpageMission
			// 
			this.tpageMission.BackColor = System.Drawing.SystemColors.Control;
			this.tpageMission.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tpageMission.Controls.Add(this.textBox1);
			this.tpageMission.Controls.Add(this.label8);
			this.tpageMission.Controls.Add(this.label7);
			this.tpageMission.Controls.Add(this.label4);
			this.tpageMission.Controls.Add(this.label2);
			this.tpageMission.Controls.Add(this.label1);
			this.tpageMission.Controls.Add(this.tboxHero);
			this.tpageMission.Controls.Add(this.label5);
			this.tpageMission.Controls.Add(this.label3);
			this.tpageMission.Controls.Add(this.lblInvade);
			this.tpageMission.Controls.Add(this.lblAccept);
			this.tpageMission.Controls.Add(this.butGo);
			this.tpageMission.Location = new System.Drawing.Point(4, 22);
			this.tpageMission.Name = "tpageMission";
			this.tpageMission.Padding = new System.Windows.Forms.Padding(3);
			this.tpageMission.Size = new System.Drawing.Size(475, 411);
			this.tpageMission.TabIndex = 0;
			this.tpageMission.Text = "Your Mission...";
			// 
			// textBox1
			// 
			this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBox1.BackColor = System.Drawing.SystemColors.Control;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Location = new System.Drawing.Point(66, 210);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(338, 35);
			this.textBox1.TabIndex = 14;
			this.textBox1.Text = "Be careful; it takes two shots to kill and you aren\'t guaranteed to hit, but the " +
    "more you shoot the bigger the chance you\'ll get hit back.";
			// 
			// label8
			// 
			this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(63, 248);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(270, 13);
			this.label8.TabIndex = 13;
			this.label8.Text = "Defeat the aliens and leave them quaking in their boots.";
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(74, 182);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(196, 13);
			this.label7.TabIndex = 12;
			this.label7.Text = "and Salvaged Alien Death Ray Gauntlet";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(73, 169);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "Spear";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(74, 156);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "Big Fifty Sharps Rifle";
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(73, 144);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Colt 45 Peacemaker";
			// 
			// tboxHero
			// 
			this.tboxHero.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.tboxHero.BackColor = System.Drawing.SystemColors.Control;
			this.tboxHero.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tboxHero.Location = new System.Drawing.Point(66, 95);
			this.tboxHero.Multiline = true;
			this.tboxHero.Name = "tboxHero";
			this.tboxHero.Size = new System.Drawing.Size(338, 23);
			this.tboxHero.TabIndex = 8;
			this.tboxHero.Text = "We need a hero to make them turn tail and run by proving them wrong.";
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(63, 127);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(169, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "Only you can stop them using your";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(63, 79);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(332, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "These aliens think we\'re an easy target and are here to subjugate us.";
			// 
			// lblInvade
			// 
			this.lblInvade.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblInvade.AutoSize = true;
			this.lblInvade.Location = new System.Drawing.Point(63, 64);
			this.lblInvade.Name = "lblInvade";
			this.lblInvade.Size = new System.Drawing.Size(338, 13);
			this.lblInvade.TabIndex = 3;
			this.lblInvade.Text = "Seven aliens, acting as scouts, are here to gather intel for an invasion.";
			// 
			// lblAccept
			// 
			this.lblAccept.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblAccept.AutoSize = true;
			this.lblAccept.Location = new System.Drawing.Point(63, 32);
			this.lblAccept.Name = "lblAccept";
			this.lblAccept.Size = new System.Drawing.Size(344, 13);
			this.lblAccept.TabIndex = 2;
			this.lblAccept.Text = "... should you accept it, will be to take down the invading alien scourge.";
			// 
			// butGo
			// 
			this.butGo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.butGo.AutoSize = true;
			this.butGo.Location = new System.Drawing.Point(329, 294);
			this.butGo.Name = "butGo";
			this.butGo.Size = new System.Drawing.Size(75, 23);
			this.butGo.TabIndex = 0;
			this.butGo.Text = "Go!";
			this.butGo.UseVisualStyleBackColor = true;
			this.butGo.Click += new System.EventHandler(this.butGo_Click);
			// 
			// tpageGame
			// 
			this.tpageGame.BackColor = System.Drawing.SystemColors.Control;
			this.tpageGame.Controls.Add(this.tboxInfo);
			this.tpageGame.Controls.Add(this.lblCBox);
			this.tpageGame.Controls.Add(this.butRepos);
			this.tpageGame.Controls.Add(this.lblNoAlien);
			this.tpageGame.Controls.Add(this.lblShootWarn);
			this.tpageGame.Controls.Add(this.lblAreaName);
			this.tpageGame.Controls.Add(this.lblError);
			this.tpageGame.Controls.Add(this.lblAreasTotal);
			this.tpageGame.Controls.Add(this.lblAreasnum);
			this.tpageGame.Controls.Add(this.lblAreas);
			this.tpageGame.Controls.Add(this.butSearch);
			this.tpageGame.Controls.Add(this.gboxArea);
			this.tpageGame.Controls.Add(this.lblAliensTotal);
			this.tpageGame.Controls.Add(this.lblAliensNum);
			this.tpageGame.Controls.Add(this.lblAliens);
			this.tpageGame.Controls.Add(this.lblHPtotal);
			this.tpageGame.Controls.Add(this.lblHPnum);
			this.tpageGame.Controls.Add(this.lblHP);
			this.tpageGame.Controls.Add(this.butReset);
			this.tpageGame.Controls.Add(this.butShoot);
			this.tpageGame.Controls.Add(this.butNext);
			this.tpageGame.Controls.Add(this.butPrevious);
			this.tpageGame.Controls.Add(this.cboxWinds);
			this.tpageGame.Controls.Add(this.cboxCondit);
			this.tpageGame.Controls.Add(this.cboxWeapons);
			this.tpageGame.Controls.Add(this.cboxRounds);
			this.tpageGame.Controls.Add(this.cboxRange);
			this.tpageGame.Location = new System.Drawing.Point(4, 22);
			this.tpageGame.Name = "tpageGame";
			this.tpageGame.Padding = new System.Windows.Forms.Padding(3);
			this.tpageGame.Size = new System.Drawing.Size(475, 411);
			this.tpageGame.TabIndex = 1;
			this.tpageGame.Text = "Fight!";
			// 
			// tboxInfo
			// 
			this.tboxInfo.Location = new System.Drawing.Point(6, 303);
			this.tboxInfo.Multiline = true;
			this.tboxInfo.Name = "tboxInfo";
			this.tboxInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tboxInfo.Size = new System.Drawing.Size(463, 37);
			this.tboxInfo.TabIndex = 37;
			// 
			// lblCBox
			// 
			this.lblCBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.lblCBox.AutoSize = true;
			this.lblCBox.ForeColor = System.Drawing.Color.Red;
			this.lblCBox.Location = new System.Drawing.Point(171, 378);
			this.lblCBox.Name = "lblCBox";
			this.lblCBox.Size = new System.Drawing.Size(140, 13);
			this.lblCBox.TabIndex = 36;
			this.lblCBox.Text = "Please select from each box";
			this.lblCBox.Visible = false;
			// 
			// butRepos
			// 
			this.butRepos.Location = new System.Drawing.Point(394, 37);
			this.butRepos.Name = "butRepos";
			this.butRepos.Size = new System.Drawing.Size(75, 23);
			this.butRepos.TabIndex = 35;
			this.butRepos.Text = "Reposition";
			this.butRepos.UseVisualStyleBackColor = true;
			this.butRepos.Click += new System.EventHandler(this.butRepos_Click);
			// 
			// lblNoAlien
			// 
			this.lblNoAlien.AutoSize = true;
			this.lblNoAlien.ForeColor = System.Drawing.Color.Green;
			this.lblNoAlien.Location = new System.Drawing.Point(179, 264);
			this.lblNoAlien.Name = "lblNoAlien";
			this.lblNoAlien.Size = new System.Drawing.Size(126, 13);
			this.lblNoAlien.TabIndex = 34;
			this.lblNoAlien.Text = "There are no Aliens here.";
			this.lblNoAlien.Visible = false;
			// 
			// lblShootWarn
			// 
			this.lblShootWarn.AutoSize = true;
			this.lblShootWarn.ForeColor = System.Drawing.Color.Red;
			this.lblShootWarn.Location = new System.Drawing.Point(169, 279);
			this.lblShootWarn.Name = "lblShootWarn";
			this.lblShootWarn.Size = new System.Drawing.Size(155, 13);
			this.lblShootWarn.TabIndex = 33;
			this.lblShootWarn.Text = "Please select an Alien to shoot.";
			this.lblShootWarn.Visible = false;
			// 
			// lblAreaName
			// 
			this.lblAreaName.AutoSize = true;
			this.lblAreaName.Location = new System.Drawing.Point(208, 46);
			this.lblAreaName.Name = "lblAreaName";
			this.lblAreaName.Size = new System.Drawing.Size(60, 13);
			this.lblAreaName.TabIndex = 32;
			this.lblAreaName.Text = "Area Name";
			// 
			// lblError
			// 
			this.lblError.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.lblError.AutoSize = true;
			this.lblError.ForeColor = System.Drawing.Color.Red;
			this.lblError.Location = new System.Drawing.Point(162, 378);
			this.lblError.Name = "lblError";
			this.lblError.Size = new System.Drawing.Size(116, 13);
			this.lblError.TabIndex = 31;
			this.lblError.Text = "There are only 8 areas.";
			this.lblError.Visible = false;
			// 
			// lblAreasTotal
			// 
			this.lblAreasTotal.AutoSize = true;
			this.lblAreasTotal.Location = new System.Drawing.Point(290, 8);
			this.lblAreasTotal.Name = "lblAreasTotal";
			this.lblAreasTotal.Size = new System.Drawing.Size(21, 13);
			this.lblAreasTotal.TabIndex = 30;
			this.lblAreasTotal.Text = "/ 8";
			// 
			// lblAreasnum
			// 
			this.lblAreasnum.AutoSize = true;
			this.lblAreasnum.Location = new System.Drawing.Point(281, 8);
			this.lblAreasnum.Name = "lblAreasnum";
			this.lblAreasnum.Size = new System.Drawing.Size(13, 13);
			this.lblAreasnum.TabIndex = 29;
			this.lblAreasnum.Text = "1";
			// 
			// lblAreas
			// 
			this.lblAreas.AutoSize = true;
			this.lblAreas.Location = new System.Drawing.Point(194, 8);
			this.lblAreas.Name = "lblAreas";
			this.lblAreas.Size = new System.Drawing.Size(86, 13);
			this.lblAreas.TabIndex = 28;
			this.lblAreas.Text = "Areas Searched:";
			// 
			// butSearch
			// 
			this.butSearch.Location = new System.Drawing.Point(394, 275);
			this.butSearch.Name = "butSearch";
			this.butSearch.Size = new System.Drawing.Size(75, 23);
			this.butSearch.TabIndex = 26;
			this.butSearch.Text = "Search";
			this.butSearch.UseVisualStyleBackColor = true;
			this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
			// 
			// gboxArea
			// 
			this.gboxArea.Location = new System.Drawing.Point(6, 31);
			this.gboxArea.Name = "gboxArea";
			this.gboxArea.Size = new System.Drawing.Size(463, 266);
			this.gboxArea.TabIndex = 27;
			this.gboxArea.TabStop = false;
			this.gboxArea.Text = "Area 1";
			// 
			// lblAliensTotal
			// 
			this.lblAliensTotal.AutoSize = true;
			this.lblAliensTotal.ForeColor = System.Drawing.Color.Red;
			this.lblAliensTotal.Location = new System.Drawing.Point(451, 8);
			this.lblAliensTotal.Name = "lblAliensTotal";
			this.lblAliensTotal.Size = new System.Drawing.Size(21, 13);
			this.lblAliensTotal.TabIndex = 25;
			this.lblAliensTotal.Text = "/ 7";
			// 
			// lblAliensNum
			// 
			this.lblAliensNum.AutoSize = true;
			this.lblAliensNum.ForeColor = System.Drawing.Color.Red;
			this.lblAliensNum.Location = new System.Drawing.Point(442, 8);
			this.lblAliensNum.Name = "lblAliensNum";
			this.lblAliensNum.Size = new System.Drawing.Size(13, 13);
			this.lblAliensNum.TabIndex = 24;
			this.lblAliensNum.Text = "7";
			// 
			// lblAliens
			// 
			this.lblAliens.AutoSize = true;
			this.lblAliens.Location = new System.Drawing.Point(405, 8);
			this.lblAliens.Name = "lblAliens";
			this.lblAliens.Size = new System.Drawing.Size(38, 13);
			this.lblAliens.TabIndex = 23;
			this.lblAliens.Text = "Aliens:";
			// 
			// lblHPtotal
			// 
			this.lblHPtotal.AutoSize = true;
			this.lblHPtotal.ForeColor = System.Drawing.Color.Green;
			this.lblHPtotal.Location = new System.Drawing.Point(130, 9);
			this.lblHPtotal.Name = "lblHPtotal";
			this.lblHPtotal.Size = new System.Drawing.Size(24, 13);
			this.lblHPtotal.TabIndex = 22;
			this.lblHPtotal.Text = "/10";
			// 
			// lblHPnum
			// 
			this.lblHPnum.AutoSize = true;
			this.lblHPnum.ForeColor = System.Drawing.Color.Green;
			this.lblHPnum.Location = new System.Drawing.Point(115, 9);
			this.lblHPnum.Name = "lblHPnum";
			this.lblHPnum.Size = new System.Drawing.Size(19, 13);
			this.lblHPnum.TabIndex = 21;
			this.lblHPnum.Text = "10";
			// 
			// lblHP
			// 
			this.lblHP.AutoSize = true;
			this.lblHP.Location = new System.Drawing.Point(6, 8);
			this.lblHP.Name = "lblHP";
			this.lblHP.Size = new System.Drawing.Size(22, 13);
			this.lblHP.TabIndex = 20;
			this.lblHP.Text = "HP";
			// 
			// butReset
			// 
			this.butReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.butReset.Location = new System.Drawing.Point(394, 373);
			this.butReset.Name = "butReset";
			this.butReset.Size = new System.Drawing.Size(75, 23);
			this.butReset.TabIndex = 8;
			this.butReset.Text = "Reset";
			this.butReset.UseVisualStyleBackColor = true;
			this.butReset.Click += new System.EventHandler(this.butReset_Click);
			// 
			// butShoot
			// 
			this.butShoot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.butShoot.Location = new System.Drawing.Point(313, 373);
			this.butShoot.Name = "butShoot";
			this.butShoot.Size = new System.Drawing.Size(75, 23);
			this.butShoot.TabIndex = 7;
			this.butShoot.Text = "Shoot";
			this.butShoot.UseVisualStyleBackColor = true;
			this.butShoot.Click += new System.EventHandler(this.butShoot_Click);
			// 
			// butNext
			// 
			this.butNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.butNext.Location = new System.Drawing.Point(87, 373);
			this.butNext.Name = "butNext";
			this.butNext.Size = new System.Drawing.Size(75, 23);
			this.butNext.TabIndex = 6;
			this.butNext.Text = "Next";
			this.butNext.UseVisualStyleBackColor = true;
			this.butNext.Click += new System.EventHandler(this.butNext_Click);
			// 
			// butPrevious
			// 
			this.butPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.butPrevious.Location = new System.Drawing.Point(6, 373);
			this.butPrevious.Name = "butPrevious";
			this.butPrevious.Size = new System.Drawing.Size(75, 23);
			this.butPrevious.TabIndex = 5;
			this.butPrevious.Text = "Previous";
			this.butPrevious.UseVisualStyleBackColor = true;
			this.butPrevious.Click += new System.EventHandler(this.butPrevious_Click);
			// 
			// cboxWinds
			// 
			this.cboxWinds.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.cboxWinds.FormattingEnabled = true;
			this.cboxWinds.Items.AddRange(new object[] {
            "0 mph winds",
            "5 mph winds",
            "10 mph winds",
            "15 mph winds",
            "20 mph winds",
            "25 mph winds"});
			this.cboxWinds.Location = new System.Drawing.Point(378, 346);
			this.cboxWinds.Name = "cboxWinds";
			this.cboxWinds.Size = new System.Drawing.Size(91, 21);
			this.cboxWinds.TabIndex = 4;
			// 
			// cboxCondit
			// 
			this.cboxCondit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.cboxCondit.FormattingEnabled = true;
			this.cboxCondit.Items.AddRange(new object[] {
            "Clear day",
            "Clear night",
            "Dusk",
            "Fog",
            "Smoke"});
			this.cboxCondit.Location = new System.Drawing.Point(285, 346);
			this.cboxCondit.Name = "cboxCondit";
			this.cboxCondit.Size = new System.Drawing.Size(91, 21);
			this.cboxCondit.TabIndex = 3;
			// 
			// cboxWeapons
			// 
			this.cboxWeapons.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.cboxWeapons.FormattingEnabled = true;
			this.cboxWeapons.Items.AddRange(new object[] {
            "Six-Shooter",
            "Rifle",
            "Spear",
            "Alien Gauntlet"});
			this.cboxWeapons.Location = new System.Drawing.Point(6, 346);
			this.cboxWeapons.Name = "cboxWeapons";
			this.cboxWeapons.Size = new System.Drawing.Size(91, 21);
			this.cboxWeapons.TabIndex = 2;
			// 
			// cboxRounds
			// 
			this.cboxRounds.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.cboxRounds.FormattingEnabled = true;
			this.cboxRounds.Items.AddRange(new object[] {
            "1 round",
            "2 rounds",
            "3 rounds",
            "4 rounds",
            "5 rounds"});
			this.cboxRounds.Location = new System.Drawing.Point(99, 346);
			this.cboxRounds.Name = "cboxRounds";
			this.cboxRounds.Size = new System.Drawing.Size(91, 21);
			this.cboxRounds.TabIndex = 1;
			// 
			// cboxRange
			// 
			this.cboxRange.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.cboxRange.FormattingEnabled = true;
			this.cboxRange.Items.AddRange(new object[] {
            "5 yards",
            "25 yards",
            "50 yards",
            "100 yards",
            "500 yards",
            "1000 yards"});
			this.cboxRange.Location = new System.Drawing.Point(192, 346);
			this.cboxRange.Name = "cboxRange";
			this.cboxRange.Size = new System.Drawing.Size(91, 21);
			this.cboxRange.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(507, 460);
			this.Controls.Add(this.tcontrolAliens);
			this.MaximumSize = new System.Drawing.Size(523, 499);
			this.MinimumSize = new System.Drawing.Size(523, 499);
			this.Name = "Form1";
			this.Text = "LeVeeP5 by Angela LeVee";
			this.tcontrolAliens.ResumeLayout(false);
			this.tpageMission.ResumeLayout(false);
			this.tpageMission.PerformLayout();
			this.tpageGame.ResumeLayout(false);
			this.tpageGame.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcontrolAliens;
        private System.Windows.Forms.TabPage tpageMission;
        private System.Windows.Forms.Button butGo;
        private System.Windows.Forms.TabPage tpageGame;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblInvade;
        private System.Windows.Forms.Label lblAccept;
        private System.Windows.Forms.TextBox tboxHero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cboxWinds;
        private System.Windows.Forms.ComboBox cboxCondit;
        private System.Windows.Forms.ComboBox cboxWeapons;
        private System.Windows.Forms.ComboBox cboxRounds;
        private System.Windows.Forms.ComboBox cboxRange;
        private System.Windows.Forms.Button butReset;
        private System.Windows.Forms.Button butShoot;
        private System.Windows.Forms.Button butNext;
        private System.Windows.Forms.Button butPrevious;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.Label lblAliensTotal;
        private System.Windows.Forms.Label lblAliensNum;
        private System.Windows.Forms.Label lblAliens;
        private System.Windows.Forms.Label lblHPtotal;
        private System.Windows.Forms.Label lblHPnum;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.Label lblAreasTotal;
        private System.Windows.Forms.Label lblAreasnum;
        private System.Windows.Forms.Label lblAreas;
        private System.Windows.Forms.GroupBox gboxArea;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblAreaName;
        private System.Windows.Forms.Label lblShootWarn;
        private System.Windows.Forms.Label lblNoAlien;
        private System.Windows.Forms.Button butRepos;
        private System.Windows.Forms.ToolTip ttipReposition;
        private System.Windows.Forms.Label lblCBox;
        private System.Windows.Forms.TextBox tboxInfo;
    }
}

