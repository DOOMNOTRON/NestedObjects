using NestedObjects;

Advisor compScienceAdvisor = new Advisor()
{
    SchoolEmail = "Annemarie@cptc.edu",
    FirstName = "Annemarie",
    LastName = "Smith",
    OfficeLocation = "B17 Room 150"
};

Student student1 = new Student()
{
    FirstName = "Homer",
    LastName = "Simpson",
    DateOfBirth = new DateOnly(2000, 3, 20),
    AssignedAdvisor = compScienceAdvisor,
    PhoneNumber = "2531234567",
    SchoolEmail = "Homer.Simpson@students.cptc.edu"
};

Console.WriteLine($"Student: {student1.FirstName} {student1.LastName} has {student1.AssignedAdvisor.FirstName} {student1.AssignedAdvisor.LastName} as an advisor.");
