using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScreenChange : MonoBehaviour
{
    [SerializeField] private WindowChanger winCh;
    
    void Start()
    {
        
        for(int i = 0; i < winCh.screenCounts.Count; i++)
        {
            var screen = winCh.screenCounts[i];
            if (winCh.TypeSpase != screen.spaceScreen) return;
            winCh.WindowsChanger(screen.Width, screen.Height);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
