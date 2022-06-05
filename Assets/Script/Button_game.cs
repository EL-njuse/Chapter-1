using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_game : MonoBehaviour
{
    public GameObject gameObject;
    public void Button_Game1()
    {
        gameObject.SetActive(true);
    }

    public void End1_3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
