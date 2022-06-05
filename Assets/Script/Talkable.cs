using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Talkable : MonoBehaviour
{
    public GameObject rb;
    [SerializeField] private bool isEntered;
    [TextArea(1, 3)]
    public string[] lines;
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
        }
    }

    private void Update()
    {
        if(isEntered && Input.GetKeyDown(KeyCode.Space) && DialogueManager.instance.dialogueBox.activeInHierarchy ==false)
        {
            DialogueManager.instance.ShowDialogue(lines);
        }
    }


}
