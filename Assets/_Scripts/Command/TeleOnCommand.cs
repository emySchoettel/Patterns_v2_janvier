using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleOnCommand :  ICommand
{
    private CTele tele; 
    public void execute()
    {
        tele.on();
    }

    public TeleOnCommand(CTele unetele)
    {
        tele = unetele;
    }

}
