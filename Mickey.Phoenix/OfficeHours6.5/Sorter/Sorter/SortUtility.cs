using System;
using System.Collections.Generic;

namespace Sorter
{
    public class SortUtility
    {
        // "Auto-property" -- this is kind of like an instance variable, and kind of like the combination
        // of a "getter method" and a "setter method".
        // You can say Console.WriteLine(sortUtils.Operations), and it will write out the value of
        // Operations.
        // You can say sortUtils.Operations = 0, and it will reset the number of operations to zero.
        public int Operations { get; set; }

        public void Sort(int[] values)
        {
            // How I sort a handful of playing cards in numerical order:
            // I look at the first card and the second card, and compare them.
            // If they're in the right order, I go on to the third card.
            // If they're not in the right order, I swap them.
            //
            // Then I look at the third card.  If it's smaller than the first
            // card, then I put it in front of the first card.  If it's bigger 
            // than the first card but smaller than the second card, then I
            // put it in between them.  If it's bigger than both of them, then
            // I leave it where it is.
            //
            // Then I look at the fourth card.  If it's smaller than the first
            // card, I put it in front; likewise, between the first and second
            // or second and third.  If it's bigger than all three of the first
            // cards, I leave it where it is.
            //
            // When I get to the last card, and I've put it into its correct place
            // in the stack, I'm done.
            //
            // This is tricky when using an array, because if I want to take the
            // fourth card and put it at the beginning, I have to move the first
            // three cards up one position in the array, and then put the fourth
            // card where the first card ones.
            //
            // This algorithm, by the way, is called "insertion sort".

            // Another way I might sort a stack of playing cards:
            //
            // I look through the stack for the lowest value, and I swap it
            // with the first card on the stack.
            //
            // Then I look through the rest of the stack (everything but the
            // first value) for the lowest value, and I swap it with the second
            // card on the stack.
            //
            // Then I look through the rest of the stack (from the third card
            // to the end) for the lowest value, and I swap it with the third 
            // card on the stack.
            //
            // When I get to the last card, I'm done.
            //
            // This is tricky when working with an array, because I have to
            // keep track both of the lowest value I've seen during this scan,
            // and of the index of that value (or, I have to keep looking up the
            // value at the index "index_of_lowest_value").
            //
            // This algorithm is called "selection sort".

            // What's another way I could sort the cards in the stack?
            //
            // I could start at the first card, and compare pairs of cards
            // from there to the end.  If they're out of order, I swap them.
            //
            // This will result in the biggest card "bubbling up" to the top
            // position.
            //
            // Then, I start at the first card again, and compare pairs of cards
            // from there to one card before the end (since the last card is
            // already the biggest card).  If they're out of order, I swap them.
            //
            // This will result in the second-biggest card "bubbling up" to the
            // second-from-the-top position.
            //
            // Then, I start at the first card again, and compare pairs of cards
            // from there to the third card from the top.
            //
            // And so on, until I've only got one card left, and then I'm done.
            //
            // This is actually a pretty straightforward algorithm to implement
            // with an array, because we're only ever comparing two adjacent
            // elements, and swapping them if they are out of order.
            //
            // This algorithm is called "bubble sort", for obvious reasons.

            BubbleSortEfficient(values);
        }

        // I'm going to implement a really, really, really simple sort.
        //
        // It's a version of BubbleSort, but it's a very inefficient version of BubbleSort.
        //
        // The algorithm (in human terms) goes like this:
        // 1) Go through the whole list, and if two elements are out of order, swap them.
        // 2) Go through the whole list, and check if it is in order yet.
        // 3) If it is in order, we're done.  If not, do step (1) again.

        // Proof that this algorithm will sort all possible lists:
        //
        // I'm going to define the term "inversion" as "two elements that are out of order".
        // 
        // If a list has no inversions, then it is in order, and we'll return
        //
        // If a list has any inversions, and we swap any two elements that are out of order, we
        // are guaranteed to remove at least one inversion when we swap the two out-of-order elements.
        //
        // A list can only have a finite number of inversions.  Every time we go through the list
        // and swap out-of-order elements, we reduce the number of inversions by at least one.
        //
        // Eventually, for any list, we run out of inversions, and return the sorted list.

