using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.LiskowSubstitutionPrinciple.Good;
public class Samsung : MobilePhone, ITakePhoto
{
    public void TakePhoto()
    {
        Console.WriteLine("Fotoğraf çekildi...");
    }
}
