using Moq;
using UnitTest;
using UnitTest.Models;
using UnitTest.Services;

namespace App.UnitTest
{
    public class AppEvaluateUnitTest
    {
        [Test]
        public void Appliaction_WithUnderAge_TransferToAutoRejected()
        {
            //arragment
            ApplicationEveluator applicationEveluator = new ApplicationEveluator(null);
            var evaluator = new ApplicationEveluator(null);
            var form = new JobApplication
            {
                Applicant = new Applicant()
                {
                    Age = 17
                },
            };
            var appResult = evaluator.Eveluate(form);
            Assert.AreEqual(appResult, ApplicationResult.AutoRejected);
            //action
        }

        [Test]
        public void Appliaction_TechRequirement_TransferToAutoAccepted()
        {
            var mockValidator = new Mock<IIdentityValidator>();
            var result = mockValidator.Setup(x => x.isValid("")).Returns(true);
            //arragment
            ApplicationEveluator applicationEveluator = new ApplicationEveluator(mockValidator.Object);
            var evaluator = new ApplicationEveluator(mockValidator.Object);
            var form = new JobApplication
            {
                Applicant = new Applicant()
                {
                    Age = 23,
                    IdentityNumber=""
                },
                TechStacList = new List<string>()
                {
                    "c#",
                    "rabbitmq",
                    "microservice"
                }
            };
            var appResult = applicationEveluator.Eveluate(form);
            Assert.AreEqual(appResult, ApplicationResult.AutoAccepted);
            //action
        }

        [Test]
        public void Appliaction_WithIsValidFalse_TransferToHr()
        {
            var mockValidator = new Mock<IIdentityValidator>(MockBehavior.Default);
            var result = mockValidator.Setup(x => x.isValid(It.IsAny<string>())).Returns(false);
            //arragment
            ApplicationEveluator applicationEveluator = new ApplicationEveluator(mockValidator.Object);
            var evaluator = new ApplicationEveluator(mockValidator.Object);
            var form = new JobApplication
            {
                Applicant = new Applicant()
                {
                    Age = 23,
                    IdentityNumber = ""
                },
                TechStacList = new List<string>()
                {
                    "c#",
                    "rabbitmq",
                    "microservice"
                }
            };
            var appResult = applicationEveluator.Eveluate(form);
            Assert.AreEqual(appResult, ApplicationResult.AutoRejected);
            //action
        }


    }
}