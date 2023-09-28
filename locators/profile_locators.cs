using OpenQA.Selenium;

public class ProfileLocators {
    // Профиль
    readonly public static By InputImgFile = By.XPath("//input[@type='file']");
    readonly public static By ButtonSubmit = By.XPath("//input[@type='submit']");
    readonly public static By ProfileImg = By.XPath("//div[@class='col-md-4 center']/img");
}