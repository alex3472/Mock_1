using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using Skat;

namespace TCP_server
{
    class EchoService
    {
        private TcpClient _connectionSocket;

        public EchoService(TcpClient connection)
        {
            _connectionSocket = connection;
        }

        // this method needs to be async and have the return type Task
        public async Task doIt()
        {
            Stream ns = _connectionSocket.GetStream();
            // Stream ns = new NetworkStream(connectionSocket);

            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            sw.AutoFlush = true; // enable automatic flushing

            
            while (true)
            {
                string type = await sr.ReadLineAsync();
                string price = await sr.ReadLineAsync();

                // runs this code if the type is per
                if (type == "per")
                {
                    int outcome = Afgift.BilAfgift(Convert.ToInt32(price));
                    sw.WriteLine(outcome + " kr");
                }

                // runs this code if the type is el
                if (type == "el")
                {
                    int outcome = Afgift.ElBilAfgift(Convert.ToInt32(price));
                    sw.WriteLine(outcome + " kr");
                }
            }

            ns.Close();
        }


    }
}
