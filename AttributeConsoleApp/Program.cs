// See https://aka.ms/new-console-template for more information

using CustomAttributeExample;

Student s1 = new Student();
s1.Name = "John";
s1.Surname = "Doe";
s1.Department = "Computer Science";
s1.DateOfBirth = "01/01.1990";

bool validateRequired = ReqiredControl.Validate(s1);

if (!validateRequired)
{
    Console.WriteLine("Reqiured Field cannot be empty");
}
else if (!DateFormatControl.Validate(s1))
{
    Console.WriteLine("Date format is not valid. Must be 'dd/MM/yyyy'");
}
else
{
    Console.WriteLine($"Name :{s1.Name} Surname: {s1.Surname} Department: {s1.Department} Date: {s1.DateOfBirth}");
}
