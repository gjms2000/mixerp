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
    [PrimaryKey("", autoIncrement=false)]
    [TableName("core.shipping_package_shape_selector_view")]
    [ExplicitColumns]
    public sealed class ShippingPackageShapeSelectorView : PetaPocoDB.Record<ShippingPackageShapeSelectorView>, IPoco
    {
        [Column("shipping_package_shape_id")]
        [ColumnDbType("int4", 0, true, "")] 
        public int? ShippingPackageShapeId { get; set; }
    
        [Column("shipping_package_shape_code")]
        [ColumnDbType("varchar", 12, true, "")] 
        public string ShippingPackageShapeCode { get; set; }
    
        [Column("shipping_package_shape_name")]
        [ColumnDbType("varchar", 64, true, "")] 
        public string ShippingPackageShapeName { get; set; }
    
        [Column("is_rectangular")]
        [ColumnDbType("bool", 0, true, "")] 
        public bool? IsRectangular { get; set; }
    }
}