using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumUsersSharp;

public class TestUserRegistration
{
    [Test]
    public void TestUserReg()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl("http://users.bugred.ru/");

        String name = "Tur123";
        String email = "verygood@gmail.com";
        String password = "123";
        String expectedResult = "http://users.bugred.ru/";

        AutAndRegPage.IntoAuthorization(driver);
        AutAndRegPage.Registrarion(driver, name, email, password);
        String result = driver.Url;

        if (result.Equals("http://users.bugred.ru/")) {
            AutAndRegPage.LogoutAccount(driver);
            AutAndRegPage.IntoAuthorization(driver);
            AutAndRegPage.Authorization(driver, "manager@mail.ru", "1");
            AutAndRegPage.DeleteUserAccount(driver, name);
            AutAndRegPage.LogoutAccount(driver);
        }

                
        driver.Close();
        driver.Quit();
        Assert.AreEqual(0, String.CompareOrdinal(result, expectedResult));
    }
}