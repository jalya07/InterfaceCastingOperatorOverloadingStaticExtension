using System;
namespace StaticInterfaceOperatocOvverloading1
{
	public class Student
	{
		sing System.Text.RegularExpressions;

namespace StaticInterfaceOperatocOvverloading1
{
	public class Student
	{
		public string FullName { get; set; }
		public string GroupNo { get; set; }
		public int Age { get; set; }
        public Student(string fullname, string groupNo, int age)
        {
            if (!CheckFullname(fullname))
                throw new ArgumentException("Fullname должен содержать имя и фамилию, разделённые пробелом ");

            if (!CheckGroupNo(groupNo))
                throw new ArgumentException("GroupNo должен состоять из 1 заглавной буквы и 3 цифр ");

            if (age < 0)
                throw new ArgumentException("Возраст не может быть отрицательным.");

            FullName = fullname;
            GroupNo = groupNo;
            Age = age;
        }
        public static bool CheckFullname(string fullname)
        {
            if (string.IsNullOrWhiteSpace(fullname))
                return false;

            string[] parts = fullname.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length != 2)
                return false;

            bool firstNameValid = char.IsUpper(parts[0][0]);
            bool lastNameValid = char.IsUpper(parts[1][0]);

            return firstNameValid && lastNameValid;
        }
        public static bool CheckGroupNo(string groupNo)
        {
            if (string.IsNullOrWhiteSpace(groupNo))
                return false;

            return Regex.IsMatch(groupNo, @"^[A-Z]\d{3}$");
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Fullname: {FullName}");
            Console.WriteLine($"GroupNo: {GroupNo}");
            Console.WriteLine($"Age: {Age}");
        }

    }
}
	}
}

