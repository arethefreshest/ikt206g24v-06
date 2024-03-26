﻿using Example.Models;

namespace Example.Data
{
    public static class ApplicationDbInitializer
    {
        public static void Initialize(ApplicationDbContext db)
        {
            

            // Add test data to simplify debugging and testing

            var authors = new[]
            {
                new Author("Author 1", "Author 1", DateTime.SpecifyKind(new DateTime(1981, 1, 1), DateTimeKind.Utc)),
                new Author("Author 2", "Author 2", DateTime.SpecifyKind(new DateTime(1982, 2, 2), DateTimeKind.Utc)),
                new Author("Author 3", "Author 3", DateTime.SpecifyKind(new DateTime(1983, 3, 3), DateTimeKind.Utc))
            };
            
            db.Authors.AddRange(authors);

            // Finally save the added relationships
            db.SaveChanges();
        }
    }
}
