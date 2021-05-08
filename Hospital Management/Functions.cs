﻿using System;
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
        public static void ResizeForm(Form fName, Control name)
        {
            fName.Size = new Size(name.Size.Width, name.Size.Height);
        }

    }
}