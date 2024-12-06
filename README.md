# BMI Calculator

## Overview
This is a simple Body Mass Index (BMI) calculator built using C# and Windows Forms. It allows users to input their weight (in kilograms) and height (in meters), calculate their BMI, and categorize their weight based on the result. The program provides real-time feedback on the BMI category: Underweight, Normal Weight, Overweight, Obesity, or Severe Obesity.

## Features
- **User-friendly Interface**: The application is built using Windows Forms for an intuitive and interactive interface.
- **BMI Calculation**: Calculates BMI based on the formula: 
BMI = weight / (height^2)

- **Weight Categories**: Displays a category based on the BMI value:
1. Underweight: BMI < 18.5
2. Normal Weight: 18.5 <= BMI <= 24.9
3. Overweight: 25 <= BMI <= 29.9
4. Obesity: 30 <= BMI <= 34.9
5. Severe Obesity: BMI >= 35
- **Input Validation**: Validates user input and displays appropriate messages for invalid data.
- **Clear Feedback**: Displays the calculated BMI and the corresponding weight category.

## Installation

To run this project, follow these steps:

1. Clone the repository:
 ```bash
 git clone https://github.com/minihnacik/BMICalculator.git
```
2. Open the project in Visual Studio (or another C# compatible IDE).
3. Build and run the application

## How to Use
1. Enter your weight (kg) in the first text box.
2. Enter your height (m) in the second text box.
3. Click the Calculate BMI button.
4. The result will display your BMI and categorize your weight according to the BMI value.

## Example
### Input:
- Weight: 70 kg
- Height: 1.75 m
  
### Output:
```bash
Your BMI is: 22.86
Your category: Normal Wieght
```

## Technologies Used
- C# programming language
- Windows Forms for GUI
- Visual Studio for development

## Acknowledgements
- This project is created as a basic BMI calculator for learning purposes.
