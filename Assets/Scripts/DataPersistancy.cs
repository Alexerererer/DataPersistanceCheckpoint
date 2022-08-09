using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataPersistancy : MonoBehaviour
{
    public static DataPersistancy Instance;
    public string PlayerName;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetPlayerName(string name)
    {
        PlayerName = name;
    }
}
