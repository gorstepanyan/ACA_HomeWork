namespace _20241103
{
    internal class Student
    {
        private string _name;
        private int _age;
        private string _university;
        private Group _group;

        public Student()
        {

        }

        public Student(string name, int age, string university, Group group)
        {
            Name = name;
            Age = age;
            Group = group;
            University = university;
        }


        internal string Name
        {
            get { return _name; }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("Name should be less than equal to 50");
                }
                _name = value;
            }
        }

        internal int Age
        {
            get { return _age; }
            set
            {
                if (value < 10 || value > 65)
                {
                    throw new ArgumentException("Age should be between 10 and 65");
                }
                _age = value;
            }
        }

        internal string University
        {
            get { return _university; }
            set
            {
                if (value.Length > 250 || !value.Contains("University"))
                {
                    throw new ArgumentException("University should be less than equal to 250 and have expression 'University'");
                }
                _university = value;
            }
        }

        internal Group Group { get; set; }

        public string GetStudentInfo()
        {
            return $"Student {_name} is {_age} yo, he is studying in {_university} at the {Group.ToString().ToLower()} group.";
        }

    }

    internal enum Group
    {
        first = 1,
        second,
        third
    }


}
