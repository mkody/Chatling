// ==== MOTD ========================================================== //
// Salut à toi, petit curieux !                                         //
// Si tu lis ce message, c'est que tu regardes bel-et-bien le code      //
// source de ce programme, et je t'en remercie.                         //
// Je te préviens, tu vas y voir beaucoup de code "spaghetti" par ici.  //
//                                                                      //
// Bon "vomissage" et à la prochaine !                                  //
// ==================================================================== //

// ==== License ======================================================= //
//         DO WHAT THE FUCK YOU WANT TO PUBLIC LICENSE                  //
//                    Version 2, December 2004                          //
//                                                                      //
// Copyleft 2014-2016 André Kody Fernandes <im@kdy.ch>                  //
//                                                                      //
// Everyone is permitted to copy and distribute verbatim or modified    //
// copies of this license document, and changing it is allowed as long  //
// as the name is changed.                                              //
//                                                                      //
//            DO WHAT THE FUCK YOU WANT TO PUBLIC LICENSE               //
//   TERMS AND CONDITIONS FOR COPYING, DISTRIBUTION AND MODIFICATION    //
//                                                                      //
//  0. You just DO WHAT THE FUCK YOU WANT TO.                           //
// ==================================================================== //

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Chatling {
    class Message {
        public int ip { get; set; }
        public int pv { get; set; }
        public string h { get; set; }
        public string tm { get; set; }
        public string cnt { get; set; }
        public int clr { get; set; }

        public string ToJson() {
            return new JavaScriptSerializer().Serialize(this);
        }

        public void ToMessageString() {
            if (Client.PROTOCOL_VERSION != this.pv) return;

            if (this.tm == "r") {
                fmMain._Form1.UpdateUserList(2, this.ip, this.cnt);
                fmMain._Form1.WriteChatMessages(1, this.h, this.cnt, this.clr);
            } else if (this.tm == "j") {
                fmMain._Form1.UpdateUserList(1, this.ip, this.h);
                fmMain._Form1.WriteChatMessages(2, this.h, actionColor: this.clr);
                fmMain._Form1.timPing_Tick();
            } else if (this.tm == "q") {
                fmMain._Form1.UpdateUserList(3, this.ip, this.h);
                fmMain._Form1.WriteChatMessages(3, this.h, actionColor: this.clr);
            } else if (this.tm == "a") {
                fmMain._Form1.WriteChatMessages(4, this.h, this.cnt, this.clr);
            } else if (this.tm == "p") {
                fmMain._Form1.UpdateUserList(1, this.ip, this.h);
                fmMain._Form1.PongUpdate(this.ip);
                Console.WriteLine("PONG! (de " + this.h + ")");
            } else if (this.tm == "m") {
                fmMain._Form1.WriteChatMessages(5, this.h, this.cnt, this.clr);
            } else {
                Console.WriteLine("WARNING >> Got message without recognized TypeMessage from " + string.Format("{0}\r\n", this.h));
            }
            fmMain._Form1.rtbLogs_TextChanged();
        }
    }

    class Messages : Queue<Message> {
        public event EventHandler MessageQueued;

        public void Add(Message item) {
            base.Enqueue(item);
            if (MessageQueued != null) MessageQueued(this, new EventArgs());
        }
    }

    class MessageEventArgs : EventArgs {
        public Message ReceivedMessage { get; set; }

        public MessageEventArgs(string content) {
            try {
                ReceivedMessage = new JavaScriptSerializer().Deserialize<Message>(content);
            } catch {
                fmMain._Form1.notifyIcon.ShowBalloonTip(2000, "Chatling Error", "Chatling n'a pas pu traîter un message, problème réseau ? " + content.ToString(), ToolTipIcon.Error);
            }
        }
    }
}
