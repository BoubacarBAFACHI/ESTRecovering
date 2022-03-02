using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace ESTRecovering.Formz
{
    public partial class ReceptIns : Form
    {
        public int mat { get; set; }
        private string Date;

        public ReceptIns()
        {
            InitializeComponent();
            Date = DateTime.Now.ToString("M/d/yyyy");
        }

        private void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            panelPrint = pnl;
            getprintarea(pnl);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memorying, (pagearea.Width / 2) - (this.panelPrint.Width / 2), this.panelPrint.Location.Y);
        }

        private Bitmap memorying;

        private void getprintarea(Panel pnl)
        {
            memorying = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memorying, new Rectangle(2, 2, pnl.Width, pnl.Height));
        }

        private void ReceptIns_Load(object sender, EventArgs e)
        {
            labeldate.Text = Date;
        }

        private void GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonImp_Click(object sender, EventArgs e)
        {
            Print(this.panelPrint);

            /*DGVPrinter printer = new DGVPrinter();
            printer.Title = "Recu d'Inscription";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.Footer = "Ecole Supérieure des Télécommunications EST_Niger";
            printer.FooterSpacing = 55;
            printer.PrintPreviewDataGridView(dataGridView1);*/
            this.Close();
        }

        private void ButtonImp_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(ButtonImp, "Imprimer");
        }

       
    }
}
