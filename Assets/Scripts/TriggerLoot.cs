using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLoot : MonoBehaviour
{
    [SerializeField] private GameObject _directorsGO;
    [SerializeField] private DirectorsControl _directorsControlScript;

    // Start is called before the first frame update
    void Start()
    {
        DoNullChecks();

        _directorsControlScript = _directorsGO.GetComponent<DirectorsControl>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //Check if chest is already open
            if (_directorsControlScript.chestIsOpen == false)
            {
                //if chest not open, open chest
                _directorsControlScript.OpenChest();
            }
        }
    }

    //private void OnTriggerExit(Collider other)
    //{
    //    if(_directorsControlScript.chestIsOpen == true)
    //    {
    //        _directorsControlScript.CloseChest();
    //    }
    //}

    private void DoNullChecks()
    {
        if (_directorsGO == null)
        {
            Debug.Log("TriggerLoot:DoNullChecks - _directorsGO is null!");
        }
    }
}
