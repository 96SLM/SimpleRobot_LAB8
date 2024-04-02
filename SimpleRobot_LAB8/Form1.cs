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
        //robots start center is 90,90
        Robot rob;

        private void frmPlaySpace_Load(object sender, EventArgs e)
        {
            rob = new Robot(lblBot.Location);

            lblXYCords.Text = "{X = " + (rob.RobPoint.X - 100+2) + 
                ", Y = " + (rob.RobPoint.Y - 100) + "}";
            lblBot.Text = char.ConvertFromUtf32(233);
            //wires the event handler to the delagate in load

        }
        //is calld by delegat in frm load

        public void Refresh()
        {
            lblBot.Location = rob.RobPoint;
            lblBot.Update();

            lblXYCords.Text = "{X = " + (rob.RobPoint.X - 100+2) +"," +
                " Y = " + ((rob.RobPoint.Y - 100)*-1)+"}";
            lblXYCords.Update();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNorth_Click(object sender, EventArgs e)
        {
            lblBot.Text = char.ConvertFromUtf32(233);
            rob.IsNorth = true;
            rob.IsSouth = false; rob.IsWest = false; rob.IsEast = false;
        }

        private void btnEast_Click(object sender, EventArgs e)
        {
            lblBot.Text = char.ConvertFromUtf32(232);
            rob.IsEast = true;
            rob.IsSouth = false; rob.IsWest = false; rob.IsNorth = false;
        }

        private void btnWest_Click(object sender, EventArgs e)
        {
            lblBot.Text = char.ConvertFromUtf32(231);
            rob.IsWest = true;
            rob.IsSouth = false; rob.IsNorth = false; rob.IsEast = false;
        }

        private void btnSouth_Click(object sender, EventArgs e)
        {
            lblBot.Text = char.ConvertFromUtf32(234);
            rob.IsSouth = true;
            rob.IsNorth = false; rob.IsWest = false; rob.IsEast = false;
        }

        private void btnGoOne_Click(object sender, EventArgs e)
        {
            rob.Move(1);
            Refresh();
        }

        private void btnGoTen_Click(object sender, EventArgs e)
        {
            
            rob.Move(10);
            Refresh();
        }
    }
}
