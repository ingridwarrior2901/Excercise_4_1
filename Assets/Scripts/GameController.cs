using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour, IWinnable
{
    public GameObject canvas;
    public Text canvasText;

    public CharacterManager character;
    private const string playerTag = "Player";
    private const string gameoverText = "Gameover";
    private const string winText = "You win";

    void Update()
    {
        if (character.playerHealth <= 0)
        {
            ShowCanvas(gameoverText);  
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }

    public void OnWinGame()
    {
        ShowCanvas(winText);
    }

    private void ShowCanvas(string text)
    {
        canvasText.text = text;
        canvas.SetActive(true);
    }
}
