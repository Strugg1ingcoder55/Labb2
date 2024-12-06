using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Logiclayer;
using Models;

namespace WinformsGUI
{
    //Av någon anledning heter den här klassen det här istället för Form1
    //Vi är osäkra på hur vi ska lägga till våran meny till winforms, ska vi göra flera winforms?
    //En plan är att vi börjar med en winform som har två val, avsluta och välj användare, trycker på den så kommer man till en ny winform som visar 3 knappar
    //Knapp 1 och 2 ger dig normala kunder som gör går till samma sak fast kund 2 kan inte köpa fordon för de använder kontanter
    //Knapp 3 går till admin då man kan göra det som finns i denna form, uppdatera, visa, lägga till och ta bort fordon
    //Problemet är att vi vet inte hur vi skulle göra det och vi har inte tillräckligt med tid!
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
