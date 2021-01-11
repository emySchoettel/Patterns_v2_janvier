using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CRadio : MonoBehaviour
{
      #region Variables
    [SerializeField]
    private Text txtEtat; 

    #endregion

    private void Awake() {
    txtEtat = GameObject.Find("EtatRadio").GetComponent<Text>();
   }
   
   public void on()
   {
       txtEtat.text = "Etat : allumé"; 
       GetComponent<Renderer>().material.color = Color.red;
   }

   public void off()
   {
       txtEtat.text = "Etat : eteint";
       GetComponent<Renderer>().material.color = Color.gray;
   }
}
