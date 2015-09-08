using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using MixERP.Net.Framework.Contracts.Checklist;
using MixERP.Net.i18n.Resources;

namespace MixERP.Net.Core.Modules.HRM.FirstSteps
{
    public class EducationLevel : FirstStep
    {
        public EducationLevel()
        {
            Order = 1000;
            Name = "Create Education Levels";
            Category = "Human Resource Management";
            CategoryAlias = "hrm";

            Description = "Create education levels applicable to your country and industry.";
            Icon = "university icon";
            NavigateUrl = "/Modules/HRM/Setup/EducationLevels.mix";

            long count = CountFrequencySetups();

            if (count > 0)
            {
                Status = true;
                Message = Titles.OK;
                return;
            }

            Message = "No education level defined.";
        }

        private long CountFrequencySetups()
        {
            Data.EducationLevel educationLevel = new Data.EducationLevel
            {
                Catalog = AppUsers.GetCurrentUserDB(),
                LoginId = AppUsers.GetCurrent().View.LoginId.ToLong(),
                SkipValidation = true
            };

            return educationLevel.Count();
        }
    }
}