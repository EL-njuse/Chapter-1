using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Talkable_npc2 : MonoBehaviour
{
    public GameObject rb;
    [SerializeField] private bool isEntered;
    [TextArea(1, 3)]
    public string[] lines1;
    [TextArea(1, 3)]
    public string[] lines2;
    [TextArea(1, 3)]
    public string[] lines3;
    public bool isTalkedDoor = false;
    public bool isTalkedNpc = false;
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
        isTalkedDoor = FindObjectOfType<Talkable_door>().isCommunicated;
        if (isEntered && Input.GetKeyDown(KeyCode.Space) && DialogueManager.instance.dialogueBox.activeInHierarchy == false)
        {
            if (isTalkedDoor && (!isTalkedNpc))
            {
                isTalkedNpc = true;
                DialogueManager.instance.ShowDialogue(lines2);
            }
            else if(isTalkedDoor && isTalkedNpc)
            {
                DialogueManager.instance.ShowDialogue(lines3);
            }
            else
            {
                DialogueManager.instance.ShowDialogue(lines1);
            }
        }
    }
}
