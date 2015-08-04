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

using System.Collections.Generic;
using System.IO;
using System.Net.Mail;
using System.Net.Mime;

namespace MixERP.Net.Messaging.Email
{
    public static class AttachmentFactory
    {
        public static List<Attachment> GetAttachments(params string[] files)
        {
            List<Attachment> attachments = new List<Attachment>();

            if (files != null)
            {
                foreach (string file in files)
                {
                    if (!string.IsNullOrWhiteSpace(file))
                    {
                        using (Attachment attachment = new Attachment(file, MediaTypeNames.Application.Octet))
                        {
                            ContentDisposition disposition = attachment.ContentDisposition;
                            disposition.CreationDate = File.GetCreationTime(file);
                            disposition.ModificationDate = File.GetLastWriteTime(file);
                            disposition.ReadDate = File.GetLastAccessTime(file);

                            disposition.FileName = Path.GetFileName(file);
                            disposition.Size = new FileInfo(file).Length;
                            disposition.DispositionType = DispositionTypeNames.Attachment;

                            attachments.Add(attachment);
                        }
                    }
                }
            }

            return attachments;
        }
    }
}