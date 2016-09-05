using Redux.net.Actions;

namespace Redux.net.Reducers
{
    public static class CounterReducer
    {
        public static int Execute(int state, IAction action)
        {
            if (action is IncrementAction)
            {
                return state + 1;
            }

            if (action is DecrementAction)
            {
                return state - 1;
            }

            return state;
        }
    }
}