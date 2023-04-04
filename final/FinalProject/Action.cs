using System;

public abstract class Action
{
    public virtual string Name => "";

    public virtual void Execute(string[] args)
    {
        throw new Exception("Nothing left to execute");
    }

}