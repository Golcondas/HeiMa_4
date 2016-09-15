using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class D_Customer:BaseDao<M_KH>
    {
        //Entities db = new Entities();

        //public D_Customer()
        //{
        //    ////1.0
        //    //int i = this.DelByWhere(u => u.iKHID == 35);
        //    //Predicate<M_KH> model = delegate(M_KH customer) { return customer.iKHID == 35; };

        //    ////2.0
        //    //M_KH kh = new M_KH() { iKHID = 35, nKHMC = "大神归来" };
        //    //this.Modefiy(kh, "nKHMC");

        //    ////3.0
        //    //List<M_KH> khList=this.GetKHList(u=>u.iKHID>0);
        //    //List<M_KH> khListOrderBy = this.GetKHListOrdeBy(u => u.iKHID > 0, y => y.nKHMC);//需要自动推断类型 
        //    ////List<M_KH> khListOrderBy = this.GetKHListOrdeBy<int>(u => u.iKHID > 0, y => y.nKHMC); //int 类型
        //}

        //#region 1.0 新增
        ///// <summary>
        ///// 新增
        ///// </summary>
        ///// <param name="model"></param>
        ///// <returns></returns>
        //public bool Add(M_KH model)
        //{
        //    db.M_KH.Add(model);
        //    int i = db.SaveChanges();
        //    return i > 0;
        //} 
        //#endregion

        //#region 2.0 根据ID删除
        ///// <summary>
        ///// 根据ID删除
        ///// </summary>
        ///// <param name="ID"></param>
        ///// <returns></returns>
        //public int DelByID(int ID)
        //{
        //    M_KH model = new M_KH() { iKHID = ID };
        //    db.M_KH.Attach(model);
        //    db.M_KH.Remove(model);
        //    int i = db.SaveChanges();
        //    return i;
        //} 
        //#endregion

        //#region 3.0 根据条件删除
        ///// <summary>
        ///// 根据条件删除
        ///// </summary>
        ///// <param name="deleteWhere"></param>
        ///// <returns></returns>
        //public int DelByWhere(Expression<Func<M_KH, bool>> deleteWhere)
        //{
        //    List<M_KH> customerList = new List<M_KH>();
        //    customerList = db.M_KH.Where(deleteWhere).ToList();
        //    customerList.ForEach(u => db.M_KH.Remove(u));
        //    int i = db.SaveChanges();
        //    return i;
        //} 
        //#endregion

        //#region 4.0 修改
        ///// <summary>
        ///// 修改
        ///// </summary>
        ///// <param name="model"></param>
        ///// <param name="proNames"></param>
        ///// <returns></returns>
        //public int Modefiy(M_KH model, params string[] proNames)
        //{
        //    DbEntityEntry entry = db.Entry<M_KH>(model);
        //    entry.State = System.Data.EntityState.Modified;
        //    foreach (var proName in proNames)
        //    {
        //        entry.Property(proName).IsModified = true;
        //    }
        //    return db.SaveChanges();
        //} 
        //#endregion

        //#region 5.0 查找
        ///// <summary>
        ///// 5.0 查找
        ///// </summary>
        ///// <param name="seletWhere"></param>
        ///// <returns></returns>
        //public List<M_KH> GetKHList(Expression<Func<M_KH, bool>> seletWhere)
        //{
        //    return db.M_KH.Where(seletWhere).ToList();
        //} 
        //#endregion

        //#region 5.1 查找全部
        ///// <summary>
        ///// 5.1 查找全部
        ///// </summary>
        ///// <param name="seletWhere"></param>
        ///// <returns></returns>
        //public List<M_KH> GetKHListSelect()
        //{
        //    return db.M_KH.Select(u=>u).ToList();
        //}
        //#endregion

        //#region 6.0 查找排序
        ///// <summary>
        ///// 5.0 查找排序
        ///// </summary>
        ///// <param name="seletWhere"></param>
        ///// <returns></returns>
        //public List<M_KH> GetKHListOrdeBy<Tkey>(Expression<Func<M_KH, bool>> seletWhere,Expression<Func<M_KH,Tkey>> OrderWhere)
        //{
        //    return db.M_KH.Where(seletWhere).OrderBy(OrderWhere).ToList();
        //}
        //#endregion

        //#region 7.0 分页查询
        ///// <summary>
        ///// 分页查询
        ///// </summary>
        ///// <param name="pageIndex"></param>
        ///// <param name="pageSize"></param>
        ///// <returns></returns>
        //public List<M_KH> GetPageList(int pageIndex, int pageSize)
        //{
        //    List<M_KH> list = new List<M_KH>();
        //    list = db.M_KH.Select(a => a).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
        //    return list;
        //} 
        //#endregion
        
        //#region 8.0 分页查询-排序
        ///// <summary>
        ///// 分页查询-排序
        ///// </summary>
        ///// <param name="pageIndex"></param>
        ///// <param name="pageSize"></param>
        ///// <returns></returns>
        //public List<M_KH> GetPageList<TResult>(int pageIndex, int pageSize,Expression<Func<M_KH,TResult>> orderWhere)
        //{
        //    List<M_KH> list = new List<M_KH>();
        //    list = db.M_KH.Select(a => a).Skip((pageIndex - 1) * pageSize).Take(pageSize).OrderBy(orderWhere).ToList();
        //    return list;
        //}
        //#endregion

        //#region 9.0 分页查询-排序-待条件查询
        ///// <summary>
        ///// 分页查询-排序-待条件查询
        ///// </summary>
        ///// <param name="pageIndex"></param>
        ///// <param name="pageSize"></param>
        ///// <returns></returns>
        //public List<M_KH> GetPageList<TResult>(int pageIndex, int pageSize, Expression<Func<M_KH, TResult>> orderWhere, Expression<Func<M_KH, bool>> selectWhere)
        //{
        //    List<M_KH> list = new List<M_KH>();
        //    list = db.M_KH.Where(selectWhere).Select(a => a).Skip((pageIndex - 1) * pageSize).Take(pageSize).OrderBy(orderWhere).ToList();
        //    return list;
        //}
        //#endregion
    }
}
