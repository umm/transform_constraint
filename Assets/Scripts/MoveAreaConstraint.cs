using System;
using UnityEngine;

namespace UnityModule.TransformConstraints
{
    public class MoveAreaConstraint : MonoBehaviour
    {
        public Bounds AreaBounds;

        void LateUpdate()
        {
            var x = Math.Min(this.AreaBounds.max.x, Math.Max(this.AreaBounds.min.x, this.transform.position.x));
            var y = Math.Min(this.AreaBounds.max.y, Math.Max(this.AreaBounds.min.y, this.transform.position.y));
            var z = Math.Min(this.AreaBounds.max.z, Math.Max(this.AreaBounds.min.z, this.transform.position.z));
            this.transform.position = new Vector3(x, y, z);
        }
    }
}