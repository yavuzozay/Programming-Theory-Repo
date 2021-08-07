using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenuUI : MonoBehaviour
{
    public void Restart()
    {
        GameManager.Instance.StartGame();
    }
    public void MainMenuBtn()
    {
        Loader.Instance.LoadScene(0);
    }
}
