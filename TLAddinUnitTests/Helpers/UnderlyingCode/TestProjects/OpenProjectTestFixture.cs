﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 11/18/2012
 * Time: 12:18 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace TLAddinUnitTests.TestProjects
{
    using System;
    using MbUnit.Framework;
    using PSTestLib;
    using Moq;
    //using Autofac;
    //using Autofac.Builder;
    using TMX;
    using Meyn.TestLink;
    using CookComputing.XmlRpc;
    
    //using NUnit.Framework;
    
    /// <summary>
    /// Description of OpenProjectTestFixture.
    /// </summary>
    [TestFixture]
    //[Parallelizable]
    public class OpenProjectTestFixture
    {
        public OpenProjectTestFixture()
        {
        }
        
        [SetUp]
        public void SetUp()
        {
            UnitTestingHelper.PrepareUnitTestDataStore();
        }
        
        [TearDown]
        public void TearDown()
        {
        }
        
        private System.Collections.Generic.List<TestProject> getProject(
            System.Collections.Generic.List<TestProject> listOfProjects,
            string[] names,
            bool makeFail)
        {
            TLProjectCmdletBase cmdlet = new TLProjectCmdletBase();
            cmdlet.UnitTest = true;
            cmdlet.Name = names;
            
            TLAddinData.CurrentTestLinkConnection =
                FakeTestLinkFactory.GetTestLinkWithProjects(listOfProjects);

            if (makeFail) {
                TLAddinData.CurrentTestLinkConnection = null;
            }
            
            TLSrvGetProjectCommand command =
                new TLSrvGetProjectCommand(cmdlet);
            command.Execute();
            
            System.Collections.Generic.List<TestProject> resultList =
                new System.Collections.Generic.List<TestProject>();

            foreach (object tpr in TMX.CommonCmdletBase.UnitTestOutput) {
                resultList.Add((Meyn.TestLink.TestProject)tpr);
            }

            return resultList;
        }
        
        
        [Test] //, Parallelizable]
        public void Broken_connection()
        {
            string projectName = "project";

            System.Collections.Generic.List<TestProject> list =
                new System.Collections.Generic.List<TestProject>();
            
            list.Add(
                FakeTestLinkFactory.GetTestProject(
                    projectName,
                    "prj",
                    string.Empty));
            
            System.Collections.Generic.List<TestProject> resultList =
                getProject(list, (new string[]{ projectName }), true);
            
            Assert.AreEqual<System.Collections.Generic.List<TestProject>>(
                (new System.Collections.Generic.List<TestProject>()),
                resultList);
        }
        
#region to delete
//        [Test] //, Parallelizable]
//        public void No_projects_Null()
//        {
//            string projectName = "project";
//            
//            System.Collections.Generic.List<TestProject> list = null;
//            
//            System.Collections.Generic.List<TestProject> resultList =
//                getProject(list, (new string[]{ projectName }), false);
//            
//            Assert.AreEqual<System.Collections.Generic.List<TestProject>>(
//                list,
//                resultList);
//        }
#endregion to delete

        [Test] //, Parallelizable]
        public void No_projects()
        {
            System.Collections.Generic.List<TestProject> list =
                new System.Collections.Generic.List<TestProject>();
            
            System.Collections.Generic.List<TestProject> resultList =
                getProject(list, null, false);
            
            Assert.AreEqual<System.Collections.Generic.List<TestProject>>(
                list,
                resultList);
        }
        
        [Test] //, Parallelizable]
        public void One_project_by_name()
        {
            string projectName = "project01";
            
            System.Collections.Generic.List<TestProject> list =
                new System.Collections.Generic.List<TestProject>();
            list.Add(
                FakeTestLinkFactory.GetTestProject(
                    "project00",
                    "prj0",
                    string.Empty));
            list.Add(
                FakeTestLinkFactory.GetTestProject(
                    projectName,
                    "prj1",
                    string.Empty));
            list.Add(
                FakeTestLinkFactory.GetTestProject(
                    "project02",
                    "prj2",
                    string.Empty));
            
            System.Collections.Generic.List<TestProject> resultList =
                getProject(list, (new string[]{ projectName }), false);
            
            list.RemoveAt(2);
            list.RemoveAt(0);
            
            Assert.AreEqual<System.Collections.Generic.List<TestProject>>(
                list,
                resultList);
        }
        
        [Test] //, Parallelizable]
        public void Three_projects_by_name()
        {

            string[] projectNames = { "project01", "project02", "project03" };

            System.Collections.Generic.List<TestProject> list =
                new System.Collections.Generic.List<TestProject>();
            list.Add(
                FakeTestLinkFactory.GetTestProject(
                    projectNames[0],
                    "prj1",
                    string.Empty));
            list.Add(
                FakeTestLinkFactory.GetTestProject(
                    "project04",
                    "prj4",
                    string.Empty));
            list.Add(
                FakeTestLinkFactory.GetTestProject(
                    projectNames[1],
                    "prj2",
                    string.Empty));
            list.Add(
                FakeTestLinkFactory.GetTestProject(
                    projectNames[2],
                    "prj3",
                    string.Empty));
            
            System.Collections.Generic.List<TestProject> resultList =
                getProject(list, projectNames, false);
            
            list.RemoveAt(1);
            
            Assert.AreEqual<System.Collections.Generic.List<TestProject>>(
                list,
                resultList);
        }
        
        [Test] //, Parallelizable]
        public void One_project_by_id()
        {
            string projectName = "project01";
            
            System.Collections.Generic.List<TestProject> list =
                new System.Collections.Generic.List<TestProject>();
            list.Add(
                FakeTestLinkFactory.GetTestProject(
                    "project00",
                    "prj0",
                    string.Empty));
            list.Add(
                FakeTestLinkFactory.GetTestProject(
                    projectName,
                    "prj1",
                    string.Empty));
            list.Add(
                FakeTestLinkFactory.GetTestProject(
                    "project02",
                    "prj2",
                    string.Empty));
            
            System.Collections.Generic.List<int> projectIds =
                new System.Collections.Generic.List<int>();
            projectIds.Add(list[1].id);
            
            System.Collections.Generic.List<TestProject> resultList =
                getProject(list, (new string[]{ projectName }), false);
            
            list.RemoveAt(2);
            list.RemoveAt(0);
            
            Assert.AreEqual<int>(
                //list,
                projectIds[0],
                //resultList);
                resultList[0].id);
        }
        
        [Test] //, Parallelizable]
        public void Three_projects_by_id()
        {

            string[] projectNames = { "project01", "project02", "project03" };

            System.Collections.Generic.List<TestProject> list =
                new System.Collections.Generic.List<TestProject>();
            list.Add(
                FakeTestLinkFactory.GetTestProject(
                    projectNames[0],
                    "prj1",
                    string.Empty));
            list.Add(
                FakeTestLinkFactory.GetTestProject(
                    "project04",
                    "prj4",
                    string.Empty));
            list.Add(
                FakeTestLinkFactory.GetTestProject(
                    projectNames[1],
                    "prj2",
                    string.Empty));
            list.Add(
                FakeTestLinkFactory.GetTestProject(
                    projectNames[2],
                    "prj3",
                    string.Empty));
            
            int[] projectIds =
                { list[0].id, list[2].id, list[3].id };
            
            System.Collections.Generic.List<TestProject> resultList =
                getProject(list, projectNames, false);
            
            list.RemoveAt(1);
            
//            Assert.AreEqual<System.Collections.Generic.List<TestProject>>(
//                list,
//                resultList);
            
            Assert.AreEqual<int>(
                projectIds[0],
                resultList[0].id);
            
            Assert.AreEqual<int>(
                projectIds[1],
                resultList[1].id);
            
            Assert.AreEqual<int>(
                projectIds[2],
                resultList[2].id);
        }
    }
}
