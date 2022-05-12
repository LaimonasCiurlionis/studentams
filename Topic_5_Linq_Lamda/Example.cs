using System.Collections.Generic;

namespace Topic_5_Linq_Lamda
{
    public class Example
    {
        public IEnumerable<string> MyOwnIterator(IEnumerable<string> words)
        {
            foreach (var word in words)
            {
                if (word == "orange")
                {
                    yield return word;
                }
            }

            yield return null;
        }
    }
}
