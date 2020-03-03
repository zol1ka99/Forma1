using Forma1projekt.Exceptionmy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forma1projekt
{
    public partial class Form1Form : Form
    {
        private void buttonAddTeam_Click(object sender, EventArgs e)
        {
            string teamName = textBoxTeamName.Text;
            f1c.addTeamToF1(teamName);
            listBoxTeam.DataSource = null;
            listBoxTeam.DataSource = f1c.getTeamNames();
            textBoxTeamName.Text = string.Empty;
        }
        private void buttonDeleteTeam_Click(object sender, EventArgs e)
        {
            errorProviderDeleteTeam.Clear();
            try
            {
                if (listBoxTeam.SelectedIndex < 0)
                {
                    return;
                }
                string teamNameToDelete = listBoxTeam.Text;
                f1c.deleteTeam(teamNameToDelete);
                listBoxTeam.DataSource = null;
                listBoxTeam.DataSource = f1c.getTeamNames();
            }
            catch (ControllerException ce)
            {
                errorProviderDeleteTeam.SetError(buttonDeleteTeam, ce.Message);
            }
            
        }

        private void buttonUpdateTeam_Click(object sender, EventArgs e)
        {
            errorProviderModifyTeamName.Clear();
            try
            {
                string oldTeamName = listBoxTeam.Text;
                string newTeamName = textBoxTeamName.Text;

                f1c.modifyTeamName(oldTeamName, newTeamName);
            }
            catch (ControllerException ce)
            {
                errorProviderModifyTeamName.SetError(buttonUpdateTeam, ce.Message);
            }
        }

    }
}
