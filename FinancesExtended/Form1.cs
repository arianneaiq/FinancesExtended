using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancesExtended
{
    public partial class Form1 : Form
    {
        Person person;
    

        public Form1()
        {
            InitializeComponent();
            person = new Person("Sam", 20, "sam90@gamil.com", "Wallet for vacation", 200, "Wallet for school", 400);
           
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            lbNameInfo.Text = person.GetInfo();
        }
    }
}
