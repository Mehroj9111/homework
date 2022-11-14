namespace homework;
public class Teacher : Person
{ 
    private int  _numCourses = 0 ;
    private string _courses ;
    public Teacher( string name, string address) : base(name, address)
    {
    }
    public string ToString()
    {
        return $"Teacher {_name}({_address})";
    }
    public Boolean AddCourse(string courses)
    {
        _courses = courses;
        if(_courses == null)
        {
            return false;
        }
        else{
            return true;
        }
    }
    public Boolean RemoveCourse(string courses)
    {
        if(_courses == courses)
        return false;
        else{
            return true;
        }
    }


    
    
}