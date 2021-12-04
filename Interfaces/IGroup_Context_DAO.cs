using FinalProj.Models;
using FinalProj.Data;
using System.Collections.Generic;


namespace FinalProj.Interfaces
{
    public interface IGroup_Context_DAO
    {
        List<Group_Members> GetAllMembers();
        Group_Members GetMemberById(int id);
        int? RemoveMemberById(int id);
        int? UpdateMember(Group_Members member);
        int? Add(Group_Members member);

        List<Group_Hobbies> GetAllHobbies();
        Group_Hobbies GetHobbyById(int id);
        int? DeleteHobbyById(int id);
        int? UpdateHobbyById(Group_Hobbies hobby);
        int? AddNew(Group_Hobbies hobby);

        List<Course> GetAllCourses();
        Course GetCourseByID(int id);
        int? RemoveCourseByID(int id);
        int? UpdateCourse(Course course);
        int? Add(Course course);

        List<FavFood> GetAllFoods();
        FavFood GetFoodById(int id);
        int? RemoveFoodById(int id);
        int? UpdateFood(FavFood food);
        int? AddFood(FavFood food);
    }

   
}
