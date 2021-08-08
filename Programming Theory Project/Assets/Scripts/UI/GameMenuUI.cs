using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameMenuUI : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI playerHealthTxt;
    [SerializeField]private TextMeshProUGUI gameOverText;
    [SerializeField] private TextMeshProUGUI scoreTxt;

    private Player player;
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }
    private void Update()
    {
        SetTextUI();

    }
    private void SetTextUI()
    {
        playerHealthTxt.SetText("Health :" + player.health);
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
 
}
