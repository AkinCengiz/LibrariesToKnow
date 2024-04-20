namespace Solid.LiskowSubstitutionPrinciple.Good;

internal class Program
{
    static void Main(string[] args)
    {
        //MobilePhone samsung = new Samsung();
        Samsung samsung = new Samsung();
        samsung.Call();
        samsung.TakePhoto();
        //((ITakePhoto)samsung).TakePhoto();
        MobilePhone nokia = new Nokia();
        nokia.Call();
        //((ITakePhoto)nokia).TakePhoto();
        
    }
}
