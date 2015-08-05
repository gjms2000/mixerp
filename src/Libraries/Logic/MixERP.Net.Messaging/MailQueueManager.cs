using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MixERP.Net.Entities.Core;
using PetaPoco;
using Config = MixERP.Net.Messaging.Email.Helpers.Config;

namespace MixERP.Net.Messaging.Email
{
    public class MailQueueManager
    {
        public MailQueueManager()
        {
        }

        public MailQueueManager(string catalog, string message, string attachments, string sendTo, string subject)
        {
            this.Catalog = catalog;
            this.Message = message;
            this.Attachments = attachments;
            this.SendTo = sendTo;
            this.Subject = subject;
        }

        public string Message { get; private set; }
        public string Attachments { get; private set; }
        public string SendTo { get; private set; }
        public string Subject { get; private set; }
        public string Catalog { get; set; }

        public void Add()
        {
            EmailQueue queue = new EmailQueue
            {
                Subject = this.Subject,
                SendTo = this.SendTo,
                Attachments = this.Attachments,
                Message = this.Message,
                AddedOn = DateTime.UtcNow
            };

            Database.MailQueue.AddToQueue(this.Catalog, queue);
        }

        public async Task ProcessMailQueue()
        {
            IEnumerable<EmailQueue> queue = Database.MailQueue.GetMailInQueue(this.Catalog);
            Config config = new Config(this.Catalog);

            foreach (EmailQueue mail in queue)
            {
                Processor processor = new Processor(this.Catalog);
                bool success =
                    await
                        processor.Send(mail.SendTo, mail.Subject, mail.Message, false,
                            mail.Attachments.Split(',').ToArray());

                if (success)
                {
                    mail.Delivered = true;
                    mail.DeliveredOn = DateTime.UtcNow;
                    Factory.Update(this.Catalog, mail, mail.QueueId);
                }
            }
        }
    }
}