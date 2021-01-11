using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioOffCommand : ICommand
{
    [SerializeField]
    CRadio radio;
    // Start is called before the first frame update
    public void execute()
    {
        radio.off();
    }

    public RadioOffCommand(CRadio uneRadio)
    {
        radio = uneRadio; 
    }

}
