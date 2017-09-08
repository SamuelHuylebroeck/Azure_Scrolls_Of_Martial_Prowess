namespace Azure_Scrolls_of_Martial_Prowess.Views
{
    partial class AddEffect
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
            this.button_AddEffect = new System.Windows.Forms.Button();
            this.checkBox_AddEffect_isTemporary = new System.Windows.Forms.CheckBox();
            this.numericUpDown_AddEffect_Duration = new System.Windows.Forms.NumericUpDown();
            this.textBox_AddEffect_Name = new System.Windows.Forms.TextBox();
            this.label_AddEffect_Name = new System.Windows.Forms.Label();
            this.textBox_AddEffect_Description = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AddEffect_Duration)).BeginInit();
            this.SuspendLayout();
            // 
            // button_AddEffect
            // 
            this.button_AddEffect.Location = new System.Drawing.Point(286, 351);
            this.button_AddEffect.Name = "button_AddEffect";
            this.button_AddEffect.Size = new System.Drawing.Size(75, 23);
            this.button_AddEffect.TabIndex = 0;
            this.button_AddEffect.Text = "Add Effect";
            this.button_AddEffect.UseVisualStyleBackColor = true;
            this.button_AddEffect.Click += new System.EventHandler(this.button_AddEffect_Click);
            // 
            // checkBox_AddEffect_isTemporary
            // 
            this.checkBox_AddEffect_isTemporary.AutoSize = true;
            this.checkBox_AddEffect_isTemporary.Location = new System.Drawing.Point(12, 39);
            this.checkBox_AddEffect_isTemporary.Name = "checkBox_AddEffect_isTemporary";
            this.checkBox_AddEffect_isTemporary.Size = new System.Drawing.Size(84, 17);
            this.checkBox_AddEffect_isTemporary.TabIndex = 1;
            this.checkBox_AddEffect_isTemporary.Text = "IsTemporary";
            this.checkBox_AddEffect_isTemporary.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.checkBox_AddEffect_isTemporary.UseVisualStyleBackColor = true;
            this.checkBox_AddEffect_isTemporary.CheckedChanged += new System.EventHandler(this.checkBox_AddEffect_isTemporary_CheckedChanged);
            // 
            // numericUpDown_AddEffect_Duration
            // 
            this.numericUpDown_AddEffect_Duration.Enabled = false;
            this.numericUpDown_AddEffect_Duration.Location = new System.Drawing.Point(299, 39);
            this.numericUpDown_AddEffect_Duration.Name = "numericUpDown_AddEffect_Duration";
            this.numericUpDown_AddEffect_Duration.Size = new System.Drawing.Size(62, 20);
            this.numericUpDown_AddEffect_Duration.TabIndex = 2;
            this.numericUpDown_AddEffect_Duration.Visible = false;
            // 
            // textBox_AddEffect_Name
            // 
            this.textBox_AddEffect_Name.Location = new System.Drawing.Point(113, 12);
            this.textBox_AddEffect_Name.Name = "textBox_AddEffect_Name";
            this.textBox_AddEffect_Name.Size = new System.Drawing.Size(248, 20);
            this.textBox_AddEffect_Name.TabIndex = 3;
            // 
            // label_AddEffect_Name
            // 
            this.label_AddEffect_Name.AutoSize = true;
            this.label_AddEffect_Name.Location = new System.Drawing.Point(12, 15);
            this.label_AddEffect_Name.Name = "label_AddEffect_Name";
            this.label_AddEffect_Name.Size = new System.Drawing.Size(66, 13);
            this.label_AddEffect_Name.TabIndex = 4;
            this.label_AddEffect_Name.Text = "Effect Name";
            // 
            // textBox_AddEffect_Description
            // 
            this.textBox_AddEffect_Description.Location = new System.Drawing.Point(12, 72);
            this.textBox_AddEffect_Description.Multiline = true;
            this.textBox_AddEffect_Description.Name = "textBox_AddEffect_Description";
            this.textBox_AddEffect_Description.Size = new System.Drawing.Size(349, 273);
            this.textBox_AddEffect_Description.TabIndex = 5;
            // 
            // AddEffect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 386);
            this.Controls.Add(this.textBox_AddEffect_Description);
            this.Controls.Add(this.label_AddEffect_Name);
            this.Controls.Add(this.textBox_AddEffect_Name);
            this.Controls.Add(this.numericUpDown_AddEffect_Duration);
            this.Controls.Add(this.checkBox_AddEffect_isTemporary);
            this.Controls.Add(this.button_AddEffect);
            this.Name = "AddEffect";
            this.Text = "AddEffect";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AddEffect_Duration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_AddEffect;
        private System.Windows.Forms.CheckBox checkBox_AddEffect_isTemporary;
        private System.Windows.Forms.NumericUpDown numericUpDown_AddEffect_Duration;
        private System.Windows.Forms.TextBox textBox_AddEffect_Name;
        private System.Windows.Forms.Label label_AddEffect_Name;
        private System.Windows.Forms.TextBox textBox_AddEffect_Description;
    }
}