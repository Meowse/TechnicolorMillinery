namespace Sorter
{
    public class SortUtility
    {
        public void Sort(int[] values)
        {
            // Read a value with "values[3]"
            // Write a value with "values[2] = 17"
            // Get the number of values with "values.Length"

            // First value in the array is "values[0]"
            // Last value in the array is "values[values.Length - 1]"

            // Example of using a for-loop to double all elements of an array
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = values[i] * 2;
            }
        } //How I sort a handful of palying cards in numerical order:
        // I need to know that Aces, Kings, Queens and Jacks are the placement of highest 
        //to lowest when I come across these cards.
        //I look at two cards and compare which one is bigger
        // I place the bigger card on the bottom
        //I bring another card from the pile and compare it with the two cards
        // If the new card is bigger than both of the cards I place it at the bottom. 
        //If it is bigger than the top card and smaller than the bottom card. 
        //I place that card in between the two cards. 
        // When I bring in another card from the pile of random cards. I compare all 
        //of the cards and see which card is the biggest.That card goes on the bottom. 
        //The next biggest will go on top of that card and the next biggest card will go 
        //on top of that card. The smallest card will go on top. 
        //I keep doing this until the stack of random cards are gone and placed into the 
        //stack that is being sorted highest to lowest. 
        //Keeping in mind that the biggest card will be at the bottom and the smallest 
        //card will be at the top. 
    }
}
