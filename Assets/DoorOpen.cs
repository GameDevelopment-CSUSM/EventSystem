using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
   // public Door doorRef;
    

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log(other.gameObject.tag);
            //StartCoroutine(doorRef.LerpPosition(doorRef.positonToMoveTo, Door.getDuration()));
            GameEvents.current.DoorwayTriggerEntered();
        }
    }

   /* private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.gameObject.transform.localPosition);
        if (other.gameObject.tag == "Player")
        {
            Debug.Log(other.gameObject.tag);
            StartCoroutine(LerpPosition(moveBack, duration));

            GameEvents.current.DoorwayTriggerExited();
        }
    }*/
}
