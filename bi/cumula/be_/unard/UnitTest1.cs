using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.obj.str;
using nilnul.obj.str.op_.of_;
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


			var tmp = System.IO.Path.GetTempPath();


			var csv = (
				System.IO.Path.Combine(
					tmp
					,
					DateTime.UtcNow.ToString("yyMMddHHmmssfffffff")+ ".csv"
				)
			);

			var sw=System.IO.File.AppendText(
				csv);
			sw.WriteLine(

				string.Join(",",
				[
					"op",

				nameof(leftUnardBe)
					, nameof(rightUnardBe)
					,nameof(
unardBe)

,nameof(
leftUnardBe)
,
				nameof(
rightUnardBe)
,nameof(
unardBe)

])

			);


			
				dict.Select(
					attr=>
						$"{attr.Key},{nilnul.objs._PhraseX._Phrase_0finite( attr.Value.ToSeq<bool>())}"
				).Each(l=>sw.WriteLine(l))
			;

			sw.Flush();
			sw.Close();
			sw.Dispose();

			var container = System.IO.Path.GetDirectoryName(csv);
			Process.Start(container);


			Process.Start(csv);

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
