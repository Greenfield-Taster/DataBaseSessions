using DataBase.Forms;

namespace DataBase;

public partial class FormMain : Form
{
    public FormMain()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        FormSessions formSessions = new FormSessions();
        formSessions.Show();
    }

    private void buttonSchedule_Click(object sender, EventArgs e)
    {
        FormSchedule formSchedule = new FormSchedule();
        formSchedule.Show();
    }

    private void buttonSubjects_Click(object sender, EventArgs e)
    {
        FormSubjects formSubjects = new FormSubjects();
        formSubjects.Show();
    }

    private void buttonGroups_Click(object sender, EventArgs e)
    {
        FormGroups formGroups = new FormGroups();
        formGroups.Show();
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
        FormStudents formStudents = new FormStudents();
        formStudents.Show();
    }

    private void buttonResults_Click(object sender, EventArgs e)
    {
        FormResults formResults = new FormResults();
        formResults.Show();
    }
}