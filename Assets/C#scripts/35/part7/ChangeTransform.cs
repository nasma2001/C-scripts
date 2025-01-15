using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTransform : MonoBehaviour
{
    public ChangeTransform SetPosition(Vector3 position){
        transform.position = position;
        return this;
    }
    public ChangeTransform SetRotation(Vector3 rotation){
        transform.rotation = Quaternion.Euler(rotation);
        return this;
    }
    public ChangeTransform SetScale(Vector3 scale){
        transform.localScale = scale;
        return this;
    }
}
