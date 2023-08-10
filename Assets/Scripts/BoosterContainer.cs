using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoosterContainer : MonoBehaviour
{
    private List<BoosterInstance> _activeBoosters = new List<BoosterInstance>();


    public void AddBooster(Booster booster)
    {
        var boosterInstance = new BoosterInstance(booster);
        _activeBoosters.Add(boosterInstance);
    }

    public void RemoveBooster(Booster booster)
    {
        foreach (var instance in _activeBoosters)
        {
            if (instance.Booster == booster)
            {
                instance.RemainingDuration = 0;
            }
        }
    }

    public void Update()
    {
        for (int i = _activeBoosters.Count - 1; i >= 0; i--)
        {
            var instance = _activeBoosters[i];
            instance.RemainingDuration -= Time.deltaTime;
            if (instance.RemainingDuration <= 0)
            {
                _activeBoosters.RemoveAt(i);
            }
        }
    }

    public class BoosterInstance
    {
        public Booster Booster { get; set; }
        public float RemainingDuration { get; set; }

        public BoosterInstance(Booster booster)
        {
            Booster = booster;
            RemainingDuration = Booster.Duration;
        }
    }
}
