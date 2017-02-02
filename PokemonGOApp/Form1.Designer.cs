namespace PokemonGOApp
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Output1 = new System.Windows.Forms.Label();
            this.Equals1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.pokemon1 = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(474, 341);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Output1);
            this.tabPage1.Controls.Add(this.Equals1);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.pokemon1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(466, 315);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Output1
            // 
            this.Output1.AutoSize = true;
            this.Output1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output1.Location = new System.Drawing.Point(376, 10);
            this.Output1.Name = "Output1";
            this.Output1.Size = new System.Drawing.Size(24, 25);
            this.Output1.TabIndex = 3;
            this.Output1.Text = "0";
            this.Output1.Click += new System.EventHandler(this.Output1_Click);
            // 
            // Equals1
            // 
            this.Equals1.AutoSize = true;
            this.Equals1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equals1.Location = new System.Drawing.Point(346, 10);
            this.Equals1.Name = "Equals1";
            this.Equals1.Size = new System.Drawing.Size(24, 25);
            this.Equals1.TabIndex = 2;
            this.Equals1.Text = "=";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(223, 7);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(117, 31);
            this.numericUpDown1.TabIndex = 1;
            // 
            // pokemon1
            // 
            this.pokemon1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pokemon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pokemon1.FormattingEnabled = true;
            this.pokemon1.Items.AddRange(new object[] {
            " #001\tBulbasaur",
            " #002\tIvysaur",
            " #003\tVenusaur",
            " #004\tCharmander",
            " #005\tCharmeleon",
            " #006\tCharizard",
            " #007\tSquirtle",
            " #008\tWartortle",
            " #009\tBlastoise",
            " #010\tCaterpie",
            " #011\tMetapod",
            " #012\tButterfree",
            " #013\tWeedle",
            " #014\tKakuna",
            " #015\tBeedrill",
            " #016\tPidgey",
            " #017\tPidgeotto",
            " #018\tPidgeot",
            " #019\tRattata",
            " #020\tRaticate",
            " #021\tSpearow",
            " #022\tFearow",
            " #023\tEkans",
            " #024\tArbok",
            " #025\tPikachu",
            " #026\tRaichu",
            " #027\tSandshrew",
            " #028\tSandslash",
            " #029\tNidoran♀",
            " #030\tNidorina",
            " #031\tNidoqueen",
            " #032\tNidoran♂",
            " #033\tNidorino",
            " #034\tNidoking",
            " #035\tClefairy",
            " #036\tClefable",
            " #037\tVulpix",
            " #038\tNinetales",
            " #039\tJigglypuff",
            " #040\tWigglytuff",
            " #041\tZubat",
            " #042\tGolbat",
            " #043\tOddish",
            " #044\tGloom",
            " #045\tVileplume",
            " #046\tParas",
            " #047\tParasect",
            " #048\tVenonat",
            " #049\tVenomoth",
            " #050\tDiglett",
            " #051\tDugtrio",
            " #052\tMeowth",
            " #053\tPersian",
            " #054\tPsyduck",
            " #055\tGolduck",
            " #056\tMankey",
            " #057\tPrimeape",
            " #058\tGrowlithe",
            " #059\tArcanine",
            " #060\tPoliwag",
            " #061\tPoliwhirl",
            " #062\tPoliwrath",
            " #063\tAbra",
            " #064\tKadabra",
            " #065\tAlakazam",
            " #066\tMachop",
            " #067\tMachoke",
            " #068\tMachamp",
            " #069\tBellsprout",
            " #070\tWeepinbell",
            " #071\tVictreebel",
            " #072\tTentacool",
            " #073\tTentacruel",
            " #074\tGeodude",
            " #075\tGraveler",
            " #076\tGolem",
            " #077\tPonyta",
            " #078\tRapidash",
            " #079\tSlowpoke",
            " #080\tSlowbro",
            " #081\tMagnemite",
            " #082\tMagneton",
            " #083\tFarfetch\'d",
            " #084\tDoduo",
            " #085\tDodrio",
            " #086\tSeel",
            " #087\tDewgong",
            " #088\tGrimer",
            " #089\tMuk",
            " #090\tShellder",
            " #091\tCloyster",
            " #092\tGastly",
            " #093\tHaunter",
            " #094\tGengar",
            " #095\tOnix",
            " #096\tDrowzee",
            " #097\tHypno",
            " #098\tKrabby",
            " #099\tKingler",
            " #100\tVoltorb",
            " #101\tElectrode",
            " #102\tExeggcute",
            " #103\tExeggutor",
            " #104\tCubone",
            " #105\tMarowak",
            " #106\tHitmonlee",
            " #107\tHitmonchan",
            " #108\tLickitung",
            " #109\tKoffing",
            " #110\tWeezing",
            " #111\tRhyhorn",
            " #112\tRhydon",
            " #113\tChansey",
            " #114\tTangela",
            " #115\tKangaskhan",
            " #116\tHorsea",
            " #117\tSeadra",
            " #118\tGoldeen",
            " #119\tSeaking",
            " #120\tStaryu",
            " #121\tStarmie",
            " #122\tMr. Mime",
            " #123\tScyther",
            " #124\tJynx",
            " #125\tElectabuzz",
            " #126\tMagmar",
            " #127\tPinsir",
            " #128\tTauros",
            " #129\tMagikarp",
            " #130\tGyarados",
            " #131\tLapras",
            " #132\tDitto",
            " #133\tEevee",
            " #134\tVaporeon",
            " #135\tJolteon",
            " #136\tFlareon",
            " #137\tPorygon",
            " #138\tOmanyte",
            " #139\tOmastar",
            " #140\tKabuto",
            " #141\tKabutops",
            " #142\tAerodactyl",
            " #143\tSnorlax",
            " #144\tArticuno",
            " #145\tZapdos",
            " #146\tMoltres",
            " #147\tDratini",
            " #148\tDragonair",
            " #149\tDragonite",
            " #150\tMewtwo",
            " #151\tMew"});
            this.pokemon1.Location = new System.Drawing.Point(7, 7);
            this.pokemon1.Name = "pokemon1";
            this.pokemon1.Size = new System.Drawing.Size(210, 33);
            this.pokemon1.TabIndex = 0;
            this.pokemon1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(466, 315);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 363);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox pokemon1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label Output1;
        private System.Windows.Forms.Label Equals1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

