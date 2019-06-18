using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopLibrary;

namespace lab14
{
    class ReqCollection:MySortedDictionary<int, Goods>
    {

        public void Generate(int num)
        {
            
            for(int i = 0; i < num; i++)
            {
                switch (i / 3)
                {
                    case 0:
                        Add(i, new Toy(true));
                        break;
                    case 1:
                        Add(i, new MilkProduct(true));
                        break;
                    case 2:
                        Add(i, new Product(true));
                        break;
                }
            }
        }
        public ReqCollection(int cap):base(cap)
        {

        }
        public List<Goods> Intersect(ReqCollection list2)
        {
            List<Goods> intersect = (from c in this select c.Value).Intersect(from c in list2 select c.Value).ToList();
            return intersect;
        }

        public List<Goods> Except(ReqCollection list2)
        {
            List<Goods> except = (from c in this select c.Value).Except(from c in list2 select c.Value).ToList();
            return except;
        }
        public List<Goods> Concat(ReqCollection list2)
        {
            List<Goods> concat = (from c in this select c.Value).Concat(from c in list2 select c.Value).ToList();
            return concat;
        }
        public List<string> NamesOfGoods(string department)
        {
            return (from c in this where c.Value.Department == department select c.Value.Name).ToList();
        }
        public int GetNumberOfGoods(string name)
        {
            return (from c in this where c.Value.Name == name select c.Value).Count();
        }
        public double GetPriceByName(string name)
        {
            double[] prices = (from c in this select c.Value.Price).ToArray();
            double sum = prices.Aggregate((a, b) => a + b);
            return sum;
        }

        //IEnumerator<Goods> IEnumerable<Goods>.GetEnumerator()
        //{
        //    return Values.GetEnumerator();
        //}
    }
}
