using Domain.Models;
using Infrastructure.Services;

var courseServices = new CourseService();
int counter = 1;
    Console.WriteLine("what do you want to do:  stop, show, update, delete, insert");
while (true)
{
    string option = Console.ReadLine();
    if (option == "stop") break;

    _ = option switch
    {
        "show" => Show(),
        "update" => Update(),
        "delete" => Delete(),
        "insert" => Insert(),
        _ => false,
    };
}

bool Show()
{
    var courses = courseServices.GetCourses();
    Console.WriteLine($"     Id       Title     Description          Fee:        HasDiscount: ");
    foreach (var st in courses)
    {
        Console.WriteLine($"     {st.Id}       {st.Title}     {st.Description}          {st.Fee}        {st.HasDiscount}");
    }
    return true;
}
bool Insert()
{
    var course = new Course(counter);
    Console.Write("Your Title: ");
    course.Title = Console.ReadLine();

    Console.Write("Your Description: ");
    course.Description = Console.ReadLine();

    Console.Write("Your Fee: ");
    course.Fee = Convert.ToDecimal(Console.ReadLine());

    Console.Write("Your HasDiscount: ");
    course.HasDiscount =Convert.ToBoolean(Console.ReadLine());

    courseServices.AddCourses(course);
    counter++;

    return true;

}
bool Update()
{
    Console.Write("Course Id: ");
    int id = Convert.ToInt32(Console.ReadLine());
    var course = new Course(id);

    Console.WriteLine("what do you want to change: title, description, fee, discount");
    string updatee = Console.ReadLine();
    switch (updatee)
    {
        case "title":
            Console.Write("Your Update Title: ");
            course.Title = Console.ReadLine();
            courseServices.UpdateStudent(course); 
            break;
        case "description":
            Console.Write("Your Update Description: ");
            course.Description = Console.ReadLine();
            courseServices.UpdateStudent(course); 
            break;
        case "fee":
            Console.Write("Your Update Fee: ");
            course.Fee = Convert.ToDecimal(Console.ReadLine());
            courseServices.UpdateStudent(course); 
            break;
        case "discount":
            Console.Write("Your Update HasDiscount: ");
            course.HasDiscount = Convert.ToBoolean(Console.ReadLine());
            courseServices.UpdateStudent(course); 
            break;

    }
    courseServices.UpdateStudent(course);
    return true;
    
}

bool Delete()
{
    Console.Write("Course Id: ");
    int id = Convert.ToInt32(Console.ReadLine());
    courseServices.Delete(id);
    return true;
}



