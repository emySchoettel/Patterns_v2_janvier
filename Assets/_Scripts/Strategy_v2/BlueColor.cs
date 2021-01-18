using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueColor : MonoBehaviour, IColor
{

    public void setColor()
    {
        Renderer rend = this.gameObject.GetComponent<Renderer>(); 
        rend.material.shader = Shader.Find("Legacy Shaders/Diffuse");
        rend.material.SetColor("_Color", Color.blue);
    }
}
