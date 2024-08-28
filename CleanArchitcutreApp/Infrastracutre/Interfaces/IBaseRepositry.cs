using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastracutre.Interfaces
{
    public interface IBaseRepositry<T> where T : class
    {
        IEnumerable<T> GetAll();

    }
}
