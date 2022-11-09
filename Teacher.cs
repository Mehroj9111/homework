namespace homework;
public class Teacher : Person
{ 
    public int  numCourses = 0 ;
    public string courses ;
    private List<Object>list;
    public Teacher( string name, string address) : base(name, address)
    {
        list= new List<Object>();
    }

    
    
}