using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
// TODO: Use Cryptography

namespace ChatterBox
{
    public partial class Chat : Form
    {
        #region Uninteresting Stuff

        private string _name = "?";
        private Chat _partner = null;

        public event SendingMessageEventHandler SendingMessage;

        private Chat()
        {
            InitializeComponent();
        }

        public Chat(string name)
            : this()
        {
            this.Chatname = name;
        }

        public Chat Partner
        {
            get { return this._partner; }
            set
            {
                this._partner = value;
                this._partner.SendingMessage += new SendingMessageEventHandler(MessageReceived);
            }
        }

        public string Chatname
        {
            get { return this._name; }
            set
            {
                this._name = value;
                this.Text = this._name;
                this.lblSend.Text = this._name + " Says:";
            }
        }

        private void Chat_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.txtSend.Text = null;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            PreSendMessage();
        }

        private void txtSend_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;

                PreSendMessage();
            }
        }

        private void PreSendMessage()
        {
            string message = this.txtSend.Text;

            // Show message in this window
            if ((message != null) && (message.Trim() != string.Empty))
            {
                this.txtMessages.AppendText(
                    this._name + " says: " + message + Environment.NewLine
                    );
            }

            this.SendMessage(message);
            this.txtSend.Text = null;
        }

        #endregion

        // TODO: Configuration symmetric algorithm provider name

        private void SendMessage(string message)
        {
            // TODO: Encrypt message

            // Fire SendingMessage Event
            if (this.SendingMessage != null)
                this.SendingMessage(new MessageEventArgs(this._name, message));
        }

        private void MessageReceived(MessageEventArgs args)
        {
            string message = args.Message;

            // TODO: Decrypt message

            this.txtMessages.AppendText(
                args.Sender + " says: " + message + Environment.NewLine);
        }
    }
}