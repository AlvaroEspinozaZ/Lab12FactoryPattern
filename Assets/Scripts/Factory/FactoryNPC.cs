using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FactoryLab12;
[CreateAssetMenu(fileName = "Factorys", menuName = "ScriptableObject/Factorys/FactoryNPC")]
public class FactoryNPC : FactoryBase
{
    [SerializeField] GlobalPrefab currentN;
 
    public override void createEntity()
    {
        NPCEntity tmp = Instantiate(currentN.prefab.GetComponent<NPCEntity>());
    }
}
