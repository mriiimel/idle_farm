using System.Collections.Generic;
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
    [SerializeField] private uint _screenRate;
    
    public RefreshRate _maxWindowFPS { get; set; }
    public uint ScreenRate { get { return _screenRate; } }

    public TypeSpaseScreen TypeSpase { get { return _typeSpaseScreen;} }

    
    public void WindowsChanger(int width, int height)
    {
        Screen.SetResolution(width,height,_fullscreenMode,60);            

    }
}
