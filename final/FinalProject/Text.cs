using System;
using System.Text;

public class Text
{    
    public string ChooseName = "Greetings adventurer! Tell us your name!";
    public string DefaultName = "Nameless";
    public static string DefaultAreaName = "Area {0} ({1},{2})";
    public static string DefaultAreaDesc = "You are in an area and can move to the {0}";
    public static string ActionError = "I can't do that now";
    public static string Go = "Go";
    public static string GoError = "I can't go there!";
    public static string WhatToDo = "What should I do?";
    public static string Quit = "quit";
    public static string AreaNew = "You entered {0}.";
    public static string AreaOld = "you return to {0}.";
    public static string And = "and";
    public static string Comma = ",";
    public static string Space = " ";
    private readonly StringBuilder _sb = new();
    public virtual string JoinedWordList(string[] words, string conjunction)
    {

        _sb.Clear();

        for(var i =0; i < words.Length; i++)
        {

            if (i > 0)
                _sb.Append(words.Length > 2 ? Comma + Space : Space);

            if( i == words.Length -1 && words.Length > 1)
            {
                _sb.Append(conjunction + Space);
            }

            _sb.Append(words[i]);

        }

        return _sb.ToString();
    }


}