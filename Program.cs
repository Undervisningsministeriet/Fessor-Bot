using System;
using System.CodeDom;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;






namespace shoe_box_cleaner
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Title = ":) SKud ud til fessor og deres top retarderede udviklere.";

            Console.WriteLine("ok ");
            Program.beregn_mat();
        }


        private static void get_opgave()
        {

        }

        private static void beregn_mat()
        {
            int tal = 0;
            int tal2 = 0;
            int opgaver = 0;

            Console.Clear();
            IWebDriver webDriver = new ChromeDriver();
            Console.WriteLine("Starter Chrome...");
            webDriver.Navigate().GoToUrl("https://matematikfessor.dk/");
            webDriver.Navigate().GoToUrl("https://broker.unilogin.dk/auth/realms/broker/protocol/saml-stil?SAMLRequest=nZLBbsIwEER%2FJfI9cRIgEAuQaDkUiaoI0h56qTaOAYvETr1ORf%2B%2BToCWqhKHnizvet7OrDxGqMqazRq7V2vx3gi03rEqFbKuMSGNUUwDSmQKKoHMcraZPS5ZHISsNtpqrktyJbmtAERhrNSKeIv5hLz1BgmPBqmIIO4Xw2LbTyKeRtthfxQn%2BTbMixHwVKRpwon3Igw65YQ4kJMjNmKh0IKyrhTGsR8mfjTK4ogNYhb1Xok3d2mkAtup9tbWyCjNjT4IEzRKlnonVVAcKLj01AgoKzy36SUabTP5DuNCzi7m77XCphJmI8yH5OJ5vfzBgy0BW7r%2FjUdZ1aVoQbTSRVOKoN7XHZji6Yx94NhVAX1E7bvxx0%2Firc4u7qQqpNrd3m1%2BeoTsIctW%2Fuppk5HpuKWzbldm%2Bm%2BLlbBQgIU%2FDsf0mn%2B6%2Ff5M0y8%3D&RelayState=https%3A%2F%2Fatlas.uni-login.dk%2Funilogin%2Flogin.cgi%3Fid%3Dedulab%26path%3DaHR0cHM6Ly9sb2dpbi5tYXRlbWF0aWtmZXNzb3IuZGsvZXh0L3VuaWxvZ2luL2xvZ2luX2NhbGxiYWNrLz9yPWh0dHBzJTNBJTJGJTJGd3d3Lm1hdGVtYXRpa2Zlc3Nvci5kayUyRg%253D%253D%26auth%3D0a0212afeada128f9e719da9c10e879f&SigAlg=http%3A%2F%2Fwww.w3.org%2F2001%2F04%2Fxmldsig-more%23rsa-sha256&Signature=ESYbffCdeeC%2FJLfpZW1u2rzInLIw4%2BCDH%2F%2Ff55mZG9kAZsc0MpacteX2w4Fdm9OoRP2Tl5%2F%2BdC6zZnKFYqkz6RpPKGpCsqXPC9qhOgSKK%2FYKsWiNwbQY%2FTAT6XdNFVd5T%2FxEBQM9eD%2BFiiFsGOKpIao%2F%2FmEnydopSjWdJjUR%2BmmY7kKjGCVfPQ1GzXwGNtDWgCbepX2%2B2QebTBkUWVxbjLFzj4%2Boyex7cYEwmExa8h0%2BX6WGbVNeLBqJGZHTxlZqPmOa0N%2BSTKzDc1jBJLIps%2Bn8G3QvrVR%2F1tX6uiYpWw1ozneb1%2BTaSIXT9szcH2ZdRMKcPzE5vKcM1dWEywAnMQ%3D%3D");
            Console.Clear();
            Console.WriteLine("Skriv done i konsolen når du har logget ind.");
            if (Console.ReadLine() == "done")
            {
                Console.Clear();
                Console.WriteLine("Cool... :)");

                solveme:

                webDriver.Navigate().GoToUrl("https://www.matematikfessor.dk/test/trialexam/?id=5458&grade=false&history=false");

                try
                {

                    webDriver.FindElement(By.XPath("/html/body/div[2]/main/div/article/ul/li/div/div[1]/p/span")).Click();
                    for (int i = 0; i < 4; i++)
                    {
                        Thread.Sleep(1000);

                        tal = Convert.ToInt32(webDriver.FindElement(By.XPath("/html/body/div[2]/main/div/article/ul/li/div/div[1]/div[2]/div/div/p[3]/span[2]/span/span/span[1]/span\r\n")).Text);
                        tal2 = Convert.ToInt32(webDriver.FindElement(By.XPath("/html/body/div[2]/main/div/article/ul/li/div/div[1]/div[2]/div/div/p[3]/span[2]/span/span/span[5]/span\r\n")).Text);
                        int svar = tal2 - tal;
                        Console.WriteLine("Opgaven er løst... Svaret er : " + Convert.ToString(svar));
                        string text = Convert.ToString(svar);
                        webDriver.FindElement(By.XPath("/html/body/div[2]/main/div/article/ul/li/div/div[1]/div[3]/div/p/input")).SendKeys(text);
                        webDriver.FindElement(By.XPath("/html/body/div[2]/main/div/article/ul/li/button")).Click();
                        Thread.Sleep(2350);

                        opgaver += 1;


                        Console.Title = "Opgaver Klaret: " + Convert.ToString(opgaver);

                    }


                    webDriver.FindElement(By.XPath("/html/body/div[2]/main/div/article/span/button\r\n")).Click();
                    Thread.Sleep(1100);
                    webDriver.FindElement(By.XPath("/html/body/div[2]/main/div/article/div[2]/article/p/button[1]")).Click();
                    goto solveme;



                    return;
                }
                catch (Exception)
                {
                    Console.WriteLine("Der skete en fejl... genstarter...");
                    goto solveme;

                }
                





            }

        }

    }
}


