using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumUsersSharp;

public class TestAddAvatar
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestAddAva()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl("http://users.bugred.ru/");

        driver.FindElement(By.XPath("//span[text()='Войти']")).Click();

        driver.FindElement(By.XPath("//input[@required=''][@name='name']")).SendKeys("Tur123");
        driver.FindElement(By.XPath("//input[@required=''][@name='email']")).SendKeys("verygood@gmail.com");
        driver.FindElement(By.XPath("//input[@name='password'][@required='']")).SendKeys("123");

        driver.FindElement(By.XPath("//input[@value='Зарегистрироваться']")).Click();

        driver.Close();
        driver.Quit();
        Assert.Pass();
    }
}