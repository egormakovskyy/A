namespace TestSQLApp
{
    partial class CreateHumanForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.WeightField = new System.Windows.Forms.TextBox();
            this.TargetField = new System.Windows.Forms.TextBox();
            this.CreateHuman = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.WeightField);
            this.panel1.Controls.Add(this.TargetField);
            this.panel1.Controls.Add(this.CreateHuman);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 540);
            this.panel1.TabIndex = 2;
            // 
            // WeightField
            // 
            this.WeightField.Location = new System.Drawing.Point(581, 274);
            this.WeightField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WeightField.Multiline = true;
            this.WeightField.Name = "WeightField";
            this.WeightField.Size = new System.Drawing.Size(302, 104);
            this.WeightField.TabIndex = 3;
            this.WeightField.TextChanged += new System.EventHandler(this.WeightField_TextChanged);
            this.WeightField.Enter += new System.EventHandler(this.WeightField_Enter);
            this.WeightField.Leave += new System.EventHandler(this.WeightField_Leave);
            // 
            // TargetField
            // 
            this.TargetField.Location = new System.Drawing.Point(95, 274);
            this.TargetField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TargetField.Multiline = true;
            this.TargetField.Name = "TargetField";
            this.TargetField.Size = new System.Drawing.Size(302, 104);
            this.TargetField.TabIndex = 2;
            this.TargetField.TextChanged += new System.EventHandler(this.TargetField_TextChanged);
            this.TargetField.Enter += new System.EventHandler(this.TargetField_Enter);
            this.TargetField.Leave += new System.EventHandler(this.TargetField_Leave);
            // 
            // CreateHuman
            // 
            this.CreateHuman.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CreateHuman.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateHuman.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CreateHuman.Location = new System.Drawing.Point(0, 458);
            this.CreateHuman.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CreateHuman.Name = "CreateHuman";
            this.CreateHuman.Size = new System.Drawing.Size(978, 82);
            this.CreateHuman.TabIndex = 1;
            this.CreateHuman.Text = "Создать человека";
            this.CreateHuman.UseVisualStyleBackColor = false;
            this.CreateHuman.Click += new System.EventHandler(this.CreateHuman_Click);
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
            this.panel2.Size = new System.Drawing.Size(978, 186);
            this.panel2.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.Window;
            this.CloseButton.Location = new System.Drawing.Point(920, 11);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(41, 48);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "x";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(978, 186);
            this.label1.TabIndex = 0;
            this.label1.Text = "Меню создания человека";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateHumanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 540);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CreateHumanForm";
            this.Text = "CreateHumanForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox WeightField;
        private System.Windows.Forms.TextBox TargetField;
        private System.Windows.Forms.Button CreateHuman;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label label1;
    }
}