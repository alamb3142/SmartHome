# SmartHome

## About

A Smart Home system focusing on privacy and security. This project mainly serves as a demonstration of design practices rather than a commercially viable product, so the implementation may be a little thin.

## Documentation

- [Architecture](./Documentation/architecture.md)
- [Context Diagrams](./Documentation/c4-diagrams.md)
- [Domain Model/Ubiquitous Language](./Documentation/domain-model.md)
- [SPA Design](./Documentation/spa-design.md)

## Project Guidelines

1. **Domain-Driven Design** - This project is built following domain driven design principles. Any changes that affect the model should be accompanied by changes to the [domain model document](./Documentation/domain-model.md)
1. **No exceptions for control flow** - All projects should have the `FluentResults` package installed, use it. Any action that is likely to fail, or has failed in the past, should return a `Result` type. This limits any exceptions to third party libraries & forces us to be explicit about failures & how to handle them.
1. **CQRS** - State changes (commands) are to be handled by MediatR in the application layer using domain & application layer classes/interfaces. Queries bypass the domain layer & query data directly, however the preferred approach is to define a "read repository", like `IDeviceReadRepository`, in the application layer & implement it in infrastructure.
