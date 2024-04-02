namespace SimpleRobot_LAB8
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
            lblBot = new Label();
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
            pnlBorder.Controls.Add(lblBot);
            pnlBorder.Location = new Point(32, 27);
            pnlBorder.Name = "pnlBorder";
            pnlBorder.Size = new Size(207, 207);
            pnlBorder.TabIndex = 0;
            // 
            // lblBot
            // 
            lblBot.AutoSize = true;
            lblBot.Font = new Font("Wingdings", 5.25F, FontStyle.Regular, GraphicsUnit.Point, 2);
            lblBot.Location = new Point(98, 100);
            lblBot.MaximumSize = new Size(10, 10);
            lblBot.MinimumSize = new Size(10, 10);
            lblBot.Name = "lblBot";
            lblBot.Size = new Size(10, 10);
            lblBot.TabIndex = 0;
            lblBot.Text = "J";
            // 
            // lblXYCords
            // 
            lblXYCords.AutoSize = true;
            lblXYCords.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblXYCords.Location = new Point(42, 9);
            lblXYCords.Name = "lblXYCords";
            lblXYCords.Size = new Size(65, 15);
            lblXYCords.TabIndex = 1;
            lblXYCords.Text = "{X=0, Y=0}";
            // 
            // btnNorth
            // 
            btnNorth.Location = new Point(121, 245);
            btnNorth.Name = "btnNorth";
            btnNorth.Size = new Size(23, 23);
            btnNorth.TabIndex = 2;
            btnNorth.Text = "N";
            btnNorth.UseVisualStyleBackColor = true;
            btnNorth.Click += btnNorth_Click;
            // 
            // btnGoTen
            // 
            btnGoTen.Location = new Point(179, 271);
            btnGoTen.Name = "btnGoTen";
            btnGoTen.Size = new Size(54, 23);
            btnGoTen.TabIndex = 3;
            btnGoTen.Text = "&Go 10";
            btnGoTen.UseVisualStyleBackColor = true;
            btnGoTen.Click += btnGoTen_Click;
            // 
            // btnGoOne
            // 
            btnGoOne.Location = new Point(32, 271);
            btnGoOne.Name = "btnGoOne";
            btnGoOne.Size = new Size(55, 23);
            btnGoOne.TabIndex = 4;
            btnGoOne.Text = "Go 1";
            btnGoOne.UseVisualStyleBackColor = true;
            btnGoOne.Click += btnGoOne_Click;
            // 
            // btnEast
            // 
            btnEast.Location = new Point(150, 271);
            btnEast.Name = "btnEast";
            btnEast.Size = new Size(23, 23);
            btnEast.TabIndex = 5;
            btnEast.Text = "E";
            btnEast.UseVisualStyleBackColor = true;
            btnEast.Click += btnEast_Click;
            // 
            // btnWest
            // 
            btnWest.Location = new Point(93, 271);
            btnWest.Name = "btnWest";
            btnWest.Size = new Size(23, 23);
            btnWest.TabIndex = 6;
            btnWest.Text = "W";
            btnWest.UseVisualStyleBackColor = true;
            btnWest.Click += btnWest_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(158, 345);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 7;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSouth
            // 
            btnSouth.Location = new Point(121, 295);
            btnSouth.Name = "btnSouth";
            btnSouth.Size = new Size(23, 23);
            btnSouth.TabIndex = 8;
            btnSouth.Text = "S";
            btnSouth.UseVisualStyleBackColor = true;
            btnSouth.Click += btnSouth_Click;
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
            Load += frmPlaySpace_Load;
            pnlBorder.ResumeLayout(false);
            pnlBorder.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlBorder;
        private Label lblBot;
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
