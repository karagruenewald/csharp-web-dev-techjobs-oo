using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;
using System;
namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        Job testJob1; //test job object

        [TestInitialize]
        public void CreateJobObject()
        {
            testJob1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        }

        [TestMethod]
        public void TestSettingJobId()
        {
            Job testJob3 = new Job();
            Job testJob4 = new Job();
            Assert.IsFalse(testJob3.Id == testJob4.Id);
            Assert.IsTrue((testJob4.Id - testJob3.Id) == 1);
            
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual("Product tester", testJob1.Name);
            Assert.AreEqual("ACME", testJob1.EmployerName.Value);
            Assert.AreEqual("Desert", testJob1.EmployerLocation.Value);
            Assert.AreEqual("Quality control", testJob1.JobType.Value);
            Assert.AreEqual("Persistence", testJob1.JobCoreCompetency.Value);

        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job testJob2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsFalse(testJob1.Equals(testJob2));
        }

        [TestMethod]
        public void ToStringBlankLinesBeforeAndAfter()
        {
            
            Assert.IsTrue(testJob1.ToString().StartsWith("\n"));
            Assert.IsTrue(testJob1.ToString().EndsWith("\n"));
        }

        [TestMethod]
        public void ToStringContainsLabelAndDataForEachField()
        {
            string output = "\nID: 8\nName: Product tester\nEmployer: ACME\nLocation: Desert\nPosition Type: Quality control\nCoreCompetency: Persistence\n";
            Assert.AreEqual(output, testJob1.ToString());
        }

        [TestMethod]
        public void ToStringIfFieldEmpty()
        {
            Job testJob5 = new Job("", new Employer(""), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            string output = "\nID: 10\nName: Data not available\nEmployer: Data not available\nLocation: Desert\nPosition Type: Quality control\nCoreCompetency: Persistence\n";
            Assert.AreEqual(output, testJob5.ToString());

        }

        [TestMethod]
        public void ToStringIfOnlyContainsID()
        {
            Job testJob6 = new Job();
            string output = "OOPS! This job does not seem to exist.";
            Assert.AreEqual(output, testJob6.ToString());
        }
    }
}
