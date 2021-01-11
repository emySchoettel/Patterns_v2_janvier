using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkBehaviour : SkillBehaviour
{
   public void TriggerActiveEffect(SkillUser user)
   {
       user.moveForward(20f);
   }

   public void TriggerPassiveEffect(SkillUser user)
   {
       user.ModifySpeed(10);
   }
}
