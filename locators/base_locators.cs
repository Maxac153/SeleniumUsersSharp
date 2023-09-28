using OpenQA.Selenium;


public class BaseLocators {
    // Пользователи
    readonly public static By ButtonUsers = By.XPath("//span[text()='Пользователи']");
    
    // Войти
    readonly public static By ButtonLogin = By.XPath("//a[@href='/user/login/index.html']");

    // Профиль пользователя
    readonly public static By ButtonIcon = By.XPath("//a[@class='dropdown-toggle']");
    readonly public static By ButtonProfile = By.XPath("//a[@href='/user/profile/index.html']");
    readonly public static By ButtonLogout = By.XPath("//a[@href='/user/logout.html']");

    // Пользователи
    readonly public static By InputNameOrEmail = By.XPath("//input[@placeholder='Введите email или имя']");
    readonly public static By ButtonSearch = By.XPath("//button[@class='btn btn-submit']");
    readonly public static By ButtonDelete = By.XPath("//a[text()='Удалить']");
}
