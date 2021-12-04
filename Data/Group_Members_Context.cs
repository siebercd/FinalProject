using Microsoft.EntityFrameworkCore;
using System;
using FinalProj.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProj.Data
{
    public class Group_Members_Context : DbContext
    {
        public Group_Members_Context(DbContextOptions<Group_Members_Context> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Group_Members>().HasData(
                new Group_Members { Id = 1, TeamMemberName = "Riley Setser", Birthdate = new DateTime(2001, 8, 17), CollegeProgram = "Software Development", YearInProgram = "Sophomore" },
                new Group_Members { Id = 2, TeamMemberName = "JP Kelczewski", Birthdate = new DateTime(2001, 10, 13), CollegeProgram = "Software Development", YearInProgram = "Sophomore" },
                new Group_Members { Id = 3, TeamMemberName = "Chris Royce", Birthdate = new DateTime(1976, 12, 23), CollegeProgram = "Software Development/Game Design", YearInProgram = "Junior" },
                new Group_Members { Id = 4, TeamMemberName = "Cooper Siebert", Birthdate = new DateTime(1997, 10, 27), CollegeProgram = "Software Development", YearInProgram = "Junior" });

            builder.Entity<Group_Hobbies>().HasData(
                new Group_Hobbies { Id = 1, HobbyName = "Music Producing", StartYear = 2017, Expensive = "Yes", TotalSpent = 500 },
                new Group_Hobbies { Id = 2, HobbyName = "Golf", StartYear = 2018, Expensive = "Yes", TotalSpent = 300 },
                new Group_Hobbies { Id = 3, HobbyName = "Gaming", StartYear = 1995, Expensive = "Yes", TotalSpent = 5000 },
                new Group_Hobbies { Id = 4, HobbyName = "Gaming", StartYear = 2010, Expensive = "Yes", TotalSpent = 2000 });
            
            builder.Entity<Course>().HasData(
                new Course { Id = 1, FavoriteITSubject = "Programming", FavoriteLanguage = "C#", YearsInIT = "2", CareerGoal = "Yes" },
                new Course { Id = 2, FavoriteITSubject = "Programming", FavoriteLanguage = "C#", YearsInIT = "2", CareerGoal = "Yes" },
                new Course { Id = 3, FavoriteITSubject = "Human Computer Interaction", FavoriteLanguage = "C#", YearsInIT = "25", CareerGoal = "Software Analyst" },
                new Course { Id = 4, FavoriteITSubject = "Database Management", FavoriteLanguage = "C#", YearsInIT = "3", CareerGoal = "QA/Dev" });

            builder.Entity<FavFood>().HasData(
                new FavFood { Id = 1, FavoriteFood = "Hamburgers", SecondFav = "Breakfast Sandwich", LeastFav = "Tomato", MealOfTheDay = "Dinner"},
                new FavFood { Id = 2, FavoriteFood = "Chipotle Burrito", SecondFav = "Bosco Sticks", LeastFav = "Cupcakes", MealOfTheDay = "Breakfast"},
                new FavFood { Id = 3, FavoriteFood = "Chicken and Broccoli Alfredo", SecondFav = "Shrimp Scampi", LeastFav = "Hot Dogs", MealOfTheDay = "Dinner"},
                new FavFood { Id = 4, FavoriteFood = "Chicken Wings", SecondFav = "Burgers", LeastFav = "Sushi", MealOfTheDay = "Lunch"});
          
    }

        public DbSet<Group_Members> GroupMembers { get; set; }

        public DbSet<Group_Hobbies> GroupHobbies { get; set; }

        public DbSet<Course> Course { get; set; }

        public DbSet<FavFood> FavFoods { get; set; }
    }



}
