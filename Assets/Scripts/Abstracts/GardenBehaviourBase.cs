using System.Collections.Generic;
using UnityEngine;

public class GardenBehaviourBase : MonoBehaviour
{
    [SerializeField] private List<Transform> _cropSite;
    [SerializeField] private List<GameObject> _plants;
    [SerializeField] private int _maxSpotOnTheGarden;

    private void Start()
    {
        
    }
}
