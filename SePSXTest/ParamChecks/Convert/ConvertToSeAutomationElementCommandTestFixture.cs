﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 8/16/2012
 * Time: 1:18 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace SePSXTest.CheckParameters
{
    using System;
    using SePSX; using MbUnit.Framework;
    using OpenQA.Selenium;
    
    /// <summary>
    /// Description of ConvertToSeAutomationElementCommand.
    /// </summary>
    [TestFixture]
    public class ConvertToSeAutomationElementCommandTestFixture // ConvertCmdletBase
    {
        public ConvertToSeAutomationElementCommandTestFixture()
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
