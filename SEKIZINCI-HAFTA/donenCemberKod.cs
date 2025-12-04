using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class donenCemberKod : MonoBehaviour
{
    public int hiz;

    void FixedUpdate()
    {
        transform.Rotate(0, 0, hiz * Time.deltaTime);
    }
}
