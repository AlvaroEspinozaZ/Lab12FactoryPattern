using FactoryLab12;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AliedEntity : MonoBehaviour, InterfaceEntity
{
    public void MoveEntity()
    {
        
        Debug.Log("aMover alied");
    }

    void Start()
    {
        MoveEntity();
    }

    void Update()
    {
        
    }
}
