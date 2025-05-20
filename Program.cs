using System;

class CharArrayWrapper
{
    private char[] chars;

    
    public CharArrayWrapper(char[] input)
    {
        chars = new char[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            chars[i] = input[i];
        }
    }

    
    public char this[int index]
    {
        get
        {
            if (index >= 0 && index < chars.Length)
            {
                return Char.ToUpper(chars[index]);
            }
            else
            {
                throw new IndexOutOfRangeException("Індекс за межами масиву.");
            }
        }
        set
        {
            if (index >= 0 && index < chars.Length)
            {
                chars[index] = value;
            }
            else
            {
                throw new IndexOutOfRangeException("Індекс за межами масиву.");
            }
        }
    }

    public int VowelCount
    {
        get
        {
            int count = 0;
            foreach (char c in chars)
            {
                char upper = Char.ToUpper(c);
                if ("AEIOUYАЕЄИІЇОУЮЯ".IndexOf(upper) != -1)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
