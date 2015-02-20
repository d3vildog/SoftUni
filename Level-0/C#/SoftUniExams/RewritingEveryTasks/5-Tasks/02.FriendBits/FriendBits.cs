using System;

class FriendBits
{
    static void Main()
    {
        // input and variables
        uint number = uint.Parse(Console.ReadLine());
        uint friendBits = 0;
        uint aloneBits = 0;

        for (int pos = 31; pos >= 0; pos--)
        {
            uint currentBit = (number >> pos) & 1;
            // 010011
            bool hasLeftBit = (pos < 31);
            uint leftBit = (number >> (pos + 1)) & 1;
            bool sameLeftBit = hasLeftBit && (leftBit == currentBit);

            bool hasRightBit = (pos > 0);
            uint rightBit = (number >> (pos - 1)) & 1;
            bool sameRightBit = hasRightBit && (rightBit == currentBit);

            bool friendBit = sameLeftBit || sameRightBit;

            if (friendBit)
            {
                friendBits = (friendBits << 1) | currentBit;
            }
            else
            {
                aloneBits = (aloneBits << 1) | currentBit;
            }
        }

        Console.WriteLine(friendBits);
        Console.WriteLine(aloneBits);
    }
}