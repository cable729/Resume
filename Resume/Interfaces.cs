using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume
{
    public interface IHirable { IEnumerable<string> Skills { get; } }
    public interface IPassionate { IEnumerable<string> Interests { get; } }
    public interface INetDeveloper /* : IDisposable // ha ha */ { }
    public interface IStudent { }
}
