using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Main_Screen
{
    public partial class Form1 : Form
    {
        public int simplewires = 3;
        public List<RadioButton> simplewires1 = new List<RadioButton> { };
        public List<RadioButton> simplewires2 = new List<RadioButton> { };
        public List<RadioButton> simplewires3 = new List<RadioButton> { };
        public List<RadioButton> simplewires4 = new List<RadioButton> { };
        public List<RadioButton> simplewires5 = new List<RadioButton> { };
        public List<RadioButton> simplewires6 = new List<RadioButton> { };

        private void AddWires()
        {
            simplewires1.Add(Wire1Black);
            simplewires1.Add(Wire1Red);
            simplewires1.Add(Wire1White);
            simplewires1.Add(Wire1Blue);
            simplewires1.Add(Wire1Yellow);

            simplewires2.Add(Wire1Black);
            simplewires2.Add(Wire1Red);
            simplewires2.Add(Wire1White);
            simplewires2.Add(Wire1Blue);
            simplewires2.Add(Wire1Yellow);

            simplewires3.Add(Wire1Black);
            simplewires3.Add(Wire1Red);
            simplewires3.Add(Wire1White);
            simplewires3.Add(Wire1Blue);
            simplewires3.Add(Wire1Yellow);

            simplewires4.Add(Wire1Black);
            simplewires4.Add(Wire1Red);
            simplewires4.Add(Wire1White);
            simplewires4.Add(Wire1Blue);
            simplewires4.Add(Wire1Yellow);

            simplewires5.Add(Wire1Black);
            simplewires5.Add(Wire1Red);
            simplewires5.Add(Wire1White);
            simplewires5.Add(Wire1Blue);
            simplewires5.Add(Wire1Yellow);

            simplewires6.Add(Wire1Black);
            simplewires6.Add(Wire1Red);
            simplewires6.Add(Wire1White);
            simplewires6.Add(Wire1Blue);
            simplewires6.Add(Wire1Yellow);
        }

        #region Wire Amount Buttons
        private void button3_Click(object sender, EventArgs e)
        {
            simplewires = 3;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            simplewires = 4;
            groupBox4.Visible = true;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            simplewires = 5;
            groupBox4.Visible = true;
            groupBox5.Visible = true;
            groupBox6.Visible = false;
            groupBox7.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            simplewires = 6;
            groupBox4.Visible = true;
            groupBox5.Visible = true;
            groupBox6.Visible = true;
            groupBox7.Visible = true;
        }
        #endregion

        #region Wire Function
        private void button1_Click(object sender, EventArgs e)
        {
            #region 3 wires
            if (simplewires == 3)
            {
                #region If there are no red wires,
                if (Wire1Red.Checked == true || Wire2Red.Checked == true || Wire3Red.Checked == true)
                {
                    MessageBox.Show("Cut the second wire");
                    return;
                }
                #endregion
                #region Otherwise, if the lasy wire is white,
                if (Wire3White.Checked)
                {
                    MessageBox.Show("Cut the last wire");
                    return;
                }
                #endregion
                #region Otherwise, if there is more than one blue,
                List<RadioButton> blues = new List<RadioButton> { };
                blues.Add(Wire1Blue);
                blues.Add(Wire2Blue);
                blues.Add(Wire3Blue);
                int bluecount = 0;
                foreach(RadioButton wire in blues)
                {
                    if (wire.Checked)
                    {
                        bluecount++;
                    }
                }
                if (bluecount > 1)
                {
                    MessageBox.Show("Cut the last blue wire");
                    return;
                }
                #endregion
                #region Otherwise,
                MessageBox.Show("Cut the last wire");
                return;
                #endregion
            }
            #endregion

            #region 4 wires
            if(simplewires == 4)
            {
                #region If there is more than one red wire and the last digit of the serial number is odd,
                List<RadioButton> reds = new List<RadioButton> { };
                reds.Add(Wire1Red);
                reds.Add(Wire2Red);
                reds.Add(Wire3Red);
                reds.Add(Wire4Red);
                int redcount = 0;
                foreach (RadioButton wire in reds)
                {
                    if (wire.Checked)
                    {
                        redcount++;
                    }
                }
                if (redcount > 1 && comboBox1.SelectedItem.ToString() == "Odd")
                {
                    MessageBox.Show("Cut the last wire");
                    return;
                }
                #endregion
                #region Otherwise, if the last wire is yellow and there are no red wires,
                if (Wire4Yellow.Checked && redcount == 0)
                {
                    MessageBox.Show("Cut the first wire");
                    return;
                }
                #endregion
                #region Otherwise, if there is exactly one blue wire,
                List<RadioButton> blues = new List<RadioButton> { };
                blues.Add(Wire1Blue);
                blues.Add(Wire2Blue);
                blues.Add(Wire3Blue);
                blues.Add(Wire4Blue);
                int bluecount = 0;
                foreach (RadioButton wire in blues)
                {
                    if (wire.Checked)
                    {
                        bluecount++;
                    }
                }
                if (bluecount == 1)
                {
                    MessageBox.Show("Cut the first wire");
                    return;
                }
                #endregion
                #region Otherwise, if there is more than one yellow wire,
                List<RadioButton> yellows = new List<RadioButton> { };
                yellows.Add(Wire1Yellow);
                yellows.Add(Wire2Yellow);
                yellows.Add(Wire3Yellow);
                yellows.Add(Wire4Yellow);
                int yellowcount = 0;
                foreach (RadioButton wire in yellows)
                {
                    if (wire.Checked)
                    {
                        yellowcount++;
                    }
                }
                if (yellowcount > 1)
                {
                    MessageBox.Show("Cut the last wire");
                    return;
                }
                #endregion
                #region Otherwise,
                MessageBox.Show("Cut the second wire");
                return;
                #endregion
            }
            #endregion

            #region 5 wires
            if(simplewires == 5)
            {
                #region If the last wire is black and the last digit of the serial number is odd,
                if(Wire5Black.Checked && comboBox1.SelectedIndex.ToString() == "Odd")
                {
                    MessageBox.Show("Cut the fourth wire");
                    return;
                }
                #endregion
                #region Otherwise, if there is exactly one red wire and there is more than one yellow wire,
                List<RadioButton> reds = new List<RadioButton> { };
                reds.Add(Wire1Red);
                reds.Add(Wire2Red);
                reds.Add(Wire3Red);
                reds.Add(Wire4Red);
                reds.Add(Wire5Red);
                int redcount = 0;
                foreach (RadioButton wire in reds)
                {
                    if (wire.Checked)
                    {
                        redcount++;
                    }
                }
                List<RadioButton> yellows = new List<RadioButton> { };
                yellows.Add(Wire1Yellow);
                yellows.Add(Wire2Yellow);
                yellows.Add(Wire3Yellow);
                yellows.Add(Wire4Yellow);
                yellows.Add(Wire5Yellow);
                int yellowcount = 0;
                foreach (RadioButton wire in yellows)
                {
                    if (wire.Checked)
                    {
                        yellowcount++;
                    }
                }
                if (redcount == 1 && yellowcount > 1)
                {
                    MessageBox.Show("Cut the first wire");
                    return;
                }
                #endregion
                #region Otherwise, if there are no black wires,
                List<RadioButton> blacks = new List<RadioButton> { };
                blacks.Add(Wire1Black);
                blacks.Add(Wire2Black);
                blacks.Add(Wire3Black);
                blacks.Add(Wire4Black);
                blacks.Add(Wire5Black);
                int blackcount = 0;
                foreach (RadioButton wire in blacks)
                {
                    if (wire.Checked)
                    {
                        blackcount++;
                    }
                }
                if (blackcount == 0)
                {
                    MessageBox.Show("Cut the second wire");
                    return;
                }
                #endregion
                #region Otherwise,
                MessageBox.Show("Cut the first wire");
                return;
                #endregion
            }
            #endregion

            #region 6 wires
            if (simplewires == 6)
            {
                #region If there are no yellow wires and the last digit of the serial number is odd,
                List<RadioButton> yellows = new List<RadioButton> { };
                yellows.Add(Wire1Yellow);
                yellows.Add(Wire2Yellow);
                yellows.Add(Wire3Yellow);
                yellows.Add(Wire4Yellow);
                yellows.Add(Wire5Yellow);
                yellows.Add(Wire6Yellow);
                int yellowcount = 0;
                foreach (RadioButton wire in yellows)
                {
                    if (wire.Checked)
                    {
                        yellowcount++;
                    }
                }
                if (yellowcount == 0 && comboBox1.SelectedItem.ToString() == "Odd")
                {
                    MessageBox.Show("Cut the third wire");
                    return;
                }
                #endregion
                #region Otherwise, if there is exactly one yellow wire and there is more than one white wire,
                List<RadioButton> whites = new List<RadioButton> { };
                whites.Add(Wire1White);
                whites.Add(Wire2White);
                whites.Add(Wire3White);
                whites.Add(Wire4White);
                whites.Add(Wire5White);
                whites.Add(Wire6White);
                int whitecount = 0;
                foreach (RadioButton wire in whites)
                {
                    if (wire.Checked)
                    {
                        whitecount++;
                    }
                }
                if (yellowcount == 1 && whitecount > 1)
                {
                    MessageBox.Show("Cut the fourth wire");
                    return;
                }
                #endregion
                #region Otherwise, if there are no red wires,
                List<RadioButton> reds = new List<RadioButton> { };
                reds.Add(Wire1Red);
                reds.Add(Wire2Red);
                reds.Add(Wire3Red);
                reds.Add(Wire4Red);
                reds.Add(Wire5Red);
                reds.Add(Wire6Red);
                int redcount = 0;
                foreach (RadioButton wire in reds)
                {
                    if (wire.Checked)
                    {
                        redcount++;
                    }
                }
                if (redcount == 0)
                {
                    MessageBox.Show("Cut the last wire");
                    return;
                }
                #endregion
                #region Otherwise,
                MessageBox.Show("Cut the fourth wire");
                return;
                #endregion
            }
            #endregion
        }
        #endregion
    }
}
