using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonBehaviour : SkillBehaviour
{
   private GameObject prefab; 

   public SummonBehaviour(GameObject prefab)
   {
       this.prefab = prefab;
   }

   public void TriggerActiveEffect(SkillUser user)
   {
       GameObject.Instantiate(prefab, user.transform);
   }

   public void TriggerPassiveEffect(SkillUser user)
   {
       
   }
}
