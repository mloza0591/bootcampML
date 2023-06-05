using OpenQA.Selenium;
using ML_Yopmail.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML_Yopmail.src.code.page
{
    public  class MainPage
    {
        public TextBox tempcorreo = new TextBox(By.XPath("//input[@class='ycptinput']"));
        public Button revisar = new Button(By.XPath("//i[@class='material-icons-outlined f36']"));
    }
}
