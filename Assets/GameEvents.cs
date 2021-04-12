using System;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public static GameEvents current;

    private void Awake()
    {
        current = this;
    }

    public event Action onDoorwayTriggerEnter;
    public void DoorwayTriggerEntered()
    {
        if(onDoorwayTriggerEnter != null)
        {
            onDoorwayTriggerEnter();
        }
    }

    public event Action onDoorwayTriggerExit;
    public void DoorwayTriggerExited()
    {
        if (onDoorwayTriggerExit != null)
            onDoorwayTriggerExit();
    }
}
