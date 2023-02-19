using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFDesign
{
//    Interface Segregation Principle(ISP)
//Definition: No client should be forced to implement methods which it does not use, and the contracts should be broken down to thin ones.
    public interface IOrder
    {
        void AddToCart();
    }
    public interface IOnlineOrder
    {
        void CCProcess();
    }
    public class OnlineOrder: IOrder, IOnlineOrder
    {
        public void AddToCart()
        {
            //Do Add to Cart
        }
        public void CCProcess() 
        { 
            //process through credit card
        }
    }
    public class OffLineOrder : IOrder
    { 
        public void AddToCart() 
        {
            //do Add to Cart
        }
       
    }
}
