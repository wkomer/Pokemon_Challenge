using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonChallenge
{
    public class PokemonChallenge
    {
        double pPrice = 6.0, sPrice = 5.0, cPrice = 5.0, total = 0, discount = 0;

        // Ex1
        // 1P
        public double Ex1(double pPrice, double total)
        {
            total = pPrice;
            return total;
        }
        // Ex2
        // 2P
        public double Ex2(double pPrice, double total)
        {
            total = pPrice * 2;
            return total;
        }
        // Ex3
        // 1P,1S
        public double Ex3(double pPrice, double sPrice, double total, double discount)
        {
            total = pPrice + sPrice;
            discount = total * .1;
            total = total - discount;
            return total;
        }
        // Ex4
        // 2P, 2S
        public double Ex4(double pPrice,double sPrice,double total,double discount)
        {
            total = pPrice + sPrice;
            discount = total * .1;
            total = total - discount;
            total = total * 2;
            return total;
        }
        // Ex5
        // 3P, 3S
        public double Ex5(double pPrice, double sPrice, double total, double discount)
        {
            total = pPrice + sPrice;
            discount = total * .1;
            total = (total - discount) * 3;
            return total;
        }
        // Ex6
        // 2P, 1S
        public double Ex6(double pPrice, double sPrice,double total, double discount)
        {
            total = pPrice + sPrice;
            discount = total * .1;
            total = total - discount + pPrice;
            return total;
        }
        // Ex7
        // 1P, 1S, 1C
        public double Ex7(double pPrice, double sPrice, double cPrice, double total, double discount)
        {
            total = pPrice + sPrice + cPrice;
            discount = total * .2;
            total = total - discount;
            return total;
        }
        // Ex8
        // 2P, 1S, 1C;
        public double Ex8(double pPrice, double sPrice, double cPrice, double total, double discount)
        {
            total = pPrice + sPrice + cPrice;
            discount = total * .2;
            total = total - discount + pPrice;
            return total;
        }

        //Adding extra methods 

        // Added Method 1
        // 2P, 2S, 1C
        public double Ad1(double pPrice, double sPrice, double cPrice, double total, double discount)
        {
            double temp = 0;
            total = pPrice + sPrice + cPrice;
            discount = total * .2;
            temp = total - discount;
            total = pPrice + sPrice;
            discount = total * .1;
            total = total - discount + temp; 
            return total;
        }
        // Added Method 2
        // 2P, 2S, 2C
        public double Ad2(double pPrice, double sPrice, double cPrice, double total, double discount)
        {
            total = pPrice + sPrice + cPrice;
            discount = total * .2;
            total = (total - discount) * 2;
            return total;
        }
        // Added Method 3
        // 3P, 2S, 2C
        public double Ad3(double pPrice, double sPrice, double cPrice, double total, double discount)
        {
            total = pPrice + sPrice + cPrice;
            discount = total * .2;
            total = (total - discount) * 2;
            total = total + pPrice;
            return total;
        }
        // Added Method 4
        // 3P, 3S, 2C
        public double Ad4(double pPrice, double sPrice, double cPrice, double total, double discount)
        {
            double temp = 0;
            total = pPrice + sPrice + cPrice;
            discount = total * .2;
            total = (total - discount) * 2;
            temp = pPrice + sPrice;
            discount = temp * .1;
            temp = temp - discount;
            total = total + temp;
            return total;
        }
        // Added Method 5
        // 3P, 3S, 3C
        public double Ad5(double pPrice, double sPrice, double cPrice, double total, double discount)
        {
            total = pPrice + sPrice + cPrice;
            discount = total * .2;
            total = (total - discount) * 3;
            return total;
        }
    }
}
