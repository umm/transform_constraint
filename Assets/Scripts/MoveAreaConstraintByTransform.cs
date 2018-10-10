using System;
using UnityEngine;

namespace UnityModule.TransformConstraints
{
    public class MoveAreaConstraintByTransform : MonoBehaviour
    {
        public Transform AreaTransform;
        private Renderer Renderer;

        void Awake()
        {
            this.Renderer = this.AreaTransform.GetComponent<Renderer>();
        }

        void LateUpdate()
        {
            var bounds = this.Renderer.bounds;
            var x = Math.Min(bounds.max.x, Math.Max(bounds.min.x, this.transform.position.x));
            var y = Math.Min(bounds.max.y, Math.Max(bounds.min.y, this.transform.position.y));
            var z = Math.Min(bounds.max.z, Math.Max(bounds.min.z, this.transform.position.z));
            this.transform.position = new Vector3(x, y, z);
        }
    }
}