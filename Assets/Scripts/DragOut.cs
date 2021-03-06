﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragOut : MonoBehaviour
{

    public GameObject Beaker,H20,CH3OH,CH2Cl2,Carb,NaBH4,Spetular,Scale,ConeBeaker,Measuring,SphereBeaker,Funnel,Seperator,Sqeezy;
    private Vector3 offset;
    private bool isClick = false;
    private Vector3 targetScreenPoint;
    private GameObject dragOutGameObject;
    // Use this for initialization
    private void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
#if UNITY_EDITOR
        //for unity editor
        if (Input.GetMouseButtonDown(0))
        {
            if (CheckGameObjectMouse())
            {
                //Debug.Log(123);
                offset = dragOutGameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, targetScreenPoint.z));
            }
        }

        if (isClick)
        {
            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, targetScreenPoint.z);
            Vector3 curWorldPoint = Camera.main.ScreenToWorldPoint(curScreenPoint);
            dragOutGameObject.transform.position = curWorldPoint + offset;
            //Debug.Log(curWorldPoint);
        }

        if (Input.GetMouseButtonUp(0))
        {
            dragOutGameObject = null;
            isClick = false;
        }
#else
        //for android devices
        if (Input.touchCount > 0)
        {
            switch (Input.GetTouch(0).phase)
            {
                case TouchPhase.Began:
                    if (CheckGameObjectTouch())
                    {
                        offset = dragOutGameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.GetTouch(0).position.x, Input.GetTouch(0).position.y, targetScreenPoint.z));
                    }
                    break;
                case TouchPhase.Canceled: // If the interaction ends for any reason, we have to call the listeners
                case TouchPhase.Ended:
                    dragOutGameObject = null;
                    isClick = false;
                    break;
            }

            if (isClick)
            {
                Vector3 curScreenPoint = new Vector3(Input.GetTouch(0).position.x, Input.GetTouch(0).position.y, targetScreenPoint.z);

                Vector3 curWorldPoint = Camera.main.ScreenToWorldPoint(curScreenPoint);
                dragOutGameObject.transform.position = curWorldPoint + offset;
            }
        }

