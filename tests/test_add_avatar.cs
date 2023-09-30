using NUnit.Framework;
using NUnit.Allure.Core;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumUsersSharp;

[AllureNUnit]
public class TestAddAvatar
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
    [TestCase("manager@mail.ru", "1", "../../../resources/img_8Kb.png", true)]
    [TestCase("manager@mail.ru", "1", "../../../resources/img_more_150Kb.png", false)]
    public void TestAddAva(String email, String password, String img, Boolean expectedResult)
    {
        String fullPathImg = Path.GetFullPath(img);

        AutAndRegPage.IntoAuthorization(driver);
        AutAndRegPage.Authorization(driver, email, password);
        AutAndRegPage.IntoUserAccount(driver);
        String result = ProfilePage.ReplaceAvatar(driver, fullPathImg);

        string[] splitString = result.Split('/');
        string lastElement = splitString.Last();
        int myInt;
        bool digital;

        if (int.TryParse(lastElement, out myInt)) {
            digital = true;
        } else {
            digital = false;
        }

        Assert.AreEqual(expectedResult, digital);
    }
}