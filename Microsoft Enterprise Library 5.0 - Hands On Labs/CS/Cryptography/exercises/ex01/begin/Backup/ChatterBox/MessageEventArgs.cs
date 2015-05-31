using System;
using System.Collections.Generic;
using System.Text;

namespace ChatterBox
{
    public delegate void SendingMessageEventHandler(MessageEventArgs args);

    public class MessageEventArgs : EventArgs
    {
        private string sender = null;
        private string message = null;

        public MessageEventArgs(string sender, string message)
        {
            this.sender = sender;
            this.message = message;
        }

        public string Sender
        {
            get { return this.sender; }
        }

        public string Message
        {
            get { return this.message; }
        }
    }
}
