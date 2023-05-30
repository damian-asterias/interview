namespace Interview.App
{
    /*
       Instructions:
       1,  Create a function called IsPalindrome(string value). This function checks if
           the string is a palindrome. Ex.  'aba' is palindrome since you can read it the same from left to right
           and from right to left.
       2. To test it you can write unit tests on the test project.
       3. Check and throw an exception when the argument is null.

       Notes:   
        *   Do not use LinQ to solve this function.
        *   Add as much tests as you think are needed.
    */
    public class Foo
    {
        public bool IsPalindrome(string value)
        {
            if(value == null)
            {
                throw new ArgumentNullException("value");
            }
            for (int i = 0; i < value.Length/2; i++)
            {
                if (value[i] != value[value.Length - i - 1])
                    return false;
            }
            return true;
        }
    }
}