namespace StringCommands;

public class StringCommand
{
public virtual string Execute(string input){
    return String.Empty;
}
}

public class UpperCaseCommand : StringCommand{
    public override string Execute(string input)
    {
        return input.ToUpper();
    }
}

public class LowerCaseCommand : StringCommand{
    public override string Execute(string input)
    {
        return input.ToLower();
    }
}

