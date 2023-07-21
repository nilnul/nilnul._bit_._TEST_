using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit._test.singleton
{
	public partial class PredicateDefaultableXGtThree:
		Predicate<int>
	{

		public PredicateDefaultableXGtThree()
			:base(x=>x>3)
		{
		}
					
	}
}
