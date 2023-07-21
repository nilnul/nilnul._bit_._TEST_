using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.bit;

namespace nilnul.bit._test
{
    [TestClass]
    public class GetUnitByte
    {
		[TestMethod]
		public void TestGetBit() {
			var bit0 = BitX.GetBit((byte)1, 0);	
			var bit1 = BitX.GetBit((byte)1, 1);
			var bit2 = BitX.GetBit((byte)6, 0);
			var bit3 = BitX.GetBit((byte)6, 1);

		
		}

        [TestMethod]
        public void TestGetUnitByte()
        {
            try
            {
                var byte_1 = BitX.GetUnitByte(-1);

            }
            catch (ArgumentOutOfRangeException)
            {

                //throw;
            }

            var byte0 = BitX.GetUnitByte(0);
            var byte7 = BitX.GetUnitByte(7);
            try
            {
                var byte8 = BitX.GetUnitByte(8);

            }
            catch (ArgumentOutOfRangeException)
            {

                // throw;
            }



        }
    }
}
