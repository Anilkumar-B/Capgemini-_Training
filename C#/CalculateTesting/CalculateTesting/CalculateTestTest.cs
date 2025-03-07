// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class CalculateTestTest
{
    private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  [SetUp]
  public void SetUp() {
    driver = new ChromeDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
  }
  [TearDown]
  protected void TearDown() {
    driver.Quit();
  }
  [Test]
  public void calculateTest() {
    driver.Navigate().GoToUrl("https://www.calculator.net/percent-calculator.html");
    driver.Manage().Window.Size = new System.Drawing.Size(656, 672);
    driver.FindElement(By.Id("cpar1")).Click();
    driver.FindElement(By.Id("cpar1")).SendKeys("55");
    driver.FindElement(By.Id("cpar2")).Click();
    driver.FindElement(By.Id("cpar2")).SendKeys("5");
    driver.FindElement(By.Name("x")).Click();
  }
}
