using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Boosters/2x Gold")]

public class DoubleGoldBooster : Booster
{
    public override void OnAdded(BoosterContainer container)
    {
        Debug.Log("Coin Doubled!");
        GameInstance.Instance.GoldMultiplier = 2;
    }

    public override void OnRemoved(BoosterContainer container)
    {
        Debug.Log("Coin Halved!");
        GameInstance.Instance.GoldMultiplier = 1;
    }
}
