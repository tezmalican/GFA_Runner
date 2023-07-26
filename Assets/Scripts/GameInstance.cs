using UnityEngine;

public class GameInstance : MonoBehaviour
{
    private static GameInstance _instance;

    public static GameInstance Instance
    {
        get
        {
            return _instance;
        }
    }



    public int Gold { get; set; }

    public void Win()
    {

    }

    public void Lose()
    {
        // TODO Show Lose Screen
        Debug.Log("Lost!");
    }

    private void Awake()
    {
        if (_instance && _instance == this)
        {
            Destroy(gameObject);
        }
        else
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
