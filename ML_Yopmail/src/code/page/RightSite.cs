using OpenQA.Selenium;
using ML_Yopmail.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML_Yopmail.src.code.page
{
    public class RightSite
    {
        public TextBox destinatario = new TextBox(By.Id("msgto"));
        public TextBox asunto = new TextBox(By.Id("msgsubject"));
        public TextBox mensaje = new TextBox(By.Id("msgbody"));
        public Button enviar = new Button(By.Id("msgsend"));
    }
}
