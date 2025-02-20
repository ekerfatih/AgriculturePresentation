using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DataAccessLayer.Context {
    public class AgricultureContext : DbContext {

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Team> Teams { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        //    optionsBuilder.UseSqlite("Data Source=C:\Users\fatih\Github Repo\AgriculturePresentation\DataAccessLayer\AgricultureDb.db");
        //}
        public List<string> GetTableNames() {
            var tableNames = new List<string>();
            var connection = Database.GetDbConnection();
            connection.Open();

            using (var command = connection.CreateCommand()) {
                command.CommandText = "SELECT * FROM sqlite_master WHERE type = 'table'";
                using (var reader = command.ExecuteReader()) {
                    while (reader.Read()) {
                        tableNames.Add(reader.GetString(0));
                    }
                }
            }

            connection.Close();
            return tableNames;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder
                .UseSqlite("Data Source=C:\\Users\\fatih\\Github Repo\\AgriculturePresentation\\DataAccessLayer\\AgricultureDb.db")
                .LogTo(Console.WriteLine, LogLevel.Information);
        }

    }
}
