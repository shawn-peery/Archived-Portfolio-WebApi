namespace Portfolio_WebApi.Models
{
    public class Filters
    {

        public Filters(string filterString)
        {
        }

        public string FilterString { get; } // Read only proprety because no setter
        public string CategoryId { get; }
        public string Due { get; }
        public string StatusId { get; }

    }
}
