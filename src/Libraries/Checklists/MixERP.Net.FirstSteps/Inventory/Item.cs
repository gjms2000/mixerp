using System.Globalization;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Framework.Contracts.Checklist;
using MixERP.Net.i18n.Resources;
using PetaPoco;

namespace MixERP.Net.FirstSteps.Office
{
    public class Item : FirstStep
    {
        public Item()
        {
            this.Order = 410;
            this.Name = "Create Item or Service";
            this.Category = Titles.FirstTasks;
            this.CategoryAlias = "first-tasks";

            this.Description =
                "Inventory items may refer to the stockable products or nonstockable services that you buy and/or sell.";
            this.Icon = "shop icon";
            this.NavigateUrl = "/Modules/Inventory/Setup/Items.mix";

            int count = this.CountItems();

            this.Message = string.Format(CultureInfo.DefaultThreadCurrentCulture, "{0} item(s) found.",
                count);

            if (count > 2)
            {
                this.Status = true;
            }
        }

        private int CountItems()
        {
            string catalog = AppUsers.GetCurrentUserDB();

            const string sql = "SELECT COUNT(*) FROM core.items;";
            return Factory.Scalar<int>(catalog, sql);
        }
    }
}