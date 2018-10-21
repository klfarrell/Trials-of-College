using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApplication1;

namespace UnitTestProject1
{

    // LITERALLY JUST RIGHT CLICK TestClass AND SELECT "Run Tests" WITH THE VIAL NEXT TO IT
    [TestClass]
    public class ExampleTests
    {
        [TestMethod]
        public void VerifyThreeTimesThreeIsNine()
        {
            var three = 3;
            var nine = 9;
            var threeTimesThree = three * three;

            // Make sure three times three is nine
            Assert.AreEqual(threeTimesThree, nine);

            // Another way to do this, for when we aren't comparing numbers
            Assert.IsTrue(threeTimesThree == nine, "This prints when one of these fails");            
        }

        // As per our duty to the party, let's verify that two plus two is five
        // Should this test fail, we are in GRAVE danger.
        [TestMethod]
        public void VerifyTwoPlusTwoEqualsFive() {

            var two = 2;
            var twoPlusTwo = 2 + 2;
            var five = 5;

            Assert.IsTrue(twoPlusTwo == five, "Doubleplusungood error: two plus two is coming out as " +
                twoPlusTwo + " when it should be five. Rectify addition module immediatewise.");
        }

        // So obviously the point of this is that we test objects from our actual project so here
        // is an example of that with the dummy xy object
        [TestMethod]
        public void VerifyXYWorks() {
            var xyObject = new XYSaveData(5, 10);

            Assert.AreEqual(xyObject.x, 5, "Something's very wrong here.");
            Assert.AreEqual(xyObject.y, 10, "Seriously, I set y to 10. This should work.");
        }


        // Sometimes we just wanna ignore a test because it doesn't matter yet.
        // Don't know if we'll actually need it.
        [TestMethod]
        [Ignore]
        public void VerifyStringTheoryDoesNotConflictWithRelativity() {
            // Must implement StringTheorySimulator first
        }
    }
}
