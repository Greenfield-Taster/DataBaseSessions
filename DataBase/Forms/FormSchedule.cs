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
    public partial class FormSchedule : Form
    {
        public FormSchedule()
        {
            InitializeComponent();
        }

        private void FormSchedule_Load(object sender, EventArgs e)
        {
            DataSetSessions dataSetSessions = new DataSetSessions();
            ScheduleTableAdapter scheduleTableAdapter = new ScheduleTableAdapter();

            scheduleTableAdapter.Fill(dataSetSessions.Schedule);
            dataGridView1.DataSource = dataSetSessions.Schedule;
        }
    }
}
