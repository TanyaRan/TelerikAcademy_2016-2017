using System;
//03.Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range. 
//   It should hold error message and a range definition [start … end].
//   Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime> 
//   by entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].

namespace DemoRangeException
{
    public class InvalidRangeException<T> : Exception
    {
        public T Start { get; set; }
        public T End { get; set; }
        public T InputData { get; set; }

        public InvalidRangeException(string message)
            : this(message, default(T))
        {
        }

        public InvalidRangeException(string message, T inputData)
            : this(message, inputData, default(T), default(T))
        {
        }

        public InvalidRangeException(string text, T start, T end, T data)
            : base(text)
        {
            Start = start;
            End = end;
            InputData = data;
        }
    }
}
