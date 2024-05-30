using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FactoryLab12;
public class NPCEntity : MonoBehaviour, InterfaceEntity
{
    public void MoveEntity()
    {

        Debug.Log("aMover enemy");
    }
    void Start()
    {
        MoveEntity();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
