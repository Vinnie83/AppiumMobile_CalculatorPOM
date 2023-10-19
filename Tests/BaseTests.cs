using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AndroidAppiumTestsPOM.Tests
{
    public class BaseTests
    {
        private const string appiumUrl = "http://127.0.0.1:4723/wd/hub";
        private const string appLocation = @"C:\com.example.androidappsummator.apk";
        protected AndroidDriver<AndroidElement> driver;
        private AppiumOptions options;

        [SetUp]
        public void Setup()
        {
            this.options = new AppiumOptions() { PlatformName = "Android" };
            options.AddAdditionalCapability("app", appLocation);
            this.driver = new AndroidDriver<AndroidElement>(new Uri(appiumUrl), options);
        }

        [TearDown]

        public void TearDown()
        {
            driver.Quit();
        }
    }
}

