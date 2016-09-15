using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public abstract class BaseBLL<T> where T : class,new()
    {
        protected BaseDao<T> dal = null;

        public abstract void SetDaL();

        #region 1.0 新增
        /// <summary>
        /// 1.0 新增
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Add(T model)
        {
            return dal.Add(model);
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
            return dal.DelById(model);
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
            return dal.DelWhere(deleteWhere);
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
            return dal.Edit(model, proNames);
        }
        #endregion

        #region 4.0 查找
        /// <summary>
        /// 4.0 查找
        /// </summary>
        /// <returns></returns>
        public List<T> GetListAll()
        {
            return dal.GetListAll();
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
            return dal.GetListSelectWhere(selectWhere);
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
            return dal.GetSelectWhereOrderby<Tkey>(selectWhere, orderBy);
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
            return dal.GetSelectPageList(pageIndex, pageSize);
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
            return dal.GetSelectWherePageList(selectWhere, pageIndex, pageSize);
        }
        #endregion
    }
}
