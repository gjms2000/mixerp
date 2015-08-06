using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Framework.Contracts.Checklist;
using MixERP.Net.i18n.Resources;
using PetaPoco;

namespace MixERP.Net.FirstSteps.FirstTasks
{
    public class Messaging : FirstStep
    {
        public Messaging()
        {
            this.Order = 181;
            this.Name = Titles.SetupEmail;
            this.Category = Titles.FirstTasks;
            this.CategoryAlias = "first-tasks";

            this.Description = Labels.SetupEmailDescription;
            this.Icon = "mail icon";
            this.NavigateUrl = "/Modules/BackOffice/OTS/MessagingParameters.mix";

            if (this.IsSmtpEnabled())
            {
                this.Status = true;
                this.Message = Titles.OK;
                return;
            }

            this.Message = Labels.SMTPIsDisabled;
        }

        private bool IsSmtpEnabled()
        {
            string catalog = AppUsers.GetCurrentUserDB();

            const string sql = "SELECT COUNT(*) FROM config.messaging WHERE key = 'Enabled' AND value = 'true';";
            return Factory.Scalar<int>(catalog, sql).Equals(1);
        }
    }
}