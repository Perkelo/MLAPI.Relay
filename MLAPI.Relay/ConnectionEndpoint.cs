public class ConnectionEndpoint
{
    public string address;
    public int port;

    public ConnectionEndpoint(string address, int port)
    {
        this.address = address;
        this.port = port;
    }
}