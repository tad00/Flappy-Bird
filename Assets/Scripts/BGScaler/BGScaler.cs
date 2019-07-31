using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScaler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        Vector3 tempScale = transform.localScale;

        float height = sr.bounds.size.y;
        float width = sr.bounds.size.x;

        float worldHeight = Camera.main.orthographicSize * 2f;
        float worldWidht = worldHeight * Screen.width / Screen.height;

        tempScale.y = worldHeight / height;
        tempScale.x = worldWidht / width;
        transform.localScale = tempScale;
    }

    
}
