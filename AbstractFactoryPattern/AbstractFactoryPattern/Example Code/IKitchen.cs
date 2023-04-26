namespace AbstractFactoryPattern.Example_Code;

public interface IKitchen
{
    IVeg vegFood();
    INonVeg nonVegFood();
}