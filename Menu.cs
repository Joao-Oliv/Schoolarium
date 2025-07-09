namespace Schoolarium;

public class Menu
{
    private Dictionary<string, List<int>> students = new Dictionary<string, List<int>>
    {
        { "1. Elis", new List<int> { 10, 10, 10, 10 } },
        { "2. João", new List<int> { 60, 50, 32, 88 } },
        { "3. Rogerinho", new List<int> { 30, 30, 30, 30 } },
        { "4. Manola", new List<int> { 70, 75, 77, 81 } }
    };
    
    public Menu()
    {
        Console.WriteLine("*******************************************");
        Console.WriteLine("Welcome to Schoolarium!");
        Console.WriteLine("System to manage the students grades");
        Console.WriteLine("*******************************************");
    }

    public void run()
    {
        int iterator = 0;

        do
        {
            Console.WriteLine("Please, choose an option: ");
            Console.WriteLine("1. Add a student");
            Console.WriteLine("2. List students");
            Console.WriteLine("3. Insert student's grades");
            Console.WriteLine("0. Bye");

            try
            {
                iterator = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                iterator = 99;
            }
            
            switch (iterator)
            {
                case 0:
                    
                    Console.WriteLine("Bye");
                    break;
                
                case 1:
                    
                    this.insertStudent();
                    break;
                
                case 2:
                    
                    this.listStudents();
                    break;
                
                case 3:
                    
                    this.insertStudentsGrades();
                    break;
                
                default:
                    
                    Console.WriteLine("Invalid Command, try again");
                    break;
            }
            
            
        } while (iterator != 0);
    }

    public void insertStudent()
    {
        Console.Clear();
        Console.WriteLine("Insert a new student: ");
        
        string studentName = Console.ReadLine();
        int index = students.Count() + 1;
        string listIndexData = index.ToString() + ". " + studentName; 
        
        students.Add(listIndexData, new List<int>());
        
        Console.WriteLine($"Student {studentName} has been added");
        Console.WriteLine("\nPress any key to continue");
        Console.ReadKey();
        Console.Clear();
    }

    public void listStudents()
    {
        Console.Clear();
        Console.WriteLine("List of students registered:");

        foreach (string name in students.Keys)
        {
            Console.WriteLine($"{name}");
        }
        
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
        Console.Clear();
    }

    public void insertStudentsGrades()
    {
        Console.Clear();
        Console.WriteLine("Please, choose the student: ");

        if (students.Count() > 1)
        {
            foreach (string name in students.Keys)
            {
                Console.WriteLine(name);
            }
        }
        else
        {   
            Console.WriteLine("No students registered");
        }

        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
        Console.Clear();
    }

    public void insertGrade()
    {
        int index = Convert.ToInt32(Console.ReadLine());
        
        foreach (string indexName in students.Keys)
        {
            chat firstChar = students[indexName];

            if (index.ToString() == firstChar)
            {
                
            }
        }
    }
}