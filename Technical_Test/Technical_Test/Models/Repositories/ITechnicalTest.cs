using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Technical_Test.Models.Repositories
{
    public interface ITechnicalTest<TEintity>
    {
        IList<TEintity> List();
        TEintity Find(int Id);
        void Signup(TEintity eintity);
        void Update(TEintity eintity, int ID);
        TEintity Signin(TEintity eintity, int id);
    }
}
