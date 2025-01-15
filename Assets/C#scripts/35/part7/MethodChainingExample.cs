using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodChainingExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ChangeTransform changeTransform = new();
        changeTransform.SetPosition(new Vector3(0,1,0))
                        .SetRotation(new Vector3(45,0,0))
                        .SetScale(new Vector3(2,2,2));
        
    }

  
}
