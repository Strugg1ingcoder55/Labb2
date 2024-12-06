using Models;
using Logiclayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsGUI
{
    public partial class FormAddFordon : Form
    {
        private LogicService LogicService;
        public FormAddFordon(LogicService logicservice)
        {
            InitializeComponent();

            LogicService = logicservice;
        }

        private void Spara_Click(object sender, EventArgs e)
        {
            Fordon fordon = new Fordon();
            
           fordon.FordonsID = int.Parse(txtID.Text);
            fordon.FordonsTyp = txtFordonsTyp.Text;
            fordon.BatteriStatus = txtBatteriStatus.Text;
            fordon.FordonsStatus = bool.Parse(txtFordonsStatus.Text);

            LogicService.Addfordon(fordon);

            this.Close();
        }

        private void btnAvsluta_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
