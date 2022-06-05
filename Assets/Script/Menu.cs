using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void UIEnable()
    {
        GameObject.Find("Canvas/Panel/进入游戏").SetActive(true);
        GameObject.Find("Canvas/Panel/继续游戏").SetActive(true);
        GameObject.Find("Canvas/Panel/退出游戏").SetActive(true);
        GameObject.Find("Canvas/Panel/Title").SetActive(true);
        GameObject.Find("Canvas/Panel/Subtitle").SetActive(true);
    }
}