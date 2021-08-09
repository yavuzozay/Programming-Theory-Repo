using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoSingleton<GameManager>
{
    private int _score;
    private int _level;
    private bool _isGameActive=true;
    [SerializeField]private GameObject player;
    //Encapsulation
    public int score
    {
        get { return _score; }
        set { _score = value; }
    }
    public int level
    {
        get { return _level; }
        set { _level = value; }
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
