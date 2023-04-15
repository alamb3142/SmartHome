# Context Diagrams

[back to README.md](../README.md)

## C2 (Container)

![C2 Diagram](./Diagrams/SmartHomeC2.drawio.png)

TODO: "Management Portal" -> "SPA", add event bus or update the device -> application connection to imply that events are used here rather than http calls

## C3 (Component)

![C3 Diagram](./Diagrams/SmartHomeC3.drawio.png)

About these components:

| Component | Description                                                                                                                                                                                                                                                                                                                                                                                                |
| --------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| SPA       | Angular SPA                                                                                                                                                                                                                                                                                                                                                                                                |
| API       | .NET Core API, set of controllers per subdomain/module, sends CQRS\* commands & queries via mediator to relevant module                                                                                                                                                                                                                                                                                    |
| Modules   | .NET Core libraries, define commands/queries to be exposed by API, modules also subscribe to integration events from other modules & smart devices                                                                                                                                                                                                                                                         |
| Data      | Data stores will be built up based on the needs of a module, so a low data module may have a small SQLite or MongoDB database for device data & config. A more data intensive module like Cameras may have multiple stores, one for device data & domain logic, another for storing video files.                                                                                                           |
| Event Bus | Asynchronous communication between modules & devices. Exact library TBD (probably Kafka or Rabbit). Typed integration events should only be published to by the module or device that defines the event, but any module/device can subscribe to any integration event. We may implement an extra abstraction layer to map data published by smart devices to a C# type that modules can easily understand. |

\* CQRS: Command Query Responsibility Segregation

## C4 (Class):

TODO: Class diagram per aggregate root, lower definition class diagrams to show how aggregate roots within a module interact with each other & between modules.
