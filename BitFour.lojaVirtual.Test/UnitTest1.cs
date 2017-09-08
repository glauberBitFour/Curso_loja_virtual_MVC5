using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BitFour.lojaVirtual.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BitTestMethod1()
        {

        }


        [TestMethod]
        public void Take()
        {
            int[] numeros = {1, 2, 3, 4, 5, 6, 7, 8, 9, 0};

            var resultado = from num in numeros.Take(3) select num;

            int[] tete = {1, 2, 3};
            CollectionAssert.AreEqual(resultado.ToArray(), tete);
        }


        [TestMethod]
        public void Skip()
        {
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            var resultado = from num in numeros.Take(5).Skip(2) select num;

            int[] tete = {3, 4, 5};
            CollectionAssert.AreEqual(resultado.ToArray(), tete);
        }
    }
}
