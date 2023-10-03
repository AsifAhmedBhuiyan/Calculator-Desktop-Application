namespace Calculator
{
    public partial class Form1 : Form
    {
        private double storedOperand;
        private char storedOperation;
        private bool operationPerformed;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        // This method is called when a number button is clicked in a calculator application.
        // It updates the displayBox with the clicked number and handles special cases
        // when the display is currently showing "0" or when there's a pending operation.
        private void NumberButtonClick(object sender, EventArgs e)
        {
            // Cast the sender object to a Button to access its properties.
            Button button = (Button)sender;

            // Check if the display is currently showing "0" or if there's a pending operation.
            if (displayBox.Text == "0" || storedOperation != '\0')
            {
                // Set the display to the clicked number and clear any pending operation.
                displayBox.Text = button.Text;
                storedOperation = '\0';
            }
            else
            {
                // Append the clicked number to the current display value.
                displayBox.Text += button.Text;
            }
        }


        private void buttonOne_Click(object sender, EventArgs e)
        {
            NumberButtonClick(sender, e);
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            NumberButtonClick(sender, e);
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            NumberButtonClick(sender, e);
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            NumberButtonClick(sender, e);
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            NumberButtonClick(sender, e);
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            NumberButtonClick(sender, e);
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            NumberButtonClick(sender, e);
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            NumberButtonClick(sender, e);
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            NumberButtonClick(sender, e);
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            NumberButtonClick(sender, e);
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            NumberButtonClick(sender, e);
        }



        // Convert into Binary
        private void buttonBinary_Click(object sender, EventArgs e)
        {
            // Check if the displayBox contains a valid decimal number.
            if (!string.IsNullOrEmpty(displayBox.Text))
            {
                try
                {
                    // Convert the displayed decimal number to an integer.
                    int decimalNumber = Convert.ToInt32(displayBox.Text);

                    // Convert the decimal number to its binary representation.
                    string binaryNumber = Convert.ToString(decimalNumber, 2);

                    // Check if the binary number exceeds 8 digits.
                    if (binaryNumber.Length > 8)
                    {
                        // Display "OUT OF RNG" if the binary number is too large.
                        displayBox.Text = "OUT OF RNG";
                    }
                    else
                    {
                        // Pad the binary number to 8 digits and update the displayBox.
                        displayBox.Text = binaryNumber.PadLeft(8, '0');
                    }
                }
                catch (Exception ex)
                {
                    // Display "INVALID INPUT" if the input is not a valid number.
                    displayBox.Text = "INVALID INPUT";
                }
            }
            else
            {
                // Set the default binary value to "00000000" if the display is empty.
                displayBox.Text = "00000000";
            }
        }


        // Convert into Hexadecimal
        private void buttonHexa_Click(object sender, EventArgs e)
        {
            // Check if the displayBox contains a valid decimal number.
            if (!string.IsNullOrEmpty(displayBox.Text))
            {
                try
                {
                    // Convert the displayed decimal number to an integer.
                    int decimalNumber = Convert.ToInt32(displayBox.Text);

                    // Convert the decimal number to its hexadecimal representation.
                    string hexadecimalNumber = decimalNumber.ToString("X");

                    // Check if the hexadecimal number exceeds 8 characters.
                    if (hexadecimalNumber.Length > 8)
                    {
                        // Display "OUT OF RNG" if the hexadecimal number is too large.
                        displayBox.Text = "OUT OF RNG";
                    }
                    else
                    {
                        // Pad the hexadecimal number to 8 characters and update the displayBox.
                        displayBox.Text = hexadecimalNumber.PadLeft(8, '0');
                    }
                }
                catch (Exception ex)
                {
                    // Display "INVALID INPUT" if the input is not a valid number.
                    displayBox.Text = "INVALID INPUT";
                }
            }
            else
            {
                displayBox.Text = "0".PadLeft(8, '0');
            }

        }



        // This method is triggered when the user clicks the clear button.
        // It clears one number at a time from the right side of the displayed number.
        private void buttonClear_Click(object sender, EventArgs e)
        {
            // Check if the displayBox contains any text.
            if (!string.IsNullOrEmpty(displayBox.Text))
            {
                // Get the current text from the displayBox.
                string currentText = displayBox.Text;

                // Check if the current text has only one character.
                if (currentText.Length == 1)
                {
                    // If there's only one character, set the displayBox text to "0".
                    displayBox.Text = "0";
                }
                else
                {
                    // If there are multiple characters, remove the last character.
                    displayBox.Text = currentText.Substring(0, currentText.Length - 1);
                }
            }
            else
            {
                // If the displayBox is empty, set the text to "0".
                displayBox.Text = "0";
            }
        }


        // This method is triggered when the user clicks the all clear button.
        // It clears all the numbers displayed in the displayBox and resets stored memory.
        private void buttonAllclear_Click(object sender, EventArgs e)
        {
            // Clear the displayBox by setting its text to an empty string.
            displayBox.Text = string.Empty;

            // Reset all stored variables to their initial values.
            firstNumber = 0;
            operation = '\0';
            isOperationClicked = false;
            fullExpression = string.Empty;
            result = 0;
        }


        // Variable to store the first number for operations
        private double firstNumber = 0;

        // Variable to store the operation (+, -, *, /)
        private char operation = '\0';

        // Variable to track if an operation button was clicked
        private bool isOperationClicked = false;

        // Variable to store the entire expression (e.g., "1 + 1 = 2")
        private string fullExpression = "";

        // Helper method to handle operation button clicks
        private void HandleOperationButton(object sender, char op)
        {
            if (!string.IsNullOrEmpty(displayBox.Text))
            {
                try
                {
                    if (!isOperationClicked)
                    {
                        // Get the first number from the displayBox.
                        firstNumber = Convert.ToDouble(displayBox.Text);
                        // Update the fullExpression with the first number and operation.
                        fullExpression = $"{firstNumber} {op} ";
                    }
                    else
                    {
                        // If an operation button was clicked before, update the operation in fullExpression.
                        fullExpression = fullExpression.Substring(0, fullExpression.Length - 2) + op + " ";
                    }

                    // Store the operation.
                    operation = op;
                    // Set the flag indicating an operation button was clicked.
                    isOperationClicked = true;
                    // Display the current expression.
                    displayBox.Text = fullExpression;
                }
                catch (Exception ex)
                {
                    // Handle any exceptions if the input is not a valid number.
                    displayBox.Text = "INVALID INPUT";
                }
            }
            else
            {
                // If the displayBox is empty, show an error message.
                displayBox.Text = "INVALID INPUT";
            }
        }



        // This method is triggered when the user clicks the equal button.
        private double result = 0; // Variable to store the result of the previous operation

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(fullExpression) && isOperationClicked)
            {
                // Extract the second number from displayBox.Text and trim any spaces.
                string[] expressionParts = displayBox.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                // Check if there are enough parts to perform the operation.
                if (expressionParts.Length == 3)
                {
                    double secondNumber;

                    // Extract the operator and the second number.
                    string operatorSymbol = expressionParts[1];
                    string secondNumberStr = expressionParts[2];

                    // Check if the secondNumberStr is a valid number.
                    if (double.TryParse(secondNumberStr, out secondNumber))
                    {
                        try
                        {
                            // Perform the corresponding operation.
                            if (operatorSymbol == "+")
                            {
                                result = firstNumber + secondNumber;
                            }
                            else if (operatorSymbol == "-")
                            {
                                result = firstNumber - secondNumber;
                            }
                            else if (operatorSymbol == "*")
                            {
                                result = firstNumber * secondNumber;
                            }
                            else if (operatorSymbol == "/")
                            {
                                // Check if the second number is not zero to avoid division by zero.
                                if (secondNumber != 0)
                                {
                                    result = firstNumber / secondNumber;
                                }
                                else
                                {
                                    // Handle division by zero.
                                    displayBox.Text = "DIVISION BY ZERO";
                                    return;
                                }
                            }

                            // Update the fullExpression with the complete expression.
                            fullExpression = $"{firstNumber} {operatorSymbol} {secondNumber} = {result}";

                            // Display the full expression.
                            displayBox.Text = fullExpression;

                            // Update firstNumber with the result for continuous calculations.
                            firstNumber = result;

                            // Reset the operation button click flag.
                            isOperationClicked = false;
                        }
                        catch (Exception ex)
                        {
                            // Handle any other exceptions if they occur during the operation.
                            displayBox.Text = "INVALID INPUT";
                        }
                    }
                    else
                    {
                        // If secondNumberStr is not a valid number, show an error message.
                        displayBox.Text = "INVALID INPUT";
                    }
                }
                else
                {
                    // If there are not enough parts in the expression, show an error message.
                    displayBox.Text = "INVALID INPUT";
                }
            }
            else
            {
                // If the fullExpression is empty or if an operation button was not clicked, show an error message.
                displayBox.Text = "INVALID INPUT";
            }
        }



        // This method is triggered when the user clicks an operation button.
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            HandleOperationButton(sender, '+');
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            HandleOperationButton(sender, '-');
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            HandleOperationButton(sender, '*');
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            HandleOperationButton(sender, '/');
        }




        private void displayBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}