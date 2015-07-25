using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Framework.Contracts.Checklist;
using MixERP.Net.i18n.Resources;
using PetaPoco;

namespace MixERP.Net.FirstSteps.FirstTasks
{
    public class FiscalYear : FirstStep
    {
        public FiscalYear()
        {
            this.Order = 121;
            this.Name = "Create Fiscal Year";
            this.Category = Titles.FirstTasks;
            this.CategoryAlias = "first-tasks";

            this.Description = "Fiscal year is an accounting period of 12-months, used to prepare financial statements.";
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