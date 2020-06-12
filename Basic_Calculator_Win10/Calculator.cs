using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Calculator_Win10
{
    public partial class Calculator : Form
    {
        #region Declarations
        /*  Declaration of Variables */
        Double resultOfCalculation = 0;
        String operationPerform = "", firstNumber = "", oldOperation = "" , passOperation = "";
        bool isClickOnOperators = false;
        
        /*  Methods and Functions */
        /// <summary>
        /// get the number of special character like (',' OR '.')
        /// to get the length of txtCal after subtract length of special character
        /// </summary>
        /// <param name="txt"></param>
        /// <returns></returns>
        public int countOfSpecialChar(string txt)
        {
            int count = 0;
            foreach (char ch in txt)
            {
                if (ch == ',' || ch == '.' || ch == '-')
                {
                    count += 1;
                }
            }
            return count;
        }
        
        /// <summary>
        /// Handle arithmetic errors
        /// </summary>
        public void HandleErrors() //Completed Check of Syntax Code***
        {
            foreach (Control ctrl in this.tlpBottom.Controls)
            {
                if (ctrl == btnDeciemal || ctrl == btnNegative || ctrl == btnPlus
                    || ctrl == btnMinus || ctrl == btnMultiply || ctrl == btnDivide)
                {
                    if (ctrl.Enabled == true)
                    {
                        ctrl.Enabled = false;
                    }
                    else
                    {
                        ctrl.Enabled = true;
                    }
                }
            }
            resultOfCalculation = 0;
            firstNumber = "";
            isClickOnOperators = false;
        }

        /// <summary>
        /// Get Responsive Style For Table Layout Panel Right , Bottom and Main (History)
        /// </summary>
        /// <param name="firstTLP">tlpBottom</param>
        /// <param name="mainTLP">tlpMain</param>
        /// <param name="RowStyleCal">RowStyleCal refers to new instance of TableLayoutRowStyleCollection</param>
        /// <param name="secondTLP">tlpRight</param>
        public void GetResponsiveStyle(TableLayoutPanel firstTLP, TableLayoutPanel mainTLP,
            TableLayoutRowStyleCollection RowStyleCal, TableLayoutPanel secondTLP)//Completed Check of Syntax Code ***
        {
            if (firstTLP.Visible == true)
            {
                firstTLP.Visible = false;
                secondTLP.Visible = true;
                secondTLP.Size = tlpBottom.Size;
                secondTLP.Location = tlpBottom.Location;
                secondTLP.Dock = DockStyle.Bottom;

                // For Table Layout Panel Main
                RowStyleCal = mainTLP.RowStyles;
                foreach (RowStyle rs in RowStyleCal)
                {
                    rs.SizeType = SizeType.AutoSize;
                }

                // For Table Layout Panel Right
                int rowCount = 0;
                RowStyleCal = secondTLP.RowStyles;
                foreach (RowStyle rs in RowStyleCal)
                {
                    rs.SizeType = SizeType.Percent;
                    if (rowCount == 0) rs.Height = 0;
                    else if (rowCount == 1) rs.Height = 0;
                    else if (rowCount == 2) rs.Height = 88;
                    else if (rowCount == 3) rs.Height = 12;
                    rowCount += 1;
                }
            }
            else if (firstTLP.Visible == false)
            {
                firstTLP.Visible = true;
                firstTLP.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;

                secondTLP.Visible = false;
                secondTLP.Size = new Size(254, 486);//
                secondTLP.Location = new Point(298, 0);//
                secondTLP.Dock = DockStyle.Right;//

                // For Table Layout Panel Main
                int rowCount = 0;
                RowStyleCal = mainTLP.RowStyles;
                foreach (RowStyle rs in RowStyleCal)
                {
                    rs.SizeType = SizeType.Percent;
                    if (rowCount == 0) rs.Height = 10;
                    else if (rowCount == 1) rs.Height = 11;
                    else if (rowCount == 2) rs.Height = 16;
                    else if (rowCount == 3) rs.Height = 63;
                    rowCount += 1;
                }

                //For Table Layout Panel Right ***
                // redefine the counter
                rowCount = 0;
                RowStyleCal = secondTLP.RowStyles;
                foreach (RowStyle rs in RowStyleCal)
                {
                    rs.SizeType = SizeType.Percent;
                    if (rowCount == 0) rs.Height = 6;
                    else if (rowCount == 1) rs.Height = 3;
                    else if (rowCount == 2) rs.Height = 84;
                    else if (rowCount == 3) rs.Height = 7;
                    rowCount += 1;
                }
            }
        }

        /// <summary>
        /// Get Default Style For Table Layout Panel Right , Bottom and Main (History)
        /// </summary>
        /// <param name="firstTLP">tlpBottom</param>
        /// <param name="mainTLP">tlpMain</param>
        /// <param name="RowStyleCal">RowStyleCal refers to new instance of TableLayoutRowStyleCollection</param>
        /// <param name="secondTLP">tlpRight</param>
        public void GetDefaultStyle(TableLayoutPanel firstTLP, TableLayoutPanel mainTLP,
            TableLayoutRowStyleCollection RowStyleCal, TableLayoutPanel secondTLP)//Completed Check of Syntax Code ***
        {
            firstTLP.Visible = true;
            firstTLP.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            firstTLP.Dock = DockStyle.None;

            // make Refresh for Table Layout Panel Right
            secondTLP.Refresh();
            secondTLP.Dock = DockStyle.Right;
            secondTLP.Size = new Size(254, 486);
            secondTLP.Location = new Point(298, 0);


            // For Table Layout Panel Main
            //Declare integer Variable to loop in rows of table layout panel
            int rowCount = 0;
            // For Table Layout Panel Right
            RowStyleCal = secondTLP.RowStyles;
            foreach (RowStyle rs in RowStyleCal)
            {
                rs.SizeType = SizeType.Percent;
                if (rowCount == 0) rs.Height = 6;
                else if (rowCount == 1) rs.Height = 3;
                else if (rowCount == 2) rs.Height = 84;
                else if (rowCount == 3) rs.Height = 7;
                rowCount += 1;
            }

            // For Table Layout Panel Main
            // redefine the counter
            rowCount = 0;
            RowStyleCal = mainTLP.RowStyles;
            foreach (RowStyle rs in RowStyleCal)
            {
                rs.SizeType = SizeType.Percent;
                if (rowCount == 0) rs.Height = 10;
                else if (rowCount == 1) rs.Height = 11;
                else if (rowCount == 2) rs.Height = 16;
                else if (rowCount == 3) rs.Height = 63;
                rowCount += 1;
            }
        }

        #endregion

        public Calculator()
        {
            InitializeComponent();
        }

        #region Design Events Codes
        /* when the form load event raise */
        private void Calculator_Load(object sender, EventArgs e)//Completed Check of Syntax Code ***
        {
            this.Size = new Size(380, 500);

            btnDelete.Visible = false;
            lbHistory.Enabled = false;
        }
        /* if Client change the size of Form */
        private void Calculator_ClientSizeChanged(object sender, EventArgs e)//Completed Check of Syntax Code ***
        {   
            // it measure on the standard or normal size of form (width 568, height 525)
            if (this.Height > 525 || this.Width > 568)
            {
                tlpRight.Visible = true;
                btnHistory.Visible = false;

                TableLayoutRowStyleCollection RowStyle = this.tlpMain.RowStyles;
                GetDefaultStyle(tlpBottom, tlpMain, RowStyle, tlpRight);

            }
            else if (this.Height < 525 || this.Width < 568)
            {
                tlpRight.Visible = false;
                btnHistory.Visible = true;

            }
            if(tlpRight.Dock == DockStyle.Bottom)
            {
                tlpBottom.Visible = true;
            }
        }

        private void btnBackspace_Click(object sender, EventArgs e)//Completed Check of Syntax Code ***
        {
            if (txtCal.Text.Contains("Result is undefined") || txtCal.Text.Contains("Cannot divide by zero")) btnCancel.PerformClick();
            if (txtCal.Text != "0")
            {
                txtCal.Text = txtCal.Text.Remove(txtCal.Text.Length - 1, 1);
            }
            if (txtCal.Text == "0" || txtCal.Text == "")
            {
                txtCal.Text = "0";
            }
        }

        private void btnNegative_Click(object sender, EventArgs e)//Completed Check of Syntax Code ***
        {
            if (txtCal.Text.StartsWith("-"))
            {
                txtCal.Text = txtCal.Text.Remove(0, 1);
            }
            else if (!txtCal.Text.StartsWith("+") && !txtCal.Text.StartsWith("-"))
            {
                txtCal.Text = "-" + txtCal.Text;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)//Completed Check of Syntax Code ***
        {
            if (txtCal.Text.Contains("Result is undefined") || txtCal.Text.Contains("Cannot divide by zero")) HandleErrors();
            txtDisplay.Text = "";
            txtCal.Text = "0";
            firstNumber = "";
            resultOfCalculation = 0;
            isClickOnOperators = false;
        }

        private void Calculator_KeyPress(object sender, KeyPressEventArgs e) //Completed Check of Syntax Code ***
        { // change TabStop of all button = false to clear focus on it
            switch (e.KeyChar)
            {
                case '0':
                    btnZero.PerformClick();
                    break;
                case '1':
                    btnOne.PerformClick();
                    break;
                case '2':
                    btnTwo.PerformClick();
                    break;
                case '3':
                    btnThree.PerformClick();
                    break;
                case '4':
                    btnFour.PerformClick();
                    break;
                case '5':
                    btnFive.PerformClick();
                    break;
                case '6':
                    btnSix.PerformClick();
                    break;
                case '7':
                    btnSeven.PerformClick();
                    break;
                case '8':
                    btnEight.PerformClick();
                    break;
                case '9':
                    btnNine.PerformClick();
                    break;
                case '+':
                    btnPlus.PerformClick();
                    break;
                case '-':
                    btnMinus.PerformClick();
                    break;
                case '/':
                    btnDivide.PerformClick();
                    break;
                case '*':
                    btnMultiply.PerformClick();
                    break;
                case '.':
                    btnDeciemal.PerformClick();
                    break;
                case '\r':
                    btnEqual.PerformClick();
                    break;
                case (char)Keys.Escape:
                    btnCancel.PerformClick();
                    break;
                case (char)Keys.Space:
                    btnCancel.PerformClick();
                    break;
                case (char)Keys.Back:
                    btnBackspace.PerformClick();
                    break;
                default:
                    break;
            }
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)//Completed Check of Syntax Code ***
        {
            if (txtDisplay.Text.Length > 9)
            {
                txtDisplay.Font = new Font("LBC", 16, FontStyle.Regular);
            }

            if (txtDisplay.Text.Contains("=") && !txtDisplay.Text.Contains(" =  "))
            {
                if (btnDelete.Visible == false && lbHistory.Items.Contains("There’s no history yet"))
                    lbHistory.Items.Clear(); lbHistory.Enabled = true; btnDelete.Visible = true;
                //if (lbHistory.Items.Contains("There’s no history yet")) lbHistory.Items.Clear(); lbHistory.Enabled = true;
                if (lbHistory.Items.Count == 0) lbHistory.Items.Insert(0, "\n");
                lbHistory.Items.Insert(0, "  " + txtDisplay.Text + "  " + resultOfCalculation.ToString());
                if (lbHistory.Items.Count > 1) lbHistory.Items.Insert(0, "\n");
            }
        }

        private void lbHistory_SelectedIndexChanged(object sender, EventArgs e)//Completed Check of Syntax Code ***
        {
            if ((String)lbHistory.SelectedItem == "\n" && lbHistory.SelectedIndex != lbHistory.Items.Count - 1)
                lbHistory.SelectedIndex = lbHistory.SelectedIndex + 1;
            else if ((String)lbHistory.SelectedItem == "\n" && lbHistory.SelectedIndex == lbHistory.Items.Count - 1)
                lbHistory.SelectedIndex = lbHistory.SelectedIndex - 1;
        }

        private void lbHistory_DoubleClick(object sender, EventArgs e)//Completed Check of Syntax Code ***
        {
            // declare a new int variable to store index of selected item
            int posOfItem = lbHistory.SelectedIndex;
            // declare a new string variable to store the selected item of listbox
            string txtOfItem = lbHistory.Items[posOfItem].ToString();
            // declare new string array to split the selected item of listbox
            string[] splitOfItem = new string[] { };

            // fill array by string after split it two parts
            splitOfItem = txtOfItem.Split('=');
            // store the first part in  txtDisplay
            txtDisplay.Text = splitOfItem[0].ToString() + " =  ";
            // store the first part in  txtCal
            txtCal.Text = splitOfItem[1].ToString();
        }

        private void txtCal_TextChanged(object sender, EventArgs e)//Completed Check of Syntax Code ***
        {
            if (txtCal.Text.Length >= 3 && !txtCal.Text.Contains(".") && txtCal.Text.Length != 19
                && !txtCal.Text.Contains("Result is undefined") && !txtCal.Text.Contains("Cannot divide by zero"))
            {
                txtCal.Text = String.Format("{0:N0}", Convert.ToDouble(txtCal.Text));
            }
            if (txtCal.Text.Length > 9)
            {
                txtCal.Font = new Font("LBC", 28, FontStyle.Regular);
            }
            else
            {
                txtCal.Font = new Font("LBC", 42, FontStyle.Regular);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)//Completed Check of Syntax Code ***
        {
            if (lbHistory.Items.Count != 0 && !lbHistory.Items.Contains("There’s no history yet"))
            {
                btnDelete.Visible = false;
                lbHistory.Items.Clear();
                lbHistory.Items.Add("There’s no history yet");
                lbHistory.Enabled = false;
                // to return focus on btnEqual again 
                btnEqual.Focus();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)//Completed Check of Syntax Code ***
        {
            if (txtCal.Text.Contains("Result is undefined")
                || txtCal.Text.Contains("Cannot divide by zero")) btnCancel.PerformClick();
            if (txtCal.Text != "0")
            {
                txtCal.Text = "0";
                isClickOnOperators = false;
            }
        }

        private void AddNumbersClick(object sender, EventArgs e)//Completed Check of Syntax Code ***
        {
            //Create a new instance from Button
            Button NumbersBtn = new Button();
            // Casting the instance to recall any Event
            NumbersBtn = (Button)sender;

            int length = txtCal.Text.Length - countOfSpecialChar(txtCal.Text);

            

            //MessageBox.Show(" Nums " + isClickOnOperators);
            //if ((txtCal.Text.Length < 21 && !txtCal.Text.Contains(".")) || (txtCal.Text.Length < 17 && txtCal.Text.Contains(".")))
            if (txtCal.Text == "Result is undefined" || txtCal.Text == "Cannot divide by zero") { HandleErrors(); txtDisplay.Text = ""; txtCal.Text = NumbersBtn.Text; }
            if (length < 16)
                if (isClickOnOperators == false)
                {
                    if (!txtCal.Text.Contains("."))
                    {
                        if (txtCal.Text == "0" && NumbersBtn.Text != btnDeciemal.Text) txtCal.Text = NumbersBtn.Text;
                        else txtCal.Text += NumbersBtn.Text;
                    }
                    else if (txtCal.Text.Contains(".") && NumbersBtn.Text != btnDeciemal.Text)
                    {
                        txtCal.Text += NumbersBtn.Text;
                    }
                }
                else
                {
                    if (txtDisplay.Text.Contains("=")) { txtDisplay.Text = ""; resultOfCalculation = 0; }
                    txtCal.Text = "";
                    if (NumbersBtn.Text == btnDeciemal.Text) txtCal.Text = "0" + NumbersBtn.Text;
                    else txtCal.Text += NumbersBtn.Text;
                }
            firstNumber = txtCal.Text;
            isClickOnOperators = false;
        }

        private void AddOperatorsClick(object sender, EventArgs e)//Completed Check of Syntax Code ***
        {
            // Create new instance of Button
            Button OperatorsBtn = new Button();
            // Casting new instance to recall any Event
            OperatorsBtn = (Button)sender;

            operationPerform = OperatorsBtn.Text;

            passOperation = operationPerform;

            if (oldOperation != "") operationPerform = oldOperation;

            if (OperatorsBtn.Text != btnEqual.Text && isClickOnOperators == false) // && isClickOnOperators == false && !txtDisplay.Text.Contains("=")
            {
                if (firstNumber == "" && txtCal.Text == "0") firstNumber = txtCal.Text;/*MessageBox.Show("Done")*/
                txtDisplay.Text += firstNumber + " " + passOperation + " ";
                
                switch (operationPerform)
                {
                    case "+":
                        resultOfCalculation += Double.Parse(txtCal.Text);
                        txtCal.Text = resultOfCalculation.ToString();
                        break;
                    case "-":
                        if (resultOfCalculation == 0) resultOfCalculation = Double.Parse(txtCal.Text);
                        else resultOfCalculation -= Double.Parse(txtCal.Text);
                        txtCal.Text = resultOfCalculation.ToString();
                        break;
                    case "X":
                        if (txtCal.Text != "0" && resultOfCalculation == 0) resultOfCalculation = Double.Parse(txtCal.Text) * 1;
                        else resultOfCalculation *= Double.Parse(txtCal.Text);
                        txtCal.Text = resultOfCalculation.ToString();
                        break;
                    case "÷":
                        if (txtCal.Text != "0" && resultOfCalculation == 0) resultOfCalculation = Double.Parse(txtCal.Text) / 1;
                        else if (txtCal.Text == "0" && resultOfCalculation == 0) resultOfCalculation = Double.Parse(txtCal.Text) / 1;
                        else resultOfCalculation /= Double.Parse(txtCal.Text);
                        txtCal.Text = resultOfCalculation.ToString();
                        break;
                    default:
                        break;
                }
            }

            else if (isClickOnOperators == true)
            {
                //MessageBox.Show("passOperation " + passOperation + "old " + oldOperation + "oper " + operationPerform);

                if (passOperation != operationPerform && !txtDisplay.Text.Contains("="))
                {
                    // get the last index of old operation
                    int i = txtDisplay.Text.LastIndexOfAny(oldOperation.ToArray()); //MessageBox.Show("" + i);
                    //remove one item which takes the last index of old operation 
                    txtDisplay.Text = txtDisplay.Text.Remove(i, 2);
                    // txtDisplay.Text = txtDisplay.Text + operationPerform + " ";
                    txtDisplay.Text += passOperation + " ";
                }

                //MessageBox.Show("txt Dis first ==> " + txtDisplay.Text);
                //if (txtDisplay.Text.Contains("=")) txtDisplay.Text = resultOfCalculation.ToString() + " " + passOperation + " ";

                if (txtDisplay.Text.Contains("=")) txtDisplay.Text = txtCal.Text + " " + passOperation + " ";

                //MessageBox.Show("txt Dis second ==> " + resultOfCalculation);

                switch (operationPerform)
                {
                    case "+":
                        resultOfCalculation = Double.Parse(txtCal.Text);
                        txtCal.Text = resultOfCalculation.ToString();
                        break;
                    case "-":
                        if (resultOfCalculation == 0) resultOfCalculation = Double.Parse(txtCal.Text);
                        else resultOfCalculation = Double.Parse(txtCal.Text);
                        txtCal.Text = resultOfCalculation.ToString();
                        break;
                    case "X":
                        if (txtCal.Text != "0" && resultOfCalculation == 0) resultOfCalculation = Double.Parse(txtCal.Text) * 1;
                        else resultOfCalculation = Double.Parse(txtCal.Text) * 1;
                        txtCal.Text = resultOfCalculation.ToString();
                        break;
                    case "÷":
                        if (txtCal.Text != "0" && resultOfCalculation == 0) resultOfCalculation = Double.Parse(txtCal.Text) / 1;
                        else if (txtCal.Text == "0" && resultOfCalculation == 0) resultOfCalculation = Double.Parse(txtCal.Text) / 1;
                        else resultOfCalculation = Double.Parse(txtCal.Text) / 1;
                        txtCal.Text = resultOfCalculation.ToString();
                        break;
                }
            }

            //oldOperation = operationPerform;
            oldOperation = passOperation;
            isClickOnOperators = true;
        }

        private void btnEqual_Click(object sender, EventArgs e)//Completed Check of Syntax Code ***
        {
            //MessageBox.Show(" new " + operationPerform + " old " + oldOperation);
            if (oldOperation != "") operationPerform = oldOperation;

            if (txtCal.Text == "0" && resultOfCalculation == 0 && txtDisplay.Text == "0 ÷ ")
            {
                txtCal.Text = "Result is undefined";
                HandleErrors();
            }
            else if (resultOfCalculation != 0 && txtCal.Text == "0")
            {
                txtCal.Text = "Cannot divide by zero";
                HandleErrors();
            }
            else if (txtCal.Text.Contains("Result is undefined") || txtCal.Text.Contains("Cannot divide by zero"))
            {
                btnCancel.PerformClick();
            }
            else
            {
                if (txtDisplay.Text == "" && txtCal.Text == "0") { txtDisplay.Text = txtCal.Text; firstNumber = txtCal.Text; }//***

                //MessageBox.Show("isClickOnOperators " + isClickOnOperators);
                if (isClickOnOperators == false)
                {
                    switch (operationPerform)
                    {
                        case "+":
                            resultOfCalculation += Double.Parse(txtCal.Text);
                            txtCal.Text = resultOfCalculation.ToString();
                            txtDisplay.Text += firstNumber + " " + "= ";
                            break;
                        case "-":
                            if (resultOfCalculation == 0) resultOfCalculation = Double.Parse(txtCal.Text);
                            else resultOfCalculation -= Double.Parse(txtCal.Text);
                            txtCal.Text = resultOfCalculation.ToString();
                            txtDisplay.Text += firstNumber + " " + "= ";
                            break;
                        case "X":
                            resultOfCalculation *= Double.Parse(txtCal.Text);
                            txtCal.Text = resultOfCalculation.ToString();
                            txtDisplay.Text += firstNumber + " " + "= ";
                            break;
                        case "÷":
                            resultOfCalculation /= Double.Parse(txtCal.Text);
                            txtCal.Text = resultOfCalculation.ToString();
                            txtDisplay.Text += firstNumber + " " + "= ";
                            break;
                        default:
                            resultOfCalculation = Double.Parse(txtCal.Text);
                            txtCal.Text = resultOfCalculation.ToString();
                            txtDisplay.Text = txtCal.Text + " " + "= ";
                            break;
                    }
                }
                else if (isClickOnOperators == true)
                {
                    txtDisplay.Clear();
                    txtDisplay.Text = resultOfCalculation.ToString() + " ";
                    switch (operationPerform)
                    {
                        case "+":
                            resultOfCalculation += Double.Parse(firstNumber);
                            txtCal.Text = resultOfCalculation.ToString();
                            txtDisplay.Text += operationPerform + " " + firstNumber + " " + "= ";
                            break;
                        case "-":
                            if (resultOfCalculation == 0) resultOfCalculation = Double.Parse(firstNumber);
                            else resultOfCalculation -= Double.Parse(firstNumber);
                            txtCal.Text = resultOfCalculation.ToString();
                            txtDisplay.Text += operationPerform + " " + firstNumber + " " + "= ";
                            break;
                        case "X":
                            resultOfCalculation *= Double.Parse(firstNumber);
                            txtCal.Text = resultOfCalculation.ToString();
                            txtDisplay.Text += operationPerform + " " + firstNumber + " " + "= ";
                            break;
                        case "÷":
                            resultOfCalculation /= Double.Parse(firstNumber);
                            txtCal.Text = resultOfCalculation.ToString();
                            txtDisplay.Text += operationPerform + " " + firstNumber + " " + "= ";
                            break;
                        default:
                            resultOfCalculation = Double.Parse(txtCal.Text);
                            txtCal.Text = resultOfCalculation.ToString();
                            txtDisplay.Text = txtCal.Text + " " + "= ";
                            break;
                    }
                }
            }
            //resultOfCalculation = 0;
            //firstNumber = "0";
            //operationPerform = "";
            //oldOperation = "";
            isClickOnOperators = true;
        }

        private void btnHistory_Click(object sender, EventArgs e)//Completed Check of Syntax Code ***
        {
            TableLayoutRowStyleCollection RowStyle = this.tlpMain.RowStyles;
            GetResponsiveStyle(tlpBottom, tlpMain, RowStyle, tlpRight);

        }

        #endregion
    }
}
