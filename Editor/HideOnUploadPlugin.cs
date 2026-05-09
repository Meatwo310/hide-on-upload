using Meatwo310.HideOnUpload;
using nadena.dev.ndmf;
using UnityEngine;

[assembly: ExportsPlugin(typeof(Meatwo310.HideOnUpload.Editor.HideOnUploadPlugin))]

namespace Meatwo310.HideOnUpload.Editor
{
    public sealed class HideOnUploadPlugin : Plugin<HideOnUploadPlugin>
    {
        public override string DisplayName => "Hide On Upload";

        protected override void Configure()
        {
            InPhase(BuildPhase.Transforming).Run("Hide marked objects", ctx =>
            {
                var components = ctx.AvatarRootObject.GetComponentsInChildren<HideOnUpload>(true);

                foreach (var component in components)
                {
                    var target = component.gameObject;
                    Object.DestroyImmediate(component);
                    target.SetActive(false);
                }
            });
        }
    }
}
