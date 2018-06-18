using System.Data.Entity;

namespace Dublin.Infra.Data.Context
{
    public class DataContext:DbContext
    {
        public DataContext() : base("DublinConection")
        {
        }
    }
}
