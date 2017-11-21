using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Screen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string Wire1 = "";
        public string Wire2 = "";
        public string Wire3 = "";
        public string Wire4 = "";
        public string Wire5 = "";
        public string Wire6 = "";

        Dictionary<int, PictureBox> Picture = new Dictionary<int, PictureBox>();

        Dictionary<string, RadioButton> Wire1Dictionary = new Dictionary<string, RadioButton>();
        Dictionary<string, RadioButton> Wire2Dictionary = new Dictionary<string, RadioButton>();
        Dictionary<string, RadioButton> Wire3Dictionary = new Dictionary<string, RadioButton>();
        Dictionary<string, RadioButton> Wire4Dictionary = new Dictionary<string, RadioButton>();
        Dictionary<string, RadioButton> Wire5Dictionary = new Dictionary<string, RadioButton>();
        Dictionary<string, RadioButton> Wire6Dictionary = new Dictionary<string, RadioButton>();

        private void Form1_Load(object sender, EventArgs e)
        {
            Wire1Dictionary.Add("Black", Wire1Black);
            Wire1Dictionary.Add("Red", Wire1Red);
            Wire1Dictionary.Add("White", Wire1White);
            Wire1Dictionary.Add("Blue", Wire1Blue);
            Wire1Dictionary.Add("Yellow", Wire1Yellow);

            Wire2Dictionary.Add("Black", Wire2Black);
            Wire2Dictionary.Add("Red", Wire2Red);
            Wire2Dictionary.Add("White", Wire2White);
            Wire2Dictionary.Add("Blue", Wire2Blue);
            Wire2Dictionary.Add("Yellow", Wire2Yellow);

            Wire3Dictionary.Add("Black", Wire3Black);
            Wire3Dictionary.Add("Red", Wire3Red);
            Wire3Dictionary.Add("White", Wire3White);
            Wire3Dictionary.Add("Blue", Wire3Blue);
            Wire3Dictionary.Add("Yellow", Wire3Yellow);

            Wire4Dictionary.Add("Black", Wire4Black);
            Wire4Dictionary.Add("Red", Wire4Red);
            Wire4Dictionary.Add("White", Wire4White);
            Wire4Dictionary.Add("Blue", Wire4Blue);
            Wire4Dictionary.Add("Yellow", Wire4Yellow);

            Wire5Dictionary.Add("Black", Wire5Black);
            Wire5Dictionary.Add("Red", Wire5Red);
            Wire5Dictionary.Add("White", Wire5White);
            Wire5Dictionary.Add("Blue", Wire5Blue);
            Wire5Dictionary.Add("Yellow", Wire5Yellow);

            Wire6Dictionary.Add("Black", Wire6Black);
            Wire6Dictionary.Add("Red", Wire6Red);
            Wire6Dictionary.Add("White", Wire6White);
            Wire6Dictionary.Add("Blue", Wire6Blue);
            Wire6Dictionary.Add("Yellow", Wire6Yellow);

            Picture.Add(1, pictureBox1);
            Picture.Add(2, pictureBox2);
            Picture.Add(3, pictureBox3);
            Picture.Add(4, pictureBox4);
            Picture.Add(5, pictureBox5);
            Picture.Add(6, pictureBox6);
        }

        private void Wire1_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var Colour in Wire1Dictionary)
            {
                if (sender == Colour.Value)
                {
                    Wire1 = Colour.Key;
                }
            }
            Wire();
        }
        private void Wire2_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var Colour in Wire2Dictionary)
            {
                if (sender == Colour.Value)
                {
                    Wire2 = Colour.Key;
                }
            }
            Wire();
        }
        private void Wire3_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var Colour in Wire3Dictionary)
            {
                if (sender == Colour.Value)
                {
                    Wire3 = Colour.Key;
                }
            }
            groupBox4.Enabled = true;
            Wire();
        }
        private void Wire4_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var Colour in Wire4Dictionary)
            {
                if (sender == Colour.Value)
                {
                    Wire4 = Colour.Key;
                }
            }
            groupBox5.Enabled = true;
            Wire();
        }
        private void Wire5_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var Colour in Wire5Dictionary)
            {
                if (sender == Colour.Value)
                {
                    Wire5 = Colour.Key;
                }
            }
            groupBox6.Enabled = true;
            Wire();
        }
        private void Wire6_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var Colour in Wire6Dictionary)
            {
                if (sender == Colour.Value)
                {
                    Wire6 = Colour.Key;
                }
            }
            Wire();
        }

        private void Wire()
        {
            if (Wire3 == "")
            {
                
            }
            else if (Wire4 == "")
            {
                #region 3 Wires
                if (Wire1 != "Red" && Wire2 != "Red" && Wire3 != "Red")
                {
                    //2
                    showAnimatedPictureBox(2);
                }
                else if (Wire3 == "White")
                {
                    //3
                    showAnimatedPictureBox(3);
                }
                else if (Wire3 == "Blue" && Wire1 == "Blue")
                {
                    //3
                    showAnimatedPictureBox(3);
                }
                else if (Wire3 == "Blue" && Wire2 == "Blue")
                {
                    //3
                    showAnimatedPictureBox(3);
                }
                else if (Wire2 == "Blue" && Wire1 == "Blue")
                {
                    //2
                    showAnimatedPictureBox(2);
                }
                else
                {
                    //3
                    showAnimatedPictureBox(3);
                }
                #endregion
            }
            else if (Wire5 == "")
            {
                #region  4 Wires
                // odd
                if (Wire4 == "Red" && Wire3 == "Red")
                {
                    //4
                    showAnimatedPictureBox(4);
                }
                else if (Wire4 == "Red" && Wire2 == "Red")
                {
                    //4
                    showAnimatedPictureBox(4);
                }
                else if (Wire4 == "Red" && Wire1 == "Red")
                {
                    //4
                    showAnimatedPictureBox(4);
                }
                else if (Wire3 == "Red" && Wire2 == "Red")
                {
                    //3
                    showAnimatedPictureBox(3);
                }
                else if (Wire3 == "Red" && Wire1 == "Red")
                {
                    //3
                    showAnimatedPictureBox(3);
                }
                else if (Wire2 == "Red" && Wire1 == "Red")
                {
                    //2
                    showAnimatedPictureBox(2);
                }
                else if (Wire4 == "Yellow" && Wire3 != "Red" && Wire2 != "Red" && Wire1 != "Red")
                {
                    //1
                    showAnimatedPictureBox(1);
                }
                #endregion
            }
            else if (Wire6 == "")
            {
                #region  5 Wires
                #endregion
            }
            else
            {
                #region  6 Wires
                #endregion
            }
        }

        public void showAnimatedPictureBox(int Green)
        {
            foreach (var item in Picture)
            {
                if (Green == item.Key)
                    item.Value.Image = Properties.Resources.squareG;
                else
                    item.Value.Image = Properties.Resources.square;
                item.Value.Invalidate();
                item.Value.Visible = true;
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cntls = GetAll(this, typeof(RadioButton));
            foreach (Control cntrl in cntls)
            {
                RadioButton _rb = (RadioButton)cntrl;
                if (_rb.Checked)
                {
                    _rb.Checked = false;
                }
            }

            Wire1 = "";
            Wire2 = "";
            Wire3 = "";
            Wire4 = "";
            Wire5 = "";
            Wire6 = "";

            showAnimatedPictureBox(0);

            groupBox4.Enabled = false;
            groupBox5.Enabled = false;
            groupBox6.Enabled = false;
        }

        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(ctrls => GetAll(ctrls, type)).Concat(controls).Where(c => c.GetType() == type);
        }
    }
}
