using System.Globalization;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Framework.Contracts.Checklist;
using MixERP.Net.i18n.Resources;
using PetaPoco;

namespace MixERP.Net.FirstSteps.NewUser.FirstTasks
{
    public class Frequency : FirstStep
    {
        public Frequency()
        {
            this.Order = 101;
            this.Name = "Create Frequencies";
            this.Category = Titles.FirstTasks;
            this.CategoryAlias = "first-tasks";

            this.Description = "There are twelve-month frequency period in a fiscal year.";
            this.Icon = "circle notched icon";
            this.NavigateUrl = "/Modules/BackOffice/Frequency.mix";

            int count = this.CountFrequencySetups();

            if (count == 12)
            {
                this.Status = true;
                this.Message = "Frequency setup is complete.";
                return;
            }

            this.Message = string.Format(CultureInfo.DefaultThreadCurrentCulture, "{0} out of 12 frequencies defined.",
                count);
        }

        private int CountFrequencySetups()
        {
            string catalog = AppUsers.GetCurrentUserDB();

            const string sql = "SELECT COUNT(*) FROM core.frequency_setups";
            return Factory.Scalar<int>(catalog, sql);
        }
    }
}