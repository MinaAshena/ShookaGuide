﻿using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DesktopGuide
{
    public partial class fa33 : MyForm
    {
        public fa33()
        {
            InitializeComponent();
        }

        private void myButton1_Click(object sender, EventArgs e)
        {
            MoveToSlide(new fa02());
        }

        private void myButton2_Click(object sender, EventArgs e)
        {
            MoveToSlide(new fa02());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MoveToSlide(new fa04());
        }

        private void myButton3_Click(object sender, EventArgs e)
        {
            MoveToSlide(new fa08());
        }

        private void myButton4_Click(object sender, EventArgs e)
        {
            MoveToSlide(new fa10());
        }

        private void myButton5_Click(object sender, EventArgs e)
        {
            MoveToSlide(new fa04());
        }
    }
}
