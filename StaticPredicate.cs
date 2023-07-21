using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit._test
{
	public class StaticPredicate<T>
	{
		static public bool Is(T obj) {

			if (obj==null)
			{
				return true;
				
			}
			return false;
		
		}


	}
}
