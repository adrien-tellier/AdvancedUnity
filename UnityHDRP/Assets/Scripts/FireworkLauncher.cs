using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class FireworkLauncher : MonoBehaviour
{
    [SerializeField]
    private VisualEffect m_firework = null;

    // Start is called before the first frame update
    void Start()
    {
        m_firework.Play();
        m_firework.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
