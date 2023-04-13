# Domain Model - Breakdown

[back to README.md](../README.md)

## Intro

The main breakdown of the domain will be by functionality. This gives us a domain driven system with the main benefit of vertical slice architecture: isolating code by capability.

Initially we break this down into `CCTV` for camera devices, `Climate` for thermostats, temp probes, humidity sensors, `Switchables` for light switches, smart bulbs and smart sockets. This will be supported by `UserAccess` to provide domain logic and configuration to sit behind/alongside an IdentityServer implementation, and `Management` as an orchestration layer between the different functionalities.

## Domain Concepts

The domain model we're starting with will carve up the system into subdomains around the different types of device the system supports. So we will design around subdomains/bounded contexts like `Switchables`, `Cameras`, `ClimateControl`, `Security`. This gives us a basic blueprint that loosely resembles a Vertical Slice Architecture where we have modules that separate code between capabilities/functionality, using Clean Architecture within modules to separate technical concerns. This means that if we change the way a thermostat works then we only have to worry about the `ClimateControl` module, or if we want a more advanced storage solution for CCTV then we only have to implement that in the `Cameras` module.

The first and simplest module we will focus on is `Switchables`. This includes devices that act as a `Switch` for turning physical devices on and off like a light or plug socket. We will have a `SmartBulb` which acts similarly to the `Switch` but also controls brightness & RGB settings. Eventually we may interface with smart appliances like an `Oven` to allow a user to preheat before leaving work. A common thread between these types of devices is that we may want to run them on a `Timer`, which allows a user to specify a one off or recurring `Timer` for the device to switch on and off.

On top of these business capabilities we will also have supporting modules like `UserAccess` which will be responsible for authorisation logic.

## Switchables

A `Switch` is a device that controls the state of some physical device. In it's simplest form a `Switch` simply conveys an on/off state that can be updated via the API or the physical switch. A `Switch` may also be populated by a number of `Timer`s. A `Timer` contains start and end times as well as the days of the week the timer is active.

## CCTV

A `Camera` will stream video. Domain logic here will largely be informed by implementation details, so this section will be further refined when more research has been carried out.

## Conceptual Model

TODO: Domain conceptual model diagram
