# Dynamics365-MetaDataExplorer
(c) 2017, Stefan Ebert

Explore, validate and visualize Metadata of a *"Microsoft Dynamics 365 for Operations"* packages folder.

# Purpose
This program is a developer tool to provide a fast overview of packages, models, versions, references of a so called "PackagesLocalDirectory" folder.
A separation is done into the **Core** functionality, which is consumed by either the **rich Windows client** or the **command line version**.

# Milestones and goals
At time of project ramp-up, I see following implementation steps.

## MS1 - Project setup
- [x] Build project template.
- [x] Prototype some core classes for demo data usage.
- [x] Have a debug form in UI application to view dump data.

## MS2 - Core implementation
- [ ] Data model implementation.
- [ ] File system parser and loader.
- [ ] XML content wrapping into data model.
- [ ] Quick structure data model (without model elements).
- [ ] Full structure data model.

## MS3 - Windows application implementation
- [ ] Load functionality.
- [ ] Tree control implementation.
- [ ] Tree node detail implementation.
- [ ] System/custom filtering.
- [ ] Search in packages and models.

## MS4 - Console application implementation
- [ ] Implement a serialize/deserialize functionality for caching between multiple commands.
- [ ] Search for and use a cool command line parser.
- [ ] Have the "load and validate" operation (which in verbose mode, visualizes to std-output).

## MS5 - Get things completed
- [ ] Export functionality for potentionally graph visualizer.
- [ ] Complete outstanding issues and temporary solutions.
- [ ] Complete source code documentation (xml style).

## MS6 - Release
- [ ] Provide output in a way simple for others to import and use.
- [ ] Have download and install instructions.
- [ ] Have a documentation.

# Progress
During the implementation, I'll "check" the progress to see this board as the current state.

# Environment
IDE used is **Visual Studio 2017**.
Programming language is C#.

## License
Licensed under the [MIT](LICENSE) License.
