using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;
using System;
namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job testJob1 = new Job();
            Job testJob2 = new Job();
            Assert.IsFalse(testJob1.Id == testJob2.Id);
            Assert.IsTrue((testJob2.Id - testJob1.Id) == 1);
            
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job testJob1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreEqual("Product tester", testJob1.Name);
            Assert.AreEqual("ACME", testJob1.EmployerName.Value);
            Assert.AreEqual("Desert", testJob1.EmployerLocation.Value);
            Assert.AreEqual("Quality control", testJob1.JobType.Value);
            Assert.AreEqual("Persistence", testJob1.JobCoreCompetency.Value);

        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job testJob1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job testJob2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsFalse(testJob1.Equals(testJob2));
        }
    }
}
