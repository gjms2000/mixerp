using System.Globalization;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using MixERP.Net.Framework.Contracts.Checklist;
using MixERP.Net.i18n.Resources;
using PetaPoco;

namespace MixERP.Net.FirstSteps.NewUser.FirstTasks
{
    public class CountySalesTax : FirstStep
    {
        public CountySalesTax()
        {
            this.Order = 204;
            this.Name = "Create County Sales Tax";
            this.Category = Titles.TaxSetup;
            this.CategoryAlias = "tax-setup";

            this.Description = "";
            this.Icon = "tasks icon";
            this.NavigateUrl = "/Modules/BackOffice/Tax/CountySalesTaxes.mix";

            int count = this.CountCountySalesTaxes();

            if (count > 0)
            {
                this.Status = true;
                this.Message = string.Format(CultureInfo.DefaultThreadCurrentCulture, "{0} county sales taxes defined.", count);
                return;
            }

            this.Message = "No county sales tax defined.";
        }

        private int CountCountySalesTaxes()
        {
            string catalog = AppUsers.GetCurrentUserDB();
            int officeId = AppUsers.GetCurrent().View.OfficeId.ToInt();

            const string sql = "SELECT COUNT(*) FROM core.county_sales_taxes;";
            return Factory.Scalar<int>(catalog, sql, officeId);
        }
    }
}