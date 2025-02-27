﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadResults : MonoBehaviour
{
    public GameObject resultsScreenRef;
    public GameObject resultTimeRef;
    public GameObject UIRef;
    public GameObject UITimeRef;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")               //Enables the Results screen > transfers timer data > disables game HUD
        {
            UITimeRef.GetComponent<TimerScript>().counting = false;
            resultsScreenRef.SetActive(true);
            resultTimeRef.GetComponent<TimerScript>().setTime(UITimeRef.GetComponent<TimerScript>().minutes, UITimeRef.GetComponent<TimerScript>().seconds);
            UIRef.SetActive(false);

        }
    }


}