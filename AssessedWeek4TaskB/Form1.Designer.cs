
namespace AssessedWeek4TaskB
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
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.StartingTextBox = new System.Windows.Forms.TextBox();
            this.FinishingTextBox = new System.Windows.Forms.TextBox();
            this.DisplayTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SortButton = new System.Windows.Forms.Button();
            this.OrganizeButton = new System.Windows.Forms.Button();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(294, 127);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.DescriptionTextBox.TabIndex = 0;
            // 
            // StartingTextBox
            // 
            this.StartingTextBox.Location = new System.Drawing.Point(294, 153);
            this.StartingTextBox.Name = "StartingTextBox";
            this.StartingTextBox.Size = new System.Drawing.Size(100, 20);
            this.StartingTextBox.TabIndex = 1;
            // 
            // FinishingTextBox
            // 
            this.FinishingTextBox.Location = new System.Drawing.Point(294, 179);
            this.FinishingTextBox.Name = "FinishingTextBox";
            this.FinishingTextBox.Size = new System.Drawing.Size(100, 20);
            this.FinishingTextBox.TabIndex = 2;
            // 
            // DisplayTextBox
            // 
            this.DisplayTextBox.Location = new System.Drawing.Point(531, 127);
            this.DisplayTextBox.Multiline = true;
            this.DisplayTextBox.Name = "DisplayTextBox";
            this.DisplayTextBox.Size = new System.Drawing.Size(257, 164);
            this.DisplayTextBox.TabIndex = 3;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(294, 222);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(375, 222);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(75, 23);
            this.SortButton.TabIndex = 5;
            this.SortButton.Text = "Sort";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // OrganizeButton
            // 
            this.OrganizeButton.Location = new System.Drawing.Point(294, 251);
            this.OrganizeButton.Name = "OrganizeButton";
            this.OrganizeButton.Size = new System.Drawing.Size(75, 23);
            this.OrganizeButton.TabIndex = 6;
            this.OrganizeButton.Text = "Organize";
            this.OrganizeButton.UseVisualStyleBackColor = true;
            this.OrganizeButton.Click += new System.EventHandler(this.OrganizeButton_Click);
            // 
            // DisplayButton
            // 
            this.DisplayButton.Location = new System.Drawing.Point(375, 251);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(75, 23);
            this.DisplayButton.TabIndex = 7;
            this.DisplayButton.Text = "Display";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Starting:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Finishing:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(267, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Activity Organizer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DisplayButton);
            this.Controls.Add(this.OrganizeButton);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DisplayTextBox);
            this.Controls.Add(this.FinishingTextBox);
            this.Controls.Add(this.StartingTextBox);
            this.Controls.Add(this.DescriptionTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.TextBox StartingTextBox;
        private System.Windows.Forms.TextBox FinishingTextBox;
        private System.Windows.Forms.TextBox DisplayTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.Button OrganizeButton;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

