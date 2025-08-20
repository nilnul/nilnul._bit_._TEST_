using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.bit.to_;
using nilnul.bit0nul.to_;

using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;

namespace nilnul.bit0nul.abgebra_.pargoid.str
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var op8outcomeEs = nilnul.bit0nul.bi._SortieX.EachAsOutcome().ToArray();

			var els = nilnul.bit0nul._SortieX.ARRAY;

			var cos = nilnul.bit0nul.co._SortieX.Array;

			var table = new DataTable()
			{

			};

			var cols = new List<DataColumn> {
				new DataColumn("biop")
				,
				new DataColumn("isCommutable")
				,
				new DataColumn("isAssociative")
				,
				//new DataColumn("leftUnard4cumlator0")
				//,
				//new DataColumn("rightUnard4cumlator0")
				//,
				//new DataColumn("unard4cumlator0")
				//,
				//new DataColumn("inversePairFor0")
				//,
				//new DataColumn("leftUnard4cumlator1")
				//,
				//new DataColumn("rightUnard4cumlator1")
				//,
				//new DataColumn("unard4cumlator1")
				//,
				//new DataColumn("inversePairFor1")
			};


			cols.AddRange(
					((string[])
					[
						$"initial"
						,
						$"beLeftUnard"

						,
						$"beRightUnard"
						,
						$"beUnard"
						,
						$"inversesLeft"     // for each el
						,
						$"inversesRight"     // for each el
						,
						$"inverses"     // for each el
						,
						$"inversible"

					]).Select(x => new DataColumn(x))

			);


			//foreach (var item in els)
			//{


			//}
			table.Columns.AddRange(cols.ToArray());

			foreach (var op8outcome in op8outcomeEs)
			{
				//var bitOp = op8outcome
				foreach (var item in els)
				{

					var r = table.NewRow();

					var el8txt = bit0nul._TxtenX.TextenAsNum(item);

					var op1 = new nilnul.bit0nul.Bi(op8outcome.ToArray());
					var cumula = new nilnul.bit0nul.bi.Cumulator(item, op1);


					var leftUnardFor0 = nilnul.bit0nul.bi.cumula.be_._unard.semi_.LeftUnard.Singleton.be(
							cumula
						);

					var rightUnardFor0 = nilnul.bit0nul.bi.cumula.be_._unard.semi_.RightUnard.Singleton.be(
							cumula
						);
					var inversesLeft = new Dictionary<ValueTuple<bool?>, IEnumerable<bool?>>();

					var inversesRight = new Dictionary<ValueTuple<bool?>, IEnumerable<bool?>>();

					var inverses = new Dictionary<ValueTuple<bool?>, IEnumerable<bool?>>();

					foreach (var item11 in bit0nul._SortieX.ARRAY)
					{
						var valLeft = new List<bool?>();
						var valRight = new List<bool?>();
						var val = new List<bool?>();

						foreach (var item222 in _SortieX.ARRAY)
						{
							bool left = op1.op(item11, item222) == item;
							bool right = op1.op(item222, item11) == item;

							if (left)
							{
								valLeft.Add(item222);
							}
							if (right)
							{
								valRight.Add(item222);
							}
							if (left && right)
							{
								val.Add(item222);

							}


						}
						inversesLeft.Add( new ValueTuple<bool?>(item11), valLeft);
						inversesRight.Add(new ValueTuple<bool?>( item11), valRight);
						inverses.Add( new ValueTuple<bool?>(
							item11), val
						);
					}



					r.ItemArray = new object[] {
						op1.ToString()
						,

						nilnul.bit0nul.bi.be_._CommutableX.IsCommutable(op1).ToNum().ToString()
						,
						nilnul.bit0nul.bi.be_._AssociativeX.IsAssociative(op1).ToNum().ToString()
						,
						item.ToNum().ToString()
						,
						leftUnardFor0.ToNum().ToString()
						,
						rightUnardFor0.ToNum().ToString()
						,
						(leftUnardFor0 && rightUnardFor0).ToNum().ToString()
						,
						dict2txt(inversesLeft)

						,
						dict2txt(inversesRight)
						,

						dict2txt(inverses)
						,
						inverses.All(a=>a.Value.Any()).ToNum()


					};

					table.Rows.Add(r);

				}




			}

			var tmp = System.IO.Path.GetTempPath();


			var csv = (
				System.IO.Path.Combine(
					tmp
					,
					System.DateTime.Now.ToString("yyMMddHHmmssfffffff").ToString() + ".csv"
				)
			);

			System.IO.File.WriteAllLines(
				csv,
				nilnul.obj.tups.tbl._PhraseX.Lines(table)
			);

			var container = System.IO.Path.GetDirectoryName(csv);
			Process.Start(container);


			Process.Start(csv);

			static string dict2txt(Dictionary<ValueTuple<bool?>, IEnumerable<bool?>> inversesLeft)
			{
				return string.Join(";",

									inversesLeft.Select(kv => $"{kv.Key.Item1.ToNum()}:{nilnul.bit0nul.str.txten_._AsNumsX.AsTernary(kv.Value)}")

				);
			}
		}
	}
}
