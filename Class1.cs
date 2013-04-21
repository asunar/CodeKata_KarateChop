using System;
using System.Linq;
using NUnit.Framework;

namespace CodeKata_KarateChop
{
    public class KarateChop
    {
        [Test]
        public void should_find_using_binary_search()
        {
            //Assert.AreEqual(-1, Chop(3, new int[]{}));
            //Assert.AreEqual(-1, Chop(3, new [] { 1 }));
            //Assert.AreEqual(0, Chop(1, new[] {1}));
           
            Assert.AreEqual(0,  Chop(1, new[] {1, 3, 5}));
            Assert.AreEqual(1,  Chop(3, new[] {1, 3, 5}));
            Assert.AreEqual(2,  Chop(5, new[] {1, 3, 5}));
            Assert.AreEqual(-1, Chop(0, new[] {1, 3, 5}));
            Assert.AreEqual(-1, Chop(2, new[] {1, 3, 5}));
            Assert.AreEqual(-1, Chop(4, new[] {1, 3, 5}));
            Assert.AreEqual(-1, Chop(6, new[] {1, 3, 5}));
            

            Assert.AreEqual(0,  Chop(1, new[] {1, 3, 5, 7}));
            Assert.AreEqual(1,  Chop(3, new[] {1, 3, 5, 7}));
            Assert.AreEqual(2,  Chop(5, new[] {1, 3, 5, 7}));
            Assert.AreEqual(3,  Chop(7, new[] {1, 3, 5, 7}));
            Assert.AreEqual(-1, Chop(0, new[] {1, 3, 5, 7}));
            Assert.AreEqual(-1, Chop(2, new[] {1, 3, 5, 7}));
            Assert.AreEqual(-1, Chop(4, new[] {1, 3, 5, 7}));
            Assert.AreEqual(-1, Chop(6, new[] {1, 3, 5, 7}));
            Assert.AreEqual(-1, Chop(8, new[] {1, 3, 5, 7}));   
            Assert.AreEqual(8, Chop(9, new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}));   
        }

            private static int Chop(int itemToFind, int[] sortedArray)
            {
                if(sortedArray.Length == 0) return -1;
                
                if (sortedArray.Length == 1)
                    return sortedArray[0] == itemToFind ? 0 : -1;

                var midPointIndex = sortedArray.Length/2;

                if (sortedArray[midPointIndex] == itemToFind)
                    return midPointIndex;

                if (sortedArray[midPointIndex] > itemToFind)
                {
                    var pos1 = Chop(itemToFind, sortedArray.Take(midPointIndex).ToArray());
                    return pos1 == -1 ? -1 : pos1;
                }

                var pos = Chop(itemToFind, sortedArray.Skip(midPointIndex).ToArray());
                return pos == -1 ? -1 : pos + sortedArray.Length / 2;
            }


    }


}
