﻿using MathWizzz.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathWizzz
{
    public class StudentDB
    {
        public static Student GetStudentById(int studentId)
        {
            SqlConnection connection = MathWizzDB.GetConnection();
            string selectStatement = "SELECT SkillLevel, ClassId, UserId, FirstName, LastName, UserRole" +
                " from Users INNER JOIN StudentInfo ON Users.UserId = StudentInfo.StudentId  WHERE UserId = @StudentId";
            
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@StudentId", studentId);
            try
            {
                connection.Open();
                SqlDataReader studentReader = selectCommand.ExecuteReader();
                if (studentReader.Read())
                {
                    Student student = new Student();
                    student.StudentLevel = (int)studentReader["SkillLevel"];
                    student.ClassID = (int)studentReader["ClassId"];
                    student.UserId = (int)studentReader["UserId"];
                    student.FirstName = studentReader["FirstName"].ToString();
                    student.LastName = studentReader["LastName"].ToString();
                    student.UserRole = studentReader["UserRole"].ToString();
                    
                    return student;
                }
                else
                {
                    return null;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        // We will need to change the class ID it is set to 0 now since we do not have this set up yet.
        public static bool AddToStudentInfo(string commandText)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                try
                {
                    cmd.CommandText += commandText;
                    cmd.Connection = MathWizzDB.GetConnection();
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                    return true;
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }
        }

        // When the student log in this function will check the username and password
        // If the account exist it return a student object.

        public static Student StudentLogin(string username, string password)
        {
            SqlConnection connection = MathWizzDB.GetConnection();
            string selectStatement = " SELECT UserId " +
                ", FirstName, LastName, UserName, Password, UserRole  FROM Users " +
                " WHERE (UserName = @username) AND (Password = @password) ";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.AddWithValue("@username", username);
            selectCommand.Parameters.AddWithValue("@password", password);

            try
            {
                connection.Open();
                SqlDataReader studentReader = selectCommand.ExecuteReader(System.Data.CommandBehavior.SingleRow);

                if (studentReader.HasRows)
                {
                    if (studentReader.Read())
                    {
                        Student student = new Student();
                        student.firstName = studentReader["FirstName"].ToString();
                        student.lastName = studentReader["LastName"].ToString();
                        student.username = studentReader["UserName"].ToString();
                        student.password = studentReader["Password"].ToString();
                        student.userRole = studentReader["UserRole"].ToString();
                        student.UserId = (int)studentReader["UserId"];


                        return student;

                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public static Student GetStudentInfo(int studentId)
        {
            SqlConnection connection = MathWizzDB.GetConnection();
            string selectStatement = " SELECT UserId " +
                ", FirstName, LastName, UserName, Password, UserRole,SkillLevel, ClassId  FROM Users JOIN StudentInfo ON Users.UserId = StudentInfo.StudentId " +
                " WHERE (UserId = @studentId)";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.AddWithValue("@studentId", studentId);
           

            try
            {
                connection.Open();
                SqlDataReader studentReader = selectCommand.ExecuteReader(System.Data.CommandBehavior.SingleRow);

                if (studentReader.HasRows)
                {
                    if (studentReader.Read())
                    {
                        Student student = new Student();
                        student.firstName = studentReader["FirstName"].ToString();
                        student.lastName = studentReader["LastName"].ToString();
                        student.username = studentReader["UserName"].ToString();
                        student.password = studentReader["Password"].ToString();
                        student.userRole = studentReader["UserRole"].ToString();
                        student.UserId = (int)studentReader["UserId"];
                        student.StudentLevel = (int)studentReader["SkillLevel"];
                        student.ClassID = (int)studentReader["ClassId"];


                        return student;

                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool GivePointsToStudent(Student student, int rewardPoints)
        {
            bool success = false;
            SqlConnection connection = MathWizzDB.GetConnection();
            SqlCommand command = new SqlCommand("INSERT INTO StudentInfo(RewardPoints) " +
                                                "VALUES(@RewardPoints) " +
                                                "WHERE StudentId = @StudentId");

            command.Parameters.AddWithValue("@RewardPoints", rewardPoints);
            try
            {
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                command.Connection.Close();
            }

            return success;
        }

        public static bool AssignClassToStudent(Student student, int classId)
        {
            bool success = false;
            SqlConnection connection = MathWizzDB.GetConnection();
            SqlCommand command = new SqlCommand("INSERT INTO StudentInfo(ClassId) " +
                                                "VALUES('@ClassId') " +
                                                "WHERE StudentId = @StudentId");

            command.Parameters.AddWithValue("@ClassId", classId);
            try
            {
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                command.Connection.Close();
            }

            return success;
        }

        public static bool UpdatePassword(string newPassword,int studentId)
        {
            bool success = false;
            
            SqlConnection connection = MathWizzDB.GetConnection();
            string command = ("UPDATE Users " +
                              "SET Password = @newPassword " +
                              "WHERE UserId = @studentId");
            SqlCommand updateCommand = new SqlCommand(command, connection);

            updateCommand.Parameters.AddWithValue("@studentId", studentId);
            updateCommand.Parameters.AddWithValue("@newPassword", newPassword);
            
            try
            {
                connection.Open();
                int rowAffected = updateCommand.ExecuteNonQuery();

                success = true;
                return success;

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

            return success;
        }

        public static List<ActivityHistory> GetActivityHistory(int studentId)
        {
            var history = new List<ActivityHistory>();
            SqlConnection connection = MathWizzDB.GetConnection();
            string selectStatement = " SELECT DateTime " +
                ", TotalQuestions, CorrectAnswers, SkillLevel, ActivityType  FROM ActivityHistory " +
                " WHERE (StudentId = @studentId) ";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@studentId", studentId);
            try
            {
                connection.Open();
                using (SqlDataReader studentReader = selectCommand.ExecuteReader())
                {
                    while (studentReader.Read())
                    {

                        ActivityHistory activity = new ActivityHistory();
                        activity.DateTime = (DateTime)studentReader["DateTime"];
                        activity.NumberOfQuestions = (int)studentReader["TotalQuestions"];
                        activity.NumberOfCorrectAnswers = (int)studentReader["CorrectAnswers"];
                        activity.SkillLevel = (int)studentReader["SkillLevel"];
                        activity.ActivityType = studentReader["ActivityType"].ToString();

                        history.Add(activity);

                        //   return activity;
                    }; 
                };
                                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return history;
        }
    }
}

