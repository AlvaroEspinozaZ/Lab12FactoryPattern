using System.Collections;
using System.Collections.Generic;
using UnityEngine;




namespace FactoryLab12
{
    public enum typeEntity { Alied, Enemy,NPC };

    public class FactoryBase : ScriptableObject
    {
        public typeEntity current;

        public virtual void createEntity()
        {

        }

    }
}