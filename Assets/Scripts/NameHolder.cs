using UnityEngine;

public class NameHolder : MonoBehaviour
{
    public static NameHolder Instance;
    public string PlayerName;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
}
