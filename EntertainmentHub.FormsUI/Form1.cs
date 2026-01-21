using EntertainmentHub.Business.Abstract;
using EntertainmentHub.Business.Concrete;
using EntertainmentHub.DataAccess.Abstract;
using EntertainmentHub.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntertainmentHub.FormsUI
{
    public partial class main_form : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        IProductionService _productionService;

        public main_form()
        {
            InitializeComponent();
            _productionService = new ProductionManager(new EFProductionDal());
        }

        private void main_form_Load(object sender, EventArgs e)
        {

            dgw_productions.DataSource = _productionService.GetAllProductions();

            dgw_productions.Columns[0].HeaderText = "Production ID";
            dgw_productions.Columns[1].HeaderText = "Production Name";
            dgw_productions.Columns[2].HeaderText = "Production Category";
            dgw_productions.Columns[3].HeaderText = "Production Runtime";
            dgw_productions.Columns[4].HeaderText = "In Theater";
            dgw_productions.Columns[5].HeaderText = "Production Year";
            dgw_productions.Columns[6].HeaderText = "Director ID";
        }

        private void panel_titlebar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button_crossmark_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_restore_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void button_minimize_Click(object sender, EventArgs e)
        {
            WindowState=FormWindowState.Minimized;
        }
    }
}
