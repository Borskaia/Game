using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public Image button = null;
    public bool destroy = false;

    void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Player")
        {
            StartTrigger();
        }
    }

    void StartTrigger()
    {
        button.enabled = true; 
        if (destroy == true)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerExit (Collider other)
    {
        if (button != null)
        {
            button.enabled = false;
        }
    }
}
