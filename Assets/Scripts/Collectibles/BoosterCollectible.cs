using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoosterCollectible : Collectible
{
    [SerializeField] private Booster _booster;
    protected override void OnCollected(GameObject collectedBy)
    {
        /*
        var component = collectedBy.GetComponent<BoosterContainer>();
        if (component != null)
        {
        }

        -Alttaki ile ayný þey
        */

        if (collectedBy.TryGetComponent<BoosterContainer>(out BoosterContainer container))
        {
            Debug.Log("Booster Added!");
            container.AddBooster(_booster);
        }
    }
}
