namespace homework;
public class Student : Person
{
    private int  numCourses = 0 ;
    private List<string>  _courses ;
    private List<int>  _grades  ;
    private object grades;

    public Student( string name, string address) : base(name, address)
    {
         _courses = new List<string>();
         _grades = new List<int>();
    }
    public override string ToString()
    {
        return $"Student: {base.ToString()}";
    }
    public void AddCourseGrade(string courses, int grades)
    {
      _courses.Add(courses);
      _grades.Add(grades);
    }
    public void PrintGrades()
    {
        foreach (var item in _grades)
        {
            System.Console.WriteLine($"{grades},");
        }
    }
    
}