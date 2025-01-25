# School Management System

## Overview

---

*The School Management System is a C# application designed to manage various aspects of a school, including student information, courses, and faculty. The system is built using .NET 8 and C# 12.0, leveraging object-oriented principles to create a robust and scalable solution.*

---

## Features

- Student Management: Add, update, and manage student information including personal details, grades, and enrolled courses.
- Course Management: Manage course information and track which students are enrolled in which courses.
- Faculty Management: Manage faculty information and track which courses they are teaching.

---

## Project Structure

The solution is organized into several classes, each representing a different entity within the school management system. Below is a brief description of the key components:

### Classes

- Person: An abstract base class that represents a person with common attributes such as first name, last name, age, and gender.
- Student: A class that inherits from Person and includes additional attributes specific to students, such as student ID, grade, and a list of courses.
- Faculty: A class that inherits from Person and includes additional attributes specific to faculty members, such as faculty ID and a list of courses they teach.
- Class: A class that represents a course, including the course name, a list of enrolled students, and the faculty member teaching the course.

### Main Program

In this method, several instances of Student, Faculty, and Class are created to simulate a school environment. The following actions are performed:

1. **Student Instances**: Instances of the Student class are created, representing both human and feline students with various attributes such as student ID, grade, courses, and personal details.
2. **Faculty Instances**: Instances of the Faculty class are created, representing faculty members with attributes such as faculty ID, courses they teach, and personal details.
3. **Class Instances**: Instances of the Class class are created, representing different courses with attributes such as course name, enrolled students, and the faculty member teaching the course.
4. **Method Calls**: Various methods are called to demonstrate the functionality of the system, such as printing student grades and simulating class meetings.
