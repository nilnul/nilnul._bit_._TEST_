using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace nilnul._bit_._TEST_.co.sortie
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var s = nilnul.bit.co.Sortie.Singleton;


			Assert.IsTrue(
				s.objs.ee.SequenceEqual(
					(((int,int)[] )([
						(0,0)
						,
						(0,1)
						,
						(1,0)
						,
						(1,1)
					] ) ).Select( c => ( nilnul.bit.co.of_._IntsX.Of(in c)) )
				)
			);
		}
	}
}
