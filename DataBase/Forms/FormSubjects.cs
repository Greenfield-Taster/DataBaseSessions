using DataBase.DataSets;
using DataBase.DataSets.DataSetSessionsTableAdapters;

namespace DataBase.Forms;

public partial class FormSubjects : Form
{
    public FormSubjects()
    {
        InitializeComponent();
    }

    private void FormSubjects_Load(object sender, EventArgs e)
    {
        DataSetSessions dataSetSubjects = new DataSetSessions();
        SubjectsTableAdapter subjectsTableAdapter = new SubjectsTableAdapter();

        subjectsTableAdapter.Fill(dataSetSubjects.Subjects);
        dataGridView1.DataSource = dataSetSubjects.Subjects;
    }
}
