using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamerule : MonoBehaviour
{
    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;
    public GameObject panel4;
    public GameObject win;
    public GameObject lose;
    public GameObject End1_2;
    public int count = 0;

    public float player = 0;
    public float npc = 0;
    public float guess = 0;

    [TextArea(1, 3)]
    public string[] lines1;

    [TextArea(1, 3)]
    public string[] lines2;

    [TextArea(1, 3)]
    public string[] lines3;


    public void Button1_1()
    {
        player = 0;
        panel1.SetActive(false);
        panel2.SetActive(true);
    }
    public void Button1_2()
    {
        player = 5;
        panel1.SetActive(false);
        panel2.SetActive(true);
    }
    
    public void Button1_3()
    {
        player = 10;
        panel1.SetActive(false);
        panel2.SetActive(true);
    }

    public void Button2_1()
    {
        count++;
        guess = 0;
        panel2.SetActive(false);
        panel3.SetActive(true);
        if (guess == RandNumber())
        {
            DialogueManager.instance.ShowDialogue(lines1);
        }
        else
        {
            DialogueManager.instance.ShowDialogue(lines2);
        }
    }

    public void Button2_2()
    {
        count++;
        guess = 5;
        panel2.SetActive(false);
        panel3.SetActive(true);
        if (guess == RandNumber())
        {
            DialogueManager.instance.ShowDialogue(lines1);
        }
        else
        {
            DialogueManager.instance.ShowDialogue(lines2);
        }

    }

    public void Button2_3()
    {
        count++;
        guess = 15;
        panel2.SetActive(false);
        panel3.SetActive(true);
        if (guess == RandNumber())
        {
            DialogueManager.instance.ShowDialogue(lines1);
        }
        else
        {
            DialogueManager.instance.ShowDialogue(lines2);
        }
    }


    public void Button2_4()
    {
        count++; 
        guess = 15;
        panel2.SetActive(false);
        panel3.SetActive(true);
        if (guess == RandNumber())
        {
            DialogueManager.instance.ShowDialogue(lines1);
        }
        else
        {
            DialogueManager.instance.ShowDialogue(lines2);
        }
    }

    public void Button2_5()
    {
        count++;
        guess = 20;
        panel2.SetActive(false);
        panel3.SetActive(true);
        if (guess == RandNumber())
        {
            DialogueManager.instance.ShowDialogue(lines1);
        }
        else
        {
            DialogueManager.instance.ShowDialogue(lines2);
        }
    }

    public void Button3_1()
    {
        panel3.SetActive(false);
        panel1.SetActive(true);
    }

    public void Button3_2()
    {
        panel3.SetActive(false);
        panel4.SetActive(true);
        DialogueManager.instance.ShowDialogue(lines3);
        
    }

    public void Button4()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void End1_4()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }


    public float RandNumber()
    {
        var rand = new System.Random();
        int num = rand.Next(0, 2);
        npc = num * 5;
        return npc + player;
    }

    public void Update()
    {
        if (count >= 3)
        {
            End1_2.SetActive(true);
        }
    }

}
