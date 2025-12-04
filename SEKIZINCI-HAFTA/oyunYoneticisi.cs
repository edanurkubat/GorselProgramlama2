using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class oyunYoneticisi : MonoBehaviour
{
    GameObject anaCember;
    GameObject donenCember;

    public Animator animator;
    void Start()
    {
        anaCember = GameObject.FindGameObjectWithTag("anaCember");
        donenCember = GameObject.FindGameObjectWithTag("donenCember");
    }


    void Update()
    {

    }

    public void OyunBitti()
    {
        Debug.Log("Oyun Bitti!");

        // Null kontrolü ekle
        if (donenCember != null)
        {
            donenCember.GetComponent<donenCemberKod>().enabled = false;
        }

        if (anaCember != null)
        {
            anaCember.GetComponent<anaCemberKod>().enabled = false;
        }

        if (animator != null)
        {
            animator.SetTrigger("oyunbitti");
        }

        donenCember.GetComponent<donenCemberKod>().enabled = false;
        //dönme olayýný pasif hale getirdik
        anaCember.GetComponent<anaCemberKod>().enabled = false;
        animator.SetTrigger("oyunbitti");
    }
    public void OyunKazandi()
    {
        Debug.Log("Oyun Kazanýldý!");
        Time.timeScale = 0;
    }
}
