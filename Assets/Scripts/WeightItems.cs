﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightItems : MonoBehaviour
{

    public Transform Beaker;
    public Transform Bottle;
    public Transform Erl_Flask;
    public Transform Measuring_Cylinder;
    public Transform Flask_Small;
    public Transform Round_Bottomed_Flask;

    void OnTriggerStay(Collider collision)
    {
        switch (collision.tag)
        {
            case "Beaker":
                collision.gameObject.transform.position = Beaker.transform.position;
                break;

            case "Bottle":
                collision.gameObject.transform.position = Bottle.transform.position;
                break;

            case "Erl_Flask":
                collision.gameObject.transform.position = Erl_Flask.transform.position;
                break;

            case "Measuring_Cylinder":
                collision.gameObject.transform.position = Measuring_Cylinder.transform.position;
                break; 

            case "Flask_Small":
                collision.gameObject.transform.position = Flask_Small.transform.position;
                break;

            case "Round_Bottomed_Flask":
                collision.gameObject.transform.position = Round_Bottomed_Flask.transform.position;
                break;
        }
    }

}
