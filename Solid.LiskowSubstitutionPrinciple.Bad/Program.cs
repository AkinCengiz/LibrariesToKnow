namespace Solid.LiskowSubstitutionPrinciple.Bad;

internal class Program
{
    static void Main(string[] args)
    {
        Phone nokia = new Nokia();
        Phone iphone = new Iphone();
        iphone.Call();
        iphone.TakePhoto();
        nokia.Call();
        nokia.TakePhoto();
    }
}
