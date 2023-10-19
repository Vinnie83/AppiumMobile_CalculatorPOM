using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndroidAppiumTestsPOM.Pages
{
    public class Calculator
    {
        private AndroidDriver<AndroidElement> driver;   
        public Calculator(AndroidDriver<AndroidElement> driver) 
        {
            this.driver = driver;
        }

        public AndroidElement FirstInput => driver.FindElementById("com.example.androidappsummator:id/editText1");
        public AndroidElement SecondInput => driver.FindElementById("com.example.androidappsummator:id/editText2");
        public AndroidElement ResultField => driver.FindElementById("com.example.androidappsummator:id/editTextSum");
        public AndroidElement CalcButton => driver.FindElementById("com.example.androidappsummator:id/buttonCalcSum");

        public string CalculateTwoNumbers(string firstValue, string secondValue)
        {
            FirstInput.Clear();
            SecondInput.Clear();
            FirstInput.SendKeys(firstValue);
            SecondInput.SendKeys(secondValue);
            CalcButton.Click();

            return ResultField.Text;
        }
    }
}
