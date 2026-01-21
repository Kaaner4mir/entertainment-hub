using EntertainmentHub.Business.Concrete;
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
        public main_form()
        {
            InitializeComponent();
        }

        private void main_form_Load(object sender, EventArgs e)
        {
            EntertainmentHubManager manager= new EntertainmentHubManager();
            dgw_productions.DataSource = manager.GetAllProductions();

            dgw_productions.Columns[0].HeaderText = "Production ID";
            dgw_productions.Columns[1].HeaderText = "Production Name";
            dgw_productions.Columns[2].HeaderText = "Production Category";
            dgw_productions.Columns[3].HeaderText = "Production Runtime";
            dgw_productions.Columns[4].HeaderText = "In Theater";
            dgw_productions.Columns[5].HeaderText = "Production Year";
            dgw_productions.Columns[6].HeaderText = "Director ID";
        }
    }
}
