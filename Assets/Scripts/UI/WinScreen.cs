using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class WinScreen : MonoBehaviour
{
    [SerializeField] private DebugUI.Button _nextLevelButton;

    private void OnEnable()
    {
        _nextLevelButton.onClick.AddListener(OnNextLevelButtonPressed);
    }

    private void OnDisable()
    {
        _nextLevelButton.onClick.AddListener(OnNextLevelButtonPressed);
    }

    private void OnNextLevelButtonPressed()
    {
        GameInstance.Instance.LoadCurrentLevel();
    }
}
