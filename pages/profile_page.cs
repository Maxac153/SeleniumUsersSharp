using OpenQA.Selenium;

public class ProfilePage : BasePage {
    // Изменение аватара пользователя
    public String ReplaceAvatar(IWebDriver driver, String img) {
        driver.FindElement(ProfileLocators.InputImgFile).SendKeys(img);
        driver.FindElement(ProfileLocators.ButtonSubmit).Click();
        Task.Delay(3000);
        return driver.FindElement(ProfileLocators.ProfileImg).GetAttribute("src");
    }
}