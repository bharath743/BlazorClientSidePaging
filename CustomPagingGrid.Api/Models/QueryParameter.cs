namespace CustomPagingGrid.Api.Models
{
#nullable disable
    public class QueryParameter
    {
        public int Skip { get; set; }
        public int Top { get; set; }
        public string OrderBy { get; set; }
        public bool Count { get; set; } = true;
    }
}
