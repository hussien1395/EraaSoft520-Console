using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Session_007_Task_0001
{
    internal class Program
    {
        public static List<Instructor> allInstructors = new List<Instructor>();
        public static List<Course> allCourses = new List<Course>();
        public static List<Student> allStudents = new List<Student>();

        static void Main(string[] args)
        {

            int option;

            do
            {
                PrintMenu();
                option = SelectOption();

                switch (option)
                {
                    case 1:
                        AddStudent(new List<Course>());
                        break;
                    case 2:
                        AddInstructor();
                        break;
                    case 3:
                        AddCourse(allInstructors);
                        break;
                    case 4:
                        EnrollStudentInCourse(allStudents, allCourses);
                        break;
                    case 5:
                        DisplayAllStudent(allStudents);
                        break;
                    case 6:
                        DisplayAllCourse(allCourses);
                        break;
                    case 7:
                        DisplayAllInstructor(allInstructors);
                        break;
                    case 8:
                        var std= SearchStudentById(allStudents);
                        DisplayStudent(std);
                        break;
                    case 9:
                        var course= SearchCourseById(allCourses);
                        DisplayCourse(course);
                        break;
                    case 10:
                        DeleteStudent(allStudents);
                        break;
                    case 11:
                        UpdateStudent(allStudents, allCourses);
                        break;
                    case 12:
                        break;
                    default:
                        Console.WriteLine("Unknown selection, please try again");
                        Console.WriteLine("<<<---------------------------------------->>>");
                        break;
                }
            } while (option != 12);
        }

        static int SelectOption()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        public static void PrintMenu()
        {
            Console.WriteLine(" 1.Add Student");
            Console.WriteLine(" 2.Add Instructor");
            Console.WriteLine(" 3.Add Course");
            Console.WriteLine(" 4.Enroll Student in Course");
            Console.WriteLine(" 5.Show All Students");
            Console.WriteLine(" 6.Show All Courses");
            Console.WriteLine(" 7.Show All Instructors");
            Console.WriteLine(" 8.Find the student by id or name");
            Console.WriteLine(" 9.Fine the course by id or name");
            Console.WriteLine(" 10.Delete Student");
            Console.WriteLine(" 11.Update Student");
            Console.WriteLine(" 12.Exit");
        }

        public static Instructor AddInstructor()
        {
            Console.WriteLine("Add Instructor");
            Console.WriteLine("Enter instructor id:");
            int InstructorId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter instructor name:");
            string InstructorName = Console.ReadLine();
            Console.WriteLine("Enter instructor specialization:");
            string InstructorSpecialization = Console.ReadLine();

            Instructor instructor = new Instructor
            {
                InstructorId = InstructorId,
                Name = InstructorName,
                Specialization = InstructorSpecialization
            };

            allInstructors.Add(instructor);
            return instructor;
        }

        public static Course AddCourse(List<Instructor> instructors)
        {
            Console.WriteLine("Add Course");
            Console.WriteLine("Enter course id:");
            int CourseId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter course title:");
            string CourseTitle = Console.ReadLine();

            Console.WriteLine("Select Instructor for this course:");
            for (int i = 0; i < instructors.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {instructors[i].Name} (ID: {instructors[i].InstructorId})");
            }

            int instructorChoice = Convert.ToInt32(Console.ReadLine()) - 1;
            Instructor selectedInstructor = instructors[instructorChoice];

            Course course = new Course
            {
                CourseId = CourseId,
                Title = CourseTitle,
                Instructor = selectedInstructor
            };

            allCourses.Add(course);
            return course;
        }

        public static Student AddStudent(List<Course> courses)
        {
            Console.WriteLine("Add Student");
            Console.WriteLine("Enter student id:");
            int StudentId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter student name:");
            string StudentName = Console.ReadLine();
            Console.WriteLine("Enter student age:");
            int StudentAge = Convert.ToInt32(Console.ReadLine());

            Student student = new Student
            {
                StudentId = StudentId,
                Name = StudentName,
                Age = StudentAge,
                Courses = courses
            };

            allStudents.Add(student);
            return student;
        }

        public static void DisplayAllInstructor(List<Instructor> instructors)
        {
            foreach (var instructor in instructors)
            {
                Console.WriteLine("<<< Instructor >>>");
                Console.WriteLine($"Instructor ID: {instructor.InstructorId}");
                Console.WriteLine($"Name: {instructor.Name}");
                Console.WriteLine($"Specialization: {instructor.Specialization}");
            }
        }

        public static void DisplayAllCourse(List<Course> courses)
        {
            foreach (var course in courses)
            {
                Console.WriteLine("<<< Course >>>");
                Console.WriteLine($"Course ID: {course.CourseId}");
                Console.WriteLine($"Course Name: {course.Title}");
                Console.WriteLine($"Instructor Name: {course.Instructor.Name}");
            }
        }

        public static void DisplayAllStudent(List<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine("<<< Student >>>");
                Console.WriteLine($"Student ID: {student.StudentId}");
                Console.WriteLine($"Name: {student.Name}");
                Console.WriteLine($"Age: {student.Age}");
                Console.WriteLine("Courses:");
                foreach (var courseItem in student.Courses)
                {
                    Console.WriteLine($"- {courseItem.Title}");
                }
            }
        }

        public static void DisplayCourse(Course course)
        {
            Console.WriteLine("<<< Course >>>");
            Console.WriteLine($"Course ID: {course.CourseId}");
            Console.WriteLine($"Title: {course.Title}");
            Console.WriteLine($"Instructor Name: {course.Instructor.Name}");
        }

        public static void DisplayStudent(Student student)
        {
            Console.WriteLine("<<< Student >>>");
            Console.WriteLine($"Student ID: {student.StudentId}");
            Console.WriteLine($"Name: {student.Name}");
            Console.WriteLine($"Age: {student.Age}");
            Console.WriteLine("Courses:");
            foreach (var courseItem in student.Courses)
            {
                Console.WriteLine($"- {courseItem.Title}");
            }
        }

        public static Student SearchStudentById(List<Student> students)
        {
            Console.WriteLine("Enter student ID to Search");
            int stdID = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].StudentId == stdID)
                    return students[i];
            }
            return null;
        }

        public static Course SearchCourseById(List<Course> courses)
        {
            Console.WriteLine("Enter course ID to Search");
            int courseID = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < courses.Count; i++)
            {
                if (courses[i].CourseId == courseID)
                    return courses[i];
            }
            return null;
        }

        public static bool UpdateStudent(List<Student> students, List<Course> allCourses)
        {
            var student = SearchStudentById(students);
            if (student == null)
            {
                Console.WriteLine("Student not found.");
                return false;
            }

            Console.WriteLine("Enter new name");
            string newStdName = Console.ReadLine();

            Console.WriteLine("Enter new age");
            int newStdAge   = Convert.ToInt32(Console.ReadLine());

            student.Name = newStdName;
            student.Age = newStdAge;
            student.Courses.Clear();

            // Display list of available courses
            Console.WriteLine("Select a course to enroll in:");
            for (int i = 0; i < allCourses.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {allCourses[i].Title} (ID: {allCourses[i].CourseId})");
            }
            int courseChoice = Convert.ToInt32(Console.ReadLine()) -1;

            if (courseChoice < 0 || courseChoice >= allCourses.Count)
            {
                Console.WriteLine("Invalid course selection.");
                return false;
            }

            // Enroll the selected student in the selected course
            student.Courses.Add(allCourses[courseChoice]);
            Console.WriteLine($"Student {student.Name} (ID: {student.StudentId}) has been updated.");
            return true;
        }

        public static bool DeleteStudent(List<Student> students)
        {
            var student = SearchStudentById(students);
            if (student == null)
            {
                Console.WriteLine("Student not found.");
                return false;
            }

            students.Remove(student);
            Console.WriteLine($"Student {student.Name} (ID: {student.StudentId}) has been deleted.");
            return true;
        }

        public static void EnrollStudentInCourse(List<Student> students, List<Course> courses)
        {
            Console.WriteLine("Enroll Student in Course");

            // Display list of students
            Console.WriteLine("Select a student to enroll:");
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {students[i].Name} (ID: {students[i].StudentId})");
            }
            int studentChoice = Convert.ToInt32(Console.ReadLine()) - 1;

            // Display list of available courses
            Console.WriteLine("Select a course to enroll in:");
            for (int i = 0; i < courses.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {courses[i].Title} (ID: {courses[i].CourseId})");
            }
            int courseChoice = Convert.ToInt32(Console.ReadLine()) - 1; 

            // Enroll the selected student in the selected course
            students[studentChoice].Courses.Add(courses[courseChoice]);
            Console.WriteLine($"{students[studentChoice].Name} has been enrolled in {courses[courseChoice].Title}.");
        }
    }

    class Instructor
    {
        public int InstructorId { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }
    }

    class Course : Instructor
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public Instructor Instructor { get; set; }
    }

    class Student : Course
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Course> Courses { get; set; }
    }

    class StudentManager
    {
        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; }
        public List<Instructor> Instructors { get; set; }

    }
} 
