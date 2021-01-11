using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleOffCommand : ICommand
{
    private CTele tv; 

    public void execute()
    {
        tv.off();
    }

    public TeleOffCommand(CTele unetele)
    {
        tv = unetele;
    }
}
