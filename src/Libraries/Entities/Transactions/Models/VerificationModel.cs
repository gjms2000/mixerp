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

using PetaPoco;
using System;

namespace MixERP.Net.Entities.Transactions.Models
{
    [ExplicitColumns]
    public class VerificationModel
    {
        [Column("verification_reason")]
        public string VerificationReason { get; set; }

        [Column("verification_status_id")]
        public short VerificationStatusId { get; set; }

        [Column("last_verified_on")]
        public DateTime VerifiedDate { get; set; }

        [Column("verified_by_user_name")]
        public string VerifierName { get; set; }

        [Column("verified_by_user_id")]
        public int VerifierUserId { get; set; }
    }
}