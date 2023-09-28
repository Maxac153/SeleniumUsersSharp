using OpenQA.Selenium;

public class AutAndRegLocators {
    // Авторизация
    readonly public static By LoginInputUserEmail = By.XPath("//input[@name='login']");
    readonly public static By LoginInputUserPassword = By.XPath("//input[@name='password']");
    readonly public static By ButtonUserAuthorization = By.XPath("//input[@value='Авторизоваться']");

    // Регистрация
    readonly public static By RegInputUserName = By.XPath("//input[@required=''][@name='name']");
    readonly public static By RegInputUserEmail = By.XPath("//input[@required=''][@name='email']");
    readonly public static By RegInputUserPassword = By.XPath("//input[@name='password'][@required='']");
    readonly public static By ButtonUserReg = By.XPath("//input[@value='Зарегистрироваться']");
}