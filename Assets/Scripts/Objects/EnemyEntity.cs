using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FactoryLab12;
    public class EnemyEntity : MonoBehaviour, InterfaceEntity
    {
        public void MoveEntity()
        {
            
            Debug.Log("aMover enemy");
        }
        // Start is called before the first frame update
        void Start()
        {
            MoveEntity();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
