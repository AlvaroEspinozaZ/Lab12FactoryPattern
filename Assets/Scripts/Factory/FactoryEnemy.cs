using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FactoryLab12;
[CreateAssetMenu(fileName = "Factorys", menuName = "ScriptableObject/Factorys/FactoryEnemy")]

public class FactoryEnemy : FactoryBase
{
    [SerializeField] GlobalPrefab currentE;   
    public override void createEntity()
    {
        EnemyEntity tmp =Instantiate(currentE.prefab.GetComponent<EnemyEntity>());
    }
  
}
