using UnityEngine;

public class GreenCoin : Item
{

    public override void UseItem()
    {
        base.UseItem();
        Item.SpeedBoost += 2;
        Debug.Log("2x Speed Boost!");
    }
}
