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
            //Console.WriteLine("This is what happens at Page_Load");
            //Console.ReadLine();
        }

        // MyFirstChallenge
        // Declare 2 variables set them to value of TextBox .Text
        // Added some conditions to this project to provide diferent functionality

        protected void clickMeButton_Click(object sender, EventArgs e)
        {
            string ageQuery = ageQueryTextBox.Text;
            
            int parsedAge = int.Parse(ageQueryTextBox.Text);

            string moneyInPocket = moneyQueryTextBox.Text;

            int parsedMoney = int.Parse(moneyInPocket);

           

            if ((parsedAge >= 40) && (parsedMoney <= 100))
            {
                //Refactor using case statements with class level variables?
                string moneyInPocketA = moneyQueryTextBox.Text;
                string resultA = "At " + ageQuery + " one would expect you would have " +
                                "more than " + moneyInPocketA + " in your pocket";
                resultLabel.Text = resultA;
            }
            else if((parsedAge <= 39 )&&(parsedMoney >= 25))
            {
                string moneyInPocketB = moneyQueryTextBox.Text;
                string resultB = "At " + ageQuery + " your well on your way to having far " +
                                 "more than " + moneyInPocketB + " in your pocket";
                resultLabel.Text = resultB;
            }
        }
    }
}