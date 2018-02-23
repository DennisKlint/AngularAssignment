namespace AngularAssignment.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AngularAssignment.Models.AngularAssignmentDbManager>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AngularAssignment.Models.AngularAssignmentDbManager context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.People.AddOrUpdate(
                p => p.ID,
                new Person
                {
                    ID = 1,
                    PhoneNumber = 9628534,
                    FirstName = "Bob",
                    LastName = "The Builder",
                    Email = "Bob@BobTheBuilder.com",
                    Country = "America",
                    Picture = "~/Pictures/Bob-the-Builder.jpg"
                },
                new Person
                { 
                    ID = 2,
                    PhoneNumber = 9628565,
                    FirstName = "Steve",
                    LastName = "Stevington",
                    Email = "Steve@Stevington.com",
                    Country = "Sweden",
                    Picture = "~/Pictures/Pic1.jpg"
                },
                new Person
                {
                    ID = 3,
                    PhoneNumber = 9628577,
                    FirstName = "Kent",
                    LastName = "Stevington",
                    Email = "Kent@Stevington.com",
                    Country = "Sweden",
                    Picture = "~/Pictures/Pic3.jpg"
                },
                new Person
                {
                    ID = 4,
                    PhoneNumber = 9628698,
                    FirstName = "Anna",
                    LastName = "Saint",
                    Email = "Anna@SomeCompany.com",
                    Country = "Denmark",
                    Picture = "~/Pictures/Pic2.jpg"
                },
                new Person
                {
                    ID = 5,
                    PhoneNumber = 9628333,
                    FirstName = "Michael",
                    LastName = "Sten",
                    Email = "Michael@SomeCompany.com",
                    Country = "Germany",
                    Picture = "~/Pictures/Pic4.jpg"
                },
                new Person
                {
                    ID = 6,
                    PhoneNumber = 9629843,
                    FirstName = "Max",
                    LastName = "Power",
                    Email = "Max@SomeCompany.com",
                    Country = "America",
                    Picture = "~/Pictures/Pic5.jpg"
                },
                new Person
                {
                    ID = 7,
                    PhoneNumber = 9628560,
                    FirstName = "Kent",
                    LastName = "Skog",
                    Email = "Kent@SomeCompany.com",
                    Country = "France",
                    Picture = "~/Pictures/Pic6.jpg"
                },
                new Person
                {
                    ID = 8,
                    PhoneNumber = 7038218,
                    FirstName = "Max",
                    LastName = "Saint",
                    Email = "Max2@SomeCompany.com",
                    Country = "Sweden",
                    Picture = "~/Pictures/Pic7.jpg"
                }
                );
        }
    }
}
