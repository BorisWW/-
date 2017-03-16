using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomeGameHelper
{
    public partial class Form1 : Form
    {
        fInfo fIn = new fInfo();
        fDurak fD = new fDurak();
        fBlJack fbl = new fBlJack();
        fHelping fH = new fHelping();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHelper_Click(object sender, EventArgs e)
        {
            if (cbNameofGame.Text == "Покер")
            {

                fH.ShowDialog();
            }
            else if (cbNameofGame.Text == "Блэкджэк")
            {
                fbl.ShowDialog();
            }
            else if (cbNameofGame.Text=="Дурак")
            {
                fD.ShowDialog();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            fIn.ShowDialog();
        }
    }
}
