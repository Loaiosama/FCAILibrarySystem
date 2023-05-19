
namespace FCAI_library
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SignUp = new System.Windows.Forms.Button();
            this.borrowBookbutt = new System.Windows.Forms.Button();
            this.browseBooksbutt = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.mainPanel.Location = new System.Drawing.Point(215, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(802, 551);
            this.mainPanel.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(89, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(655, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please select what to you want from the select menu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.SignUp);
            this.panel1.Controls.Add(this.borrowBookbutt);
            this.panel1.Controls.Add(this.browseBooksbutt);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 551);
            this.panel1.TabIndex = 43;
            // 
            // SignUp
            // 
            this.SignUp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.SignUp.FlatAppearance.BorderSize = 0;
            this.SignUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.SignUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.SignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUp.ForeColor = System.Drawing.Color.White;
            this.SignUp.Location = new System.Drawing.Point(0, 129);
            this.SignUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(215, 48);
            this.SignUp.TabIndex = 51;
            this.SignUp.Text = "Sign Up";
            this.SignUp.UseVisualStyleBackColor = false;
            this.SignUp.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // borrowBookbutt
            // 
            this.borrowBookbutt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.borrowBookbutt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.borrowBookbutt.Dock = System.Windows.Forms.DockStyle.Top;
            this.borrowBookbutt.FlatAppearance.BorderSize = 0;
            this.borrowBookbutt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.borrowBookbutt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.borrowBookbutt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrowBookbutt.ForeColor = System.Drawing.Color.White;
            this.borrowBookbutt.Location = new System.Drawing.Point(0, 81);
            this.borrowBookbutt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.borrowBookbutt.Name = "borrowBookbutt";
            this.borrowBookbutt.Size = new System.Drawing.Size(215, 48);
            this.borrowBookbutt.TabIndex = 50;
            this.borrowBookbutt.Text = "Borrow Book";
            this.borrowBookbutt.UseVisualStyleBackColor = false;
            this.borrowBookbutt.Click += new System.EventHandler(this.borrowBookbutt_Click);
            // 
            // browseBooksbutt
            // 
            this.browseBooksbutt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.browseBooksbutt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browseBooksbutt.Dock = System.Windows.Forms.DockStyle.Top;
            this.browseBooksbutt.FlatAppearance.BorderSize = 0;
            this.browseBooksbutt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.browseBooksbutt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.browseBooksbutt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseBooksbutt.ForeColor = System.Drawing.Color.White;
            this.browseBooksbutt.Location = new System.Drawing.Point(0, 33);
            this.browseBooksbutt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.browseBooksbutt.Name = "browseBooksbutt";
            this.browseBooksbutt.Size = new System.Drawing.Size(215, 48);
            this.browseBooksbutt.TabIndex = 49;
            this.browseBooksbutt.Text = "Browse Books";
            this.browseBooksbutt.UseVisualStyleBackColor = false;
            this.browseBooksbutt.Click += new System.EventHandler(this.browseBooksbutt_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(215, 33);
            this.panel5.TabIndex = 40;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 40);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 551);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Window";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button browseBooksbutt;
        private System.Windows.Forms.Button borrowBookbutt;
        private System.Windows.Forms.Button SignUp;
    }
}