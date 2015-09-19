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
    [TableName("core.default_widget_setup_view")]
    [ExplicitColumns]
    public sealed class DefaultWidgetSetupView : PetaPocoDB.Record<DefaultWidgetSetupView>, IPoco
    {
        [Column("widget_setup_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? WidgetSetupId { get; set; }

        [Column("widget_order")]
        [ColumnDbType("int4", 0, true, "")]
        public int? WidgetOrder { get; set; }

        [Column("widget_group_name")]
        [ColumnDbType("varchar", 100, true, "")]
        public string WidgetGroupName { get; set; }

        [Column("widget_name")]
        [ColumnDbType("varchar", 100, true, "")]
        public string WidgetName { get; set; }

        [Column("widget_source")]
        [ColumnDbType("text", 0, true, "")]
        public string WidgetSource { get; set; }
    }
}