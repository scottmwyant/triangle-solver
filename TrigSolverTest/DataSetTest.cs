using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TrigSolverTest
{
    [TestClass]
    public class DataSetTest
    {
        private const double testPrecision = .000001;

        [TestMethod]
        public void Profile()
        {
            TrigSolver.Data data = new TrigSolver.Data
            {
                angA = 0, angB = .15, angC = 0,
                lenA = 0, lenB = 0, lenC = 0
            };

            TrigSolver.DataSet ds = new TrigSolver.DataSet(data);

            Assert.AreEqual(ds.Profile, "010000", false);
        }

    }
}
