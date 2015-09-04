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

namespace MixERP.Net.Entities.Audit
{
    [PrimaryKey("", autoIncrement=false)]
    [FunctionName("audit.get_office_information_model")]
    [ExplicitColumns]
    public sealed class DbGetOfficeInformationModelResult : PetaPocoDB.Record<DbGetOfficeInformationModelResult>, IPoco
    {
        [Column("office")]
        [ColumnDbType("text", 0, false, "")] 
        public string Office { get; set; }
    
        [Column("logged_in_to")]
        [ColumnDbType("text", 0, false, "")] 
        public string LoggedInTo { get; set; }
    
        [Column("last_login_ip")]
        [ColumnDbType("text", 0, false, "")] 
        public string LastLoginIp { get; set; }
    
        [Column("last_login_on")]
        [ColumnDbType("timestamp with time zone", 0, false, "")] 
        public DateTime LastLoginOn { get; set; }
    
        [Column("current_ip")]
        [ColumnDbType("text", 0, false, "")] 
        public string CurrentIp { get; set; }
    
        [Column("current_login_on")]
        [ColumnDbType("timestamp with time zone", 0, false, "")] 
        public DateTime CurrentLoginOn { get; set; }
    
        [Column("role")]
        [ColumnDbType("text", 0, false, "")] 
        public string Role { get; set; }
    
        [Column("department")]
        [ColumnDbType("text", 0, false, "")] 
        public string Department { get; set; }
    }
}