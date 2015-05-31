using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ChatterBox
{
    class ChatApplicationContext : ApplicationContext
    {
        public ChatApplicationContext()
        {
            Chat sam = new Chat("Sam");
            sam.Closed += new EventHandler(this.ChatClosed);
            sam.SendingMessage += new SendingMessageEventHandler(this.MessageReceived);
            sam.Show();

            Chat toby = new Chat("Toby");
            toby.Closed += new EventHandler(this.ChatClosed);
            toby.SendingMessage += new SendingMessageEventHandler(this.MessageReceived);
            toby.Show();

            toby.Partner = sam;
            sam.Partner = toby;
        }

        void MessageReceived(MessageEventArgs args)
        {
            // Spy on Messages
            Console.WriteLine(args.Message);
        }

        void ChatClosed(object sender, EventArgs e)
        {
            this.ExitThread();
        }
    }
}
