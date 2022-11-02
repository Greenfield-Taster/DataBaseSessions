using DataBase.DataSets.DataSetSessionsTableAdapters;
using DataBase.DataSets;

namespace DataBase.Forms;

public partial class FormStudents : Form
{
    public FormStudents()
    {
        InitializeComponent();
    }

    private void FormStudents_Load(object sender, EventArgs e)
    {
        DataSetSessions dataSetSessions = new DataSetSessions();
        StudentsTableAdapter studentsTableAdapter = new StudentsTableAdapter();

        studentsTableAdapter.Fill(dataSetSessions.Students);
        dataGridView1.DataSource = dataSetSessions.Students;
    }
}
