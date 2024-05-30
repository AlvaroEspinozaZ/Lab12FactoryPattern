using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FactoryLab12;
public class FactoryAlied : FactoryBase
{
    [SerializeField]AliedEntity currentA;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void createEntity()
    {
        Instantiate(currentA);
    }
}
