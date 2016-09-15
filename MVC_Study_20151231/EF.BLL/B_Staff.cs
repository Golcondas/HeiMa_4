using DAO;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class B_Staff:BaseBLL<M_YG>
    {
        protected DAO.D_Staff dStaff = new D_Staff();

        public B_Staff()
        {
            SetDaL();
        }
        
        //public void TestStaff()
        //{
        //    dStaff.TestStaff();
        //}

        public override void SetDaL()
        {
            dal = new D_Staff();
            dStaff = dal as DAO.D_Staff;
        }

        public List<M_YG> GetListAll()
        {
            return dStaff.GetListAll();
        }
    }
}
