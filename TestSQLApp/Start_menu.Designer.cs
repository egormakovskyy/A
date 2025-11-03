namespace TestSQLApp
{
    partial class Start_menu
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PeopleField = new System.Windows.Forms.TextBox();
            this.FloorsField = new System.Windows.Forms.TextBox();
            this.Launch_System = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.CloseButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1269, 186);
            this.panel2.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.Window;
            this.CloseButton.Location = new System.Drawing.Point(1215, 9);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(41, 48);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "x";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1269, 186);
            this.label1.TabIndex = 0;
            this.label1.Text = "Стартовое меню";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.PeopleField);
            this.panel1.Controls.Add(this.FloorsField);
            this.panel1.Controls.Add(this.Launch_System);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1269, 962);
            this.panel1.TabIndex = 1;
            // 
            // PeopleField
            // 
            this.PeopleField.Location = new System.Drawing.Point(954, 336);
            this.PeopleField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PeopleField.Multiline = true;
            this.PeopleField.Name = "PeopleField";
            this.PeopleField.Size = new System.Drawing.Size(302, 104);
            this.PeopleField.TabIndex = 4;
            this.PeopleField.Enter += new System.EventHandler(this.PeopleField_Enter);
            this.PeopleField.Leave += new System.EventHandler(this.PeopleField_Leave);
            // 
            // FloorsField
            // 
            this.FloorsField.Location = new System.Drawing.Point(954, 208);
            this.FloorsField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FloorsField.Multiline = true;
            this.FloorsField.Name = "FloorsField";
            this.FloorsField.Size = new System.Drawing.Size(302, 104);
            this.FloorsField.TabIndex = 3;
            this.FloorsField.Enter += new System.EventHandler(this.FloorsField_Enter);
            this.FloorsField.Leave += new System.EventHandler(this.FloorsField_Leave);
            // 
            // Launch_System
            // 
            this.Launch_System.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Launch_System.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Launch_System.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Launch_System.Location = new System.Drawing.Point(0, 880);
            this.Launch_System.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Launch_System.Name = "Launch_System";
            this.Launch_System.Size = new System.Drawing.Size(1269, 82);
            this.Launch_System.TabIndex = 1;
            this.Launch_System.Text = "Запустить систему";
            this.Launch_System.UseVisualStyleBackColor = false;
            this.Launch_System.Click += new System.EventHandler(this.LaunchSystem_Click);
            // 
            // Start_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 962);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Start_menu";
            this.Text = "MainForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Launch_System;
        private System.Windows.Forms.TextBox PeopleField;
        private System.Windows.Forms.TextBox FloorsField;
    }
}