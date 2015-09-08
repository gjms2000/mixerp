namespace MixERP.Net.EntityParser
{
    public class Filter
    {
        public long FilterId { get; set; }
        public string FilterName { get; set; }
        public string PropertyName { get; set; }
        public string ColumnName { get; set; }
        public int FilterCondition { get; set; }
        public string FilterValue { get; set; }
        public string FilterAndValue { get; set; }
        public string ObjectName { get; set; }
    }
}