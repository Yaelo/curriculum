using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slot : MonoBehaviour, IDropHandler
{
    GameObject lastSelected;
    GameObject selectedPannel;
    private GameObject project;
    private GameObject ExpLab;
    private GameObject knowledge;
    void Start()
    {
        foreach(var obj in GameObject.FindGameObjectsWithTag("Pan"))
        {
            print(obj.name);
            obj.GetComponent<CanvasGroup>().alpha = 0;
        }
        selectedPannel = GameObject.Find("PanMission");
        selectedPannel.GetComponent<CanvasGroup>().alpha = 1;
        lastSelected = selectedPannel.gameObject;
        project = GameObject.Find("PanProjects");
        ExpLab = GameObject.Find("PanLabExp");
        knowledge = GameObject.Find("PanCon");
        project.SetActive(false);
        ExpLab.SetActive(false);
        knowledge.SetActive(false);
    }
    public void OnDrop(PointerEventData eventData)
    {
        selectedPannel.GetComponent<CanvasGroup>().alpha = 0;
        string seccion = "";
        transform.GetComponent<Text>().text = DragHandler.itemBeingDragged.GetComponent<Text>().text;
        seccion = DragHandler.itemBeingDragged.name;
        print(seccion);
        switch (seccion)
        {
            case "tMission":
                selectedPannel = GameObject.Find("PanMission");
                selectedPannel.GetComponent<CanvasGroup>().alpha = 1;
                break;
            case "tVision":
                selectedPannel = GameObject.Find("PanVision");
                selectedPannel.GetComponent<CanvasGroup>().alpha = 1;
                break;
            case "tValores":
                selectedPannel = GameObject.Find("PanValores");
                selectedPannel.GetComponent<CanvasGroup>().alpha = 1;
                break;
            case "tLabExp":
                project.SetActive(false);
                knowledge.SetActive(false);
                ExpLab.SetActive(true);
                selectedPannel = GameObject.Find("PanLabExp");
                selectedPannel.GetComponent<CanvasGroup>().alpha = 1;
                break;
            case "tStudies":
                selectedPannel = GameObject.Find("PanStudies");
                selectedPannel.GetComponent<CanvasGroup>().alpha = 1;
                break;
            case "tLanguages":
                selectedPannel = GameObject.Find("PanLanguages");
                selectedPannel.GetComponent<CanvasGroup>().alpha = 1;
                break;
            case "tCourses":
                selectedPannel = GameObject.Find("PanCourses");
                selectedPannel.GetComponent<CanvasGroup>().alpha = 1;
                break;
            case "tProjects":
                print("Proyectos!");
                ExpLab.SetActive(false);
                knowledge.SetActive(false);
                project.SetActive(true);
                selectedPannel = GameObject.Find("PanProjects");
                selectedPannel.GetComponent<CanvasGroup>().alpha = 1;
                break;
            case "tExtra":
                selectedPannel = GameObject.Find("PanExtra");
                selectedPannel.GetComponent<CanvasGroup>().alpha = 1;
                break;
            case "tCon":
                project.SetActive(false);
                ExpLab.SetActive(false);
                knowledge.SetActive(true);
                selectedPannel = GameObject.Find("PanCon");
                selectedPannel.GetComponent<CanvasGroup>().alpha = 1;
                break;
        }
    }
}
