using OpenQA.Selenium;

public class AutAndRegLocators {
    // Авторизация
    public static By LoginInputUserEmail = By.XPath("//input[@name='login']");
    public static By LoginInputUserPassword = By.XPath("//input[@name='password']");
    public static By ButtonUserAuthorization = By.XPath("//input[@value='Авторизоваться']");

    // Регистрация
    public static By RegInputUserName = By.XPath("//input[@required=''][@name='name']");
    public static By RegInputUserEmail = By.XPath("//input[@required=''][@name='email']");
    public static By RegInputUserPassword = By.XPath("//input[@name='password'][@required='']");
    public static By ButtonUserReg = By.XPath("//input[@value='Зарегистрироваться']");
}