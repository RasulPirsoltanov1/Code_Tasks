using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest.Models;
using UnitTest.Services;

namespace UnitTest
{
    public class ApplicationEveluator
    {
        private const int minAge = 18;
        private const int autoAcceptedYearOfExperience = 15;
        List<string> techs = new List<string>() { "c#", "RabbitMQ", "Microservice" };
        private IIdentityValidator _identityValidator;

        public ApplicationEveluator(IIdentityValidator identityValidator)
        {
            _identityValidator = identityValidator;
        }

        public ApplicationResult Eveluate(JobApplication form)
        {
            if (form.Applicant.Age < minAge)
                return ApplicationResult.AutoRejected;
            var identity = _identityValidator.isValid(form.Applicant.IdentityNumber);
            if (!identity)
                return ApplicationResult.AutoRejected;
                var sr = getTechStackSimilarityRate(form.TechStacList);
            if (sr < 25)
                return ApplicationResult.AutoRejected;
            else if (sr > 60)
                return ApplicationResult.AutoAccepted;
            else if (sr > 75 && autoAcceptedYearOfExperience <= form.YerarsOfExperience)
                return ApplicationResult.AutoRejected;
            return ApplicationResult.AutoRejected;
        }
        private int getTechStackSimilarityRate(List<string> formTechs)
        {
            var matchedCount = formTechs.Where(i => techs.Contains(i, StringComparer.OrdinalIgnoreCase)).Count();
            return (matchedCount / techs.Count())*100;
        }
    }

    public enum ApplicationResult
    {
        AutoRejected,
        AutoAccepted,
        TransferredToHr,
        TransferredToLead,
        TransferredToCTO,
    }
}
