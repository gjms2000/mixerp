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
    [PrimaryKey("frequency_id", autoIncrement=true)]
    [TableName("core.frequencies")]
    [ExplicitColumns]
    public sealed class Frequency : PetaPocoDB.Record<Frequency>, IPoco
    {
        [Column("frequency_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.frequencies_frequency_id_seq'::regclass)")] 
        public int FrequencyId { get; set; }
    
        [Column("frequency_code")]
        [ColumnDbType("varchar", 12, false, "")] 
        public string FrequencyCode { get; set; }
    
        [Column("frequency_name")]
        [ColumnDbType("varchar", 50, false, "")] 
        public string FrequencyName { get; set; }
    }
}