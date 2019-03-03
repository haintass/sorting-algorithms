namespace classicSortingAlgorithms.SortingClasses {
	using System.Collections.Generic;

	class CocktailSorting<T> : Sort<T> {
		public override string ClassName { get; set; } = "Cocktail";

		public override T[] Sorting(T[] array) {
			int left = 0;
			int right = array.Length - 1;
			int border = 0;

			while (left < right) {
				for (int i = left; i < right; i++) {
					if (Comparer.Compare(array[i], array[i + 1]) == 1) {
						Swap(array, i, i + 1);
						border = i;
					}
				}
				right = border;

				if (left >= right) break;

				for (int i = right; i > left; i--) {
					if (Comparer.Compare(array[i - 1], array[i]) == 1) {
						Swap(array, i, i - 1);
						border = i;
					}
				}
				left = border;
			}

			return array;
		}

		public CocktailSorting(T[] array, IComparer<T> comparer) : base(array) {
			Comparer = comparer;
		}

		public CocktailSorting(IComparer<T> comparer) : base() {
			Comparer = comparer;
		}
	}
}
