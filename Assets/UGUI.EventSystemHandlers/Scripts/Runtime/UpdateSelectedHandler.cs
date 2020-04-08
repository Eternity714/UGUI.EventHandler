using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UpdateSelectedHandler : MonoBehaviour, IUpdateSelectedHandler
{
    public Action<GameObject, BaseEventData> onUpdateSelected;

    public void OnUpdateSelected(BaseEventData eventData)
    {
        onUpdateSelected?.Invoke(gameObject, eventData);
    }

    void OnDestroy()
    {
        onUpdateSelected = null;
    }

    public static UpdateSelectedHandler Get(GameObject go)
    {
        UpdateSelectedHandler handler = go.GetComponent<UpdateSelectedHandler>();
        if (handler == null) handler = go.AddComponent<UpdateSelectedHandler>();
        return handler;
    }

}
