using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;

public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance;

    
    // Update is called once per frame
    void Update()
    {
        
    }

    public void Entry()
    {
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
}
