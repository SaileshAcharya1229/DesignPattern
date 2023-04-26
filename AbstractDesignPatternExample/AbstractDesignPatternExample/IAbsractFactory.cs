namespace AbstractDesignPatternExample;

public interface IAbsractFactory
{
    IShape draw(string shapechoice);
    IColor fill(string colorchoice);
}