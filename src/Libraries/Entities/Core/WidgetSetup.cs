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
    [PrimaryKey("widget_setup_id", autoIncrement = true)]
    [TableName("core.widget_setup")]
    [ExplicitColumns]
    public sealed class WidgetSetup : PetaPocoDB.Record<WidgetSetup>, IPoco
    {
        [Column("widget_setup_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.widget_setup_widget_setup_id_seq'::regclass)")]
        public int WidgetSetupId { get; set; }

        [Column("widget_order")]
        [ColumnDbType("int4", 0, false, "")]
        public int WidgetOrder { get; set; }

        [Column("widget_group_name")]
        [ColumnDbType("varchar", 100, false, "")]
        public string WidgetGroupName { get; set; }

        [Column("widget_name")]
        [ColumnDbType("varchar", 100, false, "")]
        public string WidgetName { get; set; }
    }
}