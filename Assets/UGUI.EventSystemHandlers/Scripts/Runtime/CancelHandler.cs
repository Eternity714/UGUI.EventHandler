using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class CancelHandler : MonoBehaviour, ICancelHandler
{
    public Action<GameObject, BaseEventData> onCancel;

    public void OnCancel(BaseEventData eventData)
    {
        onCancel?.Invoke(gameObject, eventData);
    }

    void OnDestroy() {
        onCancel = null;
    }

    public static CancelHandler Get(GameObject go) {
        CancelHandler handler = go.GetComponent<CancelHandler>();
        if (handler == null) handler = go.AddComponent<CancelHandler>();
        return handler;
    }
}
