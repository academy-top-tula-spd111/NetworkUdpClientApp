using System.Net.Sockets;
using System.Text;

using var serverUdp = new UdpClient(7777);
Console.WriteLine("Server UDP start....");

var result = await serverUdp.ReceiveAsync();
Console.WriteLine(Encoding.UTF8.GetString(result.Buffer));