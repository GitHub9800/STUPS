﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 01/12/2011
 * Time: 12:36 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace UIAutomation.Commands
{
    using System;
    using System.Management.Automation;
    using System.Runtime.InteropServices;
    
    // 20120823
    using System.Windows.Automation;
    
    /// <summary>
    /// Description of SetUIAFocusCommand.
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "UIAFocus")]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "UIA")]
    public class SetUIAFocusCommand : HasControlInputCmdletBase
    {
        #region Constructor
        public SetUIAFocusCommand()
        {
        }
        #endregion Constructor
        
        #region Parameters
        #endregion Parameters
        
        /// <summary>
        /// Processes the pipeline.
        /// </summary>
        protected override void ProcessRecord()
        {
            // if (!this.CheckControl(this)) { return; }
            if (!this.CheckControl(this)) { return; }
            
            // 20120823
            foreach (AutomationElement inputObject in this.InputObject) {
            
            // 20120823
            //InputObject.SetFocus();
            inputObject.SetFocus();
            if (this.PassThru) {
                this.WriteObject(this, this.InputObject);
            } else {
                this.WriteObject(this, true);
            }
            
            } // 20120823

        }
    }
}
