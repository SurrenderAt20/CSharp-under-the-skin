

using Assignment4;
using Microsoft.EntityFrameworkCore;

var db = new NorthwindContex();

// Category category = CreateCategory(db);

foreach (var entity in db.Categories)
{
    Console.WriteLine(category);
}

static Category CreateCategory(NorthwindContex db)
{
    var category = new Category
    {
        Id = 102,
        Name = "Test Data Name2",
        Description = "Test Data object2"
    };

    db.Add(category);
    db.SaveChanges();
    return category;
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
