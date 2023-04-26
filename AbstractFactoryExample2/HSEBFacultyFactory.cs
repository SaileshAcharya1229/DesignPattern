namespace AbstractFactoryPattern.AbstractFactoryExample2;

public class HSEBFacultyFactory :Iinsttitute
{
    public ITeacher viewTeacher(string selectedTeacher)
    {
        if (selectedTeacher == null)
        {
            return null;
        }

        if (selectedTeacher == "FULL TIME TEACHER")
        {
            return new FullTimeTeacher();
        }
        return null;
    }

    public IStudent viewStudent(string selectedStudent)
    {
        if (selectedStudent == null)
        {
            return null;
        }

        if (selectedStudent == "PLUS TWO")
        {
            return new PlusTwoStudent();
        }
        return null;
    }
}