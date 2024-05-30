using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FactoryLab12;
public class FactoryNPC : FactoryBase
{
    [SerializeField] NPCEntity currentN;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void createEntity()
    {
        NPCEntity tmp = Instantiate(currentN);
    }
}
