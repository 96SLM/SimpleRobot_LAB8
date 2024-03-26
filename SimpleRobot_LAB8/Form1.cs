namespace SimpleRobot_LAB8
{
    public partial class frmPlaySpace : Form
    {
        public frmPlaySpace()
        {
            InitializeComponent();
        }
        //variables
        //wingding directions
        bool goNorth, goEast, goSouth, goWest;
        string facing = "north";

        //robots start center is 90,90


        private void frmPlaySpace_Load(object sender, EventArgs e)
        {            
            Robot rob = new Robot();
            int XC = rob.X;
            int YC = rob.Y;
            lblXYCords.Text = "{X = "+XC+", Y = "+YC+"}";
            lblBot.Text = 233;
        }

        private void lbl_clear(object sender, EventArgs e)
        {
            lblXYCords.Text = "X = 0, Y = 0";
            lblXYCords.Update();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
