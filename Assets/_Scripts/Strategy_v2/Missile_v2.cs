using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile_v2 : MonoBehaviour, IWeapon
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Fire()
    {
        Vector3 initialPosition = this.gameObject.transform.position; 
        GameObject missile = Instantiate(Resources.Load("Missile", typeof(GameObject)), initialPosition + new Vector3(0, 0, 1), Quaternion.Euler(new Vector3(90, 0, 0))) as GameObject;
        missile.GetComponent<Rigidbody>().velocity = Vector3.forward * 5;
    }
}
