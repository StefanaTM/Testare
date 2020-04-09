using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wattpad_1.PageObjects
{
    class LibraryPage
    {
        private IWebDriver driver;

        public LibraryPage(IWebDriver browser)
        {
            driver = browser;
        }
        private By ReadingList => By.XPath("//*[@id='library-landing-page']/div[1]/div/div/nav/ul/li[3]/a");

        private IWebElement BtnReadingList()
        {
            return driver.FindElement(ReadingList);
        }
        public void ClickReadingListButton()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(driver => driver.FindElement(ReadingList));
            BtnReadingList().Click();
        }
        
        //
        private By NewReadingList => By.XPath("//*[@id='library-controls']/div[2]/button");

        private IWebElement BtnNewReadingList()
        {
            return driver.FindElement(NewReadingList);
        }
        public void ClickNewReadingListButton()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(driver => driver.FindElement(NewReadingList));
            BtnNewReadingList().Click();
        }

        //
        private By CreateReadingList => By.XPath("//*[@id='reading-list-name']");

        private IWebElement ReadingListInput()
        {
            return driver.FindElement(CreateReadingList);
        }
        public void ClickCreateReadingList(string listName)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(driver => driver.FindElement(Modal));
            System.Threading.Thread.Sleep(1000);
            ReadingListInput().SendKeys(listName);        
        }

        //
        private By Modal => By.XPath("//*[@id='generic-modal']/div/div/div");

        private IWebElement ReadingListModal()
        {
            return driver.FindElement(Modal);
        }

        //
        private By CreateList => By.XPath("//*[@id='reading-list-create']/div[2]/button[1]");

        private IWebElement BtnCreateList()
        {
            return driver.FindElement(CreateList);
        }
        public void ClickCreateListBtn()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(driver => driver.FindElement(CreateList));
            BtnCreateList().Click();
        }

        public By Book => By.XPath("//*[@id='reading-list']/div/div[2]/aside/div[1]/div[1]/div[2]/h1/span");    

        private IWebElement BookSpan()
        {
            return driver.FindElement(Book);
        }
        public string BookItemList => BookSpan().Text;

        //

        private By MyReadingList => By.XPath("//*[@id='reading-list']/div/div[1]/a");

        private IWebElement MyReadingListButton()
        {
            return driver.FindElement(MyReadingList);
        }
        public void ClickMyReadingListButton()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(MyReadingList));
            MyReadingListButton().Click();
        }

        //*[@id="reading-list-tab"]/div[2]/div/div[3]/button

        private By BookDropdown => By.XPath(" //*[@id='reading-list-tab']/div[2]/div/div[3]/button");

        private IWebElement BookDropdownButton()
        {
            return driver.FindElement(BookDropdown);
        }
        public void ClickBookDropdownButton()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(BookDropdown));
            BookDropdownButton().Click();
        }

        private By DeleteList => By.XPath(" //*[@id='reading-list-tab']/div[2]/div/div[3]/ul/li[1]/a");
        private IWebElement DeleteListButton()
        {
            return driver.FindElement(DeleteList);
        }
        public void ClickDeleteListButton()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(DeleteList));
            DeleteListButton().Click();
            driver.SwitchTo().Alert().Accept();
        }
    }
}

