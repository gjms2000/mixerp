// ReSharper disable All
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
// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [FunctionName("core.get_workflow_model")]
    [ExplicitColumns]
    public sealed class DbGetWorkflowModelResult : PetaPocoDB.Record<DbGetWorkflowModelResult>, IPoco
    {
        [Column("flagged_transactions")]
        [ColumnDbType("integer", 0, false, "")]
        public int FlaggedTransactions { get; set; }

        [Column("in_verification_stack")]
        [ColumnDbType("integer", 0, false, "")]
        public int InVerificationStack { get; set; }

        [Column("auto_approved")]
        [ColumnDbType("integer", 0, false, "")]
        public int AutoApproved { get; set; }

        [Column("approved")]
        [ColumnDbType("integer", 0, false, "")]
        public int Approved { get; set; }

        [Column("rejected")]
        [ColumnDbType("integer", 0, false, "")]
        public int Rejected { get; set; }

        [Column("closed")]
        [ColumnDbType("integer", 0, false, "")]
        public int Closed { get; set; }

        [Column("withdrawn")]
        [ColumnDbType("integer", 0, false, "")]
        public int Withdrawn { get; set; }
    }
}