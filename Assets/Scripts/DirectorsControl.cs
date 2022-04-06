using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class DirectorsControl : MonoBehaviour
{
    [SerializeField] public bool chestIsOpen = false;
    [SerializeField] private PlayableDirector openChestDirector;
    [SerializeField] private PlayableDirector closeChestDirector;

    // Start is called before the first frame update
    void Start()
    {
        DoNullCheck();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenChest()
    {
        if (chestIsOpen == false)
        {
            //Call open chest director timeline
            openChestDirector.Play();

            //Set chestIsOpen = true
            chestIsOpen = true;
        }
    }

    public void CloseChest()
    {
        //Call close chest Director timeline

        if (chestIsOpen == true)
        {
            closeChestDirector.Play();

            //Set chestIsOpen = false
            chestIsOpen = false;
        }
    }

    private void DoNullCheck()
    {
        if (openChestDirector == null)
        {
            Debug.Log("DirectorsControl::DoNullCheck() - openChestDirector variable is null!");
        }

        if (closeChestDirector == null)
        {
            Debug.Log("DirectorsControl::DoNullCheck() - closeChestDirector variable is null!");
        }
    }
}
