# Hide On Upload

Hide On Upload is an NDMF component for VRChat avatar projects.

Add `HideOnUpload` to a GameObject under an avatar. During the NDMF build, the package removes the marker component and sets the marked GameObject inactive. The object remains in the avatar hierarchy; it is not deleted.

`HideOnUpload` implements VRChat SDK's `IEditorOnly` marker so the component is treated as editor-only by the SDK.

## Package

- Package name: `net.meatwo310.hide-on-upload`
- Author: `Meatwo310`
- Dependency: `nadena.dev.ndmf`
