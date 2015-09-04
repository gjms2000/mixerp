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

using System;
using System.Collections.ObjectModel;
using MixERP.Net.Entities.Core;
using MixERP.Net.Entities.Transactions.Models;

namespace MixERP.Net.Core.Modules.Purchase.Data.Transactions
{
    public static class GRN
    {
        public static long Add(string catalog, int officeId, int userId, long loginId, DateTime valueDate, int storeId,
            string partyCode, Collection<StockDetail> details, int costCenterId, string referenceNumber,
            string statementReference, Collection<long> transactionIdCollection, Collection<Attachment> attachments)
        {
            StockMaster stockMaster = new StockMaster();

            stockMaster.PartyCode = partyCode;
            stockMaster.StoreId = storeId;
            stockMaster.IsCredit = true;

            if (!string.IsNullOrWhiteSpace(statementReference))
            {
                statementReference = statementReference.Replace("&nbsp;", " ").Trim();
            }

            long transactionMasterId = GlTransaction.Add(catalog, valueDate, "Purchase.Receipt", officeId, userId,
                loginId, costCenterId, referenceNumber, statementReference, stockMaster, details,
                transactionIdCollection, attachments);
            return transactionMasterId;
        }
    }
}