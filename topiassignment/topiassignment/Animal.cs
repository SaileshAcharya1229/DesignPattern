namespace topiassignment;

abstract  class Animal<T>
{
     public abstract void eat(T a);
    

}

class Rat<T> : Animal<T>
{
    public override void eat(T a)
    {
        Console.WriteLine(a);
    }
}