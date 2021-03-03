using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string Name;
    public int Cost;
    public bool Consumable;

    public static int Health = 100;
    public static int SpeedBoost = 0;
    public static int GunDamage = 100;
    public static int Money = 0;


    private void OnMouseDown()
    {
        UseItem();
    }

    
    public virtual void UseItem()
    {
        Debug.Log("Using " + Name);
        if (Consumable)
        {
            Destroy(this.gameObject);
        }
    }
}
