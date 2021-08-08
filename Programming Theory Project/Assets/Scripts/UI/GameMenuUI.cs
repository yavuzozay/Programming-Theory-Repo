using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameMenuUI : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI playerHealthTxt;
    private Player player;
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }
    private void Update()
    {
        playerHealthTxt.SetText("Health :"+player.health);
    }
    public void Restart()
    {
        GameManager.Instance.StartGame();
    }
    public void MainMenuBtn()
    {
        Loader.Instance.LoadScene(0);
    }
    public void StartBtn()
    {
        GameManager.Instance.StartGame();
    }
}
