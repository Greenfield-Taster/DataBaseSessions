using DataBase.DataSets.DataSetSessionsTableAdapters;
using DataBase.DataSets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase.Forms
{
    public partial class FormGroups : Form
    {
        public FormGroups()
        {
            InitializeComponent();
        }

        private void FormGroups_Load(object sender, EventArgs e)
        {
            DataSetSessions dataSetSessions = new DataSetSessions();
            GroupsTableAdapter groupsTableAdapter = new GroupsTableAdapter();

            groupsTableAdapter.Fill(dataSetSessions.Groups);
            dataGridView1.DataSource = dataSetSessions.Groups;
        }
    }
}
