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
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;
using System.Collections.Generic;
using System.Drawing;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Chatling {
    public partial class fmMain : MaterialForm {

        bool isOui = false;
        string lastMessage = "";
        string appVersion;
        string appName;
        int welcomeTick;
        private readonly MaterialSkinManager materialSkinManager;
        private Client client;
        private Messages messages;
        public static fmMain _Form1;
        public static Form SettingsForm = null;
        public string currentName;
        public bool saveOnExit;
        List<string> userList;

        public fmMain() {
            InitializeComponent();

            // Material
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);

            _Form1 = this;
            welcomeCard.Location = new Point(0, 64);

            userList = new List<string>();

            messages = new Messages();
            messages.MessageQueued += new EventHandler(Messages_MessageQueued);
          
            client = new Client();
            client.Loading();
            client.MessageReceived += new EventHandler<MessageEventArgs>(client_MessageReceived);

            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            appName = fileVersionInfo.FileDescription;
            appVersion = fileVersionInfo.ProductVersion;
            appVersion = appVersion.Remove(appVersion.Length - 2);

            rtbLogs.AppendText("<Chatling> Bienvenue sur Chatling (" + appVersion + ") !\n");
            rtbLogs.AppendText("<Chatling> Faites '/help' pour la liste des commandes.\n");

            // Sauvegarder les valeurs
            currentName = client.Handle;
            saveOnExit = client.SaveOnQuitConfig;

            // Noraj de mon arrivage
            client.Transmit("", "j");
            _Form1.Text = appName + " (" + currentName + "@" + appVersion + ")";
        }

        private void tbxInput_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Return) {
                if (tbxInput.Text == " " || tbxInput.Text.Contains(" ") || string.IsNullOrEmpty(tbxInput.Text) || tbxInput.Text.Length <= 0 || tbxInput.Text.Length > 140 || tbxInput.Text.Trim().Length == 0 || tbxInput.Text == lastMessage) {
                    // nothing
                } else if (tbxInput.Text.Substring(0, 1) == "/") {
                    if (tbxInput.Text.Contains("/help")) {
                        if (tbxInput.Text.Substring(0, 5) == "/help") {
                            rtbLogs.AppendText("\n<Chatling> Voici la (courte) page d'aide.\n");
                            rtbLogs.AppendText("\t/bite  -> Sauvegarde les logs et BIIIIITE (quitte) le chat.\n");
                            rtbLogs.AppendText("\t/clear -> vide le chat.\n");
                            rtbLogs.AppendText("\t/help  -> afficher l'aide.\n");
                            rtbLogs.AppendText("\t/nick  -> changer votre nom.\n");
                            rtbLogs.AppendText("\t/quit  -> quitter sans sauvegarder.\n");
                            rtbLogs.AppendText("\t/oui   -> C'est très le oui, oui.\n");
                            rtbLogs.AppendText("\t/sc    -> Sauvegarde les logs et vide le chat.");
                        }
                    } else if (tbxInput.Text.Contains("/nick")) {
                        if (tbxInput.Text.Substring(0, 5) == "/nick") {
                            string newPseudo = tbxInput.Text.Remove(0, 6);
                            rtbLogs.SelectionStart = rtbLogs.TextLength;
                            rtbLogs.SelectionLength = 0;
                            rtbLogs.SelectionColor = Color.Red;
                            if (newPseudo.Contains(" ")) {
                                rtbLogs.AppendText("\n<Chatling> Pas d'espaces dans le pseudo...");
                            } else if (newPseudo.Length > 10) {
                                rtbLogs.AppendText("\n<Chatling> Pseudo bien trop long ! (cmb)");
                            } else if (newPseudo.Length < 2) {
                                rtbLogs.AppendText("\n<Chatling> Pseudo bien trop court ! (ctb)");
                            } else {
                                // Noraj de mon renommage
                                client.Transmit(newPseudo, "r");
                                client.Handle = newPseudo;
                                currentName = client.Handle;
                                _Form1.Text = appName + " (" + currentName + "@" + appVersion + ")";

                                saveConfig();
                            }
                            rtbLogs.SelectionColor = rtbLogs.ForeColor;
                        }
                    } else if (tbxInput.Text.Contains("/me")) {
                        if (tbxInput.Text.Substring(0, 3) == "/me") {
                            string doingSomething = tbxInput.Text.Remove(0, 4);
                            Console.WriteLine("send >>" + doingSomething);
                            // Noraj de mon actionnage
                            client.Transmit(doingSomething, "a");
                        }
                    } else if (tbxInput.Text.Contains("/quit")) {
                        if (tbxInput.Text.Substring(0, 5) == "/quit") {
                            // Noraj de mon quittage
                            Application.Exit();
                        }
                    } else if (tbxInput.Text.Contains("/clear")) {
                        if (tbxInput.Text.Substring(0, 6) == "/clear") {
                            // Noraj de mon vidage
                            rtbLogs.Text = null;
                        }
                    } else if (tbxInput.Text.Contains("/sc")) {
                        if (tbxInput.Text.Substring(0, 3) == "/sc") {
                            // Noraj de mon sauvegardage
                            FileStream fs = new FileStream(Environment.CurrentDirectory + "\\" + DateTime.Now.ToString("yyyy-MM-dd") + "_chatling.log", FileMode.Append);
                            StreamWriter sw = new StreamWriter(fs, ASCIIEncoding.UTF8);
                            sw.Write(rtbLogs.Text + "\r\n");
                            sw.Close();
                            fs.Close();
                            rtbLogs.Text = null;
                        }
                    } else if (tbxInput.Text.Contains("/bite")) {
                        if (tbxInput.Text.Substring(0, 5) == "/bite") {
                            // Noraj de mon enfuitage
                            FileStream fs = new FileStream(Environment.CurrentDirectory + "\\" + DateTime.Now.ToString("yyyy-MM-dd") + "_chatling.log", FileMode.Append);
                            StreamWriter sw = new StreamWriter(fs, ASCIIEncoding.UTF8);
                            sw.Write(rtbLogs.Text + "\r\n");
                            sw.Close();
                            fs.Close();
                            rtbLogs.Text = null;
                            Application.Exit();
                        }
                    } else if (tbxInput.Text.Contains("/oui")) {
                        if (tbxInput.Text.Substring(0, 4) == "/oui") {
                            // Oui
                            isOui = !isOui;
                        }
                    } else {
                        if (isOui) 
                            client.Transmit(tbxInput.Text + ", oui", "m");
                        else
                            client.Transmit(tbxInput.Text, "m");
                    }
                    tbxInput.Text = string.Empty;
                } else {
                    if (isOui)
                        client.Transmit(tbxInput.Text + ", oui", "m");
                    else 
                        client.Transmit(tbxInput.Text, "m");

                    tbxInput.Text = string.Empty;
                }
                lastMessage = tbxInput.Text;
                e.Handled = true;
            }
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);
        private const int WM_VSCROLL = 277;
        private const int SB_PAGEBOTTOM = 7;
        public static void ScrollToBottom(RichTextBox MyRichTextBox) {
            SendMessage(MyRichTextBox.Handle, WM_VSCROLL, (IntPtr)SB_PAGEBOTTOM, IntPtr.Zero);
        }
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern bool FlashWindow(IntPtr hwnd, bool bInvert);

        public void UpdateChat() {
            try {
                if (InvokeRequired) {
                    Invoke(new Action(UpdateChat));
                } else {
                    messages.Dequeue().ToMessageString();
                    FlashWindow(this.Handle, false);
                }
            } catch {
                Console.WriteLine("lol, fail");
            }
        }

        public void WriteChatMessages(int actionType, string actionUser, string actionContent = null, int actionColor = 0) {
            rtbLogs.SelectionStart = rtbLogs.TextLength;
            rtbLogs.SelectionLength = 0;
            switch (actionType) {
                case 1: // Rename
                    rtbLogs.SelectionColor = Color.FromName("blue");
                    rtbLogs.AppendText("\r\n( ! ) ");
                    rtbLogs.SelectionColor = getColorFromId(actionColor);
                    rtbLogs.AppendText(actionUser);
                    rtbLogs.SelectionColor = Color.FromName("blue");
                    rtbLogs.AppendText(" est maintenant ");
                    rtbLogs.SelectionFont = new Font(rtbLogs.Font, FontStyle.Bold);
                    rtbLogs.SelectionColor = getColorFromId(actionColor);
                    rtbLogs.AppendText(actionContent);
                    break;
                case 2: // Join
                    rtbLogs.SelectionColor = Color.FromName("green");
                    rtbLogs.AppendText("\r\n>>> Arrivée de ");
                    rtbLogs.SelectionFont = new Font(rtbLogs.Font, FontStyle.Bold);
                    rtbLogs.SelectionColor = getColorFromId(actionColor);
                    rtbLogs.AppendText(actionUser);
                    break;
                case 3: // Quit
                    rtbLogs.SelectionColor = Color.FromName("red");
                    rtbLogs.AppendText("\r\n<<< Départ de ");
                    rtbLogs.SelectionFont = new Font(rtbLogs.Font, FontStyle.Bold);
                    rtbLogs.SelectionColor = getColorFromId(actionColor);
                    rtbLogs.AppendText(actionUser);
                    break;
                case 4: // Action
                    rtbLogs.SelectionColor = Color.FromName("gray");
                    rtbLogs.AppendText("\r\n * ");
                    rtbLogs.SelectionFont = new Font(rtbLogs.Font, FontStyle.Italic);
                    rtbLogs.SelectionColor = getColorFromId(actionColor);
                    rtbLogs.AppendText(actionUser);
                    rtbLogs.SelectionColor = Color.FromName("gray");
                    rtbLogs.AppendText(" " + actionContent);
                    break;
                case 5: // Message
                    rtbLogs.AppendText("\r\n[" + DateTime.Now.ToString("HH:mm:ss") + "] <");
                    rtbLogs.SelectionFont = new Font(rtbLogs.Font, FontStyle.Bold);
                    rtbLogs.SelectionColor = getColorFromId(actionColor);
                    rtbLogs.AppendText(actionUser);
                    rtbLogs.SelectionFont = new Font(rtbLogs.Font, FontStyle.Regular);
                    rtbLogs.AppendText("> ");
                    if (actionContent.StartsWith(">")) rtbLogs.SelectionColor = Color.FromName("green");
                    else rtbLogs.SelectionColor = rtbLogs.ForeColor;
                    rtbLogs.AppendText(actionContent);
                    break;
            }
            rtbLogs.SelectionFont = new Font(rtbLogs.Font, FontStyle.Regular);
            rtbLogs.SelectionColor = rtbLogs.ForeColor;
        }

        public void UpdateUserList(int status, int userId, string name = "") {
            TimeSpan t = DateTime.UtcNow - new DateTime(1970, 1, 1);
            int timestamp = (int)t.TotalSeconds;

            string displayName = "(" + userId.ToString() + ") " + name;
            switch (status) {
                case 1:
                    // add
                    int iteminlist = lbUsers.FindString("(" + userId.ToString() + ")");
                    if (iteminlist < 0) {
                        lbUsers.Items.Add(displayName);
                        userList.Add(userId.ToString() + "," + timestamp.ToString());
                    }
                    foreach (var i in userList) {
                        Console.WriteLine(i);
                    }
                    break;
                case 2:
                    // update
                    int listBoxItemIndex = lbUsers.FindString("(" + userId.ToString() + ")");
                    if (listBoxItemIndex >= 0) {
                        lbUsers.Items[listBoxItemIndex] = displayName;
                        int iteminuserlist = userList.FindIndex(x => x.StartsWith(userId.ToString() + ","));
                        userList[iteminuserlist] = userId.ToString() + "," + timestamp.ToString();
                    }
                    foreach (var i in userList) {
                        Console.WriteLine(i);
                    }
                    break;
                case 3:
                    // remove
                    int itemtoremove = lbUsers.FindString("(" + userId.ToString() + ")");
                    int itemtoremoveuserlist = userList.FindIndex(x => x.StartsWith(userId.ToString() + ","));
                    if (itemtoremove >= 0) {
                        lbUsers.Items.RemoveAt(itemtoremove);
                        userList.RemoveAt(itemtoremoveuserlist);
                    }
                    break;
                default:
                    Console.WriteLine("wtf!");
                    break;
            }
        }

        public void PongUpdate(int userId, string name = "") {
            TimeSpan t = DateTime.UtcNow - new DateTime(1970, 1, 1);
            int timestamp = (int)t.TotalSeconds;

            int iteminuserlist = userList.FindIndex(x => x.StartsWith(userId.ToString() + ","));
            if (iteminuserlist >= 0) {
                userList[iteminuserlist] = userId.ToString() + "," + timestamp.ToString();
            }
        }

        void Messages_MessageQueued(object sender, EventArgs e) {
            UpdateChat();
        }

        void client_MessageReceived(object sender, MessageEventArgs e) {
            messages.Add(e.ReceivedMessage);
            try {
                if (e.ReceivedMessage.cnt.Contains(client.Handle) && e.ReceivedMessage.tm == "message") {
                    notifyIcon.ShowBalloonTip(2000, e.ReceivedMessage.h, e.ReceivedMessage.cnt, ToolTipIcon.None);
                }
            } catch {
                Console.WriteLine("lol, failed on check notification");
            }
        }

        private void frmGroupChat_Load(object sender, EventArgs e) {
            notifyIcon.ShowBalloonTip(2000, appName + " " + appVersion, "Vous avez rejoint en tant que " + currentName, ToolTipIcon.Info);
        }

        private void fmMain_FormClosing(object sender, FormClosingEventArgs e) {
            if (saveOnExit) {
                FileStream fs = new FileStream(Environment.CurrentDirectory + "\\" + DateTime.Now.ToString("yyyy-MM-dd") + "_chatling.log", FileMode.Append);
                StreamWriter sw = new StreamWriter(fs, ASCIIEncoding.UTF8);
                sw.Write(rtbLogs.Text + "\r\n");
                sw.Close();
                fs.Close();
            }
            client.Transmit("", "q");
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e) {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }

        private void fmMain_Resize(object sender, EventArgs e) {
            if (FormWindowState.Minimized == this.WindowState) {
                this.Hide();
            }
        }

        private void tbxInput_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Up) {
                tbxInput.Text = lastMessage;
                tbxInput.SelectionStart = tbxInput.Text.Length;
            }
        }

        private void timCheck_Tick(object sender, EventArgs e) {
            lblLeftChars.Text = (140 - tbxInput.Text.Length).ToString();
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        public void timPing_Tick(object sender = null, EventArgs e = null) {
            client.Transmit("", "p");
            Console.WriteLine("PING!");

            TimeSpan t = DateTime.UtcNow - new DateTime(1970, 1, 1);
            int timestamp = (int)t.TotalSeconds;
            int timeout = timestamp - 120;

            userList.ForEach(delegate(string value) {
                string[] checkMe = value.Split(',');
                if (Convert.ToInt32(checkMe[1]) < timeout) {
                    UpdateUserList(3, Convert.ToInt32(checkMe[0]));
                }
            });
        }

        private void timFade_Tick(object sender, EventArgs e) {
            welcomeTick++;
            int startAnimTick = 300;
            if (welcomeTick > 500) {
                timFade.Enabled = false;
                _Form1.Controls.Remove(welcomeCard);
            } else if (welcomeTick > (startAnimTick + 60)) {
                welcomeCard.Height -= 1;
            } else if (welcomeTick > (startAnimTick + 35)) {
                welcomeCard.Height -= 2;
            } else if (welcomeTick > (startAnimTick + 21)) {
                welcomeCard.Height -= 4;
            } else if (welcomeTick > startAnimTick) {
                welcomeCard.Height -= 10;
            }
        }

        private void welcomeCard_Click(object sender, EventArgs e) {
            timFade.Enabled = false;
            _Form1.Controls.Remove(welcomeCard);
        }

        public void rtbLogs_TextChanged(object sender = null, EventArgs e = null) {
            // scroll to end
            //rtbLogs.SelectionStart = rtbLogs.Text.Length;
            //rtbLogs.ScrollToCaret();

            ScrollToBottom(rtbLogs);
        }

        private void lbtnSettings_Click(object sender, EventArgs e) {
            if (SettingsForm != null) {
                SettingsForm.BringToFront();
            } else {
                SettingsForm = new fmSettings();
                SettingsForm.Show();
            }
        }

        public Color getColorFromId(int value) {
            switch (value) {
                case 0:
                    return Color.Black;
                case 1:
                    return Color.Green;
                case 2:
                    return Color.Red;
                case 3:
                    return Color.Purple;
                case 4:
                    return Color.DarkOrange;
                case 5:
                    return Color.HotPink;
                case 6:
                    return Color.Navy;
                case 7:
                    return Color.Blue;
                default:
                    return Color.Black;
            }
        }

        public int getIdFromColor(Color value) {
            string colorName = value.Name;
            switch (colorName) {
                case "Black":
                    return 0;
                case "Green":
                    return 1;
                case "Red":
                    return 2;
                case "Purple":
                    return 3;
                case "DarkOrange":
                    return 4;
                case "HotPink":
                    return 5;
                case "Navy":
                    return 6;
                case "Blue":
                    return 7;
                default:
                    return 0;
            }
        }

        private void saveConfig() {
            // Ecrire dans le fichier de configuration
            FileStream fs = new FileStream(Environment.CurrentDirectory + "\\chatling.conf", FileMode.Truncate);
            StreamWriter sw = new StreamWriter(fs, ASCIIEncoding.UTF8);
            sw.Write(currentName + "\n" + Convert.ToString(saveOnExit) + "\n" + client.UserSelectedColor);
            sw.Close();
            fs.Close();
        }

        public void setConfig(int key, string value) {
            switch (key) {
                case 1:
                    // Color
                    client.UserSelectedColor = Int32.Parse(value);
                    break;
                case 2:
                    // Nick
                    if (currentName != value) {
                        rtbLogs.SelectionColor = Color.Red;
                        if (value.Length == 0 || value == null || value.Contains(" ")) {
                                rtbLogs.AppendText("\n<Chatling> Il faudrait donner un pseudo, nan ?");
                        } else if (value.Length > 10) {
                            rtbLogs.AppendText("\n<Chatling> Pseudo bien trop long ! (cmb)");
                        } else if (value.Length < 2) {
                            rtbLogs.AppendText("\n<Chatling> Pseudo bien trop court ! (ctb)");
                        } else {
                            client.Transmit(value, "r");
                            client.Handle = value;
                            currentName = client.Handle;
                            _Form1.Text = appName + " (" + currentName + "@" + appVersion + ")";
                        }
                        rtbLogs.SelectionColor = rtbLogs.ForeColor;
                    }
                    break;
                case 3:
                    // Save logs
                    saveOnExit = Convert.ToBoolean(value);
                    break;
            }
            saveConfig();
        }
    }
}
