using System.Net;
using System.Net.Sockets;
using System.Text;

using var clientUdp = new UdpClient();

string message = "Hello world from UdpClient";
byte[] buffer = Encoding.UTF8.GetBytes(message);
IPEndPoint remoteEP = new IPEndPoint(IPAddress.Loopback, 7777);

int bytes = await clientUdp.SendAsync(buffer, remoteEP);
Console.WriteLine($"sends {bytes} bytes");