namespace AbstractDesignPatternExample;

public class ColorFactory : IAbsractFactory
{
    public IShape draw(string shapechoice)
    {
        return null;
    }

    public IColor fill(string colorchoice)
    {
        if (colorchoice == null)
        {
            return null;
        }
        if (colorchoice == "red")
        {
            return new Red();

        }

        if (colorchoice == "blue")
        {
            return new Blue();
        }

        return null;
    }
}