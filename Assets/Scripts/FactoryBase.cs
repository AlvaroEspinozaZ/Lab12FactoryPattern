using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FactoryLab12
{
    public enum typeEntity { Alied, Enemy };

    public class FactoryBase : MonoBehaviour
    {
        public typeEntity current;

        public virtual void createEntity()
        {

        }

    }
}