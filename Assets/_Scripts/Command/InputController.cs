using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    [SerializeField]
    private Remote remote;

    private void Awake() 
    {
        remote = new Remote();    
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            TeleOnCommand tvCmd = new TeleOnCommand(FindObjectOfType<CTele>());
            remote.setcommand(tvCmd);
            remote.execute();
        }
        else if(Input.GetKeyDown(KeyCode.O))
        {
            TeleOffCommand tvCmd = new TeleOffCommand(FindObjectOfType<CTele>());
            remote.setcommand(tvCmd);
            remote.execute();
        }

        if(Input.GetKeyDown(KeyCode.A))
        {
            RadioOnCommand rdCmd = new RadioOnCommand(FindObjectOfType<CRadio>());
            remote.setcommand(rdCmd);
            remote.execute();
        }
        else if(Input.GetKeyDown(KeyCode.Z))
        {
            RadioOffCommand radioOff = new RadioOffCommand(FindObjectOfType<CRadio>());
            remote.setcommand(radioOff);
            remote.execute();
        }
    }
}
