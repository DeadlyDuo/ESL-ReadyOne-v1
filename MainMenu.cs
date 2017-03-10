﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESL_ReadyOne_v1
{
    public partial class MainMenu : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
        public MainMenu()
        {
            InitializeComponent();
            
            DoubleBuffered = true;
        }

        private void Label_FirstTimeSetup_Click(object sender, EventArgs e)
        {

        }

        private void Label_FirstTimeSetup_MouseEnter(object sender, EventArgs e)
        {
            Pic_IndicatorTop.Visible = true;
        }
        private void Label_FirstTimeSetup_MouseLeave(object sender, EventArgs e)
        {
            Pic_IndicatorTop.Visible = false;
        }


        private void Label_ReadyToPlay_MouseEnter(object sender, EventArgs e)
        {
            Pic_IndicatorBottom.Visible = true;
        }

        private void Label_ReadyToPlay_MouseLeave(object sender, EventArgs e)
        {
            Pic_IndicatorBottom.Visible = false;
        }

        
    }
}
