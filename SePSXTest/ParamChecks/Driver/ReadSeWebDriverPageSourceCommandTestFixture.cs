﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 8/23/2012
 * Time: 10:31 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace SePSXTest.CheckParameters
{
    using System;
    using SePSX; using MbUnit.Framework;
    using OpenQA.Selenium;
    
    /// <summary>
    /// Description of ReadSeWebDriverPageSourceCommand.
    /// </summary>
    [TestFixture]
    public class ReadSeWebDriverPageSourceCommandTestFixture // HasWebDriverInputCmdletBase
    {
        public ReadSeWebDriverPageSourceCommandTestFixture()
        {
        }
        
        [SetUp]
        public void PrepareRunspace()
        {
            MiddleLevelCode.PrepareRunspaceForParamChecks();
        }
        
        [TearDown]
        public void DisposeRunspace()
        {
            MiddleLevelCode.DisposeRunspace();
        }
        
        [Test]
        [Ignore]
        public void Need_Code()
        {
            
        }
    }
}
