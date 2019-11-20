using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubbles : MonoBehaviour
{
    [SerializeField] float speed = 0.5f;
    [SerializeField] float startPosition;
    [SerializeField] float endPosition;
    void Update()
    {
         transform.Translate(-1 * speed * Time.deltaTime, 0, 0);

        if(transform.position.z <= endPosition)
        {
            transform.Translate(-1 * (endPosition - startPosition), 0, 0);

            SendMessage("ChangePosition", SendMessageOptions.DontRequireReceiver);
        }
    }
}
