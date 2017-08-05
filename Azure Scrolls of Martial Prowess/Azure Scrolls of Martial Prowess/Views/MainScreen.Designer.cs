namespace Azure_Scrolls_of_Martial_Prowess
{
    partial class MainScreen
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
            this.CombatScreen = new System.Windows.Forms.GroupBox();
            this.Combat_Table = new System.Windows.Forms.TableLayoutPanel();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CharacterFocus = new System.Windows.Forms.GroupBox();
            this.HealthLevels = new System.Windows.Forms.GroupBox();
            this.HealthLevelTable = new System.Windows.Forms.TableLayoutPanel();
            this.Effects = new System.Windows.Forms.GroupBox();
            this.EffectsTablePanel = new System.Windows.Forms.Panel();
            this.EffectsTable = new System.Windows.Forms.TableLayoutPanel();
            this.Button_AddEffect = new System.Windows.Forms.Button();
            this.Label_PersonalEssence = new System.Windows.Forms.Label();
            this.Label_PeripheralEssence = new System.Windows.Forms.Label();
            this.Label_Willpower = new System.Windows.Forms.Label();
            this.Label_Anima = new System.Windows.Forms.Label();
            this.PersonalEssence = new System.Windows.Forms.NumericUpDown();
            this.PeripheralEssence = new System.Windows.Forms.NumericUpDown();
            this.Willpower = new System.Windows.Forms.NumericUpDown();
            this.Anima = new System.Windows.Forms.NumericUpDown();
            this.Label_Initiative = new System.Windows.Forms.Label();
            this.Initiative = new System.Windows.Forms.NumericUpDown();
            this.Name = new System.Windows.Forms.TextBox();
            this.Type = new System.Windows.Forms.TextBox();
            this.Portrait = new System.Windows.Forms.PictureBox();
            this.Button_NextRound = new System.Windows.Forms.Button();
            this.Button_AddCharacter = new System.Windows.Forms.Button();
            this.CombatScreen.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.CharacterFocus.SuspendLayout();
            this.HealthLevels.SuspendLayout();
            this.Effects.SuspendLayout();
            this.EffectsTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonalEssence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeripheralEssence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Willpower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Anima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Initiative)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Portrait)).BeginInit();
            this.SuspendLayout();
            // 
            // CombatScreen
            // 
            this.CombatScreen.AutoSize = true;
            this.CombatScreen.Controls.Add(this.Combat_Table);
            this.CombatScreen.Location = new System.Drawing.Point(10, 25);
            this.CombatScreen.Name = "CombatScreen";
            this.CombatScreen.Size = new System.Drawing.Size(366, 457);
            this.CombatScreen.TabIndex = 0;
            this.CombatScreen.TabStop = false;
            this.CombatScreen.Text = "CombatScreen";
            // 
            // Combat_Table
            // 
            this.Combat_Table.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Combat_Table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.Combat_Table.ColumnCount = 3;
            this.Combat_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.Combat_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.Combat_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.Combat_Table.Location = new System.Drawing.Point(6, 20);
            this.Combat_Table.Name = "Combat_Table";
            this.Combat_Table.RowCount = 1;
            this.Combat_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.Combat_Table.Size = new System.Drawing.Size(351, 46);
            this.Combat_Table.TabIndex = 0;
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(828, 24);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.newToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.openToolStripMenuItem.Text = "open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.saveToolStripMenuItem.Text = "save";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.newToolStripMenuItem.Text = "new";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // CharacterFocus
            // 
            this.CharacterFocus.Controls.Add(this.HealthLevels);
            this.CharacterFocus.Controls.Add(this.Effects);
            this.CharacterFocus.Controls.Add(this.Label_PersonalEssence);
            this.CharacterFocus.Controls.Add(this.Label_PeripheralEssence);
            this.CharacterFocus.Controls.Add(this.Label_Willpower);
            this.CharacterFocus.Controls.Add(this.Label_Anima);
            this.CharacterFocus.Controls.Add(this.PersonalEssence);
            this.CharacterFocus.Controls.Add(this.PeripheralEssence);
            this.CharacterFocus.Controls.Add(this.Willpower);
            this.CharacterFocus.Controls.Add(this.Anima);
            this.CharacterFocus.Controls.Add(this.Label_Initiative);
            this.CharacterFocus.Controls.Add(this.Initiative);
            this.CharacterFocus.Controls.Add(this.Name);
            this.CharacterFocus.Controls.Add(this.Type);
            this.CharacterFocus.Controls.Add(this.Portrait);
            this.CharacterFocus.Location = new System.Drawing.Point(382, 25);
            this.CharacterFocus.Name = "CharacterFocus";
            this.CharacterFocus.Size = new System.Drawing.Size(318, 548);
            this.CharacterFocus.TabIndex = 2;
            this.CharacterFocus.TabStop = false;
            this.CharacterFocus.Text = "Focus";
            // 
            // HealthLevels
            // 
            this.HealthLevels.Controls.Add(this.HealthLevelTable);
            this.HealthLevels.Location = new System.Drawing.Point(6, 246);
            this.HealthLevels.Name = "HealthLevels";
            this.HealthLevels.Size = new System.Drawing.Size(299, 69);
            this.HealthLevels.TabIndex = 14;
            this.HealthLevels.TabStop = false;
            this.HealthLevels.Text = "Health Levels";
            // 
            // HealthLevelTable
            // 
            this.HealthLevelTable.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HealthLevelTable.ColumnCount = 2;
            this.HealthLevelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HealthLevelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HealthLevelTable.Location = new System.Drawing.Point(10, 19);
            this.HealthLevelTable.Name = "HealthLevelTable";
            this.HealthLevelTable.RowCount = 2;
            this.HealthLevelTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HealthLevelTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HealthLevelTable.Size = new System.Drawing.Size(283, 44);
            this.HealthLevelTable.TabIndex = 0;
            // 
            // Effects
            // 
            this.Effects.Controls.Add(this.EffectsTablePanel);
            this.Effects.Controls.Add(this.Button_AddEffect);
            this.Effects.Location = new System.Drawing.Point(6, 321);
            this.Effects.Name = "Effects";
            this.Effects.Size = new System.Drawing.Size(299, 194);
            this.Effects.TabIndex = 16;
            this.Effects.TabStop = false;
            this.Effects.Text = "Effects";
            // 
            // EffectsTablePanel
            // 
            this.EffectsTablePanel.Controls.Add(this.EffectsTable);
            this.EffectsTablePanel.Location = new System.Drawing.Point(6, 19);
            this.EffectsTablePanel.Name = "EffectsTablePanel";
            this.EffectsTablePanel.Size = new System.Drawing.Size(287, 126);
            this.EffectsTablePanel.TabIndex = 0;
            // 
            // EffectsTable
            // 
            this.EffectsTable.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EffectsTable.ColumnCount = 2;
            this.EffectsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EffectsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EffectsTable.Location = new System.Drawing.Point(7, 13);
            this.EffectsTable.Name = "EffectsTable";
            this.EffectsTable.RowCount = 2;
            this.EffectsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.61905F));
            this.EffectsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.38095F));
            this.EffectsTable.Size = new System.Drawing.Size(268, 31);
            this.EffectsTable.TabIndex = 0;
            // 
            // Button_AddEffect
            // 
            this.Button_AddEffect.Location = new System.Drawing.Point(218, 165);
            this.Button_AddEffect.Name = "Button_AddEffect";
            this.Button_AddEffect.Size = new System.Drawing.Size(75, 23);
            this.Button_AddEffect.TabIndex = 15;
            this.Button_AddEffect.Text = "AddEffect";
            this.Button_AddEffect.UseVisualStyleBackColor = true;
            // 
            // Label_PersonalEssence
            // 
            this.Label_PersonalEssence.AutoSize = true;
            this.Label_PersonalEssence.Location = new System.Drawing.Point(13, 196);
            this.Label_PersonalEssence.Name = "Label_PersonalEssence";
            this.Label_PersonalEssence.Size = new System.Drawing.Size(92, 13);
            this.Label_PersonalEssence.TabIndex = 10;
            this.Label_PersonalEssence.Text = "Personal Essence";
            // 
            // Label_PeripheralEssence
            // 
            this.Label_PeripheralEssence.AutoSize = true;
            this.Label_PeripheralEssence.Location = new System.Drawing.Point(16, 221);
            this.Label_PeripheralEssence.Name = "Label_PeripheralEssence";
            this.Label_PeripheralEssence.Size = new System.Drawing.Size(98, 13);
            this.Label_PeripheralEssence.TabIndex = 11;
            this.Label_PeripheralEssence.Text = "Peripheral Essence";
            // 
            // Label_Willpower
            // 
            this.Label_Willpower.AutoSize = true;
            this.Label_Willpower.Location = new System.Drawing.Point(187, 195);
            this.Label_Willpower.Name = "Label_Willpower";
            this.Label_Willpower.Size = new System.Drawing.Size(53, 13);
            this.Label_Willpower.TabIndex = 12;
            this.Label_Willpower.Text = "Willpower";
            // 
            // Label_Anima
            // 
            this.Label_Anima.AutoSize = true;
            this.Label_Anima.Location = new System.Drawing.Point(187, 221);
            this.Label_Anima.Name = "Label_Anima";
            this.Label_Anima.Size = new System.Drawing.Size(36, 13);
            this.Label_Anima.TabIndex = 13;
            this.Label_Anima.Text = "Anima";
            // 
            // PersonalEssence
            // 
            this.PersonalEssence.Location = new System.Drawing.Point(111, 193);
            this.PersonalEssence.Name = "PersonalEssence";
            this.PersonalEssence.Size = new System.Drawing.Size(70, 20);
            this.PersonalEssence.TabIndex = 6;
            // 
            // PeripheralEssence
            // 
            this.PeripheralEssence.Location = new System.Drawing.Point(111, 219);
            this.PeripheralEssence.Name = "PeripheralEssence";
            this.PeripheralEssence.Size = new System.Drawing.Size(70, 20);
            this.PeripheralEssence.TabIndex = 8;
            // 
            // Willpower
            // 
            this.Willpower.Location = new System.Drawing.Point(250, 188);
            this.Willpower.Name = "Willpower";
            this.Willpower.Size = new System.Drawing.Size(37, 20);
            this.Willpower.TabIndex = 7;
            // 
            // Anima
            // 
            this.Anima.Location = new System.Drawing.Point(250, 219);
            this.Anima.Name = "Anima";
            this.Anima.Size = new System.Drawing.Size(37, 20);
            this.Anima.TabIndex = 9;
            // 
            // Label_Initiative
            // 
            this.Label_Initiative.AutoSize = true;
            this.Label_Initiative.Location = new System.Drawing.Point(16, 83);
            this.Label_Initiative.Name = "Label_Initiative";
            this.Label_Initiative.Size = new System.Drawing.Size(83, 13);
            this.Label_Initiative.TabIndex = 5;
            this.Label_Initiative.Text = "Current Initiative";
            // 
            // Initiative
            // 
            this.Initiative.Location = new System.Drawing.Point(105, 81);
            this.Initiative.Name = "Initiative";
            this.Initiative.Size = new System.Drawing.Size(76, 20);
            this.Initiative.TabIndex = 4;
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(7, 20);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(100, 20);
            this.Name.TabIndex = 3;
            // 
            // Type
            // 
            this.Type.Location = new System.Drawing.Point(6, 46);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(100, 20);
            this.Type.TabIndex = 2;
            // 
            // Portrait
            // 
            this.Portrait.BackColor = System.Drawing.SystemColors.Window;
            this.Portrait.Location = new System.Drawing.Point(187, 19);
            this.Portrait.Name = "Portrait";
            this.Portrait.Size = new System.Drawing.Size(100, 116);
            this.Portrait.TabIndex = 0;
            this.Portrait.TabStop = false;
            // 
            // Button_NextRound
            // 
            this.Button_NextRound.Location = new System.Drawing.Point(16, 502);
            this.Button_NextRound.Name = "Button_NextRound";
            this.Button_NextRound.Size = new System.Drawing.Size(75, 23);
            this.Button_NextRound.TabIndex = 3;
            this.Button_NextRound.Text = "Next Round";
            this.Button_NextRound.UseVisualStyleBackColor = true;
            this.Button_NextRound.Click += new System.EventHandler(this.Button_NextRound_Click);
            // 
            // Button_AddCharacter
            // 
            this.Button_AddCharacter.Location = new System.Drawing.Point(260, 501);
            this.Button_AddCharacter.Name = "Button_AddCharacter";
            this.Button_AddCharacter.Size = new System.Drawing.Size(75, 23);
            this.Button_AddCharacter.TabIndex = 4;
            this.Button_AddCharacter.Text = "+";
            this.Button_AddCharacter.UseVisualStyleBackColor = true;
            this.Button_AddCharacter.Click += new System.EventHandler(this.Button_AddCharacter_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 585);
            this.Controls.Add(this.Button_AddCharacter);
            this.Controls.Add(this.Button_NextRound);
            this.Controls.Add(this.CharacterFocus);
            this.Controls.Add(this.CombatScreen);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            //this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.CombatScreen.ResumeLayout(false);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.CharacterFocus.ResumeLayout(false);
            this.CharacterFocus.PerformLayout();
            this.HealthLevels.ResumeLayout(false);
            this.Effects.ResumeLayout(false);
            this.EffectsTablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PersonalEssence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeripheralEssence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Willpower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Anima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Initiative)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Portrait)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox CombatScreen;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.GroupBox CharacterFocus;
        private System.Windows.Forms.PictureBox Portrait;
        private System.Windows.Forms.Label Label_Initiative;
        private System.Windows.Forms.NumericUpDown Initiative;
        private System.Windows.Forms.TextBox Type;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.NumericUpDown Anima;
        private System.Windows.Forms.NumericUpDown PeripheralEssence;
        private System.Windows.Forms.NumericUpDown Willpower;
        private System.Windows.Forms.NumericUpDown PersonalEssence;
        private System.Windows.Forms.TableLayoutPanel Combat_Table;
        private System.Windows.Forms.GroupBox Effects;
        private System.Windows.Forms.Button Button_AddEffect;
        private System.Windows.Forms.Label Label_Anima;
        private System.Windows.Forms.Label Label_Willpower;
        private System.Windows.Forms.Label Label_PeripheralEssence;
        private System.Windows.Forms.Label Label_PersonalEssence;
        private System.Windows.Forms.GroupBox HealthLevels;
        private System.Windows.Forms.Button Button_NextRound;
        private System.Windows.Forms.Button Button_AddCharacter;
        private System.Windows.Forms.TableLayoutPanel EffectsTable;
        private System.Windows.Forms.TableLayoutPanel HealthLevelTable;
        private System.Windows.Forms.Panel EffectsTablePanel;
    }
}