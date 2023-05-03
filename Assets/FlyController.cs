using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FlyController : MonoBehaviour
{

    private Camera playerCamera;
    [SerializeField] private GameObject[] buildings = new GameObject[3];
    [SerializeField] private GameObject[] floorSys = new GameObject[3];
    public TextMeshProUGUI Press;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            LoadBuilding(0);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            LoadBuilding(1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            LoadBuilding(2);
        }
    }

    private void LoadBuilding(int building) // 0 - 2
    {
        for(int i = 0; i < 3; i++)
        {
            if(i == building)
            {
                buildings[i].SetActive(true);
                floorSys[i].SetActive(true);
            }
            else
            {
                buildings[i].SetActive(false);
                floorSys[i].SetActive(false);
            }
        }
    }

}
