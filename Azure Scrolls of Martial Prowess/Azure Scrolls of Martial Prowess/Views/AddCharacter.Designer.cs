namespace Azure_Scrolls_of_Martial_Prowess.Views
{
    partial class AddCharacter
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
            this.containingPanel = new System.Windows.Forms.Panel();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_type = new System.Windows.Forms.Label();
            this.textBox_type = new System.Windows.Forms.TextBox();
            this.label_peripheral = new System.Windows.Forms.Label();
            this.numericUpDown_peripheral = new System.Windows.Forms.NumericUpDown();
            this.label_personal = new System.Windows.Forms.Label();
            this.numericUpDown_personal = new System.Windows.Forms.NumericUpDown();
            this.label_willpower = new System.Windows.Forms.Label();
            this.numericUpDown_willpower = new System.Windows.Forms.NumericUpDown();
            this.submit = new System.Windows.Forms.Button();
            this.containingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_peripheral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_personal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_willpower)).BeginInit();
            this.SuspendLayout();
            // 
            // containingPanel
            // 
            this.containingPanel.Controls.Add(this.label_name);
            this.containingPanel.Controls.Add(this.textBox_name);
            this.containingPanel.Controls.Add(this.label_type);
            this.containingPanel.Controls.Add(this.textBox_type);
            this.containingPanel.Controls.Add(this.label_peripheral);
            this.containingPanel.Controls.Add(this.numericUpDown_peripheral);
            this.containingPanel.Controls.Add(this.label_personal);
            this.containingPanel.Controls.Add(this.numericUpDown_personal);
            this.containingPanel.Controls.Add(this.label_willpower);
            this.containingPanel.Controls.Add(this.numericUpDown_willpower);
            this.containingPanel.Location = new System.Drawing.Point(13, 13);
            this.containingPanel.Name = "containingPanel";
            this.containingPanel.Size = new System.Drawing.Size(259, 188);
            this.containingPanel.TabIndex = 0;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(5, 7);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(35, 13);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "Name";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(104, 4);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(152, 20);
            this.textBox_name.TabIndex = 0;
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Location = new System.Drawing.Point(5, 33);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(31, 13);
            this.label_type.TabIndex = 2;
            this.label_type.Text = "Type";
            // 
            // textBox_type
            // 
            this.textBox_type.Location = new System.Drawing.Point(104, 30);
            this.textBox_type.Name = "textBox_type";
            this.textBox_type.Size = new System.Drawing.Size(152, 20);
            this.textBox_type.TabIndex = 7;
            // 
            // label_peripheral
            // 
            this.label_peripheral.AutoSize = true;
            this.label_peripheral.Location = new System.Drawing.Point(6, 93);
            this.label_peripheral.Name = "label_peripheral";
            this.label_peripheral.Size = new System.Drawing.Size(98, 13);
            this.label_peripheral.TabIndex = 3;
            this.label_peripheral.Text = "Peripheral Essence";
            // 
            // numericUpDown_peripheral
            // 
            this.numericUpDown_peripheral.Location = new System.Drawing.Point(110, 91);
            this.numericUpDown_peripheral.Name = "numericUpDown_peripheral";
            this.numericUpDown_peripheral.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_peripheral.TabIndex = 8;
            // 
            // label_personal
            // 
            this.label_personal.AutoSize = true;
            this.label_personal.Location = new System.Drawing.Point(5, 116);
            this.label_personal.Name = "label_personal";
            this.label_personal.Size = new System.Drawing.Size(92, 13);
            this.label_personal.TabIndex = 4;
            this.label_personal.Text = "Personal Essence";
            // 
            // numericUpDown_personal
            // 
            this.numericUpDown_personal.Location = new System.Drawing.Point(110, 114);
            this.numericUpDown_personal.Name = "numericUpDown_personal";
            this.numericUpDown_personal.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_personal.TabIndex = 9;
            // 
            // label_willpower
            // 
            this.label_willpower.AutoSize = true;
            this.label_willpower.Location = new System.Drawing.Point(5, 143);
            this.label_willpower.Name = "label_willpower";
            this.label_willpower.Size = new System.Drawing.Size(53, 13);
            this.label_willpower.TabIndex = 5;
            this.label_willpower.Text = "Willpower";
            // 
            // numericUpDown_willpower
            // 
            this.numericUpDown_willpower.Location = new System.Drawing.Point(110, 141);
            this.numericUpDown_willpower.Name = "numericUpDown_willpower";
            this.numericUpDown_willpower.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_willpower.TabIndex = 10;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(197, 226);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 1;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // AddCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.containingPanel);
            this.Name = "AddCharacter";
            this.Text = "AddCharacter";
            this.containingPanel.ResumeLayout(false);
            this.containingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_peripheral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_personal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_willpower)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel containingPanel;
        private System.Windows.Forms.TextBox textBox_type;
        private System.Windows.Forms.Label label_willpower;
        private System.Windows.Forms.Label label_personal;
        private System.Windows.Forms.Label label_peripheral;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.NumericUpDown numericUpDown_willpower;
        private System.Windows.Forms.NumericUpDown numericUpDown_personal;
        private System.Windows.Forms.NumericUpDown numericUpDown_peripheral;
    }
}