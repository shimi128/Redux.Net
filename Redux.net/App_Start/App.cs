using System.Net.Mime;
using System.Web;
using Redux;
using Redux.net.Reducers;

namespace Redux.net
{
    public abstract class App
    {
        public static IStore<int> CounterStore { get; private set; }

        protected App()
        {
            //InitializeComponent();
        }

        public static void Bootstrap()
        {
            CounterStore = new Store<int>(reducer: CounterReducer.Execute, initialState: 0);
        }
        
    }
}