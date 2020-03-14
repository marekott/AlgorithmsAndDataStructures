# AlgorithmsAndDataStructures

Library containing algorithms and data structures. Written in .NET Standard 2.0, can be used both with .NET Framework and .NET Core.

- AlgorithmsExtension Build: ![Build Status](
https://dev.azure.com/marekott94/AlgorithmsAndDataStructures/_apis/build/status/AlgorithmsBuild?branchName=master "Build Status")
- AlgorithmsExtension Release: ![Release Status](
https://vsrm.dev.azure.com/marekott94/_apis/public/Release/badge/2413bb11-0690-4a93-94d6-5246c6d9b814/1/1 "Release Status")

## Table of Contents
1. [ AlgorithmsExtensions ](#algorithmsExtensions)<br/>
1.1 [ Sorting Algorithms ](#sortingAlgorithms)<br/>
1.1.1 [ Bubble Sort ](#bubbleSort)<br/>
1.1.2 [ Insertion Sort ](#insertionSort)<br/>
1.1.2 [ Merge Sort ](#mergeSort)<br/>
1.1.3 [ Quick Sort ](#quickSort)<br/>
1.1.4 [ Counting Sort ](#countingSort)<br/>
2. [ Sources ](#sources)<br/>

<a name="algorithmsExtensions"></a>
## AlgorithmsExtensions 
AlgorithmsExtensions is installed from NuGet.
```
Install-Package AlgorithmsExtension
```
<a name="sortingAlgorithms"></a>
### Sorting Algorithms
Sorting algorithms are implemented as IList extensions methods.<br/>
Usage:
```
using AlgorithmsExtension.Sorting;
```

Sorting algorithms were tested on arrays of 35000 elements with numbers from 0 to 999. Each of them in 3 cases, when data are already sorted (optimistic case), when they are not (random case) and when they were sorted in reverse order (pessimistic case). Each time algorithms were sorting ten times and an average of all cases where computed. Results are presented in milliseconds.

<p>
  <img src="src/Algorithms/img/Algorithms performance.jpg" alt="Algorithms performance"/>
</p>

For beater reading executions that exceded 25 milliseconds were reduced to that time. Real performance were: BubbleSort(7555.1, 8040.3, 8241), InsertionSort(0.1, 447.1, 819.7).

<a name="bubbleSort"></a>
#### BubbleSort
```csharp
/// <summary>
/// Sorts IList collection in ascending order using bubble sort algorithm
/// </summary>
/// <typeparam name="T"></typeparam>
/// <param name="collection"></param>
public static void BubbleSortAsc<T>(this IList<T> collection) where T : IComparable, IComparable<T>
```
```csharp
/// <summary>
/// Sorts IList collection in descending order using bubble sort algorithm
/// </summary>
/// <typeparam name="T"></typeparam>
/// <param name="collection"></param>
public static void BubbleSortDesc<T>(this IList<T> collection) where T : IComparable, IComparable<T>
```

<a name="insertionSort"></a>
#### InsertionSort
```csharp
/// <summary>
/// Sorts IList collection in ascending order using insertion sort algorithm.
/// </summary>
/// <typeparam name="T"></typeparam>
/// <param name="collection"></param>
public static void InsertionSortAsc<T>(this IList<T> collection) where T : IComparable, IComparable<T>
```
```csharp
/// <summary>
/// Sorts IList collection in descending order using insertion sort algorithm.
/// </summary>
/// <typeparam name="T"></typeparam>
/// <param name="collection"></param>
public static void InsertionSortDesc<T>(this IList<T> collection) where T : IComparable, IComparable<T>
```

<a name="mergeSort"></a>
#### MergeSort
```csharp
/// <summary>
/// Sorts IList collection in ascending order using recursive divide-and-conquer algorithm
/// </summary>
/// <typeparam name="T"></typeparam>
/// <param name="collection"></param>
/// <param name="startIndex">Index of the first element of the collection</param>
/// <param name="lastIndex">Index of the last element of the collection</param>
public static void MergeSortAsc<T>(this IList<T> collection, int startIndex, int lastIndex) where T : IComparable, IComparable<T>
```
```csharp
/// <summary>
/// Sorts IList collection in descending order using recursive divide-and-conquer algorithm
/// </summary>
/// <typeparam name="T"></typeparam>
/// <param name="collection"></param>
/// <param name="startIndex">Index of the first element of the collection</param>
/// <param name="lastIndex">Index of the last element of the collection</param>
public static void MergeSortDesc<T>(this IList<T> collection, int startIndex, int lastIndex) where T : IComparable, IComparable<T>
```

<a name="quickSort"></a>
#### QuickSort
```csharp
/// <summary>
/// Sorts IList collection in ascending order using Quick sort algorithm
/// </summary>
/// <typeparam name="T"></typeparam>
/// <param name="collection"></param>
/// <param name="startIndex">Index of the first element of the collection</param>
/// <param name="lastIndex">Index of the last element of the collection</param>
public static void QuickSortAsc<T>(this IList<T> collection, int startIndex, int lastIndex) where T : IComparable, IComparable<T>
```
```csharp
/// <summary>
/// Sorts IList collection in descending order using Quick sort algorithm
/// </summary>
/// <typeparam name="T"></typeparam>
/// <param name="collection"></param>
/// <param name="startIndex">Index of the first element of the collection</param>
/// <param name="lastIndex">Index of the last element of the collection</param>
public static void QuickSortDesc<T>(this IList<T> collection, int startIndex, int lastIndex) where T : IComparable, IComparable<T>
```

<a name="countingSort"></a>
#### CountingSort
Counting sort algorithm is available for IList collections of types uint and ulong. Both versions have the same signatures.
```csharp
/// <summary>
/// Sorts IList collection in ascending order using counting sort algorithm
/// </summary>
/// <param name="collection"></param>
/// <param name="maxValue">The maximum value of the sorted collection</param>
/// <returns>New sorted IList collection</returns>
public static IList<uint> CountingSortAsc(this IList<uint> collection, uint maxValue)
```
```csharp
/// <summary>
/// Sorts IList collection in descending order using counting sort algorithm
/// </summary>
/// <param name="collection"></param>
/// <param name="maxValue">The maximum value of the sorted collection</param>
/// <returns>New sorted IList collection</returns>
public static IList<uint> CountingSortDesc(this IList<uint> collection, uint maxValue)
```

<a name="sources"></a>
## Sources
1. Thomas H. Cormen, Charles E. Leiserson, Ronald L. Rivest, Clifford Stein (2009). *Introduction to Algorithms*. 
Massachusetts Institute of Technology.
