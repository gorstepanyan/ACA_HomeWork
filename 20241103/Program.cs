using _20241103;

var student = new Student()
{
    Name = "John",
    Age = 20,
    University = "University of Yerevan",
    Group = Group.second,
};

var student1 = new Student("Gor", 56, "University of Goris", Group.third);


Console.WriteLine(student.GetStudentInfo());
Console.WriteLine(student1.GetStudentInfo());