namespace CommandPattern;

public class Button
{
    private ICommand _command;
    public Button(ICommand command) => _command = command;
    public void Press() => _command.Execute();
}