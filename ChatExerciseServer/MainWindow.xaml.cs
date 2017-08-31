using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;


namespace ChatExerciseServer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void ReceiveMessages(object sender, TextChangedEventArgs e) //receive messages
        {
            
        }

        public void Server()
        {
            string messageToSend;
            TcpListener listener = new TcpListener(IPAddress.Any, 11000);
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            listener.Start();
            Socket client = listener.AcceptSocket();

            if (client.Connected)
            {
                NetworkStream stream = new NetworkStream(client);
                StreamReader reader = new StreamReader(stream, Encoding.ASCII);
                StreamWriter writer = new StreamWriter(stream, Encoding.ASCII) { AutoFlush = true } ;

                while (true)
                {
                    messageToSend = reader.ToString();
                }
            }

        }
    }
}
