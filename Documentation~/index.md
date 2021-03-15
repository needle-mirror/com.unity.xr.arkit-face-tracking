---
uid: arkitfacetracking-manual
---
# About ARKit Face Tracking

This package provides face tracking support to augment the [ARKit XR Plugin](xref:arkit-manual).

## Installing ARKit Face Tracking

To install this package, follow the instructions in the [Package Manager documentation](https://docs.unity3d.com/Packages/com.unity.package-manager-ui@latest/index.html).

## Using ARKit Face Tracking

This package implements the [face tracking subsystem](xref:arsubsystems-face-subsystem) defined in the [AR Subsystems](xref:arsubsystems-manual) package.

This package provides additional face tracking functionality that is specific to ARKit. ARKit provides a series of [blend shapes](https://developer.apple.com/documentation/arkit/arfaceanchor/2928251-blendshapes?language=objc) to describe different features of a face. Each blend shape is modulated from 0..1. For example, one blend shape defines how open the mouth is.

## Front facing camera

Face tracking requires the use of the front-facing or "selfie" camera. When the front-facing camera is active, other tracking subsystems like plane tracking or image tracking may not be available. If the rear-facing camera is active, face tracking might not be available.

Different iOS devices support different combinations of features. If you `Start` a subsystem that requires the rear-facing camera, the ARKit package might decide to use the rear-facing camera instead. For more information, see [Camera and Tracking Mode Selection](https://docs.unity3d.com/Packages/com.unity.xr.arfoundation@4.1/manual/migration-guide-3.html#camera-and-tracking-mode-selection).

## Technical details

### Requirements

This version of ARKit Face Tracking is compatible with the following versions of the Unity Editor:

* 2020.3
* 2021.1
* 2021.2

To use this package, you must have:

- An iOS device capable of performing face tracking. Such devices require either a front-facing TrueDepth camera or an A12 Bionic chip (or later). Devices include:
  - iPhone X
  - iPhone XS
  - iPhone XS Max
  - iPhone XR
  - iPhone 11
  - iPhone 12
  - iPad Pro (11-inch)
  - iPad Pro (12.9-inch, 3rd generation)
  - iPhone SE
- iOS 11.0 or later
- Xcode 11.0 or later

### Known limitations

None

### Package contents

This version of **ARKit Face Tracking** includes a static library that provides an implementation of the [XRFaceSubsystem](xref:arsubsystems-face-subsystem).
