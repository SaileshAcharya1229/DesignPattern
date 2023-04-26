namespace FactorypatternTopi;

 class Car : IVehicle
{
  public string wheels()
  {
      return "4 wheelers gadi ho hai kta ho";
  }
  
  public string model()
  {
      return "suzuki s22";
  }

  public string mirror()
  {
      return "hunxa";
  }
}