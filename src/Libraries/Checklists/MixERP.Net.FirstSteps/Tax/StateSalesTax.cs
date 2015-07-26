using System.Globalization;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using MixERP.Net.Framework.Contracts.Checklist;
using MixERP.Net.i18n.Resources;
using PetaPoco;

namespace MixERP.Net.FirstSteps.NewUser.FirstTasks
{
    public class StateSalesTax : FirstStep
    {
        public StateSalesTax()
        {
            this.Order = 203;
            this.Name = Titles.CreateStateSalesTax;
            this.Category = Titles.TaxSetup;
            this.CategoryAlias = "tax-setup";

            this.Description = Labels.CreateStateSalesTaxDescription;
            this.Icon = "tasks icon";
            this.NavigateUrl = "/Modules/BackOffice/Tax/StateSalesTaxes.mix";

            int count = this.CountStateSalesTaxes();

            if (count > 0)
            {
                this.Status = true;
                this.Message = string.Format(CultureInfo.DefaultThreadCurrentCulture, Labels.NStateSalesTaxesDefined, count);
                return;
            }

            this.Message = Labels.NoStateSalesTaxDefined;
        }

        private int CountStateSalesTaxes()
        {
            string catalog = AppUsers.GetCurrentUserDB();
            int officeId = AppUsers.GetCurrent().View.OfficeId.ToInt();

            const string sql = "SELECT COUNT(*) FROM core.state_sales_taxes;";
            return Factory.Scalar<int>(catalog, sql, officeId);
        }
    }
}