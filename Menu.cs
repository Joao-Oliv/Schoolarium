namespace Schoolarium;

public class Menu
{
    Dictionary<string, List<int>> students = new Dictionary<string, List<int>>(); 
    
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
        
        students.Add(studentName, new List<int>());
        
        Console.WriteLine($"Student {studentName} has been added");
        Console.WriteLine("Press any key to continue");
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
            int i = 1;
            
            foreach (string name in students.Keys)
            {
                Console.WriteLine($"{i}. {name}");

                i++;
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
}