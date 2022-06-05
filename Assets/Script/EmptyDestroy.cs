using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyDestroy : MonoBehaviour
{
    public GameObject gb;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Deadline"))
        {
            gb.SetActive(false);
        }
    }
}
