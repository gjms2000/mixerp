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
    [PrimaryKey("login_id", autoIncrement=true)]
    [TableName("audit.logins")]
    [ExplicitColumns]
    public sealed class Login : PetaPocoDB.Record<Login>, IPoco
    {
        [Column("login_id")]
        [ColumnDbType("int8", 0, false, "nextval('audit.logins_login_id_seq'::regclass)")] 
        public long LoginId { get; set; }
    
        [Column("user_id")]
        [ColumnDbType("int4", 0, false, "")] 
        public int UserId { get; set; }
    
        [Column("office_id")]
        [ColumnDbType("int4", 0, false, "")] 
        public int OfficeId { get; set; }
    
        [Column("browser")]
        [ColumnDbType("varchar", 500, false, "")] 
        public string Browser { get; set; }
    
        [Column("ip_address")]
        [ColumnDbType("varchar", 50, false, "")] 
        public string IpAddress { get; set; }
    
        [Column("login_date_time")]
        [ColumnDbType("timestamptz", 0, false, "")] 
        public DateTime LoginDateTime { get; set; }
    
        [Column("remote_user")]
        [ColumnDbType("varchar", 50, false, "")] 
        public string RemoteUser { get; set; }
    
        [Column("culture")]
        [ColumnDbType("varchar", 12, false, "")] 
        public string Culture { get; set; }
    }
}