namespace classicSortingAlgorithms.SortingClasses {
	using System.Collections.Generic;

	class SelectionSorting<T> : Sort<T> {
		public override string ClassName { get; set; } = "Selection";

		public override T[] Sorting(T[] array) {
			for (int i = 0; i < array.Length; i++) {
				int min = i;

				for (int j = i + 1; j < array.Length; j++) {
					if (Comparer.Compare(array[min], array[j]) == 1)
						min = j;
				}

				if (min != i)
					Swap(array, min, i);
			}

			return array;
		}

		public SelectionSorting(T[] array, IComparer<T> comparer) : base(array) {
			Comparer = comparer;
		}

		public SelectionSorting(IComparer<T> comparer) : base() {
			Comparer = comparer;
		}
	}
}