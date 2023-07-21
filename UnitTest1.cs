using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul.bit._test
{

	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var t = from x in (new int[] { } )
					select x;
		}
	}
}
