using EmbedComparison.Models;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;

namespace EmbedComparison.Handlers
{
    public class MapHandler : ContentHandler
    {
        public MapHandler(IRepository<EmbedComparisonRecord> repository)
        {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}
