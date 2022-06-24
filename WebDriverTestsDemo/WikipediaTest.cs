
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

//Създаване на нов Хром Браузър
var driver = new ChromeDriver();

//Навигиране до Уикипедия
driver.Url = "https://wikipedia.org";

System.Console.WriteLine("CURRENT TITLE: " + driver.Title);

//Локирате на Search елемента по ID
var searchField = driver.FindElement(By.Id("searchInput"));

//Click на елемента
searchField.Click();

//Попълване с QA и натискане на Enter
searchField.SendKeys("QA" + Keys.Enter);

System.Console.WriteLine("TITLE AFTER SEARCH: " + driver.Title);

// Затваряне на браузъра
driver.Quit();