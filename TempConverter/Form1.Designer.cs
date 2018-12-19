namespace TempConverter
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
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.label_temp = new System.Windows.Forms.Label();
            this.button_celsius = new System.Windows.Forms.Button();
            this.button_fahren = new System.Windows.Forms.Button();
            this.Output_label = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(151, 78);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(100, 20);
            this.textBox_input.TabIndex = 0;
            // 
            // label_temp
            // 
            this.label_temp.AutoSize = true;
            this.label_temp.Location = new System.Drawing.Point(18, 81);
            this.label_temp.Name = "label_temp";
            this.label_temp.Size = new System.Drawing.Size(127, 13);
            this.label_temp.TabIndex = 1;
            this.label_temp.Text = "Temperature to convert : ";
            // 
            // button_celsius
            // 
            this.button_celsius.Location = new System.Drawing.Point(175, 175);
            this.button_celsius.Name = "button_celsius";
            this.button_celsius.Size = new System.Drawing.Size(124, 23);
            this.button_celsius.TabIndex = 2;
            this.button_celsius.Text = "Convert to Celsius";
            this.button_celsius.UseVisualStyleBackColor = true;
            this.button_celsius.Click += new System.EventHandler(this.button_celsius_Click);
            // 
            // button_fahren
            // 
            this.button_fahren.Location = new System.Drawing.Point(12, 175);
            this.button_fahren.Name = "button_fahren";
            this.button_fahren.Size = new System.Drawing.Size(124, 23);
            this.button_fahren.TabIndex = 3;
            this.button_fahren.Text = "Convert to Fahrenhiet";
            this.button_fahren.UseVisualStyleBackColor = true;
            this.button_fahren.Click += new System.EventHandler(this.button_fahren_Click);
            // 
            // Output_label
            // 
            this.Output_label.AutoSize = true;
            this.Output_label.Location = new System.Drawing.Point(375, 81);
            this.Output_label.Name = "Output_label";
            this.Output_label.Size = new System.Drawing.Size(45, 13);
            this.Output_label.TabIndex = 4;
            this.Output_label.Text = "Output :";
            // 
            // Output
            // 
            this.Output.FormattingEnabled = true;
            this.Output.Location = new System.Drawing.Point(426, 81);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(120, 95);
            this.Output.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(619, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 315);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Output_label);
            this.Controls.Add(this.button_fahren);
            this.Controls.Add(this.button_celsius);
            this.Controls.Add(this.label_temp);
            this.Controls.Add(this.textBox_input);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.Label label_temp;
        private System.Windows.Forms.Button button_celsius;
        private System.Windows.Forms.Button button_fahren;
        private System.Windows.Forms.Label Output_label;
        private System.Windows.Forms.ListBox Output;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}

