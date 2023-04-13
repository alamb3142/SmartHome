# SmartHome


## Initial Design Considerations

The `SmartHome` application is a privacy focused, centrally hosted `Smart Device` management system, for secure & fast communication between devices in the home.

Initially the system will comprise of a single, locally hosted application, written as a .NET monolith, with Domain Driven Design providing the strategic & tactical patterns used to break domain logic up into a number of modules.

The initial design centers around a central hub, likely an embedded Linux system, which will only be available locally for simplicity. Eventually this will have to move online to allow control to users outside the home, but we will likely keep the central hub as a gateway & potential touchscreen management device.

State control devices will poll the API regularly as this is simple and allows for an efficient use of power, especially in remote/battery powered devices. Once an MVP has been developed this will be revisited, likely moving towards MQTT for async communication.

## Domain Concepts

The core of the system is the `Home`, which will likely be omitted for the first iteration as it is represented by the system as a whole, but it's worth a mention as this may become a useful concept for organising users and individual systems in a multi tenant architecture.

The next key concept is the `Device`. This represents a smart device responsible for measuring and/or controlling some state. To avoid messy inheritence hierarchies this concept will likely be broken down into specific device types, e.g. `Thermostat`, `Switch`, `Camera`, etc. The first type of device will be a light switch as this is the simplest to get working.

For now we will consider these as two distinct types, `Controllers` and `Recorders`. A physical device can be both, but it make make sense to treat this single device as two individual domain objects. Another way we might split these devices up is by function, i.e. `Climate` (temp/humidity monitoring & control), `CCTV`, `Switchables` (light switch, smart plug, timers, etc).

Separating by function capability may be the way to go here. It resembles a vertical slice architecture where the system is decoupled across capability concerns. Within `Switchables` we may have smart plugs, light switches, smart bulbs, rgb control for our own devices, and eventually a Matter Standard implementation for this category of device.

So this rambling (to be cleaned up) leads us to our first three potential bounded contexts, represented as modules, with `Identity` and `Management` as supporting sub domains.

## Context Diagrams

### C2 (Container)

![C2 Diagram](./Documentation/Diagrams/SmartHomeC2.drawio.png)

### C3 (Component)

TODO

C4 (Class):

TODO
