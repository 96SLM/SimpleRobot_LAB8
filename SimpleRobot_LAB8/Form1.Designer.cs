﻿namespace SimpleRobot_LAB8
{
    partial class frmPlaySpace
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlBorder = new Panel();
            ldlBot = new Label();
            lblXYCords = new Label();
            btnNorth = new Button();
            btnGoTen = new Button();
            btnGoOne = new Button();
            btnEast = new Button();
            btnWest = new Button();
            btnExit = new Button();
            btnSouth = new Button();
            pnlBorder.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBorder
            // 
            pnlBorder.BackColor = SystemColors.ControlDark;
            pnlBorder.Controls.Add(ldlBot);
            pnlBorder.Location = new Point(32, 27);
            pnlBorder.Name = "pnlBorder";
            pnlBorder.Size = new Size(201, 201);
            pnlBorder.TabIndex = 0;
            // 
            // ldlBot
            // 
            ldlBot.AutoSize = true;
            ldlBot.Font = new Font("Wingdings", 12F, FontStyle.Regular, GraphicsUnit.Point, 2);
            ldlBot.Location = new Point(56, 41);
            ldlBot.Name = "ldlBot";
            ldlBot.Size = new Size(0, 17);
            ldlBot.TabIndex = 0;
            // 
            // lblXYCords
            // 
            lblXYCords.AutoSize = true;
            lblXYCords.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblXYCords.Location = new Point(32, 9);
            lblXYCords.Name = "lblXYCords";
            lblXYCords.Size = new Size(65, 15);
            lblXYCords.TabIndex = 1;
            lblXYCords.Text = "{X=0, Y=0}";
            // 
            // btnNorth
            // 
            btnNorth.Location = new Point(121, 235);
            btnNorth.Name = "btnNorth";
            btnNorth.Size = new Size(23, 23);
            btnNorth.TabIndex = 2;
            btnNorth.Text = "N";
            btnNorth.UseVisualStyleBackColor = true;
            // 
            // btnGoTen
            // 
            btnGoTen.Location = new Point(179, 261);
            btnGoTen.Name = "btnGoTen";
            btnGoTen.Size = new Size(54, 23);
            btnGoTen.TabIndex = 3;
            btnGoTen.Text = "&Go 10";
            btnGoTen.UseVisualStyleBackColor = true;
            // 
            // btnGoOne
            // 
            btnGoOne.Location = new Point(32, 261);
            btnGoOne.Name = "btnGoOne";
            btnGoOne.Size = new Size(55, 23);
            btnGoOne.TabIndex = 4;
            btnGoOne.Text = "Go 1";
            btnGoOne.UseVisualStyleBackColor = true;
            // 
            // btnEast
            // 
            btnEast.Location = new Point(150, 261);
            btnEast.Name = "btnEast";
            btnEast.Size = new Size(23, 23);
            btnEast.TabIndex = 5;
            btnEast.Text = "E";
            btnEast.UseVisualStyleBackColor = true;
            // 
            // btnWest
            // 
            btnWest.Location = new Point(93, 261);
            btnWest.Name = "btnWest";
            btnWest.Size = new Size(23, 23);
            btnWest.TabIndex = 6;
            btnWest.Text = "W";
            btnWest.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(158, 345);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 7;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnSouth
            // 
            btnSouth.Location = new Point(121, 285);
            btnSouth.Name = "btnSouth";
            btnSouth.Size = new Size(23, 23);
            btnSouth.TabIndex = 8;
            btnSouth.Text = "S";
            btnSouth.UseVisualStyleBackColor = true;
            // 
            // frmPlaySpace
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(276, 380);
            Controls.Add(btnSouth);
            Controls.Add(btnExit);
            Controls.Add(btnWest);
            Controls.Add(btnEast);
            Controls.Add(btnGoOne);
            Controls.Add(btnGoTen);
            Controls.Add(btnNorth);
            Controls.Add(lblXYCords);
            Controls.Add(pnlBorder);
            Name = "frmPlaySpace";
            Text = "Simple Robot";
            pnlBorder.ResumeLayout(false);
            pnlBorder.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlBorder;
        private Label ldlBot;
        private Label lblXYCords;
        private Button btnNorth;
        private Button btnGoTen;
        private Button btnGoOne;
        private Button btnEast;
        private Button btnWest;
        private Button btnExit;
        private Button btnSouth;
    }
}