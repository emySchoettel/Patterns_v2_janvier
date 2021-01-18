using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSPlayer : SkillUser
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Debut");
        AddSkillAndKey(new Missile(), KeyCode.A);
        AddSkillAndKey(new Elusion(), KeyCode.Z);
    }

    // Update is called once per frame
    void Update()
    {
        ListenToPlayerInput();
    }
}
