using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
      public WeaponType weaponType;

    public enum WeaponType
    {
        Bullet, 
        Missile
    }

    public enum ColorType
    {
        Blue, 
        Green
    }

    public ColorType shipColor; 

    private IWeapon iweapon;
    private IColor icolor; 

    private void SetWeaponType()
    {
        Component c = gameObject.GetComponent<IWeapon>() as Component; 
        
        if(c != null)
        {
            Destroy(c);
        }

        #region Strategy

        switch(weaponType)
        {
            case WeaponType.Bullet:
                iweapon = gameObject.AddComponent<Bullet>();
            break;

            case WeaponType.Missile:
                iweapon = gameObject.AddComponent<Missile_v2>(); 
            break;

            default:
                iweapon = gameObject.AddComponent<Bullet>();
            break; 
        }

        #endregion
    }

    private void SetShipColor()
    {
        switch(shipColor)
        {
            case ColorType.Blue :
                icolor = gameObject.AddComponent<BlueColor>(); 
                break;

            case ColorType.Green: 
                icolor = gameObject.AddComponent<GreenColor>(); 
            break; 

            default:
                icolor = gameObject.AddComponent<BlueColor>();
            break;
        }
    }

    public void Fire()
    {
        iweapon.Fire();
    }

    public void SetColor()
    {
        icolor.setColor();
    }


    void Start() 
    {
        SetWeaponType();
        SetShipColor();
        SetColor();
    }

    void Update() 
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
    }
}
