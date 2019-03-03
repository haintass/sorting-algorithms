namespace classicSortingAlgorithms.SortingClasses {
	using System.Collections.Generic;

	class DoubleSelectionSorting<T> : Sort<T> {
		public override T[] Sorting(T[] array) {
			int lastUnsorted = array.Length - 1;

			for (int i = 0; i <= lastUnsorted; i++) {
				int min = i;
				int max = lastUnsorted;

				for (int j = i + 1; j <= lastUnsorted; j++) {
					if (Comparer.Compare(array[min], array[j]) == 1)
						min = j;

					if (Comparer.Compare(array[j - 1], array[max]) == 1)
						max = j - 1;
				}

				if (min != i) {
					if (i == max) {
						max = min;
					}
					Swap(array, min, i);
				}
				if (max != lastUnsorted) {
					Swap(array, max, lastUnsorted);
				}
				lastUnsorted--;
			}

			return array;
		}

		public DoubleSelectionSorting(T[] array, IComparer<T> comparer) : base(array) {
			Comparer = comparer;
		}
	}
}