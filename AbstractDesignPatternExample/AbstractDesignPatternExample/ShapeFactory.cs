namespace AbstractDesignPatternExample;

public class ShapeFactory : IAbsractFactory
{
   
    public IShape draw(String shapechoice)
    {
        if (shapechoice == null)
        {
            return null;
        }

        if (shapechoice == "rect")
        {
            return new Rectangle();
        }

        if (shapechoice == "circle")
        {
            return new Circle();
        }

        return null;
    }

    public IColor fill(String colorchoice)
    {
        return null;
    }
}