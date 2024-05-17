using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public interface IView
    {
        void GameStart();

        int Guess();

        void WinMessage(int attempts);

        void LowNumber();

        void HighNumber();

        void EndGame();
    }
}