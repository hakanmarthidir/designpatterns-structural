using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace flyweight_pattern
{
    public enum TshirtSize
    {
        XS,
        S,
        M,
        L, 
        XL, 
        XXL
    }


    public class TShirt
    {
        public TshirtSize Size { get; set; }

        public TShirt(TshirtSize size)
        {
            this.Size = size;
        }

        public void CreateTshirt()
        {
            Console.WriteLine($"Tshirt was created {this.Size}");
        }
    }


    public class TShirtFactory
    {

        private Dictionary<TshirtSize, TShirt> tshirtList;

        public TShirtFactory()
        {
            this.tshirtList = new Dictionary<TshirtSize, TShirt>();
        }

        public TShirt CreateTshirt(TshirtSize size)
        {
            TShirt t = null;

            if (this.tshirtList.ContainsKey(size))
            {
                t = this.tshirtList[size];
            }
            else
            {
                switch (size)
                {
                    case TshirtSize.XS:
                        t = new TShirt(TshirtSize.XS);
                        break;
                    case TshirtSize.S:
                        t = new TShirt(TshirtSize.S);
                        break;
                    case TshirtSize.M:
                        t = new TShirt(TshirtSize.M);
                        break;
                    case TshirtSize.L:
                        t = new TShirt(TshirtSize.L);
                        break;
                    case TshirtSize.XL:
                        t = new TShirt(TshirtSize.XL);
                        break;
                    case TshirtSize.XXL:
                        t = new TShirt(TshirtSize.XXL);
                        break;
                    default:
                        break;
                }
            }

            return t;
        }




    }






}
