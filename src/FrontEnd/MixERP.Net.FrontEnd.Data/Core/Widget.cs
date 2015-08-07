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
using MixERP.Net.Entities.Core;
using PetaPoco;

namespace MixERP.Net.FrontEnd.Data.Core
{
    public static class Widget
    {
        public static IEnumerable<DefaultWidgetSetupView> GetDefaultWidgets(string catalog)
        {
            const string sql = "SELECT * FROM core.default_widget_setup_view;";
            return Factory.Get<DefaultWidgetSetupView>(catalog, sql);
        }

        public static IEnumerable<WidgetGroup> GetGroups(string catalog)
        {
            const string sql = "SELECT * FROM core.widget_groups;";
            return Factory.Get<WidgetGroup>(catalog, sql);
        }

        public static IEnumerable<WidgetSetupView> GetWidgetSetupView(string catalog, string group)
        {
            const string sql = "SELECT * FROM core.widget_setup_view WHERE widget_group_name=@0;";
            return Factory.Get<WidgetSetupView>(catalog, sql, group);
        }

        public static IEnumerable<Entities.Core.Widget> GetNonSelectedWidgets(string catalog, string group)
        {
            const string sql = @"SELECT * FROM core.widgets
                                WHERE widget_name NOT IN
                                (
                                    SELECT widget_name FROM core.widget_setup
                                    WHERE widget_group_name = @0
                                );";
            return Factory.Get<Entities.Core.Widget>(catalog, sql, group);
        }

        public static void RemoveWidget(string catalog, string group, string widget)
        {
            const string sql = @"DELETE FROM core.widget_setup 
                                WHERE widget_group_name = @0
                                AND widget_name = @1;";

            Factory.NonQuery(catalog, sql, group, widget);
        }

        public static void AddWidget(string catalog, int order, string group, string widget)
        {
            const string sql = @"INSERT INTO core.widget_setup(widget_order, widget_group_name, widget_name) SELECT @0, @1, @2;";

            Factory.NonQuery(catalog, sql, order, group, widget);
        }

        public static void OrderWidgets(string catalog, IEnumerable<WidgetSetup> widgets)
        {
            const string sql = "UPDATE core.widget_setup SET widget_order = @0 WHERE widget_group_name=@1 AND widget_name=@2;";

            foreach (var widget in widgets)
            {
                Factory.NonQuery(catalog, sql, widget.WidgetOrder, widget.WidgetGroupName, widget.WidgetName);
            }
        }
    }
}