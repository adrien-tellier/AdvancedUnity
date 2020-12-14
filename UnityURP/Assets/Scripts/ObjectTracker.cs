using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Renderer))]
[RequireComponent(typeof(Material))]
public class ObjectTracker : MonoBehaviour
{
	#region Variables

	[SerializeField]
	private Transform m_trackedObject = null;

	private Renderer m_renderer = null;
	private Material m_material = null;

	#endregion

	#region Properties

	public Renderer Renderer
	{
		get
		{
			if (m_renderer == null)
				m_renderer = GetComponent<Renderer>();

			return m_renderer;
		}
	}

	public Material Material
	{
		get
		{
			if (m_material == null)
				m_material = Renderer.sharedMaterial;

			return m_material;

		}
	}

	#endregion

	#region Unity Methods

	private void Awake()
	{
		m_renderer = GetComponent<Renderer>();
		m_material = m_renderer.sharedMaterial;
	}

	private void Update()
	{
		if (m_trackedObject == null)
			return;

		Material.SetVector("_TrackedPosition", m_trackedObject.position);
	}

	private void OnDestroy()
	{
		m_renderer = null;

		if (m_material)
			DestroyImmediate(m_material);

		m_material = null;
	}

	#endregion
}
