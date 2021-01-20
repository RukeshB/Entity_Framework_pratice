using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityframeworkDotnet.Context.DAL
{
    public class AllRepo<T> : _IAllRepo<T> where T : class
    {
        private fastfoodEntities _contex;
        private IDbSet<T> dbEntity;

        public  AllRepo()
        {
            _contex = new fastfoodEntities();
            dbEntity = _contex.Set<T>();
        }

        public void DeleteModel(int modelid)
        {
            T model = dbEntity.Find(modelid);
            dbEntity.Remove(model);
        }

        public IEnumerable<T> GetModel()
        {
            return dbEntity.ToList();
        }

        public T GetModelById(int modelid)
        {
            return dbEntity.Find(modelid);
        }

        public void InsertModel(T model)
        {
            dbEntity.Add(model);
        }

        public void save()
        {
            _contex.SaveChanges();
        }

        public void UpdateModel(T model)
        {
            _contex.Entry(model).State = EntityState.Modified;
        }
    }
}