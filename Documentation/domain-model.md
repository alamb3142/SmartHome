# Domain Model

[back to README.md](../README.md)

## Ubiquitous Language

### Devices

SmartHome users have `Device`s in their home to manage.

Each `Device` has one or `Control`s, for example a basic smart bulb will have `OnOff` controls, while a more advanced model may have `Level` and `Colour` controls.

### Controls

A `Switch` is a `Control` that can be turned on or off. Like a `Light`, `Plug` or a `Lock` (locks may become their own control at some point).

NB: the `Switch` may become part of the default behaviour of a device, this depends on whether or not there is a useful distinction between switching a device physically on or off or simple set some binary state. Maybe a user doesn't need to switch a device off physically.

A `Level` `Control` provides functionality for adjusting some property. For example a dimmable smart bulb would expose both `Switch` and `Level` `Control`s.

`Colour` provides RGB colour for devices.

`Blinds` are another control that users might be interested in, but is their functionality really any different to level, or onoff controls?

### Other Functionality

Some `Devices` can be programmed on a `Timer`. How exactly that will work is TBD.

## Conceptual Model

TODO
