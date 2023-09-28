using OpenQA.Selenium;

public class BasePage {
    // Войти
    public static void IntoAuthorization(IWebDriver driver) {
        driver.FindElement(BaseLocators.ButtonLogin).Click();
    }

    // Войти в профиль пользователя
    public static void IntoUserAccount(IWebDriver driver) {
        driver.FindElement(BaseLocators.ButtonIcon).Click();
        driver.FindElement(BaseLocators.ButtonProfile).Click();
    }

    // Выход из профиля
    public static void LogoutAccount(IWebDriver driver) {
        driver.FindElement(BaseLocators.ButtonIcon).Click();
        driver.FindElement(BaseLocators.ButtonLogout).Click();
    }

    // Удаление пользователя (работает только из под Администратора)
    public static void DeleteUserAccount(IWebDriver driver, String UserNameOrEmail) {
        driver.FindElement(BaseLocators.InputNameOrEmail).SendKeys(UserNameOrEmail);
        driver.FindElement(BaseLocators.ButtonSearch).Click();
        driver.FindElement(BaseLocators.ButtonDelete).Click();
    }
}