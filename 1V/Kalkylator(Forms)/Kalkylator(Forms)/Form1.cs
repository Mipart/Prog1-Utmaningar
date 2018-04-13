using System;
using System.Windows.Forms;

namespace Kalkylator_Forms_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AddListItem();
            cbFunc.SelectedIndex = 0;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            PreformMagicMath();
        }
        
        //Check if an valid input and choose Func
        private void PreformMagicMath()
        {
            float numOne;
            float numTwo;

            bool returnOne = float.TryParse(txtFirstNum.Text, out numOne);
            bool returnTwo = float.TryParse(txtSecondNum.Text, out numTwo);

            //If both values can be parsed do....
            if(returnOne && returnTwo){
                switch (cbFunc.SelectedIndex)
                {
                    case 0:
                        txtSum.Text = Add(numOne, numTwo).ToString();
                        break;
                    case 1:
                        txtSum.Text = Sub(numOne, numTwo).ToString();
                        break;
                    case 2:
                        txtSum.Text = Mult(numOne, numTwo).ToString();
                        break;
                    case 3:
                        txtSum.Text = Div(numOne, numTwo).ToString();
                        break;
                }
            }
        }

        //Add objects to List
        private void AddListItem()
        {
            cbFunc.Items.Add("+");
            cbFunc.Items.Add("-");
            cbFunc.Items.Add("*");
            cbFunc.Items.Add("/");

        }

        //Addition
        private float Add(float firstNum, float secNum)
        {
            return firstNum + secNum;
        }

        //Multiplikation
        private float Mult(float firstNum, float secNum)
        {
            return firstNum * secNum;
        }

        //Subtraktion
        private float Sub(float firstNum, float secNum)
        {
            return firstNum - secNum;
        }

        //Division
        private float Div(float firstNum, float secNum)
        {
            return firstNum / secNum;
        }
    }
}
