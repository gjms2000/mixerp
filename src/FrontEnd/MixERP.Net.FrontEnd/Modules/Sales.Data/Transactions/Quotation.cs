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
    public static class Quotation
    {
        public static long Add(string catalog, int officeId, int userId, long loginId, DateTime valueDate, string partyCode, int priceTypeId, Collection<StockDetail> details, string referenceNumber, string statementReference, Collection<long> transactionIdCollection, Collection<Attachment> attachments, bool nonTaxable, int salesPersonId, int shipperId, string shippingAddressCode, int storeId)
        {
            StockMaster stockMaster = new StockMaster();

            stockMaster.PartyCode = partyCode;
            stockMaster.PriceTypeId = priceTypeId;
            stockMaster.SalespersonId = salesPersonId;
            stockMaster.ShipperId = shipperId;
            stockMaster.ShippingAddressCode = shippingAddressCode;
            stockMaster.StoreId = storeId;

            long nonGlStockMasterId = NonGlStockTransaction.Add(catalog, "Sales.Quotation", valueDate, officeId, userId, loginId, referenceNumber, statementReference, stockMaster, details, transactionIdCollection, attachments, nonTaxable);
            return nonGlStockMasterId;
        }

        public static string AddValidation(string catalog, int validDuration, long tranId)
        {
            string validationId = Guid.NewGuid().ToString();
            const string sql =
                "INSERT INTO public.sales_quotation_validation(tran_id, catalog, validation_id, valid_till) SELECT @0::bigint, @1::text, @2::text, NOW() + INTERVAL '1 DAY' * @3;";

            Factory.NonQuery(Factory.MetaDatabase, sql, tranId, catalog, validationId, validDuration);

            return validationId;
        }

        public static SalesQuotationView GetSalesQuotationView(string catalog, long tranId)
        {
            const string sql = "SELECT * FROM transactions.sales_quotation_view WHERE tran_id = @0;";
            return Factory.Get<SalesQuotationView>(catalog, sql, tranId).FirstOrDefault();
        }

    }
}