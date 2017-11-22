using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BombLibraries
{
    public class WireLibrary
    {
        public string Wire1 = "";
        public string Wire2 = "";
        public string Wire3 = "";
        public string Wire4 = "";
        public string Wire5 = "";
        public string Wire6 = "";

        public WireLibrary()
        {

        }

        public int CheckedChanged(int wire, Dictionary<string, RadioButton> WireDictionary, object sender, char[] sn)
        {
            foreach (var Colour in WireDictionary)
            {
                if (sender == Colour.Value)
                {
                    if (wire == 1)
                        Wire1 = Colour.Key;
                    else if (wire == 2)
                        Wire2 = Colour.Key;
                    else if (wire == 3)
                        Wire3 = Colour.Key;
                    else if (wire == 4)
                        Wire4 = Colour.Key;
                    else if (wire == 5)
                        Wire5 = Colour.Key;
                    else if (wire == 6)
                        Wire6 = Colour.Key;
                }
            }
            return Wire(sn);
        }

        private int Wire(char[] sn)
        {
            List<string> Wires = new List<string>
            {
                Wire1,
                Wire2,
                Wire3,
                Wire4,
                Wire5,
                Wire6
            };

            int Black = 0;
            int Red = 0;
            int White = 0;
            int Blue = 0;
            int Yellow = 0;
            foreach (var item in Wires)
            {
                if (item == "Black")
                    Black += 1;
                else if (item == "Red")
                    Red += 1;
                else if (item == "White")
                    White += 1;
                else if (item == "Blue")
                    Blue += 1;
                else if (item == "Yellow")
                    Yellow += 1;
            };

            if (Wire3 == "")
            {
                return 0;
            }
            else if (Wire4 == "")
            {
                #region 3 Wires
                if (Red == 0)
                    return 2;
                else if (Wire3 == "White")
                    return 3;
                else if (Blue > 1)
                    return (Wires.LastIndexOf("Blue") + 1);
                else
                    return 3;
                #endregion
            }
            else if (Wire5 == "")
            {
                #region  4 Wires
                if (Red > 1 && IsOdd(int.Parse(sn[sn.Length - 1].ToString())))
                    return (Wires.LastIndexOf("Red") + 1);
                else if (Wire4 == "Yellow" && Red == 0)
                    return 1;
                else if (Blue == 1)
                    return 1;
                else if (Yellow > 1)
                    return 4;
                else
                    return 2;
                #endregion
            }
            else if (Wire6 == "")
            {
                #region  5 Wires
                if (Wire5 == "Black" && IsOdd(int.Parse(sn[sn.Length - 1].ToString())))
                    return 4;
                else if (Red == 1 && Yellow > 1)
                    return 1;
                else if (Black == 0)
                    return 2;
                else
                    return 1;
                #endregion
            }
            else
            {
                #region  6 Wires
                if (Yellow == 0 && IsOdd(int.Parse(sn[sn.Length - 1].ToString())))
                    return 3;
                else if (Yellow == 1 && White > 1)
                    return 4;
                else if (Red == 0)
                    return 6;
                else
                    return 4;
                #endregion
            }
        }
        private static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }
    }
}
