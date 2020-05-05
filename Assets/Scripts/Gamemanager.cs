using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public static Gamemanager instance;

     [SerializeField]
     Player player;

     bool isInCombat;

    public Player Player { get => player; }
    public bool IsInCombat { get => isInCombat; set => isInCombat = value; }

    void Awake() 
    {
        if(!instance)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }    
        DontDestroyOnLoad(gameObject);
    }

    public void StartCombat()
    {
        player.Anim.SetLayerWeight(1, 1);
    }
}
