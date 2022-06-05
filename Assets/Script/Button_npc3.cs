using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_npc3 : MonoBehaviour
{
    public GameObject button;
    public GameObject dialogue;
    public void Accept()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void UnAccept()
    {

        FindObjectOfType<Player>().canMove = true;
        button.SetActive(false);
        dialogue.SetActive(false);
    }
}
