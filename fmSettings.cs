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
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Chatling {
    public partial class fmSettings : MaterialForm {
        private readonly MaterialSkinManager materialSkinManager;

        public fmSettings() {
            InitializeComponent();

            // Material
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);

            // Set current values
            mtbxConfUserName.Text = fmMain._Form1.currentName;

            mckbConfLogsSave.AutoCheck = true;
            mckbConfLogsSave.Checked = fmMain._Form1.saveOnExit;
        }

        private void mbtnConfUserNameApply_Click(object sender, EventArgs e) {
            fmMain._Form1.setConfig(2, mtbxConfUserName.Text);
        }

        private void mradConfUserColorRadio_Click(object sender, EventArgs e) {
            // S'il est bien activé, l'enregistrer
            if (((RadioButton)sender).Checked == true) {
                lblConfUserColorExample.ForeColor = ((RadioButton)sender).ForeColor;
                fmMain._Form1.setConfig(1, fmMain._Form1.getIdFromColor(((RadioButton)sender).ForeColor).ToString());
            }
        }

        private void mckbConfLogsSave_CheckedChanged(object sender, EventArgs e) {
            // Enregistrer la valeur du booléan
            fmMain._Form1.setConfig(3, Convert.ToString(mckbConfLogsSave.Checked));
        }

        private void fmSettings_FormClosed(object sender, FormClosedEventArgs e) {
            fmMain.SettingsForm = null;
        }
    }
}
