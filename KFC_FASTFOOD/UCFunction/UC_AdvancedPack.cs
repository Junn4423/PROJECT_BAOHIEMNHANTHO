using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KFC_FASTFOOD.Forms;

namespace KFC_FASTFOOD.UCFunction
{
    public partial class UC_AdvancedPack : UserControl
    {
        public UC_AdvancedPack()
        {
            InitializeComponent();
        }
        private int check = 0;
        private int tonGiaoID = 0;
        private void _sttButton(bool add, bool edit, bool delete, bool update, bool cancel, bool grptg)
        {
            
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            _sttButton(true, false, true, false, false, false);
            frm_Main.Instance.pnlContainer.Controls["UC_Category"].BringToFront();
        }

        
    }
}
