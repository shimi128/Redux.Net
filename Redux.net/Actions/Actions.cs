namespace Redux.net.Actions
{
    public class IncrementAction : IAction { }

    public class DecrementAction : IAction { }

    public class AddTodoAction : IAction
    {
        public string Text { get; set; }
    }
}