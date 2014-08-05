namespace Sorter
{
    public class SortUtility
    {
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

            int n = values.Length;
            if (n <= 1)
            {
                return;
            }
            for (int i = 0; i < n; i++)
            {
                int min = int.MaxValue;
                int minIndex = i;
                for (int j = i; j < n; j++)
                {
                    if (values[j] < min)
                    {
                        min = values[j];
                        minIndex = j;
                    }
                }

                swap(values, i, minIndex);
            }
        }

        private void swap(int[] values, int a, int b)
        {
            if (a == b)
            {
                return;
            }

            int tmp = values[a];
            values[a] = values[b];
            values[b] = tmp;
        }
    }
}

// Example of using a for-loop to double all elements of an array
//            for (int i = 0; i < values.Length; i++)
//            {
//                values[i] = values[i] * 2;
//            }

