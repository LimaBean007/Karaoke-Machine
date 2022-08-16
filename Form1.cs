using KaraokeMachine.CLinkLists;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaraokeMachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            SLinkedLists sLinkedLists = new SLinkedLists();
            sLinkedLists.appendNode("I am head ");
            sLinkedLists.appendNode("I am head 2");
            sLinkedLists.appendNode("I am head 3");
            sLinkedLists.preprend("I am the new HEAD");
            sLinkedLists.preprend("Mwhahahahaha I am the new Head");
            sLinkedLists.preprend("Look at me, I am the Captain now");
         
           // sLinkedLists.deleteWithData("Mwhahahahaha I am the new Head");
            sLinkedLists.applyProfanityFilter("am");
        }

        private void button1_Click(object sender, EventArgs e)
        {
   
           

        }
    }
}
