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
    //Av n�gon anledning heter den h�r klassen det h�r ist�llet f�r Form1
    //Vi �r os�kra p� hur vi ska l�gga till v�ran meny till winforms, ska vi g�ra flera winforms?
    //En plan �r att vi b�rjar med en winform som har tv� val, avsluta och v�lj anv�ndare, trycker p� den s� kommer man till en ny winform som visar 3 knappar
    //Knapp 1 och 2 ger dig normala kunder som g�r g�r till samma sak fast kund 2 kan inte k�pa fordon f�r de anv�nder kontanter
    //Knapp 3 g�r till admin d� man kan g�ra det som finns i denna form, uppdatera, visa, l�gga till och ta bort fordon
    //Problemet �r att vi vet inte hur vi skulle g�ra det och vi har inte tillr�ckligt med tid!
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
