using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市系统
{
    class Changku
    {
        /// <summary>
        /// 添加商品种类
        /// </summary>
        List<List<ProductFather>> list = new List<List<ProductFather>>();
        public Changku()
        {
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
        }

        /// <summary>
        /// 进货
        /// </summary>
        /// <param name="strType"></param>
        /// <param name="count"></param>
        public void JinHuo(string strType, int count)
        {
            for (int i = 0; i < count; i++)
            {
                switch (strType)
                {
                    case "Acer":
                        list[0].Add(new Acer("宏碁笔记本", 5000, Guid.NewGuid().ToString()));
                        break;
                    case "Samsung":
                        list[1].Add(new Samsung("三星手机", 3000, Guid.NewGuid().ToString()));
                        break;
                    case "banana":
                        list[2].Add(new banana("香蕉", 5, Guid.NewGuid().ToString()));
                        break;
                    case "Jiangyou":
                        list[3].Add(new Jiangyou("酱油", 5, Guid.NewGuid().ToString()));
                        break;
                }
            }
        }
        /// <summary>
        /// 取货
        /// </summary>
        /// <param name="strType"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public ProductFather[] QvHuo(string strType, int count)
        {
            ProductFather[] pros = new ProductFather[count];
            for(int i = 0; i < count; i++)
            {      
                switch(strType)
                {
                    case "宏碁笔记本":
                        pros[i] = list[0][0];
                        list[0].RemoveAt(0);
                        break;
                    case "三星手机":
                        pros[i] = list[1][0];
                        list[1].RemoveAt(0);
                        break;
                    case "香蕉":
                        pros[i] = list[2][0];
                        list[2].RemoveAt(0);
                        break;
                    case "酱油":
                        pros[i] = list[3][0];
                        list[3].RemoveAt(0);
                        break;
                }
            }
            return pros;
        }
        public void Show()
        {
            Console.WriteLine("商品清单：");
            foreach(var item in list)
            {
                Console.WriteLine("商品名：" + item[0].Name + " 单价：" + item[0].Price+"元");
            }
        }
    }
}
