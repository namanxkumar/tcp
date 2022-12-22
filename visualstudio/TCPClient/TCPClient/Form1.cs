using SuperSimpleTcp;
using System.Text;

namespace TCPClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SimpleTcpClient client;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (client.IsConnected)
            {
                if (!string.IsNullOrEmpty(messageTXT.Text))
                {
                    client.Send(messageTXT.Text);
                    infoTXT.Text += $"Sent: {messageTXT.Text}{Environment.NewLine}";
                    messageTXT.Text = string.Empty;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                client.Connect();
                button1.Enabled = true;
                button2.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new(ipTXT.Text);
            client.Events.Connected += Events_Connected;
            client.Events.DataReceived += Events_DataReceived;
            client.Events.Disconnected += Events_Disconnected;
            button1.Enabled = false;
        }

        private void Events_Disconnected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                infoTXT.Text += $"Server disconnected. {Environment.NewLine}";
                button2.Enabled = true;
                button1.Enabled = false;
            });
        }

        private void Events_DataReceived(object? sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                infoTXT.Text += $"Server: {Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
            });

        }

        private void Events_Connected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                infoTXT.Text += $"Server connected. {Environment.NewLine}";
            });

        }
    }
}