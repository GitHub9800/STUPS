﻿///*
// * Created by SharpDevelop.
// * User: Alexander Petrovskiy
// * Date: 11/9/2012
// * Time: 5:46 PM
// * 
// * To change this template use Tools | Options | Coding | Edit Standard Headers.
// */
//
//namespace TMX
//{
//    using System;
//    using System.Management.Automation;
//    
//    /// <summary>
//    /// Description of OpenTLCollectionCommand.
//    /// </summary>
//    [Cmdlet(VerbsCommon.Open, "TLCollection")]
//    public class OpenTLCollectionCommand : TLCollectionCmdletBase
//    {
//        public OpenTLCollectionCommand()
//        {
//        }
//        
//        protected override void BeginProcessing()
//        {
//            TLSrvOpenCollectionCommand command =
//                new TLSrvOpenCollectionCommand();
//            command.Cmdlet = this;
//            command.Execute();
//        }
//    }
//}
