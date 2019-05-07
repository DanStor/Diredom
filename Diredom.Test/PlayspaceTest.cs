using Microsoft.VisualStudio.TestTools.UnitTesting;
using Diredom.Playspace;

namespace Diredom.Test
{
    [TestClass]
    public class PlayspaceTest
    {
        [DataTestMethod]
        [DataRow(Attributes.BoardSize.Large, 10, 14)]
        [DataRow(Attributes.BoardSize.Small, 4, 6)]
        public void InitialiseBoardOfDimensionsXY(int xDimension, int yDimension)
        {

        }

        [TestMethod]
        public void BoardArrayContainsTileReferences()
        {

        }

        [TestMethod]
        public void ExceptionThrownIfTileReferenceMissingFromBoard()
        {

        }

        [TestMethod]
        public void TileOccupationDefaultIsEmpty()
        {

        }

        [TestMethod]
        public void GivenTileCannotHaveMoreThanOneOccupyingUnit()
        {

        }

        [TestMethod]
        public void TileIsOccupiedWhenUnitMovesOntoTile()
        {

        }

        [TestMethod]
        public void TileReturnsToEmptyStateWhenOccupyingUnitMoves()
        {

        }

        [TestMethod]
        public void TileHasTileAttribute()
        {

        }

        [TestMethod]
        public void ErrorThrownIfTileDoesNotHaveAttribute()
        {

        }
    }
}
