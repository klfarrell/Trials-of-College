using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApplication1;

namespace UnitTestProject1
{

    // LITERALLY JUST RIGHT CLICK TestClass AND SELECT "Run Tests" WITH THE VIAL NEXT TO IT
    [TestClass]
    public class BoardTests
    {
        [TestMethod]
        public void verifyInitBoard_CorrectTiles()
        {
            Board myboard = new Board();

            Assert.AreEqual( ( (EventTile ) myboard.getTileAt( 38 ) ).getText(), "Taxi Service Surge Pricing — Take $1000 in Loans" );
            Assert.AreEqual( myboard.getTileAt( 64 ), null );
        }

        [TestMethod]
        public void eventTile_ActOnPlayer()
        {
            Player p = new Player( "", "", 0, 0, 0, 0, false, false );
            Tile testLoanTile = new EventTile( "testing 1", EventTileType.LOAN, 3 );
            Tile testOCCTile = new EventTile( "testing 2", EventTileType.OCC, -2 );
            Tile testFriendTile = new EventTile( "testing 3", EventTileType.FRIEND, 4 );

            Assert.AreEqual( "testing 1", testLoanTile.actOnPlayer( p ) );
            Assert.AreEqual( p.numLoans, 3 );

            Assert.AreEqual( "testing 2", testOCCTile.actOnPlayer( p ) );
            Assert.AreEqual( p.numCredits, -2 );

            Assert.AreEqual( "testing 3", testOCCTile.actOnPlayer( p ) );
            Assert.AreEqual( p.numFriends, 4 );
        }

        [TestMethod]
        public void tile_isStopTile()
        {
            Tile testEvent = new EventTile( "", EventTileType.FRIEND, 0 );
            Tile testStop = new StopTile();

            Assert.IsTrue( testStop.isStopTile() );
            Assert.IsFalse( testEvent.isStopTile() );
        }
    }
}
