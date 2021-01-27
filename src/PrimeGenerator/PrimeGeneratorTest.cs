using NUnit.Framework;

namespace AgileSoftwareDevelopment.PrimeGenerator {
    [TestFixture]
    public class PrimeGeneratorTest {
        [Test]
        public void TestPrimes() {
            int[] nullArray = PrimeGenerator.GeneratePrimeNumbers(0);
            Assert.AreEqual(0, nullArray.Length);

            int[] minArray = PrimeGenerator.GeneratePrimeNumbers(2);
            Assert.AreEqual(1, minArray.Length);
            Assert.AreEqual(2, minArray[0]);

            int[] threeArr = PrimeGenerator.GeneratePrimeNumbers(3);
            Assert.AreEqual(2, threeArr.Length);
            Assert.AreEqual(2, threeArr[0]);
            Assert.AreEqual(3, threeArr[1]);

            int[] centArr = PrimeGenerator.GeneratePrimeNumbers(100);
            Assert.AreEqual(25, centArr.Length);
            Assert.AreEqual(97, centArr[24]);
        }

        [Test]
        public void TestExhaustive() {
            for (int i = 2; i < 500; i++) {
                VerifyPrimeList(PrimeGenerator.GeneratePrimeNumbers(i));
            }
        }

        private void VerifyPrimeList(int[] list) {
            for (int i = 0; i < list.Length; i++) {
                VerifyPrime(list[i]);
            }
        }

        private void VerifyPrime(int n) {
            for (int factor = 2; factor < n; factor++) {
                Assert.IsTrue(n % factor != 0);
            }
        }
    }
}
