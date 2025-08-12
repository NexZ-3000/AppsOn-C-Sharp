using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactApp1
{
    public partial class ChatForm : Form
    {

        private TcpListener listener;
        private TcpClient client;
        private NetworkStream stream;
        private Thread listenThread;


        //------------------------------------------------------------------
        //--.
        public ChatForm()
        {
            InitializeComponent();
            //--.
            StartListening();
        }

        //------------------------------------------------------------------
        private string NickName;
        //--.
        private void StartListening()
        {
            listenThread = new Thread(ListenForMessages);
            listenThread.IsBackground = true;
            listenThread.Start();
        }


        //------------------------------------------------------------------
        //--.
        private void ListenForMessages()
        {
            try
            {
                listener = new TcpListener(IPAddress.Any, 5000);
                listener.Start();

                //--.
                while (true)
                {
                    TcpClient client = listener.AcceptTcpClient();
                    NetworkStream stream = client.GetStream();

                    byte[] buffer = new byte[1024];
                    int bytesRead;


                    //--.
                    while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        UpdateReceiveText("получено" + message);
                    }

                    client.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in listener: " + ex.Message);
            }
        }


        //------------------------------------------------------------------
        //--.
        private void UpdateReceiveText(string message)
        {
            if (tBox_ReceiveText.InvokeRequired)
            {
                tBox_ReceiveText.Invoke(new MethodInvoker(
                    delegate
                    {
                        tBox_ReceiveText.AppendText(message + Environment.NewLine);
                    }
                    ));
            }
            else
            {
                tBox_ReceiveText.AppendText(message + Environment.NewLine);
            }
        }

        //-----------------------------------------------------------------------------------
        //--.
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                string ip = tBox_IpNum.Text.Trim();
                if (string.IsNullOrEmpty(ip))
                {
                    MessageBox.Show("Введите IP-адрес в поле.");
                    return;
                }


                if (client == null || !client.Connected)
                {
                    client = new TcpClient();
                    client.Connect(ip, 5000); // используем IP из текстового поля
                    stream = client.GetStream();
                }

                byte[] data = Encoding.UTF8.GetBytes(NickName +": " + tBox_SendText.Text);
                stream.Write(data, 0, data.Length);

                tBox_ReceiveText.AppendText(NickName + ":" + tBox_SendText.Text + Environment.NewLine);
                tBox_SendText.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending message: " + ex.Message);
            }
        }

        //----------------------------------------------------------------------------------------
        //--.
        private void btnGetIp_Click(object sender, EventArgs e)
        {
            string ipAddress = GetLocalIPAddress();
            if (ipAddress != null)
            {
                tBox_IpNum.Text = ipAddress;
            }
            else
            {
                MessageBox.Show("Не удалось определить IP-адрес.");
            }
        }

        //----------------------------------------------------------------------------------------
        //--.
        private string GetLocalIPAddress()
        {
            try
            {
                var host = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName());
                foreach (var ip in host.AddressList)
                {
                    // Возьмём первый IPv4 адрес, который не является loopback (127.0.0.1)
                    if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {
                        return ip.ToString();
                    }
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBox_ReceiveText_TextChanged(object sender, EventArgs e)
        {

        }



        private void listBoxMessages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        { }

        private void connectButton_Click(object sender, EventArgs e)
        {

        }

        private void tBox_IpNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            NickName = textBox1.Text.Trim(); // считываем и убираем пробелы по краям

            if (string.IsNullOrEmpty(NickName))
            {
                MessageBox.Show("Пожалуйста, введите ДЕЙСТВИТЕЛЬНЫЙ никнейм.", "Ты тупой?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Если значение не пустое — можно использовать NickName дальше
            // Например, вывести на экран или сохранить
            MessageBox.Show($"Ваш никнейм: {NickName} был успешно применен!", "Никнейм успешно применён", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
    
  
