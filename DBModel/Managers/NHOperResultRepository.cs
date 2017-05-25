using System;
using System.Linq;
using System.Collections.Generic;
using WebCalc.Managers;
using NHibernate;
using DBModel.Helpers;
using DBModel.Models;

namespace DBModel.Managers
{
    public class NHOperResultRepository : IOperationResultRepository
    {
        public void Delet(OperationResult entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OperationResult> GetAll()
        {
            var result = new List<OperationResult>();

            using (ISession session = NHibernateHelper.OpenSession())
            {
                result.AddRange(session.CreateCriteria<OperationResult>().List<OperationResult>());
            }

            return result;
        }

        public IEnumerable<OperationResult> GetAll(bool flag)
        {
            return GetAll();
        }

        public IDictionary<string, int> GetTop(int limit = 3)
        {
            var result = new Dictionary<string, int>();
            var opers = GetAll();
            var groups = opers.GroupBy(o => o.OperationName)
                              .OrderByDescending(g => g.Count())
                              .Take(3);
            foreach (var group in groups)
            {
                result.Add(group.Key, group.Count());
            }

            return result;
        }

        public OperationResult Load(long id)
        {
            throw new NotImplementedException();
        }

        public void Save(OperationResult entity)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(entity);
                    transaction.Commit();
                }
            }
        }

        public void Update(OperationResult entity)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Update(entity);
                    transaction.Commit();
                }
            }
        }
    }
}

