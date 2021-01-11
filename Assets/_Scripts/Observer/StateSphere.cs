using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class StateSphere 
{
    private string state; 

    public abstract void Enter(Sphere sphere);
    public abstract void ChangeColor(Sphere sphere); 
    public abstract string GetState();

    public abstract void Update(Sphere sphere);
}
