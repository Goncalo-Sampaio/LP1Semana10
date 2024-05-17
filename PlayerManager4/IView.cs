using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManager4
{
    public interface IView
    {
        int ShowMenu();

        void EndMessage();

        void InvalidOption();

        void AfterMenu();

        Player InsertPlayer();

        void ListPlayers(IEnumerable<Player> playersToList);

        int AskForMinimumScore();

        PlayerOrder AskForPlayerOrder();
    }
}