#endif
    }

    private bool CheckGameObjectTouch()
    {
        if (Input.touchCount > 0)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hitInfo;
            if (Physics.Raycast(ray, out hitInfo))
            {
                if (hitInfo.collider.gameObject.tag == "ItemIcon" || hitInfo.collider.gameObject.tag == "ElementIcon")
                {
                    switch (hitInfo.collider.gameObject.name)
                    {
                        case "Beaker":
                            dragOutGameObject = Instantiate(Beaker);
                            dragOutGameObject.transform.position = hitInfo.collider.gameObject.transform.position;
                            targetScreenPoint = Camera.main.WorldToScreenPoint(dragOutGameObject.transform.position);
                            isClick = true;
                            break;
                        case "H2O":
                            dragOutGameObject = Instantiate(H20);
                            dragOutGameObject.transform.position = hitInfo.collider.gameObject.transform.position;
                            targetScreenPoint = Camera.main.WorldToScreenPoint(dragOutGameObject.transform.position);
                            isClick = true;
                            break;
                        case "NaBH":
                            dragOutGameObject = Instantiate(NaBH4);
                            dragOutGameObject.transform.position = hitInfo.collider.gameObject.transform.position;
                            targetScreenPoint = Camera.main.WorldToScreenPoint(dragOutGameObject.transform.position);
                            isClick = true;
                            break;
                        case "Carb":
                            dragOutGameObject = Instantiate(Carb);
                            dragOutGameObject.transform.position = hitInfo.collider.gameObject.transform.position;
                            targetScreenPoint = Camera.main.WorldToScreenPoint(dragOutGameObject.transform.position);
                            isClick = true;
                            break;
                        case "CH3OH":
                            dragOutGameObject = Instantiate(CH3OH);
                            dragOutGameObject.transform.position = hitInfo.collider.gameObject.transform.position;
                            targetScreenPoint = Camera.main.WorldToScreenPoint(dragOutGameObject.transform.position);
                            isClick = true;
                            break;
                        case "CH2Cl2":
                            dragOutGameObject = Instantiate(CH2Cl2);
                            dragOutGameObject.transform.position = hitInfo.collider.gameObject.transform.position;
                            targetScreenPoint = Camera.main.WorldToScreenPoint(dragOutGameObject.transform.position);
                            isClick = true;
                            break;
                        case "Spatula":
                            dragOutGameObject = Instantiate(Spetular);
                            dragOutGameObject.transform.position = hitInfo.collider.gameObject.transform.position;
                            targetScreenPoint = Camera.main.WorldToScreenPoint(dragOutGameObject.transform.position);
                            isClick = true;
                            break;
                        case "ConeBeaker":
                            dragOutGameObject = Instantiate(ConeBeaker);
                            dragOutGameObject.transform.position = hitInfo.collider.gameObject.transform.position;
                            targetScreenPoint = Camera.main.WorldToScreenPoint(dragOutGameObject.transform.position);
                            isClick = true;
                            break;
                        case "SphereBeaker":
                            dragOutGameObject = Instantiate(SphereBeaker);
                            dragOutGameObject.transform.position = hitInfo.collider.gameObject.transform.position;
                            targetScreenPoint = Camera.main.WorldToScreenPoint(dragOutGameObject.transform.position);
                            isClick = true;
                            break;
                        case "Seperator":
                            dragOutGameObject = Instantiate(Seperator);
                            dragOutGameObject.transform.position = hitInfo.collider.gameObject.transform.position;
                            targetScreenPoint = Camera.main.WorldToScreenPoint(dragOutGameObject.transform.position);
                            isClick = true;
                            break;
                        case "Funnel":
                            dragOutGameObject = Instantiate(Funnel);
                            dragOutGameObject.transform.position = hitInfo.collider.gameObject.transform.position;
                            targetScreenPoint = Camera.main.WorldToScreenPoint(dragOutGameObject.transform.position);
                            isClick = true;
                            break;
                        case "Sqeezy":
                            dragOutGameObject = Instantiate(Sqeezy);
                            dragOutGameObject.transform.position = hitInfo.collider.gameObject.transform.position;
                            targetScreenPoint = Camera.main.WorldToScreenPoint(dragOutGameObject.transform.position);
                            isClick = true;
                            break;
                        case "Measuring":
                            dragOutGameObject = Instantiate(Measuring);
                            dragOutGameObject.transform.position = hitInfo.collider.gameObject.transform.position;
                            targetScreenPoint = Camera.main.WorldToScreenPoint(dragOutGameObject.transform.position);
                            isClick = true;
                            break;
                        case "Scale":
                            dragOutGameObject = Instantiate(Scale);
                            dragOutGameObject.transform.position = hitInfo.collider.gameObject.transform.position;
                            targetScreenPoint = Camera.main.WorldToScreenPoint(dragOutGameObject.transform.position);
                            isClick = true;
                            break;
                        default:
                            return false;
                    }
                    return true;
                }
            }
        }
        return false;
    }

    private bool CheckGameObjectMouse()
    {
        //Vector3 moupos=Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        if (Physics.Raycast(ray, out hitInfo))
        {
            if (hitInfo.collider.gameObject.tag == "ItemIcon" || hitInfo.collider.gameObject.tag == "ElementIcon")
            {
                switch (hitInfo.collider.gameObject.name)
                {
                    case "Beaker":
                        dragOutGameObject = Instantiate(Beaker);
                        dragOutGameObject.transform.position = hitInfo.collider.gameObject.transform.position;
                        targetScreenPoint = Camera.main.WorldToScreenPoint(dragOutGameObject.transform.position);
                        isClick = true;
                        break;
                    case "H2O":
                        dragOutGameObject = Instantiate(H20);
                        dragOutGameObject.transform.position = hitInfo.collider.gameObject.transform.position;
                        targetScreenPoint = Camera.main.WorldToScreenPoint(dragOutGameObject.transform.position);
                        isClick = true;
                        break;
                    case "NaBH":
                        dragOutGameObject = Instantiate(NaBH4);
                        dragOutGameObject.transform.position = hitInfo.collider.gameObject.transform.position;
                        targetScreenPoint = Camera.main.WorldToScreenPoint(dragOutGameObject.transform.position);
                        isClick = true;
                        break;
                    case "Carb":
                        dragOutGameObject = Instantiate(Carb);
                        dragOutGameObject.transform.position = hitInfo.collider.gameObject.transform.position;
                        targetScreenPoint = Camera.main.WorldToScreenPoint(dragOutGameObject.transform.position);
                        isClick = true;
                        break;
                    case "CH3OH":
                        dragOutGameObject = Instantiate(CH3OH);
                        dragOutGameObject.transform.position = hitInfo.collider.gameObject.transform.position;
                        targetScreenPoint = Camera.main.WorldToScreenPoint(dragOutGameObject.transform.position);
                        isClick = true;
                        break;
                    case "CH2Cl2":
                        dragOutGameObject = Instantiate(CH2Cl2);
                        dragOutGameObject.transform.position = hitInfo.collider.gameObject.transform.position;
                        targetScreenPoint = Camera.main.WorldToScreenPoint(dragOutGameObject.transform.position);
                        isClick = true;
                        break;
                    case "Spatula":
                        dragOutGameObject = Instantiate(Spetular);
                        dragOutGameObject.transform.position = hitInfo.collider.gameObject.transform.position;
                        targetScreenPoint = Camera.main.WorldToScreenPoint(dragOutGameObject.transform.position);
                        isClick = true;
                        break;
                    case "ConeBeaker":
                        dragOutGameObject = Instantiate(ConeBeaker);
                        dragOutGameObject.transform.position = hitInfo.collider.gameObject.transform.position;
                        targetScreenPoint = Camera.main.WorldToScreenPoint(dragOutGameObject.transform.position);
                        isClick = true;
                        break;
                    case "SphereBeaker":
                        dragOutGameObject = Instantiate(SphereBeaker);
                        dragOutGameObject.transform.position = hitInfo.collider.gameObject.transform.position;
                        targetScreenPoint = Camera.main.WorldToScreenPoint(dragOutGameObject.transform.position);
                        isClick = true;
                        break;
                    case "Seperator":
                        dragOutGameObject = Instantiate(Seperator);
                        dragOutGameObject.transform.position = hitInfo.collider.gameObject.transform.position;
                        targetScreenPoint = Camera.main.WorldToScreenPoint(dragOutGameObject.transform.position);
                        isClick = true;
                        break;
                    case "Funnel":
                        dragOutGameObject = Instantiate(Funnel);
                        dragOutGameObject.transform.position = hitInfo.collider.gameObject.transform.position;
                        targetScreenPoint = Camera.main.WorldToScreenPoint(dragOutGameObject.transform.position);
                        isClick = true;
                        break;
                    case "Sqeezy":
                        dragOutGameObject = Instantiate(Sqeezy);
                        dragOutGameObject.transform.position = hitInfo.collider.gameObject.transform.position;
                        targetScreenPoint = Camera.main.WorldToScreenPoint(dragOutGameObject.transform.position);
                        isClick = true;
                        break;
                    case "Measuring":
                        dragOutGameObject = Instantiate(Measuring);
                        dragOutGameObject.transform.position = hitInfo.collider.gameObject.transform.position;
                        targetScreenPoint = Camera.main.WorldToScreenPoint(dragOutGameObject.transform.position);
                        isClick = true;
                        break;
                    case "Scale":
                        dragOutGameObject = Instantiate(Scale);
                        dragOutGameObject.transform.position = hitInfo.collider.gameObject.transform.position;
                        targetScreenPoint = Camera.main.WorldToScreenPoint(dragOutGameObject.transform.position);
                        isClick = true;
                        break;
                    default:
                        return false;
                        break;
                }
                return true;
            }
        }
        return false;
    }
}
