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
        public static void CenterUserControl(Form fName, Control name)
        {
             name.Location = new Point(fName.Size.Width / 2 - (name.Size.Width / 2), fName.Size.Height / 2 - (name.Size.Height / 2));
        }

        public static void CenterControl(UserControl userControlName, Control cName)
        {
            cName.Location = new Point(userControlName.Size.Width / 2 - (cName.Size.Width / 2), userControlName.Size.Height / 2 - (cName.Size.Height / 2));
        }
        public static void ResizeForm(Form fName, Control name)
        {
            fName.Size = new Size(name.Size.Width, name.Size.Height);
        }
        // hexadecimal renk kodlarını argb ye çeviren fonksiyon
        public static Color changeColor(int hexCode)
        {
            Color temp = Color.FromArgb(hexCode);
            Color result = Color.FromArgb(temp.R, temp.G, temp.B);

            return result;
        }

        public static void ResizeUserControl(Form fName, Control cName)
        {
            cName.Size = new Size(fName.Size.Width, fName.Size.Height);
        }

    }
}
