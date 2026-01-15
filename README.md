# School as a project
A C# console application for managing students in schools. Add, view, and delete students from the school list.
Project Structure
Main Classes
Student - class representing a student:

Properties: First Name, Last Name, Age

Constructor for initializing student data

School - class representing a school:

Properties: School Name, List of Students

Methods:

AddNewStudent() - adds a new student

PrintStudents() - displays the list of students in table format

BanStudents() - removes a student by sequential number

Program - main class with entry point:

Implements an interactive menu for school management

Handles user input

Functionality
Core Features:
✅ Create a school with a custom name

✅ Add new students (first name, last name, age)

✅ View all students in a formatted table

✅ Remove students by sequential number

✅ Input validation when removing students

✅ Interactive menu with continuous execution

Implementation Details:
Uses List<Student> collection for storing students

Formatted table output for student data

Protection against invalid input when removing students

Localized messages in Russian

Technical Details
Requirements:
.NET Framework or .NET Core

Console application

Data Structure:
text
School
├── Name
└── List of Students
    ├── Student 1
    │   ├── First Name
    │   ├── Last Name
    │   └── Age
    └── Student N...
