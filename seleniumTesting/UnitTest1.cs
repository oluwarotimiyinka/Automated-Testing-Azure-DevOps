using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;			
using OpenQA.Selenium.Chrome;	

namespace SeleniumBingTests
{
  /// <summary>
  /// Summary description for MySeleniumTests
  /// </summary>
  [TestClass]
  public class MySeleniumTests
  {
    private TestContext testContextInstance;
    private IWebDriver driver;
    private string appURL;

   
    [TestMethod]
    [TestCategory("Chrome")]
    public void TheBingSearchTest()
    {
      driver.Navigate().GoToUrl(appURL + "/");
      Assert.IsTrue(driver.Title.Contains("Google"), "Verified title of the page");
    }

    /// <summary>
    ///Gets or sets the test context which provides
    ///information about and functionality for the current test run.
    ///</summary>
    public TestContext TestContext
    {
      get
      {
        return testContextInstance;
      }
      set
      {
        testContextInstance = value;
      }
    }

    [TestInitialize()]
    public void SetupTest()
    {
      appURL = "http://www.google.com";

      string browser = "Chrome";
      switch(browser)
      {
        case "Chrome":
          driver = new ChromeDriver();
          break;
        default:
          driver = new ChromeDriver();
          break;
      }

    }

    [TestCleanup()]
    public void MyTestCleanup()
    {
      driver.Quit();
    }
  }
}