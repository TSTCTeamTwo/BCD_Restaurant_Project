#region Imports

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

#endregion

namespace BCD_Restaurant_Project.Classes {
    public static class RandomColor {
        public static List<string> hexadecimalColorList = new List<string> {
                                                                               "#3F51B5", "#009688", "#FF5722",
                                                                               "#607D8B", "#FF9800", "#9C27B0",
                                                                               "#2196F3", "#EA676C", "#E41A4A",
                                                                               "#5978BB", "#018790", "#0E3441",
                                                                               "#00B0AD", "#721D47", "#EA4833",
                                                                               "#EF937E", "#F37521", "#A12059",
                                                                               "#126881", "#8BC240", "#364D5B",
                                                                               "#C7DC5B", "#0094BC", "#E4126B",
                                                                               "#43B76E", "#7BCFE9", "#B71C46"
                                                                           };

        private static Random RandomObj {
            get;
        } = new Random();

        private static int TemporaryIndex {
            get;
            set;
        }

        public static Color PrimaryColor {
            get;
            private set;
        }

        public static Color SecondaryColor {
            get;
            private set;
        }

        public static Color TertiaryColor {
            get;
            private set;
        }

        public static void setThemeColor() {
            int index = RandomObj.Next(hexadecimalColorList.Count);
            while (TemporaryIndex == index)
                index = RandomObj.Next(hexadecimalColorList.Count);

            TemporaryIndex = index;
            PrimaryColor = ColorTranslator.FromHtml(hexadecimalColorList[index]);
            double red = PrimaryColor.R;
            double green = PrimaryColor.G;
            double blue = PrimaryColor.B;
            double secondaryColorBrightness = -0.30;
            double tertiaryColorBrightness = .93;
            //loop up if luminence calculation is correct...
            if (secondaryColorBrightness < 0) {
                secondaryColorBrightness = 1 + secondaryColorBrightness;
                red *= secondaryColorBrightness;
                green *= secondaryColorBrightness;
                blue *= secondaryColorBrightness;
            } else {
                red = ((255 - red) * secondaryColorBrightness) + red;
                green = ((255 - green) * secondaryColorBrightness) + green;
                blue = ((255 - blue) * secondaryColorBrightness) + blue;
            }

            //try to understand the github repository for this again...seemed to be easy to understand but look at again.
            SecondaryColor = Color.FromArgb(PrimaryColor.A, (byte)red, (byte)green, (byte)blue);

            red = PrimaryColor.R;
            green = PrimaryColor.G;
            blue = PrimaryColor.B;

            if (tertiaryColorBrightness < 0) {
                tertiaryColorBrightness = 1 + tertiaryColorBrightness;
                red *= tertiaryColorBrightness;
                green *= tertiaryColorBrightness;
                blue *= tertiaryColorBrightness;
            } else {
                red = ((255 - red) * tertiaryColorBrightness) + red;
                green = ((255 - green) * tertiaryColorBrightness) + green;
                blue = ((255 - blue) * tertiaryColorBrightness) + blue;
            }

            TertiaryColor = Color.FromArgb(PrimaryColor.A, (byte)red, (byte)green, (byte)blue);
        }

        public static Color getTextColor() {
            //Function for Calculating Color Contrast
            if (((SecondaryColor.R * 0.2126) + (SecondaryColor.G * 0.7152) + (SecondaryColor.B * 0.0722)) > 127)
                //light background
                return Color.Black;
            return Color.White;
        }

        public static void setFormColors(Form m) {
            setThemeColor();

            foreach (Panel panel in m.Controls.OfType<Panel>()) {
                // MessageBox.Show(panel.Name.ToString(), "Title", MessageBoxButtons.OK, MessageBoxIcon.Information);
                foreach (Label label in panel.Controls.OfType<Label>()) {
                    // MessageBox.Show(label.Name.ToString(), "Title", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    label.BackColor = PrimaryColor;
                    label.ForeColor = getTextColor();
                }
            }

            foreach (Button button in m.Controls.OfType<Button>()) {
                button.BackColor = SecondaryColor;
                button.ForeColor = getTextColor();
            }
        }
    }
}