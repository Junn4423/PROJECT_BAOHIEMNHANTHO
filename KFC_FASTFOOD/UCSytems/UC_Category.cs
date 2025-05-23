﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KFC_FASTFOOD.Forms;
using KFC_FASTFOOD.UCFunction;

namespace KFC_FASTFOOD.UCSytems
{
    public partial class UC_Category : UserControl
    {
        public UC_Category()
        {
            InitializeComponent();
        }

        private void btnSysFood_Click(object sender, EventArgs e)
        {
            if (!frm_Main.Instance.pnlContainer.Controls.ContainsKey("UC_CityCategory"))
            {
                UC_ExtendPack cityCategory = new UC_ExtendPack();
                cityCategory.Dock = DockStyle.Fill;
                frm_Main.Instance.pnlContainer.Controls.Add(cityCategory);
            }
            frm_Main.Instance.pnlContainer.Controls["UC_CityCategory"].BringToFront();
        }


        private void btnDanToc_Click(object sender, EventArgs e)
        {
            if (!frm_Main.Instance.pnlContainer.Controls.ContainsKey("UC_NationManager"))
            {
                UC_SuperiorPack nationManager = new UC_SuperiorPack();
                nationManager.Dock = DockStyle.Fill;
                frm_Main.Instance.pnlContainer.Controls.Add(nationManager);
            }
            frm_Main.Instance.pnlContainer.Controls["UC_NationManager"].BringToFront();
        }


        private void btnBoPhan_Click(object sender, EventArgs e)
        {
            if (!frm_Main.Instance.pnlContainer.Controls.ContainsKey("UC_OfficesManager"))
            {
                UC_OfficesManager officesManager = new UC_OfficesManager();
                officesManager.Dock = DockStyle.Fill;
                frm_Main.Instance.pnlContainer.Controls.Add(officesManager);
            }
            frm_Main.Instance.pnlContainer.Controls["UC_OfficesManager"].BringToFront();
        }

        private void btnTonGiao_Click(object sender, EventArgs e)
        {
            if (!frm_Main.Instance.pnlContainer.Controls.ContainsKey("UC_ReligionManager"))
            {
                UC_AdvancedPack religionManager = new UC_AdvancedPack();
                religionManager.Dock = DockStyle.Fill;
                frm_Main.Instance.pnlContainer.Controls.Add(religionManager);
            }
            frm_Main.Instance.pnlContainer.Controls["UC_ReligionManager"].BringToFront();
        }
    }
}
