using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FactoryLab12;
public class FactoryEnemy : FactoryBase
{
    [SerializeField] EnemyEntity currentE;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void createEntity()
    {
        EnemyEntity tmp =Instantiate(currentE);
    }
  
}
