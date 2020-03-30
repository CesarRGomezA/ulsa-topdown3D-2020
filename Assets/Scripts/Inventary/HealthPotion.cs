using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : MonoBehaviour
{
   [SerializeField]

   Potion potion;

    //no es lo mas optimo por si tienes varias posiones ya que todas escucharan este comportamiento
   private void OnTriggerEnter(Collider other) 
   {
       potion.Drink();
       Debug.Log("Healt Restored");
       Destroy(gameObject);
   }
}
