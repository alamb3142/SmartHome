# SmartHome

## About

A Smart Home system focusing on privacy and security. This project mainly serves as a demonstration of design practices rather than a commercially viable product, so the implementation may be a little thin.

## Domain Concepts

The domain model we're starting with will carve up the system into subdomains around the different types of device the system supports. So we will design around subdomains/bounded contexts like `Switchables`, `Cameras`, `ClimateControl`, `Security`. This gives us a basic blueprint that loosely resembles a Vertical Slice Architecture where we have modules that separate code between capabilities/functionality, using Clean Architecture within modules to separate technical concerns. This means that if we change the way a thermostat works then we only have to worry about the `ClimateControl` module, or if we want a more advanced storage solution for CCTV then we only have to implement that in the `Cameras` module.

The first and simplest module we will focus on is `Switchables`. This includes devices that act as a `Switch` for turning physical devices on and off like a light or plug socket. We will have a `SmartBulb` which acts similarly to the `Switch` but also controls brightness & RGB settings. Eventually we may interface with smart appliances like an `Oven` to allow a user to preheat before leaving work. A common thread between these types of devices is that we may want to run them on a `Timer`, which allows a user to specify a one off or recurring `Timer` for the device to switch on and off.

On top of these business capabilities we will also have supporting modules like `UserAccess` which will be responsible for authorisation logic.

## Further Reading

- [Architecture](./Documentation/architecture.md)
- [Context Diagrams](./Documentation/c4-diagrams.md)
- [Domain Model/Ubiquitous Language](./Documentation/domain-model.md)
