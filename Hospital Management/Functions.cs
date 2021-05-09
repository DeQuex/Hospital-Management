using System;
using System.Collections.Generic;
using System.Drawing;
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
             name.Location = new Point(fName.Size.Width / 2 - (name.Size.Width / 2), fName.Size.Height / 2 - (name.Size.Height / 2));
        }

        public static void CenterControl(UserControl userControlName, Control cName) // Controlleri usercontrole gore ortalar.
        {
            cName.Location = new Point(userControlName.Size.Width / 2 - (cName.Size.Width / 2), userControlName.Size.Height / 2 - (cName.Size.Height / 2));
        }
        
        public static void ResizeForm(Form fName, Control cName) // formu, usercontrol boyutuna getirir.
        {
            fName.Size = new Size(cName.Size.Width, cName.Size.Height);
        }

        public static void ResizeUserControl(Form fName, Control cName) // usercontrolu, form boyutuna getirir.
        {
            cName.Size = new Size(fName.Size.Width, fName.Size.Height);
        }

        public static Color HexToRGB(int hexCode) // hexadecimal renk kodlarını argb ye çeviren fonksiyon
        {
            var temp = Color.FromArgb(hexCode);
            var result = Color.FromArgb(temp.R, temp.G, temp.B);

            return result;
        }



    }
}
