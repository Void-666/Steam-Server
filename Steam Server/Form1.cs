namespace Steam_Server
{
    public partial class Serv : Form
    {
        public Serv()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "�� ������� ����� � �������!";
            string title = "�����!";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}