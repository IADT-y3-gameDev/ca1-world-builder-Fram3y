using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public int NumberOfCollectables { get; private set; }

    public UnityEvent<PlayerInventory> OnCollectableCollected;

    public void ObjectsCollected()
    {
        NumberOfCollectables++;
        OnCollectableCollected.Invoke(this);
    }
}
