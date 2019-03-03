namespace classicSortingAlgorithms.SortingClasses {
	using System.Collections.Generic;
	using System.Diagnostics;

	class QuickSorting<T> : Sort<T> {
		public override string ClassName { get; set; } = "Quick";

		public override T[] Sorting(T[] array) {
			Sorting(array, 0, array.Length - 1);

			return array;
		}

		public void Sorting(T[] array, int start, int end) {
			int l = start;
			int r = end;
			int m = start + (end - start >> 1);

			SwapIfGreater(array, l, m);
			SwapIfGreater(array, l, r);
			SwapIfGreater(array, m, r);

			T pivot = array[m];

			while (l <= r) {
				while (Comparer.Compare(array[l], pivot) < 0) l++;
				while (Comparer.Compare(array[r], pivot) > 0) r--;

				if (l <= r) {
					if (l < r) {
						Swap(array, l, r);
					}

					l++;
					r--;
				}
			}

			if (start < r)
				Sorting(array, start, r);
			if (end > l)
				Sorting(array, l, end);

			void SwapIfGreater(T[] arr, int a, int b) {
				if (Comparer.Compare(arr[a], arr[b]) <= 0)
					return;

				T temp = arr[a];
				arr[a] = arr[b];
				arr[b] = temp;
			}
		}

		public QuickSorting(T[] array, IComparer<T> comparer) : base(array) {
			Comparer = comparer;
		}

		public QuickSorting(IComparer<T> comparer) : base() {
			Comparer = comparer;
		}
	}
}
