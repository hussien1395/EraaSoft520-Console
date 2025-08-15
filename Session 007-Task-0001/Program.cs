using System.Collections.Specialized;
using System.Runtime.CompilerServices;

namespace Session_007_Task_0001
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            List<Instructor> allInstructors = new List<Instructor>();
            List<Course> allCourses = new List<Course>();
            List<Student> allStudents = new List<Student>();

            // Instructors
            Instructor instructor1 = AddInstructor();
            allInstructors.Add(instructor1);

            Instructor instructor2 = AddInstructor();
            allInstructors.Add(instructor2);

            // Courses
            Course course1 = AddCourse(instructor1);
            allCourses.Add((Course)course1);

            Course course2 = AddCourse(instructor1);
            allCourses.Add((Course)course2);

            // Students
            Student student1 = AddStudent(new List<Course>());
            allStudents.Add(student1);

            Student student2 = AddStudent(new List<Course>());
            allStudents.Add(student2);

            EnrollStudentInCourse(allStudents, allCourses);
            DisplayAllInstructor(allInstructors);
            DisplayAllCourse(allCourses);
            DisplayAllStudent(allStudents);

            Console.WriteLine("Enter student ID to Search");
            int stdID = Convert.ToInt32(Console.ReadLine());
            var student= SearchStudentById(allStudents, stdID);
            DisplayStudent(student);

            UpdateStudent(allStudents, allCourses);
            DisplayAllStudent(allStudents);

            DeleteStudent(allStudents);
            DisplayAllStudent(allStudents);

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

            return instructor;
        }

        public static Course AddCourse(Instructor instructor)
        {
            Console.WriteLine("Add Course");
            Console.WriteLine("Enter course id:");
            int CourseId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter course title:");
            string CourseTitle = Console.ReadLine();

            Course course = new Course
            {
                CourseId = CourseId,
                Title = CourseTitle,
                Instructor = instructor 
            };
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

        public static Student SearchStudentById(List<Student> students, int id)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].StudentId == id)
                    return students[i];
            }
            return null;
        }

        public static bool UpdateStudent(List<Student> students, List<Course> allCourses)
        {
            Console.WriteLine("Please enter student ID to update information");
            int stdID = Convert.ToInt32(Console.ReadLine());

            var student = SearchStudentById(students, stdID);
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
            Console.WriteLine("Please enter student ID to delete:");
            int stdID = Convert.ToInt32(Console.ReadLine());

            var student = SearchStudentById(students, stdID);
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
