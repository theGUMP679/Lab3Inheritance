using UnityEngine;

public class BlueCoin : Item
{

    public override void UseItem()
    {
        base.UseItem();
        Debug.Log("Gained 5 Damage!");
    }
}
