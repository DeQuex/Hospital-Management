using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Account_Management;
using Google.Protobuf;
using MySql.Data;
using MySql.Data.MySqlClient;
using static System.String;

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

                connection.Open();
                string sql = null;

                var colums = "";
                var values = "";
                for (var i = 0; i < data.Length; i++)
                {
                    colums += data[i][0];

                    values += '"';
                    values += data[i][1];
                    values += '"';
                    if (i == data.Length - 1) continue;
                    colums += ",";
                    values += ",";
                }
                sql = $"insert into sas.{table_name}({colums}) values({values});";

                var insert = new MySqlCommand(sql, connection);
                insert.ExecuteReader();
                connection.Close();

            }

            public static void Edit(string table_name, string columnKey, string columnValue, string whereKey, string whereValue)
            {
                var connection = new MySqlConnection(connectionString);
                try
                {
                    connection.Open();
                    var sql = $"update sas.{table_name} set {columnKey} = {columnValue} where {whereKey} = '{whereValue}';";
                    var edit = new MySqlCommand(sql, connection);
                    edit.ExecuteReader();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            public static List<string> ReadValue(string table_name, string columnKey, string whereKey, string whereValue)
            {
                var connection = new MySqlConnection(connectionString);
                var values = new List<string>();
                try
                {
                    connection.Open();
                    var sql = $"select {columnKey} from sas.{table_name} where {whereKey} = '{whereValue}';";
                    var data = new MySqlCommand(sql, connection);
                    var reader = data.ExecuteReader();
                    
                    var i = 0;
                    while (reader.Read())
                    {
                        values.Add(reader.GetString(i));
                        i++;
                    }

                    connection.Close();
                    return values;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                return null;
            }

            public static List<string> Read(string table_name, string whereKey, string whereValue)
            {
                var connection = new MySqlConnection(connectionString);
                var values = new List<string>();
                try
                {
                    connection.Open();
                    var sql = $"select * from sas.{table_name} where {whereKey} = '{whereValue}';";
                    var data = new MySqlCommand(sql, connection);
                    var reader = data.ExecuteReader();

                    var i = 0;
                    while (reader.Read())
                    {
                        values.Add(reader.GetString(i));
                        i++;
                    }

                    connection.Close();
                    return values;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                return null;
            }

            public static DataTable ReadAllDataSource(string table_name)
            {
                var connection = new MySqlConnection(connectionString);
                DataTable dataTable = new DataTable();
                var values = new List<string>();
                try
                {
                    var sql = $"select * from sas.{table_name};";
                    var data = new MySqlCommand(sql, connection);

                    connection.Open();
                    var da = new MySqlDataAdapter(data);
                    da.Fill(dataTable);
                    connection.Close();
                    return dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                return null;
            }

            public static AccountList GetUsers()
            {
                var liste = new AccountList();
                var data = ReadAllDataSource("users");
                foreach (DataRow xRow in data.Rows)
                {
                    liste.addAccount(new Account(xRow["id"].ToString(), xRow["name"].ToString(), xRow["surname"].ToString(),
                        xRow["staff_tc"].ToString(), xRow["password"].ToString(), xRow["mail"].ToString(),
                        xRow["department"].ToString(), xRow["approve_status"].ToString(), xRow["staff_id"].ToString()));
                }

                return liste;
            }


            public static DataTable ReadUApproved(string table_name)
            {
                var connection = new MySqlConnection(connectionString);
                DataTable dataTable = new DataTable();
                var values = new List<string>();
                try
                {

                    var sql = $"select id,name,surname,staff_tc,mail,department,approve_status,staff_id from sas.{table_name} where approve_status = '0';";
                    var data = new MySqlCommand(sql, connection);

                    connection.Open();

                    var da = new MySqlDataAdapter(data);
                    da.Fill(dataTable);




                    connection.Close();
                    return dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                return null;
            }
            public static bool check_connection()
            {
                var result = false;
                var connection = new MySqlConnection(connectionString);
                try
                {
                    connection.Open();
                    result = true;
                    connection.Close();
                }
                catch
                {
                    result = false;
                }
                return result;
            }
        }

        public static string GeneratePassword()
        {
            StringBuilder builder = new StringBuilder();
            Enumerable
                .Range(65, 26)
                .Select(e => ((char)e).ToString())
                .Concat(Enumerable.Range(97, 26).Select(e => ((char)e).ToString()))
                .Concat(Enumerable.Range(0, 10).Select(e => e.ToString()))
                .OrderBy(e => Guid.NewGuid())
                .Take(11)
                .ToList().ForEach(e => builder.Append(e));
            var id = builder.ToString();
            return id;
        }
        public static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (var sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                foreach (var t in bytes)
                {
                    builder.Append(t.ToString("x2"));
                }
                return builder.ToString();
            }
        }
        public static string CreateId(int length)
        {
            while (true)
            {
                const string valid = "1234567890";
                var res = new StringBuilder();
                var rnd = new Random();
                while (0 < length--)
                {
                    res.Append(valid[rnd.Next(valid.Length)]);
                }

                if (res.ToString().StartsWith("0")) continue;
                return res.ToString();
            }

        }
        public static void sendMail(string pwd, string mail, string ad)
        {
            var Client = new SmtpClient()
            {
                Host = "mail.ataberkozturk.com",
                Port = 587,
                EnableSsl = false,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential()
                {
                    UserName = "sasproject@ataberkozturk.com",
                    Password = "t-wY3Nv:H=Mj681_"
                }
            };
            var messageText = $"Sayın {ad}, rastgele oluşturulmuş şifreniz: {pwd} dir";
            var FromEmail = new MailAddress("sasproject@ataberkozturk.com", "SAS Project");
            var ToEmail = new MailAddress(mail, "Sayın " + ad);
            var Message = new MailMessage()
            {
                From = FromEmail,
                Subject = "Rastgele oluşturulmuş şifreniz",
                Body = messageText,
            };
            Message.To.Add(ToEmail);
            Client.Send(Message);
        }
        public static bool sendMailCheck()
        {
            var result = false;
            var Client = new SmtpClient()
            {
                Host = "mail.ataberkozturk.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential()
                {
                    UserName = "sasproject@ataberkozturk.com",
                    Password = "t-wY3Nv:H=Mj681_"
                }
            };
            var messageText = $"Connection test";
            var FromEmail = new MailAddress("sasproject@ataberkozturk.com", "Sas Hastane");
            var ToEmail = new MailAddress("sasproject@ataberkozturk.com", "Connection test");
            var Message = new MailMessage()
            {
                From = FromEmail,
                Subject = "Connection test",
                Body = messageText,
            };
            Message.To.Add(ToEmail);
            try
            {
                Client.Send(Message);
                result = true;
            }
            catch (Exception e)
            {
                result = false;
            }

            return result;
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


        // admin panel kullanıcı bulma
        public static string findUser(string first_name, string department_name)
        {
            string connectionString = "server=213.238.178.36;user=sasadmin;database=sas;port=3306;password=YcX8KqHbW3LmW3jF";
            var connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                string Query = $"SELECT * FROM sas.test WHERE tc = '{first_name}' AND testcol3 = '{department_name}';";
                var insert = new MySqlCommand(Query, connection);
                var reader= insert.ExecuteReader();
                string result = "";
                while(reader.Read())
                {
                    for (var i= 0; i < 5;i++)
                    {
                        result += reader.GetString(i) + " ";
                        Console.WriteLine(result);
                    }
                }
                connection.Close();
                return result;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return null;
        }

        public static string unapprovedUsers()
        {
            string connectionString = "server=213.238.178.36;user=sasadmin;database=sas;port=3306;password=YcX8KqHbW3LmW3jF";
            var connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                string Query = $"SELECT * FROM sas.users WHERE approve_status = '0' ;";
                var insert = new MySqlCommand(Query, connection);
                var reader = insert.ExecuteReader();
                string result = "";
                while (reader.Read())
                {
                    for (int i = 0; i < 7; i++)
                    {
                        result += reader.GetString(i) + " ";
                        Console.WriteLine(result);
                    }

                }
                connection.Close();

                return result;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            return null;
        }

        public static void editUser()
        {
            string connectionString = "server=213.238.178.36;user=sasadmin;database=sas;port=3306;password=YcX8KqHbW3LmW3jF";
            var connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                string Query = $"update sas.test set tc = 'Savaş' where testcol3 = 'deneme';";
                var insert = new MySqlCommand(Query, connection);
                var reader = insert.ExecuteReader();
                connection.Close();



            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }



    }
}
