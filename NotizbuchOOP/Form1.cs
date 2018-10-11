using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotizbuchOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var mi_NotizHinzufügen = new MenuItem("Notiz hinzufügen", test, Shortcut.CtrlA);
            var mi_NotizLöschen = new MenuItem("Notiz löschen", test, Shortcut.CtrlD);


            lb_Notizen.ContextMenu = new ContextMenu(new MenuItem[] {mi_NotizHinzufügen, mi_NotizLöschen });
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
        private void test(object sender, EventArgs e)
        {

        }
    }
}
