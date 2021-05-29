using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Hospital_Management
{
    class Functions
    {
        internal class MySQL
        {
            private static string connectionString = "server=213.238.178.36;user=sasadmin;database=sas;port=3306;password=YcX8KqHbW3LmW3jF";

            public static void Add(string table_name, params string[][] data)
            {
                var connection = new MySqlConnection(connectionString);
                try
                {
                    connection.Open();
                    string sql = null;

                    var colums = "";
                    var values = "";
                    for (var i = 0; i < data.Length; i++)
                    {
                        colums += data[i][0];
                        values += data[i][1];
                        if (i == data.Length - 1) continue;
                        colums += ",";
                        values += ",";
                    }
                    sql = $"insert into sas.{table_name}({colums}) values({values});";

                    var insert = new MySqlCommand(sql, connection);
                    insert.ExecuteReader();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }

        }

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


        public static void OrderControl(UserControl userControlName, Direction direction, int space = 0, params Control[] controls) // Controlleri usercontrole gore ortalar.
        {
            var uControlCenterWidth = userControlName.ClientSize.Width / 2;
            var uControlCenterHeight = userControlName.ClientSize.Height / 2;
            var totalControlsHeight = 0;
            var totalControlsWidth = 0;
            var hOffset = 0;
            var wOffset = 0;
            var spaceOffset = 0;
            spaceOffset = space * (controls.Length - 1);

            foreach (var x in controls)
            {
                totalControlsHeight += x.Height;
                totalControlsWidth += x.Width;
            }

            totalControlsHeight += spaceOffset;
            totalControlsWidth += spaceOffset;


            foreach (var control in controls)
            {
                switch (direction)
                {
                    case Direction.Vertical:
                        //control.Location = new Point(uControlCenterWidth - control.ClientSize.Width / 2, uControlCenterHeight - totalControlsHeight / controls.Length + hOffset); old method don't delete
                        control.Location = new Point(control.Location.X, uControlCenterHeight - totalControlsHeight / controls.Length + hOffset);
                        hOffset += control.Height + space;
                        break;
                    case Direction.Horizontal:
                        //  control.Location = new Point(uControlCenterWidth - totalControlsWidth / controls.Length + wOffset, uControlCenterHeight - control.ClientSize.Height / 2); old method don't delete
                        control.Location = new Point(uControlCenterWidth - totalControlsWidth / controls.Length + wOffset, control.Location.Y);
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

    }
}
