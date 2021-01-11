using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class StateBleu : StateSphere, Observer
{
   private string state = "bleu";
   public override string GetState()
   {
      return state;
   }
    public override void Enter(Sphere sphere)
    {
        ChangeColor(sphere);
    }


   public override void ChangeColor(Sphere sphere)
   {
      sphere.getMaterial().color = Color.blue;
      sphere.Notify(this);
   }

    public override void Update(Sphere sphere)
    {
        if(Input.GetButtonDown("Rouge"))
        {
           sphere.Attach(this);
           sphere.TransitionToState(sphere.stateRouge);
           sphere.Detach(this);
        }
        else if(Input.GetButtonDown("Vert"))
        {
           sphere.Attach(this);
           sphere.TransitionToState(sphere.stateVert);
           sphere.Detach(this);
        }
    }

   public void Notify(Sphere sphere)
   {
      Debug.Log("Etat : " + sphere.currentstate.GetState());
   }
}
