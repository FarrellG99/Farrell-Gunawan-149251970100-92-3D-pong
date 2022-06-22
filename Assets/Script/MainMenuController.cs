using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame(){
        Debug.Log("Created By Farrell Gunawan - 149251970100-92");
        SceneManager.LoadScene("SampleScene");
    }

    public void GameOver(){
        SceneManager.LoadScene("GameOver");
    }

    public void HowToPlay(){
        SceneManager.LoadScene("HowToPlay");
    }

    public void BackToMainMenu(){
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame(){
        Application.Quit();
    }
}
