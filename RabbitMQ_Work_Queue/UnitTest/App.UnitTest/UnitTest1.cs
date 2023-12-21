using UnitTest;
using UnitTest.Models;

namespace App.UnitTest
{
    public class AppEvaluateUnitTest
    {
        [Test]
        public void Appliaction_WithUnderAge_TransferToAutoRejected()
        {
            //arragment
            ApplicationEveluator applicationEveluator = new ApplicationEveluator();
            var evaluator = new ApplicationEveluator();
            var form = new JobApplication
            {
                Applicant = new Applicant()
                {
                    Age =17
                },
            };
            var appResult = evaluator.Eveluate(form);
            Assert.AreEqual(appResult, ApplicationResult.AutoRejected);
            //action
        }

        [Test]
        public void Appliaction_TechRequirement_TransferToAutoAccepted()
        {
            //arragment
            ApplicationEveluator applicationEveluator = new ApplicationEveluator();
            var evaluator = new ApplicationEveluator();
            var form = new JobApplication
            {
                Applicant = new Applicant()
                {
                    Age=23
                },
                TechStacList=new List<string>()
                {
                    "c#",
                    "rabbitmq",
                    "microservice"
                }
            };
            var appResult = evaluator.Eveluate(form);
            Assert.AreEqual(appResult, ApplicationResult.AutoAccepted);
            //action
        }

    }
}