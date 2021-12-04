using FinalProj.Interfaces;
using FinalProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProj.Data
{
    public class Group_Context_DAO : IGroup_Context_DAO
    {
        private Group_Members_Context _context;

        public Group_Context_DAO(Group_Members_Context context)
        {
            _context = context;
        }

        public int? Add(Group_Members member)
        {
            var members = _context.GroupMembers.Where(x => x.TeamMemberName.Equals(member.TeamMemberName)).FirstOrDefault();
            if (members != null)
            {
                return null;
            }
            else
            {
                try
                {
                    _context.GroupMembers.Add(member);
                    _context.SaveChanges();
                    return 1;
                }
                catch (Exception)
                {
                    return 0;
                }
            }
        }

        public List<Group_Members> GetAllMembers()
        {
            return _context.GroupMembers.ToList();
        }

        public Group_Members GetMemberById(int id)
        {
            return _context.GroupMembers.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public int? RemoveMemberById(int id)
        {
            var member = this.GetMemberById(id);
            if (member == null)
            {
                return null;
            }
            else
            {
                try
                {
                    _context.GroupMembers.Remove(member);
                    _context.SaveChanges();
                    return 1;
                }
                catch (Exception)
                {
                    return 0;
                }
            }
        }

        public int? UpdateMember(Group_Members member)
        {
            var memberToUpdate = this.GetMemberById(member.Id);
            if (memberToUpdate == null)
            {
                return null;
            }
            else
            {
                memberToUpdate.Id = member.Id;
                memberToUpdate.TeamMemberName = member.TeamMemberName;
                memberToUpdate.Birthdate = member.Birthdate;
                memberToUpdate.CollegeProgram = member.CollegeProgram;
                memberToUpdate.YearInProgram = member.YearInProgram;
                try
                {
                    _context.GroupMembers.Update(memberToUpdate);
                    _context.SaveChanges();
                    return 1;
                }
                catch (Exception)
                {
                    return 0;
                }
            }
        }

        public List<Group_Hobbies> GetAllHobbies()
        {
            return _context.GroupHobbies.ToList();
        }

        public Group_Hobbies GetHobbyById(int id)
        {
            return _context.GroupHobbies.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public int? DeleteHobbyById(int id)
        {
            var hobby = this.GetHobbyById(id);
            if (hobby == null)
                return null;
            else
            {
                try
                {
                    _context.GroupHobbies.Remove(hobby);
                    _context.SaveChanges();
                    return 1;
                }

                catch (Exception)
                {
                    return 0;
                }
            }
        }

        public int? UpdateHobbyById(Group_Hobbies hobby)
        {
            var hobbyToUpdate = this.GetHobbyById(hobby.Id);
            if (hobbyToUpdate == null)
                return null;

            else
            {
                hobbyToUpdate.Id = hobby.Id;
                hobbyToUpdate.HobbyName = hobby.HobbyName;
                hobbyToUpdate.StartYear = hobby.StartYear;
                hobbyToUpdate.Expensive = hobby.Expensive;
                hobbyToUpdate.TotalSpent = hobby.TotalSpent;

                try
                {
                    _context.GroupHobbies.Update(hobbyToUpdate);
                    _context.SaveChanges();
                    return 1;
                }

                catch (Exception)
                {
                    return 0;
                }
            }
        }

        public int? AddNew(Group_Hobbies hobby)
        {
            var hobbies = _context.GroupHobbies.Where(x => x.HobbyName.Equals(hobby.HobbyName)).FirstOrDefault();
            if (hobbies != null)
            {
                return null;
            }
            else
            {
                try
                {
                    _context.GroupHobbies.Add(hobby);
                    _context.SaveChanges();
                    return 1;
                }
                catch (Exception)
                {
                    return 0;
                }
            }
        }


        public int? Add(Course course)
        {
            var courses = _context.Course.Where(x => x.Id.Equals(course.Id)).FirstOrDefault();

                try
                {
                    _context.Course.Add(course);
                    _context.SaveChanges();
                    return 1;
                }
                catch (Exception)
                {
                    return 0;
                }

        }
        public List<Course> GetAllCourses()
        {
            return _context.Course.ToList();
        }

        public Course GetCourseByID(int id)
        {
            return _context.Course.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public int? RemoveCourseByID(int id)
        {
            var course = this.GetCourseByID(id);
            if (course == null)
            {
                return null;
            }
            else
            {
                try
                {
                    _context.Course.Remove(course);
                    _context.SaveChanges();
                    return 1;
                }
                catch (Exception)
                {
                    return 0;
                }
            }
        }

        public int? UpdateCourse(Course course)
        {
            var updatedCourse = this.GetCourseByID(course.Id);
            if (updatedCourse == null)
            {
                return null;
            }
            else
            {
                updatedCourse.Id = course.Id;
                updatedCourse.FavoriteITSubject = course.FavoriteITSubject;
                updatedCourse.FavoriteLanguage = course.FavoriteLanguage;
                updatedCourse.YearsInIT = course.YearsInIT;
                updatedCourse.CareerGoal = course.CareerGoal;
                try
                {
                    _context.Course.Update(updatedCourse);
                    _context.SaveChanges();
                    return 1;
                }
                catch (Exception)
                {
                    return 0;
                }
            }
        }

        public List<FavFood> GetAllFoods()
        {
            return _context.FavFoods.ToList();
        }

        public FavFood GetFoodById(int id)
        {
            return _context.FavFoods.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public int? RemoveFoodById(int id)
        {
            var food = this.GetFoodById(id);
            if (food == null)
            {
                return null;
            }
            else
            {
                try
                {
                    _context.FavFoods.Remove(food);
                    _context.SaveChanges();
                    return 1;
                }
                catch (Exception)
                {
                    return 0;
                }
            }
        }

        public int? UpdateFood(FavFood food)
        {
            var updatedFood = this.GetFoodById(food.Id);
            if (updatedFood == null)
            {
                return null;
            }
            else
            {
                updatedFood.Id = food.Id;
                updatedFood.FavoriteFood = food.FavoriteFood;
                updatedFood.SecondFav = food.SecondFav;
                updatedFood.LeastFav = food.LeastFav;
                updatedFood.MealOfTheDay = food.MealOfTheDay;
                try
                {
                    _context.FavFoods.Update(updatedFood);
                    _context.SaveChanges();
                    return 1;
                }
                catch (Exception)
                {
                    return 0;
                }
            }
        }

        public int? AddFood(FavFood food)
        {
            var foods = _context.FavFoods.Where(x => x.Id.Equals(food.Id)).FirstOrDefault();

            try
            {
                _context.FavFoods.Add(food);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }

}