using EntertainmentHub.Business.Abstract;
using EntertainmentHub.Business.Concrete;
using EntertainmentHub.DataAccess.Abstract;
using EntertainmentHub.DataAccess.Concrete.EntityFramework;
using EntertainmentHub.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
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
            timer.Start();
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

        private void button_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void SearchProductions()
        {
            dgw_productions.DataSource = _productionService.GetProductions(textBox_name.Text, textBox_category.Text);
        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {
            SearchProductions();
        }

        private void textBox_category_TextChanged(object sender, EventArgs e)
        {
            SearchProductions();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            _productionService.AddProduction(new Production
            {
                ProductionName = textBox_operations_name.Text,
                ProductionCategory = textBox_operations_category.Text,
                ProductionRuntime = Convert.ToDecimal(textBox_operations_runtime.Text),
                inTheaters = Convert.ToInt32(textBox_operations_inTheaters.Text),
                ProductionYear = Convert.ToInt32(textBox_operations_year.Text),
            });
            MessageBox.Show("The production has been successfully added to the system.");
            dgw_productions.DataSource = _productionService.GetAllProductions();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            textBox_name.Clear();
            textBox_category.Clear();

            textBox_operations_id.Clear();
            textBox_operations_name.Clear();
            textBox_operations_category.Clear();
            textBox_operations_runtime.Clear();
            textBox_operations_inTheaters.Clear();
            textBox_operations_year.Clear();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            _productionService.UpdateProduction(new Production
            {
                ProductionID = Convert.ToInt32(textBox_operations_id.Text),
                ProductionName = textBox_operations_name.Text,
                ProductionCategory = textBox_operations_category.Text,
                ProductionRuntime = Convert.ToDecimal(textBox_operations_runtime.Text),
                inTheaters = Convert.ToInt32(textBox_operations_inTheaters.Text),
                ProductionYear = Convert.ToInt32(textBox_operations_year.Text),
            });
            MessageBox.Show("The production has been successfully updated.");
            Clear();
            dgw_productions.DataSource = _productionService.GetAllProductions();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
             _productionService.DeleteProduction(new Production
             {
                 ProductionID = Convert.ToInt32(textBox_operations_id.Text)
             });
             MessageBox.Show("The production has been successfully deleted.");
            Clear();
            dgw_productions.DataSource = _productionService.GetAllProductions();
        }

        private void dgw_productions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgw_productions.CurrentRow;
            textBox_operations_id.Text = row.Cells[0].Value.ToString();
            textBox_operations_name.Text = row.Cells[1].Value.ToString();
            textBox_operations_category.Text = row.Cells[2].Value.ToString();
            textBox_operations_runtime.Text = row.Cells[3].Value.ToString();
            textBox_operations_inTheaters.Text = row.Cells[4].Value.ToString();
            textBox_operations_year.Text = row.Cells[5].Value.ToString();
        }

        private void label_current_time_Click(object sender, EventArgs e)
        {
            label_current_time.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            label_current_time.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }
    }
}
