using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumUsersSharp;

public class TestUserRegistration
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestUserReg()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl("http://users.bugred.ru/");

        String name = "Tur123";
        String email = "verygood@gmail.com";
        String password = "123";

        AutAndRegPage.IntoAuthorization(driver);
        AutAndRegPage.Registrarion(driver, name, email, password);

        

        driver.Close();
        driver.Quit();
        Assert.Pass();
    }
}