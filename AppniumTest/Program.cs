
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
 
namespace AppiumSample
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Windows Application Driver実行
            string serverPath = System.IO.Path.Combine(
              System.Environment.GetFolderPath(
                System.Environment.SpecialFolder.ProgramFilesX86
              ), @"Windows Application Driver", "WinAppDriver.exe"
            );
            System.Diagnostics.Process.Start(serverPath);

            //電卓操作
            DesiredCapabilities appCapabilities = new DesiredCapabilities();
            //appCapabilities.SetCapability("app", "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
            appCapabilities.SetCapability("app", "C:\\Users\\norihiko\\AppData\\Local\\Amazon\\Kindle\\application\\Kindle.exe");
            RemoteWebDriver driver = new RemoteWebDriver(new Uri(@"http://127.0.0.1:4723"), appCapabilities);
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(3));

            

            //driver.Keyboard.PressKey("F11");
            //driver.FindElementByName("次に移動:  Enter").Click();
            //driver.FindElementByName("最初のページ").Click();
            //driver.FindElementByName("移動").Click();
            //driver.Keyboard.SendKeys("Ctrl + G");
            //driver.FindElementByXPath("").Click();
            //driver.Keyboard.SendKeys("Down");
            //driver.Keyboard.SendKeys("Down");
            //driver.Keyboard.SendKeys("Down");
            //driver.Keyboard.SendKeys("Down");
            //driver.Keyboard.SendKeys("Tab");
            //driver.Keyboard.SendKeys("Enter");
            driver.FindElementByName("フルスクリーン").Click();
            
            int j = 100;
            for (int i = 100; i < 158; i ++)
            {
                driver.FindElementByName("Turn Page").Click();
                Screenshot screenshot = driver.GetScreenshot();
                screenshot.SaveAsFile("c:\\temp\\松嶋えいみ\\" + j + ".jpg",System.Drawing.Imaging.ImageFormat.Jpeg);
                j++;
            }

          


            //driver.Keyboard.PressKey("left");


            //driver.FindElementByName("1").Click();
            //driver.FindElementByName("2").Click();
            //driver.FindElementByName("3").Click();
            //driver.FindElementByName("4").Click();
            //driver.FindElementByName("5").Click();
            driver.Dispose();
            driver = null;

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}

