using OpenQA.Selenium;
using ML_Yopmail.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML_Yopmail.src.code.page
{
    public class LeftSite
    {
        public Button redactar = new Button(By.Id("newmail"));

        public Button refresh = new Button(By.Id("refresh"));

        public Button primero = new Button(By.XPath("//div[@currentmail and @class='m']"));

        //public TextBox inoxmsg = new TextBox(By.XPath(""));
       
        public Boolean ProjectNameIsDisplayed(String nameValue)
        {
            Label nameProject = new Label(By.XPath("//div[@currentmail and @class='m']/button/div[text()='"+nameValue+"']"));
            return nameProject.IsControlDisplayed();
        }

        
    }
}
