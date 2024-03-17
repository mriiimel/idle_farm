using System.Collections.Generic;
using System.Linq.Expressions;
using Unity.VisualScripting;
using UnityEditor.UI;
using UnityEngine;
using Screen = UnityEngine.Device.Screen;

[CreateAssetMenu]
public class WindowChanger : ScriptableObject
{
    [SerializeField] public List<SpaseScreenCount> screenCounts;
    [Space(10)]
    [SerializeField] private FullScreenMode _fullscreenMode;
    [Space(10)]
    [SerializeField] private TypeSpaseScreen _typeSpaseScreen;
    [SerializeField] private int _screenRate;
    

    public RefreshRate _maxWindowFPS { get; set; }
   

    public void ChangeWindowSpace()
    {
        for (int i = 0; i < screenCounts.Count; i++)
        {
            var screen = screenCounts[i];
            if (_typeSpaseScreen == screen.spaceScreen)
            {
                WindowsChanger(screen.Width, screen.Height);
            }
            
            
        }
    }
    private void WindowsChanger(int width, int height)
    {
        if (_screenRate <= 0) return;
        
        Screen.SetResolution(width,height,_fullscreenMode,_screenRate);            

    }
}
