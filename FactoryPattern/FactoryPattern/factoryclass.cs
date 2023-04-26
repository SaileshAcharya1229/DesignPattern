namespace FactoryPattern;

public class factoryclass
{
    public static I1 getobject(string typeofobj)
    {
        switch (typeofobj)
        {
            case"father":
                return new Father();
            case "son":
                return new Son();
        }

        return null;
    }
}