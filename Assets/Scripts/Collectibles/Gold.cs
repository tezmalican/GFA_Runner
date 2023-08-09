using UnityEngine;

public class Gold : Collectible
{
    protected override void OnCollected()
    {
        GameInstance.Instance.Gold++;
    }
}
