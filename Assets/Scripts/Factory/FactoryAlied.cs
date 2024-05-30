using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FactoryLab12;
[CreateAssetMenu(fileName = "Factorys", menuName = "ScriptableObject/Factorys/FactoryAlied")]
public class FactoryAlied : FactoryBase
{
    [SerializeField] GlobalPrefab currentA;
 
    public override void createEntity()
    {
        AliedEntity tmp = Instantiate(currentA.prefab.GetComponent<AliedEntity>());
    }
}
