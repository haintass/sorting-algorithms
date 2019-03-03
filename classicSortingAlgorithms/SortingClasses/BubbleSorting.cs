namespace classicSortingAlgorithms.SortingClasses {
	using System.Collections.Generic;
	using System.Diagnostics;

	class BubbleSorting<T> : Sort<T> {
		public override T[] Sorting(T[] array) {
			bool isSorted = false;
			int lastUnsorted = array.Length - 1;

			while (!isSorted) {
				isSorted = true;
				for (int i = 0; i < lastUnsorted; i++) {
					if (Comparer.Compare(array[i], array[i + 1]) == 1) {
						Swap(array, i, i + 1);
						isSorted = false;
					}
				}
				lastUnsorted--;
			}

			return array;
		}

		public BubbleSorting(T[] array, IComparer<T> comparer) : base(array) {
			Comparer = comparer;
		}
	}
}