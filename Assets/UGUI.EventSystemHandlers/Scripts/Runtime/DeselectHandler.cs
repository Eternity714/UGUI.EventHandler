using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class DeselectHandler : MonoBehaviour, IDeselectHandler
{
    public Action<GameObject, BaseEventData> onDeselect;
    public void OnDeselect(BaseEventData eventData)
    {
        onDeselect?.Invoke(gameObject, eventData);
    }

    void OnDestroy() {
        onDeselect = null;
    }

    public static DeselectHandler Get(GameObject go) {
        DeselectHandler handler = go.GetComponent<DeselectHandler>();
        if (handler == null) handler = go.AddComponent<DeselectHandler>();
        return handler;
    }
}
