using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targeter : MonoBehaviour
{
    [SerializeField]
    List<Target> targets = new List<Target>();

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Target target))
        {
            targets.Add(target);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent(out Target target))
        {
            targets.Remove(target);
        }
    }
}
