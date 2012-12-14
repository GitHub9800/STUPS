﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 11/9/2012
 * Time: 5:47 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace TMX
{
    using System;
    using System.Management.Automation;
    
    /// <summary>
    /// Description of NewTLTestPlanCommand.
    /// </summary>
    [Cmdlet(VerbsCommon.New, "TLTestPlan", DefaultParameterSetName = "PipelineInput")]
    public class NewTLTestPlanCommand : TLTestPlanCmdletBase
    {
        public NewTLTestPlanCommand()
        {
            this.Active = true;
        }
        
        #region Parameters
//        [Parameter(Mandatory = true,
//                   Position = 0,
//                   ParameterSetName = "PipelineInput")]
//        [Parameter(Mandatory = true,
//                   Position = 0,
//                   ParameterSetName = "StringInput")]
//        [Parameter(Mandatory = false,
//                   Position = 0,
//                   ParameterSetName = "FromStore")]
//        [Parameter(Mandatory = false,
//                   ParameterSetName = "fake")]
//        //public new string Name { get; set; }
//        internal new string Name { get; set; }
        
        [Parameter(Mandatory = false,
                   ParameterSetName = "PipelineInput")]
        [Parameter(Mandatory = false,
                   ParameterSetName = "StringInput")]
        [Parameter(Mandatory = false,
                   ParameterSetName = "FromStore")]
        public string Description { get; set; }
        
        [Parameter(Mandatory = false,
                   ParameterSetName = "PipelineInput")]
        [Parameter(Mandatory = false,
                   ParameterSetName = "StringInput")]
        [Parameter(Mandatory = false,
                   ParameterSetName = "FromStore")]
        public SwitchParameter Active { get; set; }
        #endregion Parameters
        
        protected override void ProcessRecord()
        {
            TLSrvNewTestPlanCommand command =
                new TLSrvNewTestPlanCommand(this);
            command.Execute();
        }
    }
}
