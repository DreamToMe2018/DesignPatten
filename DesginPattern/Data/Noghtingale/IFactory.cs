using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Data.Noghtingale
{
    public interface IFactory
    {
        Noghtingale CreateNoghtingale(string type);
    }
}
