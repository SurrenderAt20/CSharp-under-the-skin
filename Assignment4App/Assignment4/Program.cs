

using Assignment4;
using Microsoft.EntityFrameworkCore;

var db = new NorthwindContex();

foreach (var category in db.Categories.Where(x => x.Id > 5))
{
    Console.WriteLine(category);
}


//Check if DB is connected
//using (var context = new NorthwindContex())
//{
//    try
//    {
//        context.Database.ExecuteSqlRaw("SELECT 1");
//        Console.WriteLine("Database is connected!");
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine($"Database connection failed: {ex.Message}");
//    }
//}