        // The algorithm (in pseudocode) goes like this:
        // while the list is not sorted:
        //      go through the whole list, and if two elements are out of order, swap them
        //
        // while the list is not sorted:
        //      for each pair of adjacent elements in the list:
        //          if the elements are out of order, swap them
        public void BubbleSortInefficient(int[] values)
        {
            while (!IsSorted(values))
            {
                for (int i = 0; i < (values.Length - 1); i++)
                {
                    Operations++;
                    if (values[i] > values[i + 1])
                    {
                        Swap(values, i, i + 1);
                        Console.WriteLine("After swap: {0}", ForDisplay(values));
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("No swap needed: {0}", ForDisplay(values));
                        Console.ReadKey();
                    }
                }
                Console.WriteLine("After a full pass: {0}", ForDisplay(values));
                Console.ReadKey();
            }
        }

        // Like BubbleSortInefficient, but we don't call IsSorted.  Instead, we keep track of 
        // whether we did any swaps this time around.  If we didn't do any swaps, it's sorted, so
        // we return.
        public void BubbleSortLessInefficient(int[] values)
        {
            bool isSorted = false;

            while (!isSorted)
            {
                isSorted = true;
                for (int i = 0; i < (values.Length - 1); i++)
                {
                    Operations++; // compared two values
                    if (values[i] > values[i + 1])
                    {
                        isSorted = false;
                        Swap(values, i, i + 1);
                        Console.WriteLine("After swap: {0}", ForDisplay(values));
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("No swap needed: {0}", ForDisplay(values));
                        Console.ReadKey();
                    }
                }
                Console.WriteLine("After a full pass: {0}", ForDisplay(values));
                Console.ReadKey();
            }
        }

        // Like BubbleSortLessInefficient, but we don't keep going into the part we've already sorted.
        // Instead, we keep track of how much of the array is already sorted, and we stop when we get there.
        public void BubbleSortEfficient(int[] values)
        {
            bool isSorted = false;
            int numberOfPasses = 0;

            while (!isSorted)
            {
                isSorted = true;
                for (int i = 0; i < (values.Length - 1 - numberOfPasses); i++)
                {
                    Operations++; // compared two values
                    if (values[i] > values[i + 1])
                    {
                        isSorted = false;
                        Swap(values, i, i + 1);
                        Console.WriteLine("After swap: {0}", ForDisplay(values));
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("No swap needed: {0}", ForDisplay(values));
                        Console.ReadKey();
                    }
                }
                Console.WriteLine("After pass number {0}: {1}", numberOfPasses, ForDisplay(values));
                Console.ReadKey();
                numberOfPasses++;
            }
        }

        private bool IsSorted(int[] values)
        {
            // Go through the list, comparing each pair of elements.
            // If they are out of order, return false (it's not sorted).
            // If you get to the end of the list, return true (it's sorted).
            for (int i = 0; i < (values.Length - 1); i++)
            {
                Operations++; // compared two values
                if (values[i] > values[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        private void Swap(int[] values, int index1, int index2)
        {
            int temp = values[index1];
            Operations++; // changed a value
            values[index1] = values[index2];
            Operations++; // changed a value
            values[index2] = temp;
        }

        private string ForDisplay(int[] values)
        {
            return "[" + String.Join(", ", values) + "]";
        }

        public void BubbleSortFancy(int[] values)
        {
            while (!IsSorted(values))
            {
                foreach (IndexPair indexPair in IndexPairsOf(values))
                {
                    if (AreOutOfOrder(values, indexPair))
                    {
                        Swap(values, indexPair);
                        Console.WriteLine("After swap: {0}", ForDisplay(values));
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("No swap needed: {0}", ForDisplay(values));
                        Console.ReadKey();
                    }
                }
                Console.WriteLine("After a full pass: {0}", ForDisplay(values));
                Console.ReadKey();
            }
        }

        private bool AreOutOfOrder(int[] values, IndexPair indexPair)
        {
            Operations++;
            return values[indexPair.First] > values[indexPair.Second];
        }

        private void Swap(int[] values, IndexPair indexPair)
        {
            Swap(values, indexPair.First, indexPair.Second);
        }

        private IEnumerable<IndexPair> IndexPairsOf(int[] values)
        {
            for (int i = 0; i < values.Length - 2; i++)
            {
                yield return new IndexPair(i, i+1);
            }
        }
    }

    public class IndexPair
    {
        public int First { get; set; }
        public int Second { get; set; }

        public IndexPair(int first, int second)
        {
            First = first;
            Second = second;
        }
    }
}



// Example of using a for-loop to double all elements of an array
//            for (int i = 0; i < values.Length; i++)
//            {
//                values[i] = values[i] * 2;
//            }

// Code for Swap():
//                    int temp = values[0];
//                    values[0] = values[1];
//                    values[1] = temp;
