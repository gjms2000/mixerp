using System.Globalization;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Framework.Contracts.Checklist;
using MixERP.Net.i18n.Resources;
using PetaPoco;

namespace MixERP.Net.FirstSteps.FirstTasks
{
    public class Shipper : FirstStep
    {
        public Shipper()
        {
            this.Order = 110;
            this.Name = "Create Shipping Company";
            this.Category = Titles.FirstTasks;
            this.CategoryAlias = "first-tasks";

            this.Description = "Shipping companies transfer the goods through land, sea, and/or air to your customer.";
            this.Icon = "users icon";
            this.NavigateUrl = "/Modules/Inventory/Setup/Shippers.mix";

            int count = this.CountParties();

            if (count > 0)
            {
                this.Status = true;
                this.Message = string.Format(CultureInfo.DefaultThreadCurrentCulture, "{0} shippers found.", count);
                return;
            }

            this.Message = "No shipper found.";
        }

        private int CountParties()
        {
            string catalog = AppUsers.GetCurrentUserDB();

            const string sql = "SELECT COUNT(*) FROM core.shippers;";
            return Factory.Scalar<int>(catalog, sql);
        }
    }
}