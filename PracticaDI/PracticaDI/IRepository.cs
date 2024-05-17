using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDI
{
    public interface IRepository
    {
        void Save();
        void Delete();
        void Update();
        void Create();
    }
}
