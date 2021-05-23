using System;
using System.Collections.Generic;
using System.Text;

namespace SuperApp
{
    public class EmailSender: ISender
    {
        public void Send(string destination, string text)
        {
            Console.Out.WriteLine($"Mail was send to {destination}");
        }
    }
}
