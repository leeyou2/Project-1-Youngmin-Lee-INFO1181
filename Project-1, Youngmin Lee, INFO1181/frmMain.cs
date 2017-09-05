// Project-1
// CS1181
// Written By: Youngmin Lee
// 4h September 2017
// Anii Mandal 
// Description – Displaying Hello world with Name when users click the button.
// WOW: Display message box when project start "This is Hello App"
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1__Youngmin_Lee__INFO1181
{
    public partial class frmHelloApp : Form
    {
        public frmHelloApp()
        {
            InitializeComponent();
        }
        //Making the event when user click the button.
        private void btnSayHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello" + " " + txtName.Text + "!");
        }
        //When project start, message box pop up.
        private void HelloApp_Load(object sender, EventArgs e)
        {
            MessageBox.Show("This is Hello App");
        }
    }
}
