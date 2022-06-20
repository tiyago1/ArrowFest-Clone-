﻿using UnityEngine;

public class Entity : MonoBehaviour, IEntity
{
    public void Reset()
    {
        this.transform.position = Vector3.zero;
        this.transform.localPosition = Vector3.zero;
        this.gameObject.SetActive(false);
    }

    public void SetPositionAndEnable(Vector3 newPosition)
    {
        this.transform.position = newPosition;
        this.gameObject.SetActive(true);
    }

    public void SetLocalPositionAndEnable(Vector3 newPosition)
    {
        this.transform.localPosition = newPosition;
        this.gameObject.SetActive(true);
    }
}