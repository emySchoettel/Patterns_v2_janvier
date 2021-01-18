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
        int i = 0;
        foreach(KeyCode key in keys)
        {
            if(Input.GetKey(key))
            {
                i = keys.IndexOf(key);
                StartCoroutine(Use(i));
                
            }
        }
    }

    public IEnumerator Use(int i)
    {
        yield return new WaitForSeconds(2f);
        skills[i].Use(this);
    }
}
