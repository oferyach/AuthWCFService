using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AuthTest.LoyatlyService;


namespace AuthTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           InitializeComponent();
           AuthTest.LoyatlyService.LoyaltyServiceClient s = new LoyaltyServiceClient();
           AuthResult res = new AuthResult();
           
           
           res = s.GetAuth("7215701085369600","3");
           if (!res.Allowed)
               MessageBox.Show("Denied: " + res.ErrorDesc);
           else
           

            MessageBox.Show(res.DriverName+" "+res.ProductsList[0].ToString());

        }
    }
}
