/********************************************************************************
Copyright (C) MixERP Inc. (http://mixof.org).

This file is part of MixERP.

MixERP is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, version 2 of the License.

MixERP is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with MixERP.  If not, see <http://www.gnu.org/licenses/>.
***********************************************************************************/

using MixERP.Net.Common;
using MixERP.Net.Common.Helpers;
using MixERP.Net.WebJobs.BackupDatabase;
using Quartz;
using Quartz.Impl;

namespace MixERP.Net.FrontEnd.Application
{
    public static class WebJobManager
    {
        public static void Register()
        {
            int minutes = Conversion.TryCastInteger(ConfigurationHelper.GetDbServerParameter("AutoBackupEveryNMinutes"));

            if (minutes <= 0)
            {
                return;
            }

            ISchedulerFactory factory = new StdSchedulerFactory();

            IScheduler scheduler = factory.GetScheduler();
            scheduler.Start();

            IJobDetail job = JobBuilder.Create<BackupJob>().WithIdentity("BackupJob", "WebJobs").Build();

            ITrigger trigger = TriggerBuilder.Create().WithIdentity("BackupJobTrigger", "WebJobs")
                .WithSimpleSchedule(x => x.WithIntervalInMinutes(minutes).RepeatForever()).Build();

            scheduler.ScheduleJob(job, trigger);
        }
    }
}