using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace nilnul._bit_._TEST_.op_.binary.cumulator.be_.unard
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var ops = nilnul.bit.op_.binary.Sortie.OfAll();
			var leftUnardBe = nilnul.bit.op_.binary.cumulator.be_.LeftUnard.Singleton;
			var rightUnardBe = nilnul.bit.op_.binary.cumulator.be_.RightUnard.Singleton;
			var unardBe = nilnul.bit.op_.binary.cumulator.be_.Unard.Singleton;

			var dict = new Dictionary<bit.op_.BinaryI1, (bool, bool, bool, bool, bool, bool)>();


			foreach (var op in ops.ee)
			{
				var cumulatorForNil = new nilnul.bit.op_.binary.Cumulator(false, op);

				var cumulatorForOne = new nilnul.bit.op_.binary.Cumulator(true, op);

				dict.Add(
					op
					,
					(leftUnardBe.be(cumulatorForNil)
					, rightUnardBe.be(cumulatorForNil)
					,
unardBe.be(cumulatorForNil)

,
leftUnardBe.be(cumulatorForOne)
,
rightUnardBe.be(cumulatorForOne)
,
unardBe.be(cumulatorForOne)


)

				);





			}

			foreach (var item in dict)
			{
				Debug.WriteLine(
					$"--------------{item.Key}-----------------"
				);
				Debug.WriteLine(
					item.Key
				);
				Debug.WriteLine(
					"-------------cumulatorForNil--------------------"
				);

				Debug.WriteLine(
					item.Value.Item1
				); ;

				Debug.WriteLine(
					item.Value.Item2
				); ;

				Debug.WriteLine(
					item.Value.Item3
				); ;
				Debug.WriteLine(
					"-------------cumulatorForone--------------------"
				);

				Debug.WriteLine(
					item.Value.Item4
				); ;

				Debug.WriteLine(
					item.Value.Item5
				); ;

				Debug.WriteLine(
					item.Value.Item6
				); ;


			}

				Debug.WriteLine(
					"============unard for initial 0, or 1, or both============="
				);

			foreach (var item in dict.Where(
				kv => kv.Value.Item3 || kv.Value.Item6
			))
			{
				Debug.WriteLine(
					"------------------------"
				);
				Debug.WriteLine(
					item.Key
				);
				Debug.WriteLine(
					"-------------cumulatorForNil--------------------"
				);

				Debug.WriteLine(
					item.Value.Item1
				); ;

				Debug.WriteLine(
					item.Value.Item2
				); ;

				Debug.WriteLine(
					item.Value.Item3
				);

				Debug.WriteLine(
	"-------------cumulatorForone--------------------"
);

				Debug.WriteLine(
					item.Value.Item4
				); ;

				Debug.WriteLine(
					item.Value.Item5
				); ;

				Debug.WriteLine(
					item.Value.Item6
				); ;

			}

			Debug.WriteLine(
				"==============leftunardOnly==============="
			);


			foreach (var item in dict.Where(kv =>
				bit.op_.binary_.Gt.Singleton.op(
					kv.Value.Item1,
				kv.Value.Item3
				)
			))
			{
				Debug.WriteLine(
					$"--------------{item.Key}-------------"
				);
				Debug.WriteLine(
					item.Key
				);
				Debug.WriteLine(
					"-------------cumulatorForNil--------------------"
				);

				Debug.WriteLine(
					item.Value.Item1
				); ;

				Debug.WriteLine(
					item.Value.Item2
				); ;

				Debug.WriteLine(
					item.Value.Item3
				); ;
			}
			Debug.WriteLine(
				"==============rightunardOnly==============="
			);

			foreach (var item in dict.Where(kv =>
				bit.op_.binary_.Gt.Singleton.op(
					kv.Value.Item2,
				kv.Value.Item3
				)
			))
			{
				Debug.WriteLine(
					$"----------{item.Key}---------------"
				);
				Debug.WriteLine(
					item.Key
				);
				Debug.WriteLine(
					"-------------cumulatorForNil--------------------"
				);

				Debug.WriteLine(
					item.Value.Item1
				); ;

				Debug.WriteLine(
					item.Value.Item2
				); ;

				Debug.WriteLine(
					item.Value.Item3
				); ;
			}

		}

	}

}
