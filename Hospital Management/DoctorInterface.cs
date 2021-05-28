﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management
{
    public partial class DoctorInterface : UserControl
    {
        public DoctorInterface()
        {
            InitializeComponent();
        }

        private void DoctorInterface_Load(object sender, EventArgs e)
        {
            Functions.OrderControl(this, Functions.Direction.Horizontal, 20, sidePanel, information);
            Functions.OrderControl(this, Functions.Direction.Horizontal, 20, sidePanel, operation);
            Functions.OrderControl(this, Functions.Direction.Horizontal, 20, sidePanel, panel22);
            Functions.OrderControl(this, Functions.Direction.Horizontal, 20, sidePanel, ajanda);
        }


        private void DoctorInterface_SizeChanged(object sender, EventArgs e)
        {
            Functions.OrderControl(this, Functions.Direction.Horizontal, 20, sidePanel, information);
            Functions.OrderControl(this, Functions.Direction.Horizontal, 20, sidePanel, operation);
            Functions.OrderControl(this, Functions.Direction.Horizontal, 20, sidePanel, panel22);
            Functions.OrderControl(this, Functions.Direction.Horizontal, 20, sidePanel, ajanda);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            information.Visible = true;
            operation.Visible = false;
            panel22.Visible = false;
            ajanda.Visible = false;
        }


        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            information.Visible = false;
            operation.Visible = true;
            panel22.Visible = false;
            ajanda.Visible = false;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            information.Visible = false;
            operation.Visible = false;
            panel22.Visible = true;
            ajanda.Visible = false;
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            information.Visible = false;
            operation.Visible = false;
            panel22.Visible = false;
            ajanda.Visible = true;
        }
    }
}
