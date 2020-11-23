Imports System.Threading
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome

Public Class WebDriverForm
    Dim driver As IWebDriver
    Dim Name = "Demo"
    Dim Message = "Hello"
    Private Sub WebDriverForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        driver = New ChromeDriver()
        driver.Navigate().GoToUrl("https://web.whatsapp.com")

    End Sub


    Private Sub SendMessage()
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10)
        driver.FindElement(By.ClassName("_2HE1Z")).Click()
        driver.FindElement(By.ClassName("_1awRl")).SendKeys("Demo")
        Thread.Sleep(2000)
        driver.FindElement(By.ClassName("_1hI5g")).Click()
        Thread.Sleep(2000)
        driver.FindElement(By.XPath("//*[@id='main']/footer/div[1]/div[2]/div/div[2]")).SendKeys(TextBox1.Text)
        'driver.FindElement(By.ClassName("_1hI5g")).Click()
        Thread.Sleep(1000)
        driver.FindElement(By.ClassName("_2Ujuu")).Click()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SendMessage()

    End Sub
End Class