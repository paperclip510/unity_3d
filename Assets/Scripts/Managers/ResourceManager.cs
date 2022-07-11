using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    // 프로젝트 리소스 통합 관리 매니저
    
    public T Load<T>(string path) where T : Object
    {
        return Resources.Load<T>(path);
    }

    public GameObject Instantiate(string path, Transform parent = null)
    {
        GameObject prefab = Load<GameObject>($"Prefabs/{path}");
        if(prefab == null)
        {
            Debug.Log($"Failed to load prefab : {path}");
        }

        //
        return Object.Instantiate(prefab, parent);
    }

    public void Destory(GameObject go) {
        
        if(go == null) return;

        Object.Destroy(go);
    }
}
