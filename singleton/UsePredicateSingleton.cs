using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit._test.singleton
{
	[Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
      public class MyTestClass
      {
		[Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
		public void TestPredicateSingleton()
		{
			
			 PredicateSingletonXGtThree.Instance.assert(2);
		}


      }
	
}
