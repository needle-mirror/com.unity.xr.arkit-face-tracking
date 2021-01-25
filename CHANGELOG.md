# Changelog

All notable changes to this package will be documented in this file.

The format is based on [Keep a Changelog](http://keepachangelog.com/en/1.0.0/)
and this project adheres to [Semantic Versioning](http://semver.org/spec/v2.0.0.html).

## [4.0.12] - 2021-01-25

## [4.0.10] - 2021-01-05

### Changes

- Removed the `CONTRIBUTING.md` file as this package does not accept contributions.

## [4.0.9] - 2020-10-06
### Changes
- Updated dependencies on ARSubsystems and ARKit XR Plugin packages to 4.0.9.

## [4.0.8] - 2020-08-24
### Changes
- Updated dependencies on ARSubsystems and ARKit XR Plugin packages to 4.0.8.

## [4.0.6] - 2020-07-27
### Changes
- Static library was built with Xcode 11.6 (11E708).
- Removed support for Xcode versions below version 11.0 as per apple app store submission guidelines.  [See App Store submission guidelines for more information](https://developer.apple.com/app-store/submissions)

## [4.0.2] - 2020-07-10
### Fixes
- Fixed a typo in the documentation

### Changes
- Updating dependency on ARKit XR Plugin to 4.0.2.

## [4.0.1] - 2020-05-27
### Changes
- Updating dependency on AR Subsystems to 4.0.1.

## [4.0.0-preview.3] - 2020-05-04
### Changes
- Static libraries were built with Xcode 11.4.1 (11E503a) and Xcode 10.3 (10G8).

### Fixes
- Fixed all broken or missing scripting API documentation.

## [4.0.0-preview.1] - 2020-02-26
### Changes
- The ARSubsystem implementions have been updated to reflect changes in the ARSubsystems API.
- See the [ARFoundation Migration Guide](https://docs.unity3d.com/Packages/com.unity.xr.arfoundation@4.0/manual/migration-guide-3.html) for more details.

## [3.1.3] - 2020-04-13
### Changes
- Build compiled binaries with Xcode 10.3 (10G8) and Xcode 11.4 (11E146).

## [3.1.0-preview.8] - 2020-03-12

## [3.1.0-preview.7] - 2020-03-03
### Changes
- Build compiled binaries with Xcode 10.3 (10G8) and Xcode 11 (11C505).

## [3.1.0-preview.6] - 2020-02-18
### Fixes
- Updating version dependency on com.unity.xr.arkit.

## [3.1.0-preview.4] - 2020-01-17
### Fixes
- Updating version dependency on com.unity.xr.arkit.

## [3.1.0-preview.2] - 2019-11-22
### Fixes
- Cleaning the static library meta files.

## [3.1.0-preview.1] - 2019-11-21
### Changes
- Rebuilt static libraries.

## [3.0.2] - 2020-03-18
### Changes
- Build compiled binaries with Xcode 10.3 (10G8) and Xcode 11.3.1 (11C505).

### Fixes
- Updating version dependency on com.unity.xr.arkit.

## [3.0.1] - 2019-11-27
- 2020.1 verified release

### Fixes
- Updating version dependency on com.unity.xr.arkit.

## [3.0.0] - 2019-11-05

## [3.0.0-preview.4] - 2019-10-22
### Changes
- Static libraries were built with Xcode 11.1 (11A1027) and Xcode 10.3 (10G8)

### Fixes
- Fixed an incorrect face rotation when using the rear camera feed.
- Correctly report the supported number of simultaneously tracked faces. Previously, [ARFaceManager.supportedFaceCount](https://docs.unity3d.com/Packages/com.unity.xr.arfoundation@3.0/api/UnityEngine.XR.ARFoundation.ARFaceManager.html#UnityEngine_XR_ARFoundation_ARFaceManager_supportedFaceCount) would always return the supported number of tracked faces in front-facing camera mode. The value reported now depends on the current configuration since, in rear-facing camera mode, the number could be different.

## [3.0.0-preview.3] - 2019-09-26
### Changes
- Build compiled binaries with Xcode 10.3 (10G8) and Xcode 11 (11A420a)

## [3.0.0-preview.2] - 2019-09-05
### Improvements
- Update [ARSubsystems](https://docs.unity3d.com/Packages/com.unity.xr.arsubsystems@3.0) dependency to 3.0.0-preview.2

## [3.0.0-preview.1] - 2019-08-27
### New
- This package now supports bulding with Xcode 10, and 11 beta 7.

## [1.1.0-preview.4] - 2019-07-29
### New
- Add support for eye tracking.

### Changes
- Recompile static library with XCode 11 beta 5.

## [1.1.0-preview.3] - 2019-07-18
### Changes
- Recompile static library with Xcode 11 beta 4.

## [1.1.0-preview.2] - 2019-07-15
### Changes
- Recompile static library with Xcode 11 beta 3.
- Update Unity dependency to 2019.1

## [1.1.0-preview.1] - 2019-06-05
- Adding support for ARKit 3 functionality: multiple face tracking and tracking a face (with front camera) while in world tracking (with rear camera).

## [1.0.0-preview.6] - 2019-05-31
### Fixes
- Fix documentation links.

## [1.0.0-preview.4] - 2019-05-06

### This is the first release of *ARKit Face Tracking*.

Provides runtime support for Face Tracking on ARKit. This is a separate package from com.unity.xr.arkit due to security concerns: apps that contain certain face-tracking related symbols in their compiled binaries will fail App Store validation unless additional documentation explaning the uses of face tracking are documented. This allows face tracking support to be added separately.
