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
    public partial class Form1 : Form
    {
        public static int diamonds = 0;
        public static int miners = 0;
        public static int minercost = 25;
        public static int drillcost = 200;
        public static int drills = 0;
        public static int makercost = 1000;
        public static int makers = 0;
        public static int quarrycost = 10000;
        public static int quarrys = 0;
        public static Boolean istimeron = true;
        public static Boolean millionAchivement = false;
        public static Boolean TenMinersAchivement = false;

        public Form1()
        {
            InitializeComponent();
            this.DrawDiamonds.Start();
            this.Miner.Start();
            this.DrillTimer.Start();
            this.MakerTimer.Start();
            this.QuarryTimer.Start();
            this.DrawItems.Start();
            this.Achivements.Start();
            this.AutoSave.Start();
            this.Text = "Diamond Clicker v0.1";
            //this.button1.Image = Image.FromFile("Images\\diamond.png").GetThumbnailImage(100, 100, null, IntPtr.Zero);
        }
        
        

        public void button1_Click(object sender, EventArgs e)
        {
            diamonds = diamonds + 1;
        }

        public void button2_Click(object sender, EventArgs e)
        {
            if (diamonds > minercost - 1)
            {
                miners++;
                diamonds = diamonds - minercost;
                minercost = 35;
                miners++;
                minercost = minercost * miners;
                miners--;
                
            }
        }

        public async void Miner_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < miners; i++)
            {
                if (istimeron == true)
                {
                    await Task.Delay(500);
                    diamonds = diamonds + 2;
                }
            }
            
        }

        public void DrawDiamonds_Tick(object sender, EventArgs e)
        {
            this.label1.Text = "Diamonds: " + diamonds;
        }

        public void button3_Click(object sender, EventArgs e)
        {
            if (diamonds > drillcost - 1)
            {
                drills++;
                diamonds = diamonds - drillcost;
                drillcost = 235;
                drills++;
                drillcost = drills * drillcost;
                drills--;
            }
        }

        public async void DrillTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < drills; i++)
            {
                if (istimeron == true)
                {
                    await Task.Delay(500);
                    diamonds = diamonds + 15;
                }
            }
        }

        public void button4_Click(object sender, EventArgs e)
        {
            if (diamonds > makercost - 1)
            {
                makers++;
                diamonds = diamonds - makercost;
                makercost = 1350;
                makers++;
                makercost = makercost * makers;
                makers--;
            }
        }

        public async void MakerTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < makers; i++)
            {
                if (istimeron == true)
                {
                    await Task.Delay(500);
                    diamonds = diamonds + 25;
                }
            }
        }

        public async void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int toBase = 2;
                string diamondbinary = Convert.ToString(diamonds, toBase);
                string minersbinary = Convert.ToString(miners, toBase);
                string drillsbinary = Convert.ToString(drills, toBase);
                string quarrysbinary = Convert.ToString(quarrys, toBase);
                string makersbinary = Convert.ToString(makers, toBase);
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                System.IO.StreamWriter file = new System.IO.StreamWriter("c:\\Users\\" + Environment.UserName + "\\Documents\\DiamondClicker.dat");
                string lines = "" + diamondbinary + "\n" + minersbinary + "\n" + drillsbinary + "\n" + makersbinary + "\n" + quarrysbinary + "\n0\n0\n0\n0";
                await Task.Delay(100);
                file.WriteLine(lines);
                file.Close();
                this.button6.Enabled = true;
                this.button5.Enabled = true;
            }
            catch (Exception ex)
            {
                this.Catch.Text = "Error Saving Try again later";
                //this.Catch.Text = ex.ToString();
            }
            
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            String filepath = @"c:\\Users\\" + Environment.UserName + "\\Documents\\DiamondClicker.dat";
            if (System.IO.File.Exists(filepath) == true)
            {
                try
                {
                    string diamondsstring = System.IO.File.ReadLines(@"c:\\Users\\" + Environment.UserName + "\\Documents\\DiamondClicker.dat").Skip(0).Take(1).First();
                    string minersstring = System.IO.File.ReadLines(@"c:\\Users\\" + Environment.UserName + "\\Documents\\DiamondClicker.dat").Skip(1).Take(1).First();
                    string drillsstring = System.IO.File.ReadLines(@"c:\\Users\\" + Environment.UserName + "\\Documents\\DiamondClicker.dat").Skip(2).Take(1).First();
                    string makersstring = System.IO.File.ReadLines(@"c:\\Users\\" + Environment.UserName + "\\Documents\\DiamondClicker.dat").Skip(3).Take(1).First();
                    string quarrystring = System.IO.File.ReadLines(@"c:\\Users\\" + Environment.UserName + "\\Documents\\DiamondClicker.dat").Skip(4).Take(1).First();
                    string savefile = System.IO.File.ReadAllText(@"c:\\Users\\" + Environment.UserName + "\\Documents\\DiamondClicker.dat");
                    this.button5.Enabled = false;
                    this.button6.Enabled = false;
                    int d = Convert.ToInt32(diamondsstring, 2);
                    int m = Convert.ToInt32(minersstring, 2);
                    int dr = Convert.ToInt32(drillsstring, 2);
                    int ma = Convert.ToInt32(makersstring, 2);
                    int q = Convert.ToInt32(quarrystring, 2);
                    diamonds = d;
                    miners = m;
                    drills = dr;
                    makers = ma;
                    quarrys = q;
                    miners++;
                    makers++;
                    drills++;
                    quarrys++;
                    if (miners > 1)
                    {
                        minercost = 35;
                    }
                    else{
                        minercost = 25;
                    }
                    if (makers > 1)
                    {
                        makercost = 1350;
                    }
                    else
                    {
                        makercost = 1000;
                    }
                    if (quarrys > 1)
                    {
                        quarrycost = 12000;
                    }
                    else
                    {
                        quarrycost = 10000;
                    }
                    if (drills > 1)
                    {
                        drillcost = 235;
                    }
                    else
                    {
                        drillcost = 200;
                    }
                    minercost = minercost * miners;
                    makercost = makercost * makers;
                    drillcost = drillcost * drills;
                    quarrycost = quarrycost * quarrys;
                    quarrys--;
                    miners--;
                    makers--;
                    drills--;
                    this.button6.Enabled = true;
                    this.button5.Enabled = true;
                }
                catch(Exception ex)
                {
                    this.button6.Text = "The save you made was in a old version and cannot be read";
                    //this.Catch.Text = ex.ToString
                    this.button6.Text = "Load Saved Game";
                }
            }
            else
            {
                this.button6.Text = "No Save File found";
                await Task.Delay(2500);
                this.button6.Text = "Load Saved Game";
            }

        }

        public void button7_Click(object sender, EventArgs e)
        {
            if (diamonds > quarrycost - 1)
            {
                quarrys++;
                diamonds = diamonds - quarrycost;
                quarrycost = 12000;
                quarrys++;
                quarrycost = quarrycost * quarrys;
                quarrys--;
            }
        }
        public async void QuarryTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < quarrys; i++)
            {
                if (istimeron == true)
                {
                await Task.Delay(500);
                diamonds = diamonds + 75;
                }
            }
        }
        public void button8_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
        public static void RestartSave()
        {
            diamonds =1;
            miners = 1;
            drills = 1;
            makers = 1;
            quarrys = 1;
            minercost = 25;
            makercost = 1000;
            drillcost = 200;
            quarrycost = 12000;
            minercost = minercost * miners;
            makercost = makercost * makers;
            drillcost = drillcost * drills;
            quarrycost = quarrycost * quarrys;
        }
        private void DrawItems_Tick(object sender, EventArgs e)
        {
            this.button4.Text = "Buy Diamond Maker $" + makercost;
            this.button3.Text = "Buy Diamond Drill $" + drillcost;
            this.button2.Text = "Buy Diamond Miner $" + minercost;
            this.button7.Text = "Buy Diamond Quarry $" + quarrycost;
            this.label2.Text = "You have " + miners + " Miners";
            this.label3.Text = "You have " + drills + " Drills";
            this.label4.Text = "You have " + makers + " Makers";
            this.label5.Text = "You have " + quarrys + " Quarrys";
        }

        private async void Achivements_Tick(object sender, EventArgs e)
        {
            if(millionAchivement == false){
            if (diamonds > 999999)
            {
                label6.Text = "1 Million Diamonds! Achivement";
                
                label6.Visible = true;
                millionAchivement = true;
                await Task.Delay(5000);
                label6.Visible = false;
            }
            }
            if (TenMinersAchivement == false)
            {
                if (miners > 9)
                {
                    label6.Text = "10 Miners! Achivement";
                    label6.Visible = true;
                    TenMinersAchivement = true;
                    await Task.Delay(5000);
                    label6.Visible = false;
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AchivementForm Achivement = new AchivementForm();
            Achivement.Show();
        }

        private async void AutoSave_Tick(object sender, EventArgs e)
        {
            this.AutoSaveText.Visible = true;
            try
            {
                int toBase = 2;
                string diamondbinary = Convert.ToString(diamonds, toBase);
                string minersbinary = Convert.ToString(miners, toBase);
                string drillsbinary = Convert.ToString(drills, toBase);
                string quarrysbinary = Convert.ToString(quarrys, toBase);
                string makersbinary = Convert.ToString(makers, toBase);
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                System.IO.StreamWriter file = new System.IO.StreamWriter("c:\\Users\\" + Environment.UserName + "\\Documents\\DiamondClicker.dat");
                string lines = "" + diamondbinary + "\n" + minersbinary + "\n" + drillsbinary + "\n" + makersbinary + "\n" + quarrysbinary + "\n0\n0\n0\n0";
                await Task.Delay(2000);
                file.WriteLine(lines);
                file.Close();
                this.button6.Enabled = true;
                this.button5.Enabled = true;
                this.AutoSaveText.Visible = false;
            }catch(Exception ex){
                this.AutoSaveText.Text = "Error Auto saving.";
                this.Catch.Text = ex.ToString();
            }
        }
    }
}
