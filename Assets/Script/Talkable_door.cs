using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Talkable_door : MonoBehaviour
{
    public GameObject rb;
    [SerializeField] private bool isEntered;
    [TextArea(1, 3)]
    public string[] lines;
    public bool isCommunicated = false;
    public bool isRun = false;
    public GameObject panel1;
    public GameObject panel2;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isEntered = true;
            rb.SetActive(true);
            
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isEntered = false;
            rb.SetActive(false);
            panel1.SetActive(false);
            panel2.SetActive(false);
        }
    }

    private void Update()
    {
        isRun = FindObjectOfType<Talkable_npc2>().isTalkedNpc;
        if (isEntered && Input.GetKeyDown(KeyCode.Space) && DialogueManager.instance.dialogueBox.activeInHierarchy == false)
        {
            DialogueManager.instance.ShowDialogue(lines);
            isCommunicated = true;
            if (isRun)
            {
                panel2.SetActive(true);
            }
            else
            {
                panel1.SetActive(true);
            }
               
        }
    }

    public void Button1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+3);
    }

    public void Button2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+4);
    }
}
