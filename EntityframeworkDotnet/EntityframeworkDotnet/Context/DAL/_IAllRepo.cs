using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityframeworkDotnet.Context.DAL
{
    public interface _IAllRepo<T> where T : class
    {
        IEnumerable<T> GetModel();

        T GetModelById(int modelid);

        void InsertModel(T model);

        void DeleteModel(int modelid);

        void UpdateModel(T model);

        void save();
    }
}
