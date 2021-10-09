using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameMenuUI : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI playerHealthTxt;
    [SerializeField]private TextMeshProUGUI gameOverText;
    [SerializeField] private TextMeshProUGUI scoreTxt;

   
 
    private void Update()
    {
        SetTextUI();

    }
    private void SetTextUI()
    {
       
        scoreTxt.SetText("Score :" + GameManager.Instance.score);
        if (!GameManager.Instance.isGameActive)
        {
            gameOverText.gameObject.SetActive(true);
    
        }
    }
    public void Restart()
    {
        GameManager.Instance.StartGame();
    }
    public void MainMenuBtn()
    {
        Loader.Instance.LoadScene(0);
    }
    void onPlayerHPChanged(float curhHP,float maxHp)
    {
        playerHealthTxt.SetText("Health :"+curhHP);
    }
    void onScoreChanged(float score)
    {
        scoreTxt.SetText("Score :" +score);
    }


    private void OnEnable()
    {
        EventManager.onPlayerHPChanged += onPlayerHPChanged;
        EventManager.onScoreChanged += onScoreChanged;
    }
    private void OnDisable()
    {
        EventManager.onPlayerHPChanged -= onPlayerHPChanged;
        EventManager.onScoreChanged -= onScoreChanged;
    }

}
