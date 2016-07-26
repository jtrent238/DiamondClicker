using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicker_Game
{
    public partial class AchivementForm : Form
    {
        Boolean millionachivementdone = false;
        Boolean tenminersachivementdone = false;
        public AchivementForm()
        {
            InitializeComponent();
            this.Achivementtimer.Start();
        }

        private void Achivementtimer_Tick(object sender, EventArgs e)
        {
            if (millionachivementdone == false)
            {
                if (Form1.millionAchivement == true)
                {
                    millionachivementdone = true;
                    this.label1.Visible = true;
                    this.label3.Visible = false;
                }
            }
            if (tenminersachivementdone == false)
            {
                if (Form1.TenMinersAchivement == true)
                {
                    tenminersachivementdone = true;
                    this.label2.Visible = true;
                    this.label3.Visible = false;
                }
            }
        }

    }
}
