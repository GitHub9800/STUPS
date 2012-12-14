﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 7/19/2012
 * Time: 10:52 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace SePSXTest.CheckParameters
{
    using System;
    using SePSX; using MbUnit.Framework;
    using OpenQA.Selenium;
    
    /// <summary>
    /// Description of ReadSeWebElementDisplayedCommand.
    /// </summary>
    [TestFixture]
    public class ReadSeWebElementDisplayedCommandTestFixture
    {
        public ReadSeWebElementDisplayedCommandTestFixture()
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
        public void InputObject()
        {
            CmdletUnitTest.TestRunspace.RunAndCheckParameters(
                "Read-SeWebElementDisplayed " +
                "-InputObject ([SePSXTest.ParamChecks.FakeWebObjectsFactory]::GetFakeWebElement());");
        }
        
        [Test]
        public void NoInputObject()
        {
            CmdletUnitTest.TestRunspace.RunAndCheckParameters(
                "[SePSXTest.ParamChecks.FakeWebObjectsFactory]::GetFakeWebElement() | " +
                "Read-SeWebElementDisplayed;");
        }
    }
}
