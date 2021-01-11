using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SkillUser : MonoBehaviour
{
    [SerializeField] protected List<Skill> skills = new List<Skill>();
    [SerializeField] protected List<KeyCode> keys = new List<KeyCode>();
    protected int _speed;

    public void ModifySpeed(int speed)
    {
        _speed += speed; 
    }

    public void moveForward(float speed)
    {
        transform.Translate(Vector3.forward * speed);
    }

    public void AddSkillAndKey(Skill newSkill, KeyCode newKey)
    {
        skills.Add(newSkill);
        keys.Add(newKey);
        newSkill.Initialize(this);
    }

    protected void ListenToPlayerInput()
    {
        for(int i = 0; i < keys.Count; i++)
        {
            if(Input.GetKey(keys[i]))
            {
                skills[i].Use(this);
            }
        }
    }
}
