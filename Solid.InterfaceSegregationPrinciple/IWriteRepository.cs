using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.InterfaceSegregationPrinciple;
public interface IWriteRepository
{
    void Create();
    void Update();
    void Delete();
}
