namespace _20241103
{
    internal class Student
    {
        private string? _name;
        private int _age;
        private string? _university;

        internal Student()
        {
        }

        internal Student(string name)
        {
            Name = name;
        }

        internal Student(string name, int age, string university, Group group) : this(name)
        {
            Age = age;
            Group = group;
            University = university;
        }


        internal string? Name
        {
            get { return _name; }
            set
            {
                if (value?.Length > 0 && value?.Length <= 50)
                {
                    _name = value;
                }

            }
        }

        internal int Age
        {
            get { return _age; }
            set
            {
                if (value >= 10 && value <= 65)
                {
                    _age = value;
                }
            }
        }

        internal string? University
        {
            get { return _university; }
            set
            {
                if (value?.Length > 0 && value?.Length <= 250 && value.Contains("University"))
                {
                    _university = value;
                }
            }
        }

        internal Group Group { get; set; }

        public string GetStudentInfo()
        {
            return $"Student {Name} is {Age} yo, he is studying in {University} at the {Group.ToString().ToLower()} group.";
        }

    }

    internal enum Group
    {
        first = 1,
        second,
        third
    }


}
