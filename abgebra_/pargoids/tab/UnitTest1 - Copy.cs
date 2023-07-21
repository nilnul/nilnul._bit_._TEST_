using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;

namespace nilnul._bit_._TEST_.algebra_.pargoids.tab
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var biops = nilnul.bit.op_.binary.Sortie.OfAll();

			var bits = nilnul.bit.Sortie.OfAll();

			var cos = nilnul.bit.co.Sortie.All;

			var table = new DataTable() {
				
			};

			var cols = new[] {
				new DataColumn("biop")
				,
				new DataColumn("isCommutable")
				,
				new DataColumn("isAssociative")
				,
				new DataColumn("leftUnard4cumlator0")
				,
				new DataColumn("rightUnard4cumlator0")
				,
				new DataColumn("unard4cumlator0")
				,
				new DataColumn("inversePairFor0")	
				,
				new DataColumn("leftUnard4cumlator1")
				,
				new DataColumn("rightUnard4cumlator1")
				,
				new DataColumn("unard4cumlator1")
				,
				new DataColumn("inversePairFor1")
			};
			table.Columns.AddRange(cols);

			foreach (var op in biops.ee)
			{
				var r=table.NewRow();
				var cumulatorFalsy = new nilnul.bit.op_.binary.cumulator_.Falsy(op);

				var leftUnardFor0 = nilnul.bit.op_.binary.cumulator.be_.LeftUnard.Singleton.be(
						cumulatorFalsy
					);

				var rightUnardFor0 = nilnul.bit.op_.binary.cumulator.be_.RightUnard.Singleton.be(
						cumulatorFalsy
					);

				var cumulatorTruthy = new nilnul.bit.op_.binary.cumulator_.Truthy(op);

				var leftUnardFor1 = nilnul.bit.op_.binary.cumulator.be_.LeftUnard.Singleton.be(
						cumulatorTruthy
					);

				var rightUnardFor1 = nilnul.bit.op_.binary.cumulator.be_.RightUnard.Singleton.be(
						cumulatorTruthy
					);




				r.ItemArray = new object[] {
					op
					,
					nilnul.bit.op_.binary.be_.Commutable.Singleton.be(op)
					,
					nilnul.bit.op_.binary.be_.Associative.Singleton.be(op)
					,
					leftUnardFor0
					,
					rightUnardFor0
					,
					leftUnardFor0 && rightUnardFor0
					,
					string.Join(";",
						nilnul.obj.tups._PhraseX.Lines(
							cos.ee.Select(
								c=>(c, op.op(c.Item1,c.Item2))
							).Where(
								d=>d.Item2 ==false
							).Select(x=>(IEnumerable<object>) new object[]{  x.c.Item1,x.c.Item2 })
						)
					)
					,
					leftUnardFor1
					,
					rightUnardFor1
					,
					leftUnardFor1&&rightUnardFor1
					,
					string.Join(";",
						nilnul.obj.tups._PhraseX.Lines(cos.ee.Select(
							c=>(c, op.op(c.Item1,c.Item2))
						).Where(
							d=>d.Item2 ==true
						).Select(x=> new object[]{x.c.Item1,x.c.Item2 })
						)
					)
					,



				};

				table.Rows.Add(r);


				

			}

			var tmp = System.IO.Path.GetTempPath();


			var csv =(
				System.IO.Path.Combine(
					tmp
					,
					Guid.NewGuid().ToString()+".csv"
				)
			);

			System.IO.File.WriteAllLines(
				csv,
				nilnul.obj.tups_.table.phrase_._CelSepByTabX.Lines(table)
			);

			var container=System.IO.Path.GetDirectoryName(csv);
			Process.Start(container);


			Process.Start(csv);

		}
	}
}
