using _20241103;

var student = new Student()
{
    Name = "John",
    Age = 20,
    University = "Universit of Yerevan",
    Group = Group.second,
};

var student1 = new Student("Gor", 56, "Universit of Goris", Group.third);

var student2 = new Student();
student2.Name = "Vruyr";
student2.Age = 43;
student2.Group = Group.first;


Console.WriteLine(student.GetStudentInfo());
Console.WriteLine(student1.GetStudentInfo());
Console.WriteLine(student2.GetStudentInfo());