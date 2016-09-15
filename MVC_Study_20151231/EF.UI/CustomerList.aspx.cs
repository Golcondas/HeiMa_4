using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EF.UI
{
    public partial class CustomerList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                BLL.B_Customer bll = new BLL.B_Customer();
                List<M_KH> customerList = new List<M_KH>();
                customerList=bll.GetListAll();
                //var customerList = bll.GetKHList(u => u.iKHID > 0).ToList();
                //var customerList = bll.GetKHListSelect();
                this.rptCustomerList.DataSource = customerList;
                this.rptCustomerList.DataBind();
            }
        }
    }
}