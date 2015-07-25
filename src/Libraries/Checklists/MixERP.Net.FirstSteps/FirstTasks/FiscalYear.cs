using System.Globalization;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Framework.Contracts.Checklist;
using MixERP.Net.i18n.Resources;
using PetaPoco;

namespace MixERP.Net.FirstSteps.NewUser.FirstTasks
{
    public class FiscalYear : FirstStep
    {
        public FiscalYear()
        {
            this.Order = 101;
            this.Name = "Create Fiscal Year";
            this.Category = Titles.FirstTasks;
            this.CategoryAlias = "first-tasks";

            this.Description = "There are twelve-month frequency period in a fiscal year.";
            this.Icon = "bar chart icon";
            this.NavigateUrl = "/Modules/BackOffice/FiscalYear.mix";

            int count = this.CountFrequencySetups();

            if (count > 0)
            {
                this.Status = true;
                this.Message = "OK";
                return;
            }

            this.Message = "No Fiscal Year defined.";
        }

        private int CountFrequencySetups()
        {
            string catalog = AppUsers.GetCurrentUserDB();

            const string sql = "SELECT COUNT(*) FROM core.fiscal_year";
            return Factory.Scalar<int>(catalog, sql);
        }
    }
}