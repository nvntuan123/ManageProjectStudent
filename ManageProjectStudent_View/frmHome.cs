﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageProjectStudent_View
{
    public partial class frmHome : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        public frmHome()
        {
            InitializeComponent();
            random = new Random();
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColorHome.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColorHome.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColorHome.ColorList[index];
            return ColorTranslator.FromHtml(color);

        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Arial", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenuHome.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(10, 25, 77);
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("Arial", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.Close();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panelMenuHome.Height == 647 & panelMenuHome.Width == 264)
            {
                panelMenuHome.Height = 647;
                panelMenuHome.Width = 56;
            }
            else
            {
                panelMenuHome.Height = 647;
                panelMenuHome.Width = 264;
            }
        }
    }
}
