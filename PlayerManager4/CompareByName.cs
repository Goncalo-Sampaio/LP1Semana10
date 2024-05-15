using System.Collections.Generic;

namespace PlayerManager4
{
    /// <summary>
    /// Compares players by name.
    /// </summary>
    public class CompareByName : IComparer<Player>
    {
        // If true will compare by alphabetical order, otherwise will compare
        // in reverse alphabetical order
        private readonly bool ord;

        /// <summary>
        /// Compare two players.
        /// </summary>
        /// <param name="p1">First player.</param>
        /// <param name="p2">Second player.</param>
        /// <returns>-1, 0 or 1</returns>
        public int Compare(Player p1, Player p2)
        {
            if (p1 == p2) return 0;
            if (p1 is null) return -1;
            if (p2 is null) return 1;

            if (ord)
                return p1.Name.CompareTo(p2.Name);
            else
                return p2.Name.CompareTo(p1.Name);
        }

        /// <summary>
        /// Creates a new instance of this class.
        /// </summary>
        /// <param name="ord">
        /// If true order alphatetically, otherwise sort in reverse
        /// alphabetical order.
        /// </param>
        public CompareByName(bool ord)
        {
            this.ord = ord;
        }
    }
}
