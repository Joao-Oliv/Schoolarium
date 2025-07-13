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
            Console.WriteLine("4. Show student's grades");
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
                
                case 4:

                    this.showStudentsGrades();
                    break;
                
                case 5:
                    
                    break;
                
                default:
                    
                    Console.WriteLine("Invalid Command, try again");
                    break;
            }
            
            
        } while (iterator != 0);
    }

    public bool showStudentsMenu()
    {
        Console.Clear();
        Console.WriteLine("Please, choose the student: ");
        
        bool existStudents = false;
        
        if (students.Count() > 1)
        {
            foreach (string name in students.Keys)
            {
                Console.WriteLine(name);
            }
            
            existStudents = true;
        }
        else
        {
            Console.WriteLine("No students registered");
        }

        return existStudents;
    }

    public string getStudentMenu()
    {
        string studentName = null;
        char index = Console.ReadKey().KeyChar;
        
        foreach (string indexName in students.Keys)
        {
            if (index == indexName[0])
            {
                studentName = indexName;
                break;
            }
        }
        
        return studentName;
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

        this.showStudentsMenu();
        
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
        Console.Clear();
    }

    public void insertStudentsGrades()
    {
        Console.Clear();

        if (this.showStudentsMenu())
        {
            string studentKey = this.getStudentMenu();

            if (studentKey != null)
            {
                Console.WriteLine($"\n{studentKey} selected");
                Console.WriteLine("Please, insert the grade of the student: ");

                int grade = Convert.ToInt32(Console.ReadLine());

                students[studentKey].Add(grade);

                Console.WriteLine($"{studentKey} grade was {grade}");
            }
            else
            {
                Console.WriteLine("\nNo students registered with this index");
            }
        }

        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
        Console.Clear();
    }

    public void showStudentsGrades()
    {
        Console.Clear();
        Console.WriteLine("Please, choose the student: ");

        if (this.showStudentsMenu())
        {
            string studentKey = this.getStudentMenu();

            if (studentKey != null)
            {
                List<int> studentGrades = students[studentKey];
                
                Console.WriteLine($"********************************");
                Console.WriteLine($"\n{studentKey}");

                for (int i = 0; i < studentGrades.Count; i++)
                {
                    Console.WriteLine($"{i + 1} = {studentGrades[i]}");
                }
                
                Console.WriteLine($"********************************");
            }
        }
        
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
        Console.Clear();
    }

    public void getStudentMedia()
    {
        Console.Clear();
        Console.WriteLine("Please, choose the student: ");

        if (this.showStudentsMenu())
        {
            string studentKey = this.getStudentMenu();

            if (studentKey != null)
            {
                
            }
        }
        
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
        Console.Clear();
    }
}