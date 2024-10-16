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
using KFC_FASTFOOD.UCFunction;

namespace KFC_FASTFOOD.UCSytems
{
    public partial class UC_Report : UserControl
    {
        public UC_Report()
        {
            InitializeComponent();
        }




        private void btnRpDoanhThu_Click(object sender, EventArgs e)
        {
            if (!frm_Main.Instance.pnlContainer.Controls.ContainsKey("UC_RpRevenue"))
            {
                UC_RpRevenue rpRevenue = new UC_RpRevenue();
                rpRevenue.Dock = DockStyle.Fill;
                frm_Main.Instance.pnlContainer.Controls.Add(rpRevenue);
            }
            frm_Main.Instance.pnlContainer.Controls["UC_RpRevenue"].BringToFront();
        }

        private void btnRpHoaDon_Click(object sender, EventArgs e)
        {
            if (!frm_Main.Instance.pnlContainer.Controls.ContainsKey("UC_InvoiceDetails"))
            {
                UC_InvoiceDetails invoiceDetails = new UC_InvoiceDetails();
                invoiceDetails.Dock = DockStyle.Fill;
                frm_Main.Instance.pnlContainer.Controls.Add(invoiceDetails);
            }
            frm_Main.Instance.pnlContainer.Controls["UC_InvoiceDetails"].BringToFront();
        }

    }
}
