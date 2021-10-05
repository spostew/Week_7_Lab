/*
 * Project_1: This GUI will allow the user to enter in two numbers and select an operation they want to use with the numbers
 * Name: Spencer Unitt
 * Module: Week 7 Lab
 * Problem Statement: Create a GUI calculator that uses two numbers and lets the user select an operation to use
 * 
 * Algoritm:
 * 1. Create a GUI with three textBoxes, a button and a listbox. Two textboxes will be used to store numbers, 
 *    one will be used to display the results, the button will be used to calculate and a listbox will store the operations
 * 2. When the button is clicked, start a try and catch block. 
 * 3. Inside the try block create a new int that will hold the value of the index in the listBox
 * 4. Create two deciaml/doubles that take the input from the textboxes called left and right
 * 5. Create a final decimal named result that equals 0
 * 6. Create a switch statement that takes in the operation as an argument
 * 7. For each case in the switch statement. set the varible result equal to left (the selected operation) right decimals
 *    set the textbox on the righthand side equal to the result.toString()
 * 8. Set the default case equal to no operation selected and break
 * 9. In the catch block, look for the user trying to divide by 0 and throw an error message if they try
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Project_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void control_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // takes the index of the selected option from the listBox
                int operation = listBox.SelectedIndex;
                // Sets two decimals equal to the inputs in the textBoxes
                decimal leftHand = Convert.ToDecimal(leftBox.Text);
                decimal rightHand = Convert.ToDecimal(rightBox.Text);
                decimal result = 0;

                // Selects the case based of the index number the operation gets.
                switch(operation)
                {
                    case 0:
                        // In each case, set the result equal to the left and right textBoxes based off the operation in listBox
                        result = leftHand + rightHand;
                        // Send the information from result into the empty textBox on the far right of the GUI
                        resultBox.Text = result.ToString();
                        break;
                    case 1:
                        result = leftHand - rightHand;
                        resultBox.Text = result.ToString();
                        break;
                    case 2:
                        result = leftHand * rightHand;
                        resultBox.Text = result.ToString();
                        break;
                    case 3:
                        result = leftHand / rightHand;
                        resultBox.Text = result.ToString();
                        break;
                    case 4:
                        result = leftHand % rightHand;
                        resultBox.Text = result.ToString();
                        break;
                    default:
                        // Will tell the user that an error has occured and continue to run the program
                        result = 0;
                        MessageBox.Show("No operation selected");
                        break;
                }
            }
            // if the user trys to divide by zero, an error message will be thrown
            catch(DivideByZeroException)
            {
                MessageBox.Show("Error, cannot devide by zero");
            }
            
        }
    }
}
