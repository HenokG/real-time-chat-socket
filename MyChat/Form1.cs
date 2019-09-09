using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;

namespace MyChat
{
    public partial class Form1 : Form
    {

        Socket socket;
        EndPoint myNode, friendsNode;
        byte[] buffer;
        String friendsPort;
        bool connectedFlag;
        public string txt;

        public Form1()
        {
            InitializeComponent();
            connectedFlag = false;
            myPort80.Checked = true;
            stickerPanel.Visible = false;
            portHandler();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //set up the socket
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            myIp.Text = GetIpAddress();
            friendsIp.Text = GetIpAddress();
        }

        public void portHandler() {
            if (myPort81.Checked)
            {
                friendsPort = "80";
                friendsPortLabel.Text = friendsPort;
            }
            else if (myPort80.Checked)
            {
                friendsPort = "81";
                friendsPortLabel.Text = friendsPort;
            }
        }

        private void connect_Click(object sender, EventArgs e)  
        {
            String myPort = null;
            if (myPort81.Checked)
            {
                myPort = myPort81.Text;
                friendsPort = "80";
                friendsPortLabel.Text = friendsPort;
            }
            else if (myPort80.Checked)
            {
                myPort = myPort80.Text;
                friendsPort = "81";
                friendsPortLabel.Text = friendsPort;
            }
            
            //Connecting Each Nodes
            myNode = new IPEndPoint(IPAddress.Parse(myIp.Text), Convert.ToInt32(myPort));
            
            //Bind IP Address With Socket
            socket.Bind(myNode);
            
            //Connecting to The Friends IP
            friendsNode = new IPEndPoint(IPAddress.Parse(friendsIp.Text), Convert.ToInt32(friendsPort));
            socket.Connect(friendsNode);
            
            //Listening to specific Port
            buffer = new byte[2000];
            socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref friendsNode, new AsyncCallback(MessageCallBack), buffer);
            connected.Visible = Visible;
            pictureBox1.Enabled = true;
        }

        private string GetIpAddress()
        {
           // IPHostEntry host;
           // host = Dns.GetHostEntry(Dns.GetHostName());

            //foreach (IPAddress ip in host.AddressList)
            //{
              //  if (ip.AddressFamily == AddressFamily.InterNetwork)
                //    return ip.ToString();
            //}
            return "localhost";
        }

        private void sendMessage_Click(object sender, EventArgs e)
        {
        }

        private void messagesList_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (!connectedFlag)
            {
                MessageBox.Show("Please Connect With Your Friends First!");
            }
            else
            {

                //Converting String to byte array
                UnicodeEncoding encoding = new UnicodeEncoding();
                byte[] messageInByte = new byte[2000];
                messageInByte = encoding.GetBytes(messageBox.Text);
                socket.Send(messageInByte);
                
                //Add My Own Messages To ListBox
                messagesList.Items.Add("Me \t " + messageBox.Text);
            }
        }

        private void connect_Click_1(object sender, EventArgs e)
        {

            try
            {
                String myPort = null;
                if (myPort81.Checked)
                    myPort = myPort81.Text;
                else if (myPort80.Checked)
                    myPort = myPort80.Text;

                //Connecting Each Nodes
                myNode = new IPEndPoint(IPAddress.Parse("127.0.0.1"), Convert.ToInt32(myPort));

                //Bind IP Address With Socket
                socket.Bind(myNode);

                //Connecting to The Friends IP
                friendsNode = new IPEndPoint(IPAddress.Parse("127.0.0.1"), Convert.ToInt32(friendsPort));
                socket.Connect(friendsNode);

                //Listening to specific Port
                buffer = new byte[2000];
                socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref friendsNode, new AsyncCallback(MessageCallBack), buffer);
                connected.Visible = Visible;
                connectedFlag = true;
            }
            catch (Exception){
                MessageBox.Show("You Are Already Connected!");
            }
            
        }

        private void CheckedPort80(object sender, EventArgs e)
        {
        }

        private void CheckedPort81(object sender, EventArgs e)
        {
        }

        private void myPort80_CheckedChanged(object sender, EventArgs e)
        {
            portHandler();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            int selected = messagesList.SelectedIndex;
            if(selected != -1)
            {
                messagesList.Items.RemoveAt(selected);
            }
            else
            {
                MessageBox.Show("You Must Choose One Conversation To Delete!");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if(messagesList.Items.Count == 0)
            {
                MessageBox.Show("There Is Nothing To Delete!");
            }
            messagesList.Items.Clear();
        }

        private void stickerToggle_Click(object sender, EventArgs e)
        {
            if (stickerPanel.Visible)
            {
                stickerPanel.Visible = false;
            }
            else{
                stickerPanel.Visible = true;
            }
        }

        private void MessageCallBack(IAsyncResult asyncResult) {
            try
            {

                byte[] dataFromFriend = new byte[2000];
                dataFromFriend = (byte[])asyncResult.AsyncState;
                
                //Converting Byte Array To String
                UnicodeEncoding encoding = new UnicodeEncoding();
                string messageFromFriend = encoding.GetString(dataFromFriend);
                txt = messageFromFriend;
                string date = DateTime.Now.ToString("h:mm tt");

                //Add Message To ListBox
                messagesList.Items.Add("Friend \t " + messageFromFriend+ " - " + date);
                
                buffer = new byte[2000];
                socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref friendsNode, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
           
        }
    }
}
