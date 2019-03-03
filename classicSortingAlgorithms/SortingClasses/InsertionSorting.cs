namespace classicSortingAlgorithms.SortingClasses {
	using System.Collections.Generic;
	using System.Diagnostics;

	class InsertionSorting<T> : Sort<T> {
		public override T[] Sorting(T[] array) {
			for (int i = 1; i < array.Length; i++) {
				int j = i;
				T current = array[j];

				while (j > 0 && Comparer.Compare(array[j - 1], current) == 1) {
					array[j] = array[j - 1];
					j--;
				}
				array[j] = current;
			}

			return array;
		}

		public InsertionSorting(T[] array, IComparer<T> comparer) : base(array) {
			Comparer = comparer;
		}
	}
}