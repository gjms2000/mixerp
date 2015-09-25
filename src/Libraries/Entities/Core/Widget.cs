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
    [PrimaryKey("widget_name", autoIncrement = false)]
    [TableName("core.widgets")]
    [ExplicitColumns]
    public sealed class Widget : PetaPocoDB.Record<Widget>, IPoco
    {
        [Column("widget_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.widgets_widget_id_seq'::regclass)")]
        public int WidgetId { get; set; }

        [Column("widget_name")]
        [ColumnDbType("text", 0, false, "")]
        public string WidgetName { get; set; }

        [Column("widget_source")]
        [ColumnDbType("text", 0, false, "")]
        public string WidgetSource { get; set; }
    }
}