using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Etat
{
   void Update(ICommand commande);
}
