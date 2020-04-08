using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SubmitHandler : MonoBehaviour, ISubmitHandler
{
    public Action<GameObject, BaseEventData> onSubmit;

    public void OnSubmit(BaseEventData eventData)
    {
        onSubmit?.Invoke(gameObject, eventData);
    }

    void OnDestroy()
    {
        onSubmit = null;
    }

    public static SubmitHandler Get(GameObject go)
    {
        SubmitHandler handler = go.GetComponent<SubmitHandler>();
        if (handler == null) handler = go.AddComponent<SubmitHandler>();
        return handler;
    }

}
