﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML_Yopmail.src.code.factoryBrowser
{
    public interface IBrowser
    {
        IWebDriver Create();
    }
}
