# Changelog
All notable changes to this package will be documented in this file.

The format is based on [Keep a Changelog](http://keepachangelog.com/en/1.0.0/)
and this project adheres to [Semantic Versioning](http://semver.org/spec/v2.0.0.html).

## [1.0.7] - 2020-04-08
### Fixes
- Subsystem registration now happens earlier in the runtime initialization process.

## [1.0.2] - 2019-08-31
### Updated
- Update depedency on AR Subsystems package to version 2.1.1. This should not impact existing functionality, but helps with future compatibility.

## [1.0.1] - 2019-07-03
- 2019.3 verified release

## [1.0.0-preview.6] - 2019-05-31
### Fixes
- Fix documentation links.

## [1.0.0-preview.4] - 2019-05-06

### This is the first release of *ARKit Face Tracking*.

Provides runtime support for Face Tracking on ARKit. This is a separate package from com.unity.xr.arkit due to security concerns: apps that contain certain face-tracking related symbols in their compiled binaries will fail App Store validation unless additional documentation explaning the uses of face tracking are documented. This allows face tracking support to be added separately.
