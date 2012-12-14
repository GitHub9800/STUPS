﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 9/8/2012
 * Time: 7:07 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace TMX
{
    using System;
    using System.Management.Automation;
    
    /// <summary>
    /// Description of TestResultsCmdletBase.
    /// </summary>
    public class TestResultsCmdletBase : CommonCmdletBase
    {
        public TestResultsCmdletBase()
        {
        }
        
        #region Parameters
        [Parameter(Mandatory = false)]
        internal new string Name { get; set; }
        #endregion Parameters
    }
}
