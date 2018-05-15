using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // c2.InitShow();

            /*
             * 零散小语法
             */
            //进位
            var s = 1 << 3;

            /*
             * 数组
             */
            int[] arrayInt = new Int32[2] { 32, 23 };
            arrayInt[0] = 12;
            //将数组增加一个长度
            Array.Resize(ref arrayInt, arrayInt.Length + 1);

            int[] x = new int[2];
            int[] y = new int[2];
            x[0] = 5; x[1] = 6;
            x.Initialize();
            y.Initialize();

            /*
             * 索引
             */
            var z = new Z();
            var zArr = z[1];
            var zTestModelArr = z["TestModel_Arrar_" + 49];
        }
    }
    #region 类的继承

    public class c1
    {
        public c1()
        {
            Console.WriteLine("Str:c1");
        }
        public virtual void GetString()
        {
            Console.WriteLine("Str:C1-GetString");
        }
        public void Test_New()
        {
            Console.WriteLine("Str:C1-Test_New");
        }
    }
    public class c2 : c1
    {
        public c2()
        {
            Console.WriteLine("Str:c2");
        }
        public override void GetString()
        {
            Console.WriteLine("Str:C2-GetString");
        }
        public new void Test_New()
        {
            Console.WriteLine("Str:C2-Test_New");
        }
        public static void InitShow()
        {
            c1 c = new c2();
            c.GetString();
            c.Test_New();

            c2 c2 = new c2();
            c2.Test_New();
            Console.ReadKey();
        }
    }
    #endregion

    #region 索引
    public class Z
    {
        public Z()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr.Length - 1 - i;
            }

            for (int i = 0; i < testModelArray.Length; i++)
            {
                testModelArray[i] = new TestModel()
                {
                    Id = i,
                    Name = "TestModel_Arrar_" + i
                };
            }
        }

        #region 简单int数组索引

        private Int32[] arr = new Int32[101];

        public Int32 this[Int32 index]
        {
            get
            {
                return arr[index];
            }
            set
            {
                arr[index] = value;
            }
        }

        #endregion

        #region 数组对象索引
        private TestModel[] testModelArray = new TestModel[50];
        public TestModel this[String name]
        {
            get
            {
                foreach (var item in testModelArray)
                {
                    if (item.Name == name)
                    {
                        return item;
                    }
                }

                return null;
            }
        }

        public class TestModel
        {
            public Int32 Id { get; set; }
            public String Name { get; set; }
        }
        #endregion
    }
    #endregion
}
