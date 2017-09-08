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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CombatScreen = new System.Windows.Forms.GroupBox();
            this.CombatTablePanel = new System.Windows.Forms.Panel();
            this.dataGridView_CombatTable = new System.Windows.Forms.DataGridView();
            this.InitiativeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParticipantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParticipantDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HasActedColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CharacterFocus = new System.Windows.Forms.GroupBox();
            this.checkBox_Focus_KeepOnslaught = new System.Windows.Forms.CheckBox();
            this.label_Onslaught = new System.Windows.Forms.Label();
            this.numericUpDown_Focus_Onslaught = new System.Windows.Forms.NumericUpDown();
            this.comboBox_Focus_Anima = new System.Windows.Forms.ComboBox();
            this.Button_Refresh_Character = new System.Windows.Forms.Button();
            this.HealthLevels = new System.Windows.Forms.GroupBox();
            this.dataGridView_Focus_HealthLevels = new System.Windows.Forms.DataGridView();
            this.Effects = new System.Windows.Forms.GroupBox();
            this.EffectsTablePanel = new System.Windows.Forms.Panel();
            this.dataGridView_Focus_Effects = new System.Windows.Forms.DataGridView();
            this.EffectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EffectDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EffectTurnsRemaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Button_AddEffect = new System.Windows.Forms.Button();
            this.Label_PersonalEssence = new System.Windows.Forms.Label();
            this.Label_PeripheralEssence = new System.Windows.Forms.Label();
            this.Label_Willpower = new System.Windows.Forms.Label();
            this.Label_Anima = new System.Windows.Forms.Label();
            this.numericUpDown_Focus_PersonalEssence = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Focus_PeripheralEssence = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Focus_Willpower = new System.Windows.Forms.NumericUpDown();
            this.Label_Initiative = new System.Windows.Forms.Label();
            this.numericUpDown_Focus_Initiative = new System.Windows.Forms.NumericUpDown();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.Type = new System.Windows.Forms.TextBox();
            this.Portrait = new System.Windows.Forms.PictureBox();
            this.Button_NextRound = new System.Windows.Forms.Button();
            this.Button_AddCharacter = new System.Windows.Forms.Button();
            this.Button_Refresh = new System.Windows.Forms.Button();
            this.CombatScreen.SuspendLayout();
            this.CombatTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CombatTable)).BeginInit();
            this.MainMenu.SuspendLayout();
            this.CharacterFocus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Focus_Onslaught)).BeginInit();
            this.HealthLevels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Focus_HealthLevels)).BeginInit();
            this.Effects.SuspendLayout();
            this.EffectsTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Focus_Effects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Focus_PersonalEssence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Focus_PeripheralEssence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Focus_Willpower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Focus_Initiative)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Portrait)).BeginInit();
            this.SuspendLayout();
            // 
            // CombatScreen
            // 
            this.CombatScreen.AutoSize = true;
            this.CombatScreen.Controls.Add(this.CombatTablePanel);
            this.CombatScreen.Location = new System.Drawing.Point(10, 25);
            this.CombatScreen.Name = "CombatScreen";
            this.CombatScreen.Size = new System.Drawing.Size(606, 592);
            this.CombatScreen.TabIndex = 0;
            this.CombatScreen.TabStop = false;
            this.CombatScreen.Text = "CombatScreen";
            // 
            // CombatTablePanel
            // 
            this.CombatTablePanel.AutoScroll = true;
            this.CombatTablePanel.Controls.Add(this.dataGridView_CombatTable);
            this.CombatTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CombatTablePanel.Location = new System.Drawing.Point(3, 16);
            this.CombatTablePanel.Name = "CombatTablePanel";
            this.CombatTablePanel.Size = new System.Drawing.Size(600, 573);
            this.CombatTablePanel.TabIndex = 1;
            // 
            // dataGridView_CombatTable
            // 
            this.dataGridView_CombatTable.AllowUserToAddRows = false;
            this.dataGridView_CombatTable.AllowUserToDeleteRows = false;
            this.dataGridView_CombatTable.AllowUserToResizeColumns = false;
            this.dataGridView_CombatTable.AllowUserToResizeRows = false;
            this.dataGridView_CombatTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_CombatTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView_CombatTable.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView_CombatTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_CombatTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView_CombatTable.ColumnHeadersHeight = 25;
            this.dataGridView_CombatTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_CombatTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InitiativeColumn,
            this.ParticipantName,
            this.ParticipantDetails,
            this.HasActedColumn});
            this.dataGridView_CombatTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_CombatTable.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView_CombatTable.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_CombatTable.Name = "dataGridView_CombatTable";
            this.dataGridView_CombatTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_CombatTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView_CombatTable.RowHeadersVisible = false;
            this.dataGridView_CombatTable.RowHeadersWidth = 40;
            this.dataGridView_CombatTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_CombatTable.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView_CombatTable.RowTemplate.Height = 25;
            this.dataGridView_CombatTable.Size = new System.Drawing.Size(600, 573);
            this.dataGridView_CombatTable.TabIndex = 1;
            // 
            // InitiativeColumn
            // 
            this.InitiativeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.InitiativeColumn.HeaderText = "Initiative";
            this.InitiativeColumn.Name = "InitiativeColumn";
            this.InitiativeColumn.Width = 71;
            // 
            // ParticipantName
            // 
            this.ParticipantName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ParticipantName.HeaderText = "Name";
            this.ParticipantName.Name = "ParticipantName";
            this.ParticipantName.Width = 60;
            // 
            // ParticipantDetails
            // 
            this.ParticipantDetails.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ParticipantDetails.HeaderText = "Details";
            this.ParticipantDetails.Name = "ParticipantDetails";
            // 
            // HasActedColumn
            // 
            this.HasActedColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.HasActedColumn.HeaderText = "Acted?";
            this.HasActedColumn.Name = "HasActedColumn";
            this.HasActedColumn.Width = 47;
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1010, 24);
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
            this.CharacterFocus.Controls.Add(this.checkBox_Focus_KeepOnslaught);
            this.CharacterFocus.Controls.Add(this.label_Onslaught);
            this.CharacterFocus.Controls.Add(this.numericUpDown_Focus_Onslaught);
            this.CharacterFocus.Controls.Add(this.comboBox_Focus_Anima);
            this.CharacterFocus.Controls.Add(this.Button_Refresh_Character);
            this.CharacterFocus.Controls.Add(this.HealthLevels);
            this.CharacterFocus.Controls.Add(this.Effects);
            this.CharacterFocus.Controls.Add(this.Label_PersonalEssence);
            this.CharacterFocus.Controls.Add(this.Label_PeripheralEssence);
            this.CharacterFocus.Controls.Add(this.Label_Willpower);
            this.CharacterFocus.Controls.Add(this.Label_Anima);
            this.CharacterFocus.Controls.Add(this.numericUpDown_Focus_PersonalEssence);
            this.CharacterFocus.Controls.Add(this.numericUpDown_Focus_PeripheralEssence);
            this.CharacterFocus.Controls.Add(this.numericUpDown_Focus_Willpower);
            this.CharacterFocus.Controls.Add(this.Label_Initiative);
            this.CharacterFocus.Controls.Add(this.numericUpDown_Focus_Initiative);
            this.CharacterFocus.Controls.Add(this.textBox_name);
            this.CharacterFocus.Controls.Add(this.Type);
            this.CharacterFocus.Controls.Add(this.Portrait);
            this.CharacterFocus.Location = new System.Drawing.Point(622, 27);
            this.CharacterFocus.Name = "CharacterFocus";
            this.CharacterFocus.Size = new System.Drawing.Size(376, 628);
            this.CharacterFocus.TabIndex = 2;
            this.CharacterFocus.TabStop = false;
            this.CharacterFocus.Text = "Focus";
            // 
            // checkBox_Focus_KeepOnslaught
            // 
            this.checkBox_Focus_KeepOnslaught.AutoSize = true;
            this.checkBox_Focus_KeepOnslaught.Location = new System.Drawing.Point(105, 124);
            this.checkBox_Focus_KeepOnslaught.Name = "checkBox_Focus_KeepOnslaught";
            this.checkBox_Focus_KeepOnslaught.Size = new System.Drawing.Size(102, 17);
            this.checkBox_Focus_KeepOnslaught.TabIndex = 21;
            this.checkBox_Focus_KeepOnslaught.Text = "Keep Onslaught";
            this.checkBox_Focus_KeepOnslaught.UseVisualStyleBackColor = true;
            this.checkBox_Focus_KeepOnslaught.CheckedChanged += new System.EventHandler(this.checkBox_Focus_KeepOnslaught_CheckedChanged);
            // 
            // label_Onslaught
            // 
            this.label_Onslaught.AutoSize = true;
            this.label_Onslaught.Location = new System.Drawing.Point(6, 99);
            this.label_Onslaught.Name = "label_Onslaught";
            this.label_Onslaught.Size = new System.Drawing.Size(55, 13);
            this.label_Onslaught.TabIndex = 20;
            this.label_Onslaught.Text = "Onslaught";
            // 
            // numericUpDown_Focus_Onslaught
            // 
            this.numericUpDown_Focus_Onslaught.Location = new System.Drawing.Point(105, 97);
            this.numericUpDown_Focus_Onslaught.Name = "numericUpDown_Focus_Onslaught";
            this.numericUpDown_Focus_Onslaught.Size = new System.Drawing.Size(76, 20);
            this.numericUpDown_Focus_Onslaught.TabIndex = 19;
            this.numericUpDown_Focus_Onslaught.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_Focus_Onslaught.ValueChanged += new System.EventHandler(this.numericUpDown_Focus_Onslaught_ValueChanged);
            // 
            // comboBox_Focus_Anima
            // 
            this.comboBox_Focus_Anima.FormattingEnabled = true;
            this.comboBox_Focus_Anima.Items.AddRange(new object[] {
            "Dim",
            "Glowing",
            "Burning",
            "Bonfire"});
            this.comboBox_Focus_Anima.Location = new System.Drawing.Point(105, 147);
            this.comboBox_Focus_Anima.MaxDropDownItems = 4;
            this.comboBox_Focus_Anima.Name = "comboBox_Focus_Anima";
            this.comboBox_Focus_Anima.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Focus_Anima.TabIndex = 18;
            this.comboBox_Focus_Anima.Text = "Dim";
            // 
            // Button_Refresh_Character
            // 
            this.Button_Refresh_Character.Location = new System.Drawing.Point(6, 596);
            this.Button_Refresh_Character.Name = "Button_Refresh_Character";
            this.Button_Refresh_Character.Size = new System.Drawing.Size(75, 23);
            this.Button_Refresh_Character.TabIndex = 17;
            this.Button_Refresh_Character.Text = "Refresh Focus";
            this.Button_Refresh_Character.UseVisualStyleBackColor = true;
            this.Button_Refresh_Character.Click += new System.EventHandler(this.Button_Refresh_Character_Click);
            // 
            // HealthLevels
            // 
            this.HealthLevels.Controls.Add(this.dataGridView_Focus_HealthLevels);
            this.HealthLevels.Location = new System.Drawing.Point(6, 246);
            this.HealthLevels.Name = "HealthLevels";
            this.HealthLevels.Size = new System.Drawing.Size(364, 94);
            this.HealthLevels.TabIndex = 14;
            this.HealthLevels.TabStop = false;
            this.HealthLevels.Text = "Health Levels";
            // 
            // dataGridView_Focus_HealthLevels
            // 
            this.dataGridView_Focus_HealthLevels.AllowUserToAddRows = false;
            this.dataGridView_Focus_HealthLevels.AllowUserToDeleteRows = false;
            this.dataGridView_Focus_HealthLevels.AllowUserToResizeColumns = false;
            this.dataGridView_Focus_HealthLevels.AllowUserToResizeRows = false;
            this.dataGridView_Focus_HealthLevels.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Focus_HealthLevels.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Focus_HealthLevels.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView_Focus_HealthLevels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Focus_HealthLevels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Focus_HealthLevels.Location = new System.Drawing.Point(3, 16);
            this.dataGridView_Focus_HealthLevels.Name = "dataGridView_Focus_HealthLevels";
            this.dataGridView_Focus_HealthLevels.RowHeadersVisible = false;
            this.dataGridView_Focus_HealthLevels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView_Focus_HealthLevels.Size = new System.Drawing.Size(358, 75);
            this.dataGridView_Focus_HealthLevels.TabIndex = 0;
            // 
            // Effects
            // 
            this.Effects.Controls.Add(this.EffectsTablePanel);
            this.Effects.Controls.Add(this.Button_AddEffect);
            this.Effects.Location = new System.Drawing.Point(7, 360);
            this.Effects.Name = "Effects";
            this.Effects.Size = new System.Drawing.Size(363, 226);
            this.Effects.TabIndex = 16;
            this.Effects.TabStop = false;
            this.Effects.Text = "Effects";
            // 
            // EffectsTablePanel
            // 
            this.EffectsTablePanel.AutoSize = true;
            this.EffectsTablePanel.Controls.Add(this.dataGridView_Focus_Effects);
            this.EffectsTablePanel.Location = new System.Drawing.Point(6, 19);
            this.EffectsTablePanel.Name = "EffectsTablePanel";
            this.EffectsTablePanel.Size = new System.Drawing.Size(354, 172);
            this.EffectsTablePanel.TabIndex = 0;
            // 
            // dataGridView_Focus_Effects
            // 
            this.dataGridView_Focus_Effects.AllowUserToAddRows = false;
            this.dataGridView_Focus_Effects.AllowUserToDeleteRows = false;
            this.dataGridView_Focus_Effects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Focus_Effects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EffectName,
            this.EffectDescription,
            this.EffectTurnsRemaining});
            this.dataGridView_Focus_Effects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Focus_Effects.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Focus_Effects.Name = "dataGridView_Focus_Effects";
            this.dataGridView_Focus_Effects.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView_Focus_Effects.RowHeadersVisible = false;
            this.dataGridView_Focus_Effects.Size = new System.Drawing.Size(354, 172);
            this.dataGridView_Focus_Effects.TabIndex = 0;
            // 
            // EffectName
            // 
            this.EffectName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EffectName.HeaderText = "Name";
            this.EffectName.Name = "EffectName";
            this.EffectName.Width = 60;
            // 
            // EffectDescription
            // 
            this.EffectDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EffectDescription.HeaderText = "Description";
            this.EffectDescription.Name = "EffectDescription";
            // 
            // EffectTurnsRemaining
            // 
            this.EffectTurnsRemaining.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EffectTurnsRemaining.HeaderText = "TR";
            this.EffectTurnsRemaining.Name = "EffectTurnsRemaining";
            this.EffectTurnsRemaining.Width = 47;
            // 
            // Button_AddEffect
            // 
            this.Button_AddEffect.Location = new System.Drawing.Point(285, 197);
            this.Button_AddEffect.Name = "Button_AddEffect";
            this.Button_AddEffect.Size = new System.Drawing.Size(75, 23);
            this.Button_AddEffect.TabIndex = 15;
            this.Button_AddEffect.Text = "AddEffect";
            this.Button_AddEffect.UseVisualStyleBackColor = true;
            this.Button_AddEffect.Click += new System.EventHandler(this.Button_AddEffect_Click);
            // 
            // Label_PersonalEssence
            // 
            this.Label_PersonalEssence.AutoSize = true;
            this.Label_PersonalEssence.Location = new System.Drawing.Point(7, 176);
            this.Label_PersonalEssence.Name = "Label_PersonalEssence";
            this.Label_PersonalEssence.Size = new System.Drawing.Size(92, 13);
            this.Label_PersonalEssence.TabIndex = 10;
            this.Label_PersonalEssence.Text = "Personal Essence";
            // 
            // Label_PeripheralEssence
            // 
            this.Label_PeripheralEssence.AutoSize = true;
            this.Label_PeripheralEssence.Location = new System.Drawing.Point(6, 202);
            this.Label_PeripheralEssence.Name = "Label_PeripheralEssence";
            this.Label_PeripheralEssence.Size = new System.Drawing.Size(98, 13);
            this.Label_PeripheralEssence.TabIndex = 11;
            this.Label_PeripheralEssence.Text = "Peripheral Essence";
            // 
            // Label_Willpower
            // 
            this.Label_Willpower.AutoSize = true;
            this.Label_Willpower.Location = new System.Drawing.Point(6, 228);
            this.Label_Willpower.Name = "Label_Willpower";
            this.Label_Willpower.Size = new System.Drawing.Size(53, 13);
            this.Label_Willpower.TabIndex = 12;
            this.Label_Willpower.Text = "Willpower";
            // 
            // Label_Anima
            // 
            this.Label_Anima.AutoSize = true;
            this.Label_Anima.Location = new System.Drawing.Point(6, 149);
            this.Label_Anima.Name = "Label_Anima";
            this.Label_Anima.Size = new System.Drawing.Size(36, 13);
            this.Label_Anima.TabIndex = 13;
            this.Label_Anima.Text = "Anima";
            // 
            // numericUpDown_Focus_PersonalEssence
            // 
            this.numericUpDown_Focus_PersonalEssence.Location = new System.Drawing.Point(105, 174);
            this.numericUpDown_Focus_PersonalEssence.Name = "numericUpDown_Focus_PersonalEssence";
            this.numericUpDown_Focus_PersonalEssence.Size = new System.Drawing.Size(70, 20);
            this.numericUpDown_Focus_PersonalEssence.TabIndex = 6;
            this.numericUpDown_Focus_PersonalEssence.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDown_Focus_PeripheralEssence
            // 
            this.numericUpDown_Focus_PeripheralEssence.Location = new System.Drawing.Point(105, 200);
            this.numericUpDown_Focus_PeripheralEssence.Name = "numericUpDown_Focus_PeripheralEssence";
            this.numericUpDown_Focus_PeripheralEssence.Size = new System.Drawing.Size(70, 20);
            this.numericUpDown_Focus_PeripheralEssence.TabIndex = 8;
            this.numericUpDown_Focus_PeripheralEssence.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDown_Focus_Willpower
            // 
            this.numericUpDown_Focus_Willpower.Location = new System.Drawing.Point(105, 226);
            this.numericUpDown_Focus_Willpower.Name = "numericUpDown_Focus_Willpower";
            this.numericUpDown_Focus_Willpower.Size = new System.Drawing.Size(70, 20);
            this.numericUpDown_Focus_Willpower.TabIndex = 7;
            this.numericUpDown_Focus_Willpower.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label_Initiative
            // 
            this.Label_Initiative.AutoSize = true;
            this.Label_Initiative.Location = new System.Drawing.Point(6, 73);
            this.Label_Initiative.Name = "Label_Initiative";
            this.Label_Initiative.Size = new System.Drawing.Size(83, 13);
            this.Label_Initiative.TabIndex = 5;
            this.Label_Initiative.Text = "Current Initiative";
            // 
            // numericUpDown_Focus_Initiative
            // 
            this.numericUpDown_Focus_Initiative.Location = new System.Drawing.Point(105, 71);
            this.numericUpDown_Focus_Initiative.Name = "numericUpDown_Focus_Initiative";
            this.numericUpDown_Focus_Initiative.Size = new System.Drawing.Size(76, 20);
            this.numericUpDown_Focus_Initiative.TabIndex = 4;
            this.numericUpDown_Focus_Initiative.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(6, 14);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(175, 20);
            this.textBox_name.TabIndex = 3;
            // 
            // Type
            // 
            this.Type.Location = new System.Drawing.Point(6, 40);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(175, 20);
            this.Type.TabIndex = 2;
            // 
            // Portrait
            // 
            this.Portrait.BackColor = System.Drawing.SystemColors.Window;
            this.Portrait.Location = new System.Drawing.Point(260, 19);
            this.Portrait.Name = "Portrait";
            this.Portrait.Size = new System.Drawing.Size(100, 116);
            this.Portrait.TabIndex = 0;
            this.Portrait.TabStop = false;
            // 
            // Button_NextRound
            // 
            this.Button_NextRound.Location = new System.Drawing.Point(538, 623);
            this.Button_NextRound.Name = "Button_NextRound";
            this.Button_NextRound.Size = new System.Drawing.Size(75, 23);
            this.Button_NextRound.TabIndex = 3;
            this.Button_NextRound.Text = "Next Round";
            this.Button_NextRound.UseVisualStyleBackColor = true;
            this.Button_NextRound.Click += new System.EventHandler(this.Button_NextRound_Click);
            // 
            // Button_AddCharacter
            // 
            this.Button_AddCharacter.Location = new System.Drawing.Point(13, 623);
            this.Button_AddCharacter.Name = "Button_AddCharacter";
            this.Button_AddCharacter.Size = new System.Drawing.Size(75, 23);
            this.Button_AddCharacter.TabIndex = 4;
            this.Button_AddCharacter.Text = "+";
            this.Button_AddCharacter.UseVisualStyleBackColor = true;
            this.Button_AddCharacter.Click += new System.EventHandler(this.Button_AddCharacter_Click);
            // 
            // Button_Refresh
            // 
            this.Button_Refresh.Location = new System.Drawing.Point(457, 623);
            this.Button_Refresh.Name = "Button_Refresh";
            this.Button_Refresh.Size = new System.Drawing.Size(75, 23);
            this.Button_Refresh.TabIndex = 5;
            this.Button_Refresh.Text = "Refresh";
            this.Button_Refresh.UseVisualStyleBackColor = true;
            this.Button_Refresh.Click += new System.EventHandler(this.Button_Refresh_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 658);
            this.Controls.Add(this.Button_Refresh);
            this.Controls.Add(this.Button_AddCharacter);
            this.Controls.Add(this.Button_NextRound);
            this.Controls.Add(this.CharacterFocus);
            this.Controls.Add(this.CombatScreen);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.CombatScreen.ResumeLayout(false);
            this.CombatTablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CombatTable)).EndInit();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.CharacterFocus.ResumeLayout(false);
            this.CharacterFocus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Focus_Onslaught)).EndInit();
            this.HealthLevels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Focus_HealthLevels)).EndInit();
            this.Effects.ResumeLayout(false);
            this.Effects.PerformLayout();
            this.EffectsTablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Focus_Effects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Focus_PersonalEssence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Focus_PeripheralEssence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Focus_Willpower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Focus_Initiative)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numericUpDown_Focus_Initiative;
        private System.Windows.Forms.TextBox Type;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.NumericUpDown numericUpDown_Focus_PeripheralEssence;
        private System.Windows.Forms.NumericUpDown numericUpDown_Focus_Willpower;
        private System.Windows.Forms.NumericUpDown numericUpDown_Focus_PersonalEssence;
        private System.Windows.Forms.GroupBox Effects;
        private System.Windows.Forms.Button Button_AddEffect;
        private System.Windows.Forms.Label Label_Anima;
        private System.Windows.Forms.Label Label_Willpower;
        private System.Windows.Forms.Label Label_PeripheralEssence;
        private System.Windows.Forms.Label Label_PersonalEssence;
        private System.Windows.Forms.GroupBox HealthLevels;
        private System.Windows.Forms.Button Button_NextRound;
        private System.Windows.Forms.Button Button_AddCharacter;
        private System.Windows.Forms.Panel EffectsTablePanel;
        private System.Windows.Forms.Panel CombatTablePanel;
        private System.Windows.Forms.DataGridView dataGridView_CombatTable;
        private System.Windows.Forms.Button Button_Refresh_Character;
        private System.Windows.Forms.Button Button_Refresh;
        private System.Windows.Forms.ComboBox comboBox_Focus_Anima;
        private System.Windows.Forms.DataGridView dataGridView_Focus_HealthLevels;
        private System.Windows.Forms.DataGridView dataGridView_Focus_Effects;
        private System.Windows.Forms.Label label_Onslaught;
        private System.Windows.Forms.NumericUpDown numericUpDown_Focus_Onslaught;
        private System.Windows.Forms.CheckBox checkBox_Focus_KeepOnslaught;
        private System.Windows.Forms.DataGridViewTextBoxColumn EffectTurnsRemaining;
        private System.Windows.Forms.DataGridViewTextBoxColumn EffectDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn EffectName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn HasActedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParticipantDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParticipantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn InitiativeColumn;
    }
}