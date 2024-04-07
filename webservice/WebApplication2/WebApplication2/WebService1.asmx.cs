using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication2
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        // thêm hàm kiểm tra chẳn lẻ và tìm số lớn nhất/nhỏ nhất
        [WebMethod]
        public string KTchanle(int n)
        {
            if (n % 2 == 0)
            {
                return n + " la chan";

            }
            else
            {
                return n + " la le";
            }
        }
        [WebMethod]
        public string FindMinMax(int num1, int num2, int num3)
        {
            int min = Math.Min(num1, Math.Min(num2, num3));
            int max = Math.Max(num1, Math.Max(num2, num3));
            string message = string.Format("Số lớn nhất: {0} \n Số nhỏ nhất: {1}", max, min);
            return message.Replace("\n", Environment.NewLine);
            //kết nối webservice với một project khác
        }
    }
}
