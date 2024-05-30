using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using FactoryLab12;
public class GameController : MonoBehaviour
{
    [SerializeField] Button buttonAlied;
    [SerializeField] Button buttonEnemy;
    public List<FactoryBase> listaEntitys;
    void Start()
    {
        buttonAlied.onClick.AddListener(delegate () { listaEntitys[0].createEntity();});
        buttonEnemy.onClick.AddListener(delegate () { listaEntitys[1].createEntity();});
    }

    // Update is called once per frame
    void Update()
    {
        
    }    
}
