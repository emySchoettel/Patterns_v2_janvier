using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioOnCommand : ICommand
{
     [SerializeField]
    private CRadio radio;
    // Start is called before the first frame update
    public void execute()
    {
        radio.on();
    }

    public RadioOnCommand(CRadio uneradio)
    {
        radio = uneradio; 
    }
}
