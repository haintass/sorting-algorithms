namespace classicSortingAlgorithms.SortingClasses {
	using System.Collections.Generic;
	using System.Diagnostics;

	abstract class Sort<T> {
		public T[] Array { get; set; }
		public Stopwatch Stopwatch { get; set; }
		public IComparer<T> Comparer { get; set; }
		public abstract string ClassName { get; set; }

		public void Swap(T[] arr, int first, int second) {
			T temp = arr[first];
			arr[first] = arr[second];
			arr[second] = temp;
		}

		public abstract T[] Sorting(T[] array);

		public Sort() {
			Stopwatch = new Stopwatch();
		}

		public Sort(T[] array) {
			Array = array;
			Stopwatch = new Stopwatch();
		}
	}
}
