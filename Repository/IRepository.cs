using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace OnlineShoppingStore_MVC.Repository
{
    public interface IRepository<Tbl_Entity> where Tbl_Entity:class
    {
        IEnumerable<Tbl_Entity> GetProduct();
        IEnumerable<Tbl_Entity> GetAllRecord();
        IQueryable<Tbl_Entity> GetAllRecordsQueryable();
        int GetAllrecordCount();
        void Add(Tbl_Entity entity);
        void Update(Tbl_Entity entity);
        void UpdateByWhereClause(Expression<Func<Tbl_Entity, bool>> wherePredict, Action<Tbl_Entity> ForEachPredict);
        Tbl_Entity GetFirstorDefault(int recordId);
        void Remove(Tbl_Entity entity);
        void RemovebywhereClause(Expression<Func<Tbl_Entity,bool>> wherePredict);
        void RemoveRangeBywhereClause(Expression<Func<Tbl_Entity, bool>> wherePredict);
        void InactiveAndDeleteMarkBywhereClause(Expression<Func<Tbl_Entity, bool>> wherePredict,Action<Tbl_Entity> ForEachPredict);
        Tbl_Entity GetFirstorDefaultByParameter(Expression<Func<Tbl_Entity, bool>> wherePredict);
        IEnumerable<Tbl_Entity> GetListParameter(Expression<Func<Tbl_Entity, bool>> wherePredict);
        IEnumerable<Tbl_Entity> GetResultBySqlprocedure(string query, params object[] parameters);
        IEnumerable<Tbl_Entity> GetRecordsToShow(int PageNo, int PageSize, int CurrentPage, Expression<Func<Tbl_Entity, bool>> wherePredict,Expression<Func<Tbl_Entity,int>> orderByPredict);
    }
}