using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumUsersSharp;

public class TestAddAvatar
{
    [Test]
    public void TestAddAva()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl("http://users.bugred.ru/");

        String email = "manager@mail.ru";
        String password = "1";
        String img = "/home/turgor/VisualStudioCode/SeleniumUsersSharp/resources/img_more_150Kb.png";
        Boolean expectedResult = true;

        AutAndRegPage.IntoAuthorization(driver);
        AutAndRegPage.Authorization(driver, email, password);
        AutAndRegPage.IntoUserAccount(driver);
        String result = ProfilePage.ReplaceAvatar(driver, img);

        string[] splitString = result.Split('/');
        string lastElement = splitString.Last();
        int myInt;
        bool digital;

        if (int.TryParse(lastElement, out myInt)) {
            digital = true;
        } else {
            digital = false;
        }

        driver.Close();
        driver.Quit();

        Assert.AreEqual(expectedResult, digital);
    }
}