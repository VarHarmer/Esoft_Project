using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esoft_Project
{
    public partial class FormAgent : Form
    {
        public FormAgent()
        {
            InitializeComponent();
            ShowAgent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AgentsSet agentSet = new AgentsSet();
            agentSet.FirstName = textBoxFirstName.Text;
            agentSet.MiddleName = textBoxMiddleName.Text;
            agentSet.LastName = textBoxLastName.Text;
            agentSet.DealShare = textBoxDealShare.Text;
            Program.bazadb.AgentsSet.Add(agentSet);
            Program.bazadb.SaveChanges();
            ShowAgent();
        }

        void ShowAgent()
        {
            listViewAgents.Items.Clear();
            foreach (AgentsSet agentSet in Program.bazadb.AgentsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    agentSet.Id.ToString(), agentSet.FirstName, agentSet.MiddleName,
                    agentSet.LastName, agentSet.DealShare
                });
                item.Tag = agentSet;
                listViewAgents.Items.Add(item);
            }
            listViewAgents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listViewAgents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAgents.SelectedItems.Count == 1)
            {
                AgentsSet agentSet = listViewAgents.SelectedItems[0].Tag as AgentsSet;
                textBoxFirstName.Text = agentSet.FirstName;
                textBoxMiddleName.Text = agentSet.MiddleName;
                textBoxLastName.Text = agentSet.LastName;
                textBoxDealShare.Text = agentSet.DealShare;
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxDealShare.Text = "";
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewAgents.SelectedItems.Count == 1)
            {
                AgentsSet agentSet = listViewAgents.SelectedItems[0].Tag as AgentsSet;
                agentSet.FirstName = textBoxFirstName.Text;
                agentSet.MiddleName = textBoxMiddleName.Text;
                agentSet.LastName = textBoxLastName.Text;
                agentSet.DealShare = textBoxDealShare.Text;
                Program.bazadb.SaveChanges();
                ShowAgent();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewAgents.SelectedItems.Count == 1)
                {
                    AgentsSet agentSet = listViewAgents.SelectedItems[0].Tag as AgentsSet;
                    Program.bazadb.AgentsSet.Remove(agentSet);
                    Program.bazadb.SaveChanges();
                    ShowAgent();
                }
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxDealShare.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
