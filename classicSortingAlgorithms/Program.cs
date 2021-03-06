﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using classicSortingAlgorithms.SortingClasses;

namespace classicSortingAlgorithms {
	class Program {
		static void Main(string[] args) {
			ComparerInt comparer = new ComparerInt();
			Random random = new Random();

			int[] smallArray = new int[1000];
			int[] middleArray = new int[10000];
			int[] largeArray = new int[30000];

			for (int i = 0; i < smallArray.Length; i++) {
				smallArray[i] = random.Next(1, 100000);
			}

			for (int i = 0; i < middleArray.Length; i++) {
				middleArray[i] = random.Next(1, 100000);
			}

			for (int i = 0; i < largeArray.Length; i++) {
				largeArray[i] = random.Next(1, 100000);
			}

			List<Sort<int>> algorithms = new List<Sort<int>>() {
				new BubbleSorting<int>(comparer),
				new InsertionSorting<int>(comparer),
				new SelectionSorting<int>(comparer),
				new DoubleSelectionSorting<int>(comparer),
				new CocktailSorting<int>(comparer),
				new QuickSorting<int>(comparer),
				new MergeSorting<int>(comparer)
			};

			Console.WriteLine("Sorting of a small array:\n");
			foreach(var sort in algorithms) {
				sort.Stopwatch.Start();
				sort.Array = sort.Sorting(smallArray.ToArray());
				sort.Stopwatch.Stop();

				Console.WriteLine(sort.ClassName + ": " + sort.Stopwatch.Elapsed);
			}
			Console.WriteLine("\n--------------------------------------------\n");

			Console.WriteLine("Sorting of a middle array:\n");
			foreach (var sort in algorithms) {
				sort.Stopwatch.Start();
				sort.Array = sort.Sorting(middleArray.ToArray());
				sort.Stopwatch.Stop();

				Console.WriteLine(sort.ClassName + ": " + sort.Stopwatch.Elapsed);
			}
			Console.WriteLine("\n--------------------------------------------\n");

			Console.WriteLine("Sorting of a large array:\n");
			foreach (var sort in algorithms) {
				sort.Stopwatch.Start();
				sort.Array = sort.Sorting(largeArray.ToArray());
				sort.Stopwatch.Stop();

				Console.WriteLine(sort.ClassName + ": " + sort.Stopwatch.Elapsed);
			}
		}
	}

	class ComparerInt : IComparer<int> {
		int IComparer<int>.Compare(int x, int y) {
			return x == y ? 0 : x > y ? 1 : -1;
		}
	}
}
