using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class StateRouge : StateSphere, Observer
{
   private string state = "rouge";
   public override string GetState()
   {
      return state;
   }

   public override void Enter(Sphere sphere)
   {
      ChangeColor(sphere);
   }

    public override void Update(Sphere sphere)
    {
        if(Input.GetButtonDown("Bleu"))
        {
            sphere.Attach(this);
            sphere.TransitionToState(sphere.stateVert);
            sphere.Detach(this);
        }
        else if(Input.GetButtonDown("Vert"))
        {
           sphere.Attach(this);
           sphere.TransitionToState(sphere.stateVert);
           sphere.Detach(this);
        }
         
    }

   public override void ChangeColor(Sphere sphere)
   {
      sphere.getMaterial().color = Color.red;
      sphere.Notify(this);
   }
      public void Notify(Sphere sphere)
   {
      Debug.Log("Etat : " + sphere.currentstate.GetState());
   }
}
