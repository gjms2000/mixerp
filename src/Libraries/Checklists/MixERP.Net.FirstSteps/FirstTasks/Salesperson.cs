using System.Globalization;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Framework.Contracts.Checklist;
using MixERP.Net.i18n.Resources;
using PetaPoco;

namespace MixERP.Net.FirstSteps.FirstTasks
{
    public class Salesperson : FirstStep
    {
        public Salesperson()
        {
            this.Order = 110;
            this.Name = "Create Salespersons";
            this.Category = Titles.FirstTasks;
            this.CategoryAlias = "first-tasks";

            this.Description =
                "Salespersons are the sales guys who sell your products and bring business to your company.";
            this.Icon = "users icon";
            this.NavigateUrl = "/Modules/Sales/Setup/Salespersons.mix";

            int count = this.CountParties();

            if (count > 0)
            {
                this.Status = true;
                this.Message = string.Format(CultureInfo.DefaultThreadCurrentCulture, "{0} salespersons found.", count);
                return;
            }

            this.Message = "No salesperson found.";
        }

        private int CountParties()
        {
            string catalog = AppUsers.GetCurrentUserDB();

            const string sql = "SELECT COUNT(*) FROM core.salespersons;";
            return Factory.Scalar<int>(catalog, sql);
        }
    }
}