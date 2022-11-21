using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public SceneManger sceneManger;
    private void OnCollisionEnter(Collision collision)
    {
        sceneManger.CompleteLevel();
    }
}
