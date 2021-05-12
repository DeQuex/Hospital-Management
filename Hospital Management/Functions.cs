using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management
{
    class Functions
    {
        public static void CenterUserControl(Form fName, Control name) // usercontrolu forma gore ortalar.
        {
             name.Location = new Point(fName.Size.Width / 2 - name.Size.Width / 2, fName.Size.Height / 2 - name.Size.Height / 2);
        }

        public enum Direction
        {
            Vertical,
            Horizontal,
            Diagonal
        }

        public static void CenterControl(UserControl userControlName, Direction direction, int space = 0, params Control[] controls) // Controlleri usercontrole gore ortalar.
        {
            var uControlCenterWidth = userControlName.Size.Width / 2;
            var uControlCenterHeight = userControlName.Size.Height / 2;
            var totalControlsHeight = 0;
            var totalControlsWidth = 0;
            var hOffset = 0;
            var wOffset = 0;

            foreach (var x in controls)
            {
                totalControlsHeight += x.Height;
                totalControlsWidth += x.Width;
            }

            foreach (var control in controls)
            {
                switch (direction)
                {
                    case Direction.Vertical:
                        control.Location = new Point(uControlCenterWidth - control.Size.Width / 2, uControlCenterHeight - totalControlsHeight / controls.Length + hOffset);
                        hOffset += control.Height + space;
                        break;
                    case Direction.Horizontal:
                        control.Location = new Point(uControlCenterWidth - totalControlsWidth / controls.Length + wOffset, uControlCenterHeight - control.Size.Height / 2);
                        wOffset += control.Width + space;
                        break;
                    case Direction.Diagonal:
                        control.Location = new Point(uControlCenterWidth - totalControlsWidth / controls.Length + wOffset, uControlCenterHeight - totalControlsHeight / controls.Length + hOffset);
                        hOffset += control.Height + space;
                        wOffset += control.Width + space;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(direction), direction, null);
                }
               
            }

            
        }
        
        public static void ResizeForm(Form fName, Control cName) // formu, usercontrol boyutuna getirir.
        {
            fName.ClientSize = new Size(cName.Size.Width, cName.Size.Height );
        }

        public static void ResizeUserControl(Form fName, Control cName) // usercontrolu, form boyutuna getirir.
        {
            cName.ClientSize = new Size(fName.Size.Width, fName.Size.Height);
        }

        public static Color HexToRGB(int hexCode) //  !!GEREKSİZ!!             hexadecimal renk kodlarını argb ye çeviren fonksiyon
        {
            var temp = Color.FromArgb(hexCode);
            var result = Color.FromArgb(temp.R, temp.G, temp.B);

            return result;
        }


    }
}
