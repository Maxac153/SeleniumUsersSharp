using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumUsersSharp;

public class TestUserRegistration
{
    private IWebDriver driver;

    [SetUp]
    public void SetUp() {
        driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl("http://users.bugred.ru/");
    }

    [TearDown]
    public void TearDown() {
        driver.Close();
        driver.Quit();
    }

    [Test]
    [TestCase("Tur123", "verygood@gmail.com", "123", "http://users.bugred.ru/")]
    public void TestUserReg(String name, String email, String password, String expectedResult) {

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

        Assert.AreEqual(0, String.CompareOrdinal(result, expectedResult));
    }
}