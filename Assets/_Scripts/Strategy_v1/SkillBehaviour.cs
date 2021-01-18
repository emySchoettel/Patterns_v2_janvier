using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface SkillBehaviour 
{
    void TriggerActiveEffect(SkillUser user);
    void TriggerPassiveEffect(SkillUser user);
}
