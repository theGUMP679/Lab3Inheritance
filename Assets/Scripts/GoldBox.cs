using UnityEngine;

public class GoldBox : Item
{

    public override void UseItem()
    {
        base.UseItem();
        Debug.Log("Gained 5 Money!");
    }
}