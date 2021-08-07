using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class MenuUI : MonoBehaviour
{
  public void LoadGame()
    {
        Loader.Instance.LoadScene(1);
        
    }
    public void Exit()
    {
        Application.Quit();
        EditorApplication.ExitPlaymode();
    }
}
