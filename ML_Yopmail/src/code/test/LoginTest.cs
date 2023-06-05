using OpenQA.Selenium;
using ML_Yopmail.src.code.page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML_Yopmail.src.code.test
{
    [TestClass]
    public class LoginTest : TestBase
    {

        MainPage mainPage = new MainPage();
        LeftSite leftSite = new LeftSite();
        RightSite rightSite = new RightSite();

        [TestMethod]
        public void VerifyTheLoginIsSuccessfuly2()
        {
            mainPage.tempcorreo.SetText("miguelloza9001@yopmail.com");
            mainPage.revisar.Click();

            leftSite.redactar.Click();

            session.Session.Instance().GetBrowser().SwitchTo().Frame("ifmail");

            rightSite.destinatario.SetText("miguelloza9001@yopmail.com");
            rightSite.asunto.SetText("Testcase email");
            rightSite.mensaje.SetText("Testcase email");
            rightSite.enviar.Click();

            session.Session.Instance().GetBrowser().SwitchTo().ParentFrame();

            leftSite.refresh.Click();

            session.Session.Instance().GetBrowser().SwitchTo().Frame("ifinbox");

            leftSite.primero.Click();
            
            //verification por asunto de correo
            Assert.IsTrue(leftSite.ProjectNameIsDisplayed("Testcase email"), "ERROR!The project was not updated");
        }

    }
}
