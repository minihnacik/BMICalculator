using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
{
    public partial class Form1 : Form
    {
        // Enum for BMI categories
        public enum BMICategory
        {
            Underweight,    // BMI < 18.5
            NormalWeight,   // 18.5 <= BMI <= 24.9
            OverWeight,     // 25 <= BMI <= 29.9
            Obesity,        // 30 <= BMI <= 34.9
            SevereObesity   // BMI >= 35
        }

        public Form1()
        {
            InitializeComponent();
        }

        // Button click event for calculating BMI
        private void calculateBMIButton_Click(object sender, EventArgs e)
        {
            // Get weight and height values from user input
            double weight, height;

            // Validate if the input values are valid numbers
            bool isWeightValid = double.TryParse(weightTextBox.Text, out weight);
            bool isHeightValid = double.TryParse(heightTextBox.Text, out height);

            // Check if the weight and height are valid positive numbers
            if (isWeightValid && isHeightValid && weight > 0 && height > 0)
            {
                // Calculate BMI: BMI = weight / (height^2)
                double bmi = weight / (height * height);

                // Get the BMI category
                BMICategory category = GetBMICategory(bmi);

                // Display the result in the result label
                resultLabel.Text = $"Your BMI is: {bmi:F2}\nYour category: {category}";
            }
            else
            {
                // If the input values are not valid
                resultLabel.Text = "Please enter valid weight and height values.";
            }

        }

        // Function to determine BMI category based on BMI value
        private BMICategory GetBMICategory(double bmi)
        {
            if (bmi >= 35)
                return BMICategory.SevereObesity;
            else if (bmi >= 30)
                return BMICategory.Obesity;
            else if (bmi >= 25)
                return BMICategory.OverWeight;
            else if (bmi >= 18.5)
                return BMICategory.NormalWeight;
            else
                return BMICategory.Underweight;
        }
    }
}
