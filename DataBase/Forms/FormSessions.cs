using DataBase.DataSets;
using DataBase.DataSets.DataSetSessionsTableAdapters;

namespace DataBase.Forms;

public partial class FormSessions : Form
{
    public FormSessions()
    {
        InitializeComponent();
    }

    private void FormSessions_Load(object sender, EventArgs e)
    {
        DataSetSessions dataSetSessions = new DataSetSessions();
        SessionsTableAdapter sessionsTableAdapter = new SessionsTableAdapter();

        sessionsTableAdapter.Fill(dataSetSessions.Sessions);
        dataGridView1.DataSource = dataSetSessions.Sessions;
    }
}
