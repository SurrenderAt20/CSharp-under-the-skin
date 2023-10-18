

using Assignment4;
using Microsoft.EntityFrameworkCore;

var db = new NorthwindContex();

//Category category = CreateCategory(db);

//delete from db
var category = db.Categories.FirstOrDefault(x => x.Id == 101);
if (category != null)
{
    db.Categories.Remove(category);
    db.SaveChanges();
}



foreach (var entity in db.Categories)
{
    Console.WriteLine(entity);
}

static Category CreateCategory(NorthwindContex db)
{
    var category = new Category
    {
        Id = 103,
        Name = "Test Data Name3",
        Description = "Test Data object3"
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
