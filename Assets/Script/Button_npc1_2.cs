using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Button_npc1_2 : MonoBehaviour
{
    [TextArea(1, 3)]
    public string[] lines;
    public void Accept()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void UnAccept()
    {
        DialogueManager.instance.ShowDialogue(lines);
    }

}
