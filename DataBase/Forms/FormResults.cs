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
    public partial class FormResults : Form
    {
        public FormResults()
        {
            InitializeComponent();
        }

        private void FormResults_Load(object sender, EventArgs e)
        {
            DataSetSessions dataSetSessions = new DataSetSessions();
            ResultsTableAdapter resultsTableAdapter = new ResultsTableAdapter();

            resultsTableAdapter.Fill(dataSetSessions.Results);
            dataGridView1.DataSource = dataSetSessions.Results;
        }
    }
}
