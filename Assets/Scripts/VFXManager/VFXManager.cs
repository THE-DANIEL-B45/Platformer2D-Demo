using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ebac.Core.Singleton;

public class VFXManager : Singleton<VFXManager>
{
    public enum VFXType
    {
        Jump,
        VFX_2
    }

    public List<VFXManagerSetup> vfxSetup;

    public void PlayVFXByType(VFXType vFXType, Vector3 position)
    {
        foreach (var vfx in vfxSetup)
        {
            if(vfx.vFXType == vFXType)
            {
                var item = Instantiate(vfx.prefab);
                item.transform.position = position;
                Destroy(item.gameObject, 5f);
                break;
            }
        }
    }
}

[System.Serializable]
public class VFXManagerSetup
{
    public VFXManager.VFXType vFXType;
    public GameObject prefab;
}
