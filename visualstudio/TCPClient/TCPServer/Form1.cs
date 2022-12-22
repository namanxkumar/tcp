using SuperSimpleTcp;
using System.Text;

namespace TCPServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SimpleTcpServer server;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonSend.Enabled = false;
            server = new SimpleTcpServer(ipTXT.Text);
            server.Events.ClientConnected += Events_ClientConnected;
            server.Events.ClientDisconnected += Events_ClientDisconnected;
            server.Events.DataReceived += Events_DataReceived;
        }

        private void Events_DataReceived(object? sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                infoTXT.Text += $"{e.IpPort}: {Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
            });
        }

        private void Events_ClientDisconnected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                infoTXT.Text += $"{e.IpPort} disconnected.{Environment.NewLine}";
                clientIP.Items.Remove(e.IpPort);
            });
        }

        private void Events_ClientConnected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                infoTXT.Text += $"{e.IpPort} connected.{Environment.NewLine}";
                clientIP.Items.Add(e.IpPort);
            });
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (server.IsListening)
            {
                if (!string.IsNullOrEmpty(messageTXT.Text) && clientIP.SelectedItem != null)
                {
                    server.Send(clientIP.SelectedItem.ToString(), messageTXT.Text);
                    infoTXT.Text += $"Server: {messageTXT.Text}{Environment.NewLine}";
                    messageTXT.Text = string.Empty;
                }
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            server.Start();
            infoTXT.Text += $"Starting... {Environment.NewLine}";
            buttonStart.Enabled = false;
            buttonSend.Enabled = true;
        }
    }
}