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

using MixERP.Net.Entities.Core;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using MixERP.Net.Entities.Transactions;
using PetaPoco;
using StockDetail = MixERP.Net.Entities.Models.Transactions.StockDetail;
using StockMaster = MixERP.Net.Entities.Models.Transactions.StockMaster;

namespace MixERP.Net.Core.Modules.Sales.Data.Transactions
{
    public static class Delivery
    {
        public static long Add(string catalog, int officeId, int userId, long loginId, DateTime valueDate, int storeId, string partyCode, int priceTypeId, int paymentTermId, Collection<StockDetail> details, int shipperId, string shippingAddressCode, decimal shippingCharge, int costCenterId, string referenceNumber, int agentId, string statementReference, Collection<long> tranIds, Collection<Attachment> attachments, bool nonTaxable)
        {
            StockMaster stockMaster = new StockMaster();

            stockMaster.PartyCode = partyCode;
            stockMaster.IsCredit = true; //Credit
            stockMaster.PaymentTermId = paymentTermId;

            stockMaster.PriceTypeId = priceTypeId;
            stockMaster.ShipperId = shipperId;
            stockMaster.ShippingAddressCode = shippingAddressCode;
            stockMaster.ShippingCharge = shippingCharge;
            stockMaster.SalespersonId = agentId;
            stockMaster.StoreId = storeId;

            long transactionMasterId = GlTransaction.Add(catalog, "Sales.Delivery", valueDate, officeId, userId, loginId, costCenterId, referenceNumber, statementReference, stockMaster, details, attachments, nonTaxable, tranIds);

            return transactionMasterId;
        }

        public static SalesDeliveryView GetSalesDeliveryView(string catalog, long tranId)
        {
            const string sql = "SELECT * FROM transactions.sales_delivery_view WHERE tran_id = @0;";
            return Factory.Get<SalesDeliveryView>(catalog, sql, tranId).FirstOrDefault();
        }

    }
}