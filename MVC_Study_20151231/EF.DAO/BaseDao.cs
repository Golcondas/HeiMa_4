using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BaseDao<T> where T:class,new ()
    {
        Entities db = new Entities();

        #region 1.0 新增
        /// <summary>
        /// 1.0 新增
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Add(T model)
        {
            db.Set<T>().Add(model);
            return db.SaveChanges() > 0;
        } 
        #endregion

        #region 2.0 删除 根据ID
        /// <summary>
        /// 2.0 删除 根据ID
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool DelById(T model)
        {
            db.Set<T>().Attach(model);
            db.Set<T>().Remove(model);
            return db.SaveChanges() > 0;
        } 
        #endregion

        #region 2.1 根据条件删除
        /// <summary>
        /// 2.1 根据条件删除
        /// </summary>
        /// <param name="deleteWhere"></param>
        /// <returns></returns>
        public bool DelWhere(System.Linq.Expressions.Expression<Func<T, bool>> deleteWhere)
        {
            List<T> list = db.Set<T>().Where(deleteWhere).ToList();
            list.ForEach(u =>
            {
                db.Set<T>().Attach(u);
                db.Set<T>().Remove(u);
            });
            return db.SaveChanges() > 0;
        } 
        #endregion

        #region 3.0 修改
        /// <summary>
        /// 3.0 修改
        /// </summary>
        /// <param name="model"></param>
        /// <param name="proNames"></param>
        /// <returns></returns>
        public bool Edit(T model, params string[] proNames)
        {
            DbEntityEntry entry = db.Entry<T>(model);
            entry.State = EntityState.Modified;
            foreach (string proName in proNames)
            {
                entry.Property(proName).IsModified = true;
            }
            return db.SaveChanges() > 0;
        } 
        #endregion

        #region 4.0 查找
        /// <summary>
        /// 4.0 查找
        /// </summary>
        /// <returns></returns>
        public List<T> GetListAll()
        {
            return db.Set<T>().Select(u => u).ToList();
        } 
        #endregion

        #region 4.1 根据条件查找
        /// <summary>
        /// 4.1 根据条件查找
        /// </summary>
        /// <param name="selectWhere"></param>
        /// <returns></returns>
        public List<T> GetListSelectWhere(Expression<Func<T, bool>> selectWhere)
        {
            return db.Set<T>().Where(selectWhere).ToList();
        } 
        #endregion

        #region 4.2 查找 排序
        /// <summary>
        /// 4.2 查找 排序
        /// </summary>
        /// <typeparam name="Tkey"></typeparam>
        /// <param name="selectWhere"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        public List<T> GetSelectWhereOrderby<Tkey>(Expression<Func<T, bool>> selectWhere, Expression<Func<T, Tkey>> orderBy)
        {
            return db.Set<T>().Where(selectWhere).OrderBy(orderBy).ToList();
        } 
        #endregion

        #region 4.3 分页 查找
        /// <summary>
        /// 4.3 分页 查找
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<T> GetSelectPageList(int pageIndex, int pageSize)
        {
            return db.Set<T>().Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
        } 
        #endregion

        #region 4.4 条件 查找 分页
        /// <summary>
        /// 4.4 条件 查找 分页
        /// </summary>
        /// <param name="selectWhere"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<T> GetSelectWherePageList(Expression<Func<T, bool>> selectWhere, int pageIndex, int pageSize)
        {
            return db.Set<T>().Where(selectWhere).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
        } 
        #endregion
    }
}
