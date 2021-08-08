using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoSingleton<GameManager>
{
    private int _score;
    private bool _isGameActive=true;
    [SerializeField]private GameObject player;
    public int score
    {
        get { return _score; }
        set { _score = value; }
    }
    
    public bool isGameActive
    {
        get { return _isGameActive; }
        set { _isGameActive = value; }
    }
   
    public void StartGame()
    {
      

        _isGameActive = true;
         Loader.Instance.LoadScene(1);
    }
   
    public void GameOver()
    {
        _isGameActive = false;
    }
   
}
