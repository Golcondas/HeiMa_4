using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2013_03_17
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyDelegate d = new MyDelegate(Program.Compares);
            //d(12, 15);
            //MyDelegate e = new MyDelegate(Program.HHH);
            //e(212313,131);
//            RSAPEM pems = new RSAPEM();
//            string a="MIIEowIBAAKCAQEA0HjR1NBhM8sKE1HDXOgomVTLsomPBRkT2ALMsoWnszntE+QC";
//a+="7s4DkNBo4lqB8cIkxBbRm98cEwY4bYFHxEVMPQ8cbyppFu0LSEqfUgMze/cYvYU8";
//a+="IZCzGCZFhFIlxua7ouVrPGZ4sgFu8XP5zN+zxaPXgaAd9vvtUzhC17QvYJnetIwz";
//a+="nB84x+vYkQRT6fz3A6VNCY3mtw1X/0Civho/9fL8lDbGnHMDRJlGdAx6s9PbmfzP";
//a+="NdaJcHloti9X4w3OV7jz++Mf0Iuydun5WGxk6FomJDGRc2LhfQP1bo2/90RwfvKQ";
//a+="/d9TJVsORpunTIcKkBNu8XCCSiddZjlmlOmxDQIDAQABAoIBAQDNjUN/7ZLaCam+";
//a+="kNDrS3G0ddp/CIk/QpHBXElPAN/wpP3wrdKCehkj8YppHUqhAIdV3RYB9cPtsiVz";
//a+="O5Ryns1kKwEjTxLdaw7D0egzajqaUXJQdA1tHwqnlhzXMlRTQO/j1wecP4FkKmuk";
//a+="oXC9pBjSmBEGm8TP4WkItCGcI+rO+EDyajqYz5wS0bqqeshlg2tJAA4qV/UL3qUW";
//a+="y8BXBcCftnlTJldTKal4wp27bqUDJYUTs34BlI/b1roiv0oah+0/lZpT/Z7A/ovO";
//a+="jBMYoKInEVGObvf191QRai8RFLbYn/9oPGs8EfHqFh0UvhNtOZnjJmSVhfqIgsRi";
//a+="C37CDsEVAoGBAOqO6VWJJqXcE3YIwABo+Zp5A9soqgkDzZIcfkPJ7v/6qBnW7jf8";
//a+="zWZ5p0NHlIM315yfYILl/qHRcBI144xPpJ0lW0pDDtioB/qVrB6laGvWD1CY0AbB";
//a+="omB+LP729J4FjE8qeTv2Rjx+FdqlPG2N71cjE0uyzgQPaf0H/iyNXIzrAoGBAOOH";
//a+="cQiOGWquRgfNDkgJpPabEwF96zmr3aJkLRslgeOuM6V1JX6Nk+a3UZ8oKCUdpcsU";
//a+="O4Hlty75OMyIni3ThtOReX6Aa0RChJAaq695eycy0eCmaNVrfIVyCVl4+Udqm08P";
//a+="CsyggqVHH8ZmP0gm5k3fe/D6qna5XaeYj0hRLVvnAoGAY2Zu0ZXOsAkkoiexHjte";
//a+="U60nCjAgZrOa4Wl7xMSFqSsTI+gmiclzThMN5AAomrcGg1QzNSW8k9zKrpzxsltp";
//a+="+kKDfmQOnZgP0YyuJUqZhuFvGgu4VLSoWFYAQYhsP69AN6hbOiLyvt376u2NPywg";
//a+="GoA9xB2hGq1hkB5cA4tghkMCgYBxjCwqus+QX7xvNDRGWxnKQAWyHub+9vg6jIe+";
//a+="Hm+98jewANBfYcRHxYCkTuQJ8cvFlylDYCKU/KcN27gk4oVMnDLnoKrne9KwH79C";
//a+="aPu+yivXUvTKXUPdTNXBow+0Rk2PnNAk4o2Qcfg3iNtX5KHWhwtRbacYbNWCSC5p";
//a+="Rqm+TQKBgC3WjW7EGdf9XtEcREWUXZUgwtLZ3TDQB5hxk19vp2h28ltHbMRQAFeT";
//a+="ww26PkJ5PCqVqvAAiQZSZtz908CM0JpIU9PNprJ+As1ktgh2goo5QIQojMjjr5JY";
//a+="X5ihhkP9ZGcg85yU1Jm8Kwrora+Bd26rfg4nr6g3h3rFEgGMTi5G";
//            pems.getKeyPara(a,0);

            Console.ReadKey();
        }

        static List<Dog> GetListDog()
        {
            List<Dog> dog = new List<Dog>() { 
                new Dog(){Name="小王",Age=1},
                new Dog(){Name="小张",Age=12},
                new Dog(){Name="小黄",Age=22},
                new Dog(){Name="小高",Age=332}
            };
            return dog;
        }

        /// <summary>
        /// 带自定义的返回值func
        /// </summary>
        static void TestFunc() {
            List<Dog> listDog = GetListDog();
            //listDog.Select(new Func<Dog, Person>(delegate(Dog dog)
            //{
            //    return new Person() { Name = dog.Name };
            //}));
            listDog.Select(new Func<Dog, Person>(delegate(Dog dg){
                return new Person(){Name=dg.Name};
            });
            //listDog.Select(new Func<Dog,Person>(delegate(Dog dogs) { return dogs.Name; }));
        }
        
        // 声明delegate对象
        delegate void CompareDelegate(int x, int y);
        //欲传递的方法，它与CompareDelegate具有相同的参数和返回值类型  
        static void Compares(int x, int y)
        {
            Console.WriteLine((x > y).ToString());
        }

        static void HHH(int aaa,int bbb=0)
        {
            Console.WriteLine("a="+aaa+" b="+bbb);
        }
    }

    public delegate void MyDelegate(int x,int y);
}
