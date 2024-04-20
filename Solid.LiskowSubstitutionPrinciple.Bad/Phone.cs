using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.LiskowSubstitutionPrinciple.Bad;
public abstract class Phone
{
    public void Call()
    {
        Console.WriteLine("Arama yapıldı.");
    }

    public abstract void TakePhoto();
}
