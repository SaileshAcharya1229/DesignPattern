namespace AbstractionBeplop;

abstract class Father
{
   public  abstract void Study();
}

class younger : Father
{
   public override void Study()
   {
      Console.WriteLine("pada babuuuuuuuu kanxooooo");
   }
}

class Elder : Father
{
   public override void Study()
   {
      Console.WriteLine("paad na jetha ramrarii!");
   }
}