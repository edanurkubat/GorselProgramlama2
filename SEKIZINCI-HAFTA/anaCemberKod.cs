using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using System;
using UnityEngine.UI;

public class anaCemberKod : MonoBehaviour
{

    public GameObject kucukCember;
    public GameObject donenCember;
    public GameObject anaCember_;
    public GameObject oyunuYoneticisi;
    public int atisSayisi = 8;

    private void Start()
    {
        oyunuYoneticisi = GameObject.FindGameObjectWithTag("oyunYoneticisi");
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(kucukCember, transform.position, transform.rotation);
            for (int i = 0; i < transform.childCount; i++)
            {
                //her atýþ yapýldýðýnda sayýlarý bir eksiltiyoruz..
                int sayi = Convert.ToInt32(transform.GetChild(i).GetComponentInChildren<Text>().text);
                sayi--;

                if (sayi > 0)
                {
                    transform.GetChild(i).GetComponentInChildren<Text>().text = sayi.ToString();
                }
                else
                {
                    Destroy(transform.GetChild(i).gameObject);
                }
            }
            atisSayisi--;
            if (atisSayisi == 0)
            {
                oyunuYoneticisi.transform.GetComponent<oyunYoneticisi>().OyunKazandi();
            }
        }

    }
}
