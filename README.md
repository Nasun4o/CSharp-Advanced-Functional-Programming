# CSharp-Advanced-Functional-Programming
Advanced CSharp

Problem 1.	Class Student
Create a class Student with properties FirstName, LastName, Age, FacultyNumber, Phone, Email, Marks (IList<int>), GroupNumber. Create a List<Student> with sample students. These students will be used for the next few tasks.

Problem 2.	Students by Group
Print all students from group number 2. Use a LINQ query. Order the students by FirstName.

Problem 3.	Students by First and Last Name
Print all students whose first name is before their last name alphabetically. Use a LINQ query.

Problem 4.	Students by Age
Write a LINQ query that finds the first name and last name of all students with age between 18 and 24. The query should return only the first name, last name and age.

Problem 5.	Sort Students
Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order. Rewrite the same with LINQ query syntax.

Problem 6.	Filter Students by Email Domain
Print all students that have email @abv.bg. Use LINQ.

Problem 7.	Filter Students by Phone
Print all students with phones in Sofia (starting with 02 / +3592 / +359 2). Use LINQ.

Problem 8.	Excellent Students
Print all students that have at least one mark Excellent (6). Using LINQ first select them into a new anonymous class that holds { FullName + Marks}.

Problem 9.	Weak Students
Write a similar program to the previous one to extract the students with exactly two marks "2". Use extension methods.

Problem 10.	Students Enrolled in 2014
Extract and print the Marks of the students that enrolled in 2014 (the students from 2014 have 14 as their 5-th and 6-th digit in the FacultyNumber).
