using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Remote
{
   ICommand commande;

   public void setcommand(ICommand nouvelleCommande)
   {
       commande = nouvelleCommande; 
   }

   public void execute()
   {
       commande.execute(); 
   }
}
