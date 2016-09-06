using System;
using System.Windows.Forms;

namespace Test
{
    public partial class RobotForm : Form
    {
        private Robot mijnRobot;

        public RobotForm()
        {
            InitializeComponent();
        }

        private void btInitialiseer_Click(object sender, EventArgs e)
        {
            int initielePlaats = Convert.ToInt32(nudInitielePlaats.Value);
            int initieleRichting = Convert.ToInt32(nudInitieleRichting.Value);

            mijnRobot = new Robot(initielePlaats, initieleRichting);
        }

        private void btZetEenStap_Click(object sender, EventArgs e)
        {
            if (mijnRobot != null)
            {
                mijnRobot.zetEenStap();
            }
        }

        private void btGaNaar_Click(object sender, EventArgs e)
        {
            if (mijnRobot != null)
            {
                mijnRobot.gaNaar(Convert.ToInt32(nudBestemming.Value));
            }
        }
    }
}
