using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class kucukCemberKod : MonoBehaviour
{
    Rigidbody2D rigidbody_;

    //public GameObject donenCember;

    bool carptiMi = false;

    GameObject oyunYoneticisi;

    public int hiz;

    void Start()
    {
        rigidbody_ = GetComponent<Rigidbody2D>();
        oyunYoneticisi = GameObject.FindGameObjectWithTag("oyunYoneticisi");

       

    }

    void FixedUpdate()
    {
        if (!carptiMi)
        {
            rigidbody_.MovePosition(rigidbody_.position + Vector2.up * hiz * Time.deltaTime);
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if ( other.gameObject.tag == "donenCember")
        {
            carptiMi = true;


            transform.SetParent(other.transform);
        }
        if (other.gameObject.CompareTag("kucukCember"))
        {
            //oyun bitti
            oyunYoneticisi.GetComponent<oyunYoneticisi>().OyunBitti();
            
        }
    }
}
