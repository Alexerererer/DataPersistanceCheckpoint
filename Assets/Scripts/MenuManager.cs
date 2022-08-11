using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;
using System.IO;

public class MenuManager : MonoBehaviour
{

   

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Entry()
    {
        DataPersistancy.Instance.LoadScore();
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
     Application.Quit();
#endif
    }

    public void GetPlayerName(string name)
    {
        DataPersistancy.Instance.CurrentPlayerName = name;
        
    }
}
