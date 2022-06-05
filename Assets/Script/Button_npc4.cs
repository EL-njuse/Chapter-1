using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_npc4 : MonoBehaviour
{
    public GameObject button_npc4;
    public GameObject dialogue_npc4;
    public void Accept()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void UnAccept()
    {

        FindObjectOfType<Player>().canMove = true;
        button_npc4.SetActive(false);
        dialogue_npc4.SetActive(false);
    }
}
