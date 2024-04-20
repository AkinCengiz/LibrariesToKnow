using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.LiskowSubstitutionPrinciple.Bad;
public class Iphone : Phone
{
    public override void TakePhoto()
    {
        Console.WriteLine("Fotoğraf çekildi.");
    }
}
