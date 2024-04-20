using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.LiskowSubstitutionPrinciple.Bad;
public class Nokia : Phone
{
    public override void TakePhoto()
    {
        throw new NotImplementedException();
    }
}
