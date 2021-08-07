using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Loader : MonoSingleton<Loader>
{
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    #region Overload
    public void LoadScene(int index)
    {
        SceneManager.LoadScene(index);

    }
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);

    }
    #endregion
}
