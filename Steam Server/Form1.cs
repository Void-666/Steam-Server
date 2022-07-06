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
            string message = "Вы успешно вошли в систему!";
            string title = "Успех!";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}