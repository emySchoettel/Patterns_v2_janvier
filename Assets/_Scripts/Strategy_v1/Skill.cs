using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill 
{
   protected int manaCost;
   protected SkillBehaviour behaviour; 

   public void Initialize(SkillUser user)
   {
       behaviour.TriggerPassiveEffect(user);
   }

   public void Use(SkillUser user)
   {
       Debug.Log("Use");
       behaviour.TriggerActiveEffect(user);
   }
}
