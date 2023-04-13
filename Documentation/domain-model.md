# Domain Model - Breakdown

[back to README.md](../README.md)

## Intro

The main breakdown of the domain will be by functionality. This gives us a domain driven system with the main benefit of vertical slice architecture: isolating code by capability.

Initially we break this down into `CCTV` for camera devices, `Climate` for thermostats, temp probes, humidity sensors, `Switchables` for light switches, smart bulbs and smart sockets. This will be supported by `UserAccess` to provide domain logic and configuration to sit behind/alongside an IdentityServer implementation.

## Switchables

A `Switch` is a device that controls the state of some physical device. In it's simplest form a `Switch` simply conveys an on/off state that can be updated via the API or the physical switch. A `Switch` may also be populated by a number of `Timer`s. A `Timer` contains start and end times as well as the days of the week the timer is active.

## CCTV

A `Camera` will stream video. Domain logic here will largely be informed by implementation details, so this section will be further refined when more research has been carried out.

## Conceptual Model

TODO: Domain conceptual model diagram
