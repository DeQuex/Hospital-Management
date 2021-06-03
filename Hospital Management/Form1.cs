using System;
using System.Drawing;
using System.Windows.Forms;


namespace Hospital_Management
{
    public partial class Form1 : Form
    {
        readonly UserControl loginUserControl = new Login();
        readonly UserControl registerUserControl = new Register();
        readonly UserControl AdminUControl = new AdminInterface();
        readonly UserControl NurseUControl = new NurseInterface();
        readonly UserControl DoctorUControl = new DoctorInterface();
        readonly UserControl staffUControl = new StaffInterface();
        private Control lastControl;
        public static string loginName;

        public Form1()
        {
            InitializeComponent();
        }

        private void CenterFormLocation()
        {
            var centerScreenHeight = Screen.PrimaryScreen.Bounds.Height / 2;
            var centerScreenWidth = Screen.PrimaryScreen.Bounds.Width / 2;
            var centerFormHeight = Size.Height / 2;
            var centerFormWidth = Size.Width / 2;

            Location = new Point(centerScreenWidth - centerFormWidth, centerScreenHeight - centerFormHeight);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Controls.Add(loginUserControl);
            CenterFormLocation();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (lastControl == null) return;
            Functions.ResizeUserControl(this, lastControl);
            Functions.CenterUserControl(this, lastControl);
        }

        private void Form1_ControlAdded(object sender, ControlEventArgs e)
        {
            lastControl = e.Control;
            Functions.ResizeForm(this, lastControl);
            Functions.CenterUserControl(this, lastControl);
            CenterFormLocation();
        }
    }
}
