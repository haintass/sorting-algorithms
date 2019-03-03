namespace classicSortingAlgorithms.SortingClasses {
	using System.Collections.Generic;
	using System.Diagnostics;
	using System.Linq;

	class MergeSorting<T> : Sort<T> {
		public override string ClassName { get; set; } = "Merge";

		public override T[] Sorting(T[] array) {
			return MergeSort(array);
		}

		private T[] MergeSort(T[] array) {
			if (array.Length == 1) {
				return array;
			}

			int m = array.Length / 2;
			return Merge(MergeSort(array.Take(m).ToArray()), MergeSort(array.Skip(m).ToArray()));
		}

		private T[] Merge(T[] arr1, T[] arr2) {
			int ptr1 = 0, ptr2 = 0;
			T[] merged = new T[arr1.Length + arr2.Length];

			for (int i = 0; i < merged.Length; i++) {
				if (ptr1 < arr1.Length && ptr2 < arr2.Length) {
					merged[i] = Comparer.Compare(arr1[ptr1], arr2[ptr2]) > 0 ? arr2[ptr2++] : arr1[ptr1++];
				}
				else {
					merged[i] = ptr2 < arr2.Length ? arr2[ptr2++] : arr1[ptr1++];
				}
			}

			return merged;
		}

		public MergeSorting(T[] array, IComparer<T> comparer) : base(array) {
			Comparer = comparer;
		}

		public MergeSorting(IComparer<T> comparer) : base() {
			Comparer = comparer;
		}
	}
}