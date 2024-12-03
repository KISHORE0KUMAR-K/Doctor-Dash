using UnityEngine;

public class loopingbackground : MonoBehaviour
{
   public float backgroundSpeed;
   public Renderer backgroundRenderer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        backgroundRenderer.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime,0f);
    }
}
