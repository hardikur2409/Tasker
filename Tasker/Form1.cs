namespace Tasker
{
    public partial class Form1 : Form
    {
        Class1 rmq = new Class1();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rmq.InitRMQConnection();
            rmq.CreateRMQConnection();
            while (!rmq.connection.IsOpen) { /*loooping hingga koneksi terbuka*/ }
            rmq.CreateRMQChannel("workQ");
            while (!rmq.channel.IsOpen) { /*loooping hingga channel terbuka*/ }
            if (rmq.connection.IsOpen && rmq.channel.IsOpen)
            {
                button1.Enabled = true;
                button1.Enabled = true;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rmq.SendMessage(textBox1.Text, textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rmq.Disconnect();
            button1.Enabled = false;
            button1.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}