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

namespace MixERP.Net.Entities.Public
{
    [PrimaryKey("", autoIncrement=false)]
    [TableName("public.db_stat")]
    [ExplicitColumns]
    public sealed class DbStat : PetaPocoDB.Record<DbStat>, IPoco
    {
        [Column("relname")]
        [ColumnDbType("name", 0, true, "")] 
        public string Relname { get; set; }
    
        [Column("last_vacuum")]
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? LastVacuum { get; set; }
    
        [Column("last_autovacuum")]
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? LastAutovacuum { get; set; }
    
        [Column("last_analyze")]
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? LastAnalyze { get; set; }
    
        [Column("last_autoanalyze")]
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? LastAutoanalyze { get; set; }
    
        [Column("vacuum_count")]
        [ColumnDbType("int8", 0, true, "")] 
        public long? VacuumCount { get; set; }
    
        [Column("autovacuum_count")]
        [ColumnDbType("int8", 0, true, "")] 
        public long? AutovacuumCount { get; set; }
    
        [Column("analyze_count")]
        [ColumnDbType("int8", 0, true, "")] 
        public long? AnalyzeCount { get; set; }
    
        [Column("autoanalyze_count")]
        [ColumnDbType("int8", 0, true, "")] 
        public long? AutoanalyzeCount { get; set; }
    }
}