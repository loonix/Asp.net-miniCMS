
namespace miniCMS.Data
{
    public class DbInitializer
    {
        public static void Initialize(DbMiniCMSContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
