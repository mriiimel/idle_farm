using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScreenChange : MonoBehaviour
{
    [SerializeField] private WindowChanger winCh;
    private int _screenWidth;
    private int _screenHeight;
    void Start()
    {
        
        
       
    }

    // Update is called once per frame
    void Update()
    {
        if (winCh == null) Debug.Log("Windows Changer is null");
        winCh.ChangeWindowSpace();
    }
}
