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
}