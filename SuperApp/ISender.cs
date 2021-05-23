namespace SuperApp
{
    public interface ISender
    {
        void Send(string destination, string text);
    }
}