using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckUnlock : MonoBehaviour
{
    public GameObject door = null;
    public GameObject key = null;
    // Start is called before the first frame update
    void Start()
    {
        door.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Key"))
        {
            // unlock
            if (door.activeInHierarchy)
                door.SetActive(false);
            if (key.activeInHierarchy)
                key.SetActive(false);
        }
    }


}
