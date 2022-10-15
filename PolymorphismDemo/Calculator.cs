using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    internal class Calculator
    {
       //Static polymorphism
        //Complie time polymorphmism


        //Method Overloading 
        public int Add(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }
        public int Add(int n1, int n2)
        {
            return n1 + n2;
        }

        public float  Add(float n1, float n2)
        {
            return  n1 + n2;
        }
    }
}
