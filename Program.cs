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

namespace Chatling {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fmMain());
        }
    }
}
