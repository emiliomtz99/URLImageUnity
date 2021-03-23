using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class webImage : MonoBehaviour
{
    public RawImage img;
    public Texture texture;
    void Start()
    {
            StartCoroutine(setImage("https://gogreenfime.000webhostapp.com/1.jpeg"));
    }

    IEnumerator setImage(string url)
    {
        Debug.Log("CALLING");
        Texture2D texture = null;
        WWW www = new WWW(url);
        yield return www;       
        texture = www.texture;
        img.texture = texture;

        //gameObject.transform.localScale = new Vector2(3,1);

        
    }
}


