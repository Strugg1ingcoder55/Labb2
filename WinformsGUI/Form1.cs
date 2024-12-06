using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Logiclayer;
using Labb2;

namespace WinformsGUI
{
    //Av någon anledning heter den här klassen det här istället för Form1
    public partial class btnUppdateraDataGridViewFordon : Form
    {
        private LogicService Logiclayer = new LogicService();

        private Fordon ValtFordon;
        public btnUppdateraDataGridViewFordon()
        {
            InitializeComponent();

            Logiclayer.Seed();
        }

        private void form1_load(object sender, EventArgs e)
        {
            UppdateraGrid();
        }

        private void btnTaBortFordon_Click(object sender, EventArgs e)
        {
            if (ValtFordon != null)
            {
                Logiclayer.Removefordon(ValtFordon);
            }
            UppdateraGrid();
        }

        private void btnLaggTill_Click(object sender, EventArgs e)
        {
            FormAddFordon formAddFordon = new FormAddFordon(Logiclayer);
            formAddFordon.Show();
        }

        private void btnUppdateraGrid_Click(object sender, EventArgs e)
        {
            UppdateraGrid();
        }

        private void UppdateraGrid()
        {

            dataGridViewFordon.DataSource = new BindingList<Fordon>(Logiclayer.GetFordon());
        }

        private void dataGridViewFordon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ValtFordon = dataGridViewFordon.SelectedRows[0].DataBoundItem as Fordon;
        }
    }
}
