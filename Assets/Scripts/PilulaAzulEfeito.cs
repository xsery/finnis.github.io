﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PilulaAzulEfeito : MonoBehaviour {

    public GameObject PilulaGameObj;
    public Animator animPorta;
    public GameObject fundoDoPesadelo;
    public GameObject spirits1;
    public GameObject spirits2;
    public GameObject maoNaParede;
    public Door door;
    public AudioSource mundoReal;
    public AudioSource mundoPesadelo;
    public AudioSource remedio;
    private bool pesadelo;

    // Use this for initialization
    void Start()
    {
        fundoDoPesadelo.SetActive(true);
        spirits1.SetActive(true);
        spirits2.SetActive(true);
        maoNaParede.SetActive(true);
        pesadelo = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D coll)
    {

        if (coll.gameObject.name == "Finnis")
        {
            
            mundoPesadelo.Stop();
            mundoReal.Play();
            door.doorOpen();
            fundoDoPesadelo.SetActive(false);
            maoNaParede.SetActive(false);
            Destroy(PilulaGameObj);
        }

        if (coll.gameObject.name == "Stage04")
        {
            remedio.Play();
        }

    }


}

