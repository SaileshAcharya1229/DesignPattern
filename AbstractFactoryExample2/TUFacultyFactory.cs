namespace AbstractFactoryPattern.AbstractFactoryExample2;

public class TUFacultyFactory : Iinsttitute
{
    public ITeacher viewTeacher(string selected)
    {
        if (selected == null)
        {
            return null;
        }

        if (selected == "Parttime teacher")
        {
            return new PartTimeTeacher();
        }

        return null;
    }

    public IStudent viewStudent(String selected)
    {
        if (selected == null)
        {
            return null;
        }

        if (selected == "Bachelor student")
        {
            return new BachelorStudent();
        }

        return null;
    }
    
}