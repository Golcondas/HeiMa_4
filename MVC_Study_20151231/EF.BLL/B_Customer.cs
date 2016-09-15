using DAO;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class B_Customer:BaseBLL<M_KH>
    {
        D_Customer bll = new D_Customer();

        public B_Customer()
        {
            SetDaL();
        }

        //public List<M_KH> GetListAll()
        //{
        //    return bll.GetListAll();
        //}

        ////#region 1.0 新增
        /////// <summary>
        /////// 1.0 新增
        /////// </summary>
        /////// <param name="model"></param>
        /////// <returns></returns>
        ////public bool Add(M_KH model)
        ////{
        ////    return dao.Add(model);
        ////} 
        ////#endregion

        ////#region 2.0 根据ID删除
        /////// <summary>
        /////// 根据ID删除
        /////// </summary>
        /////// <param name="ID"></param>
        /////// <returns></returns>
        ////public int DelByID(int ID)
        ////{
        ////    return dao.DelByID(ID);
        ////}
        ////#endregion

        ////#region 3.0 根据条件删除
        /////// <summary>
        /////// 根据条件删除
        /////// </summary>
        /////// <param name="deleteWhere"></param>
        /////// <returns></returns>
        ////public int DelByWhere(Expression<Func<M_KH, bool>> deleteWhere)
        ////{
        ////    return dao.DelByWhere(deleteWhere);
        ////}
        ////#endregion

        ////#region 4.0 修改
        /////// <summary>
        /////// 修改
        /////// </summary>
        /////// <param name="model"></param>
        /////// <param name="proNames"></param>
        /////// <returns></returns>
        ////public int Modefiy(M_KH model, params string[] proNames)
        ////{
        ////    return dao.Modefiy(model,proNames);
        ////}
        ////#endregion

        ////#region 5.0 条件查找
        /////// <summary>
        /////// 5.0 查找
        /////// </summary>
        /////// <param name="seletWhere"></param>
        /////// <returns></returns>
        ////public List<M_KH> GetKHList(Expression<Func<M_KH, bool>> seletWhere)
        ////{
        ////    return dao.GetKHList(seletWhere);
        ////}
        ////#endregion

        ////#region 5.1 查找全部
        /////// <summary>
        /////// 5.0 查找全部
        /////// </summary>
        /////// <param name="seletWhere"></param>
        /////// <returns></returns>
        ////public List<M_KH> GetKHListSelect()
        ////{
        ////    return dao.GetKHListSelect();
        ////}
        ////#endregion

        ////#region 6.0 查找排序
        /////// <summary>
        /////// 5.0 查找排序
        /////// </summary>
        /////// <param name="seletWhere"></param>
        /////// <returns></returns>
        ////public List<M_KH> GetKHListOrdeBy<Tkey>(Expression<Func<M_KH, bool>> seletWhere, Expression<Func<M_KH, Tkey>> OrderWhere)
        ////{
        ////    return dao.GetKHListOrdeBy<Tkey>(seletWhere, OrderWhere);
        ////}
        ////#endregion

        ////#region 7.0 分页查询
        /////// <summary>
        /////// 分页查询
        /////// </summary>
        /////// <param name="pageIndex"></param>
        /////// <param name="pageSize"></param>
        /////// <returns></returns>
        ////public List<M_KH> GetPageList(int pageIndex, int pageSize)
        ////{
        ////    return dao.GetPageList(pageIndex, pageSize);
        ////}
        ////#endregion

        ////#region 8.0 分页查询-排序
        /////// <summary>
        /////// 分页查询-排序
        /////// </summary>
        /////// <param name="pageIndex"></param>
        /////// <param name="pageSize"></param>
        /////// <returns></returns>
        ////public List<M_KH> GetPageList<TResult>(int pageIndex, int pageSize, Expression<Func<M_KH, TResult>> orderWhere)
        ////{
        ////    return GetPageList(pageIndex, pageSize,orderWhere);
        ////}
        ////#endregion

        ////#region 9.0 分页查询-排序-待条件查询
        /////// <summary>
        /////// 分页查询-排序-待条件查询
        /////// </summary>
        /////// <param name="pageIndex"></param>
        /////// <param name="pageSize"></param>
        /////// <returns></returns>
        ////public List<M_KH> GetPageList<TResult>(int pageIndex, int pageSize, Expression<Func<M_KH, TResult>> orderWhere, Expression<Func<M_KH, bool>> selectWhere)
        ////{
        ////    return GetPageList<TResult>(pageIndex, pageSize, orderWhere, selectWhere);
        ////}
        ////#endregion

        public override void SetDaL()
        {
            dal = new D_Customer();
            bll = dal as D_Customer;
        }

        public List<M_KH> GetCustomerList()
        {
            return bll.GetListAll();
        }
    }
}
