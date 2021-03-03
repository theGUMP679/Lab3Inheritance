using UnityEngine;

public class Dynamite : Item
{

    public override void UseItem()
    {
        base.UseItem();
        Item.GunDamage -= 10;
        Debug.Log("You took 10 Damage!");
    }
}

