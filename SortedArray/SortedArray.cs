using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Sorting
{
    public class SortedArray
    {
        private Player[] players;
        private int lowest, middle, highest;
        private int elements;

        public SortedArray(int maxN)
        {
            players = new Player[maxN];
            lowest = 0;
            highest = 0;
            elements = 0;
        }

        public bool IsEmpty()
        {
            return elements == 0;
        }

        public Player Find(Player argument)
        {
            int l = lowest;
            int h = highest - 1;

            while (h >= l)
            {
                int mid = (l + h) / 2;
                if (players[mid].getNumber() == argument.getNumber())
                {
                    return players[mid];
                }
                else if (players[mid].getNumber() < argument.getNumber())
                {
                    l = mid + 1;
                }
                else
                    h = mid - 1;
            }

            return null;
        }

        public void Insert(Player argument)
        {
            int l = 0;
            int h = highest - 1;
            if (Find(argument) == null)
            {
                while (h >= l)
                {
                    int mid = (l + h) / 2;
                    if (players[mid].getNumber() < argument.getNumber())
                    {
                        l = mid + 1;
                    }
                    else
                    {
                        h = mid - 1;
                    }
                }

                for (int i = elements - 1; i >= l; i--)
                {
                    players[i + 1] = players[i];
                }
                players[l] = argument;
                elements++;
                highest++;
            }

        }
    }
}
