using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Vector3 positonToMoveTo;
    public Vector3 moveBack;
    private static float duration = 3f;
    private GameObject parentObj;

    public static float getDuration()
    {
        return duration;
    }

    private void Start()
    {
        parentObj = transform.gameObject;
        moveBack = parentObj.transform.localPosition;

        GameEvents.current.onDoorwayTriggerEnter += OnDoorwayOpen;
        GameEvents.current.onDoorwayTriggerExit += OnDoorwayExit;

    }

    private void OnDoorwayOpen()
    {
        StartCoroutine(LerpPosition(positonToMoveTo, duration));
    }

    private void OnDoorwayExit()
    {
        StartCoroutine(LerpPosition(moveBack, duration));
    }

    public IEnumerator LerpPosition(Vector3 target, float duration)
    {
        Debug.Log("Open");
        float time = 0;
        float startPosition = transform.localPosition.y;
        float x = transform.localPosition.x;
        float z = transform.localPosition.z;
        // Vector3 _startVector = parentObj.transform.localPosition;
        Vector3 start = new Vector3(x, startPosition, z);

        while (time < duration)
        {
            parentObj.transform.localPosition = Vector3.Lerp(start, target, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
        parentObj.transform.localPosition = target;
    }
}
