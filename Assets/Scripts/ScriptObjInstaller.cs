using UnityEngine;
using Zenject;

[CreateAssetMenu(fileName = "ScriptObjInstaller", menuName = "Installers/ScriptObjInstaller")]
public class ScriptObjInstaller : ScriptableObjectInstaller<ScriptObjInstaller>
{
    public override void InstallBindings()
    {
    }
}