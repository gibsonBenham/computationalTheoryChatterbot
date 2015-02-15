using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChatterbotProject
{
    class Chatterbot
    {                
        enum State
        {
            Default,
            NoMatch,
            FirstMatch,
            SecondMatch,
            Success,
            Fail
        };

        public bool Chat(string input)
        {
            State currentState = State.Default;
            for (int i = 0; i < input.Length; i++)
            {
                switch(currentState)
                {
                    case (State.Default):
                        if (input[i] == 'h')
                            currentState = State.FirstMatch;
                        else if (input[i] == ' ')
                            currentState = State.Default;
                        else
                            currentState = State.NoMatch;
                        break;
                    case (State.FirstMatch):
                        if (input[i] == 'i')
                            currentState = State.SecondMatch;
                        else if (input[i] == ' ' || input[i] == '.')
                            currentState = State.Default;
                        else
                            currentState = State.NoMatch;
                        break;
                    case (State.SecondMatch):
                        if (input[i] == ' ' || input[i] == '.')
                            currentState = State.SecondMatch;
                        else
                            currentState = State.NoMatch;
                        break;
                    case (State.NoMatch):
                        if (input[i] == ' ' || input[i] == '.')
                            currentState = State.Default;
                        else
                            currentState = State.NoMatch;
                        break;
                }
            }
            return (currentState == State.SecondMatch);
        }
    }
}
