using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoSingleton<GameManager>
{
  public void StartGame()
    {
        Loader.Instance.LoadScene(1);
    }
}
