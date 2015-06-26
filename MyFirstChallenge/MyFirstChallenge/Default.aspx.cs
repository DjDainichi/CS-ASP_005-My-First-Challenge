using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstChallenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // MyFirstChallenge
        // Declare 2 variables set them to value of TextBox .Text
        protected void clickMeButton_Click(object sender, EventArgs e)
        {
            string ageQuery = ageQueryTextBox.Text;
            string moneyInPocket = moneyQueryTextBox.Text;

            string result = "At " + ageQuery + " one would expect you would have "+
                                            "more than " + moneyInPocket + " in your pocket";
            resultLabel.Text = result;
        }
    }
}