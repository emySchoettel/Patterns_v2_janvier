using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour, IWeapon
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
        GameObject bullet = Instantiate(Resources.Load("Bullet", typeof(GameObject)), initialPosition + new Vector3(0,0,1), Quaternion.identity) as GameObject;
        bullet.GetComponent<Rigidbody>().velocity = Vector3.forward * 5; 
    }
}
