using System.Net;
using OpenQA.Selenium;

public class AutAndRegPage : BasePage {
    // Авторизация
    public static void Authorization(IWebDriver driver, String email, String password) {
        driver.FindElement(AutAndRegLocators.LoginInputUserEmail).SendKeys(email);
        driver.FindElement(AutAndRegLocators.LoginInputUserPassword).SendKeys(password);
        driver.FindElement(AutAndRegLocators.ButtonUserAuthorization).Click();
    }

    // Регистрация
    public static void Registrarion(IWebDriver driver, String name, String email, String password) {
        driver.FindElement(AutAndRegLocators.RegInputUserName).SendKeys(name);
        driver.FindElement(AutAndRegLocators.RegInputUserEmail).SendKeys(email);
        driver.FindElement(AutAndRegLocators.RegInputUserPassword).SendKeys(password);
        driver.FindElement(AutAndRegLocators.ButtonUserReg).Click();
    }
}