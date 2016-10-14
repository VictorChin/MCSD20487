using System.Data.Entity;
using NorthwindModels;

namespace EFConsoleClient
{
    internal class MyStrategy<T> : DropCreateDatabaseIfModelChanges<NW>
    {
        public override void InitializeDatabase(NW context)
        {
            base.InitializeDatabase(context);
        }
        protected override void Seed(NW context)
        {
            base.Seed(context);
        }
    }
}