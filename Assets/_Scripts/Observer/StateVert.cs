using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateVert : StateSphere, Observer
{
   private string state = "vert";
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
        if(Input.GetButtonDown("Rouge"))
        {
           sphere.Attach(this);
           sphere.TransitionToState(sphere.stateRouge);
           sphere.Detach(this);
        }
        else if(Input.GetButtonDown("Bleu"))
        {
           sphere.Attach(this);
           sphere.TransitionToState(sphere.stateBleu);
           sphere.Detach(this);
        }
    }

 

   public override void ChangeColor(Sphere sphere)
   {
      sphere.getMaterial().color = Color.green;
      sphere.Notify(this);
   }

      public void Notify(Sphere sphere)
   {
      Debug.Log("Etat : " + sphere.currentstate.GetState());
   }
}
