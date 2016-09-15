using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Staff:BaseBLL<M_YG>
    {
        DAO.D_Staff dStaff = null;
        
        public void TestStaff()
        {
            dStaff.TestStaff();
        }


        public override void SetDaL()
        {
            dal =new DAO.BaseDao<M_YG>();
            dStaff = dal as DAO.D_Staff;
        }
    }
}
