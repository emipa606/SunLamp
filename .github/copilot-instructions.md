# GitHub Copilot Instructions for Sun Lamp+ (Continued) Mod

## Mod Overview and Purpose
The Sun Lamp+ (Continued) mod is an update to the original mod by ToyWalrus. This mod provides enhancements to the default behaviors of sun lamps and hydroponic basins in RimWorld, enhancing gameplay through improved environmental and resource management.

The mod is not currently under active development, but it remains available for enhancing players' gardening experiences by modifying light and heat dynamics. It also provides compatibility with other mods enhancing utility and lighting systems, such as Simple Utilities: Ceiling, Utility Columns, Project Rimfactory, and Wallight.

## Key Features and Systems
### Sun Lamps
- **Increased Light Radius:** The mod modifies sun lamps to provide a larger area of illumination, improving the effective farming area.
- **Continuous Operation:** Sun lamps now remain active throughout the night, ensuring no interruption in light-dependent processes.
- **Increased Heat Output:** The increased heat output makes sun lamps a dual-purpose tool for providing warmth in cooler climates.

### Hydroponic Basins
- **Decreased Construction Costs:** Reduced costs for hydroponic basin construction enable players to efficiently manage resources.
- **Improved Power Efficiency:** A configuration allowing 16 basins and a sun lamp to operate from a single Geothermal Power Generator.
- **Continuous Growth Cycle:** Plants in basins will continue growth without resting at night, optimizing planting schedules.

## Coding Patterns and Conventions
- **C# Naming Conventions**: Classes and methods follow PascalCase naming conventions, while variables and fields use camelCase. Comments are used to denote the purpose of major sections within the code. Consistent naming helps Copilot generate accurate code suggestions.
- **XML Structure**: Well-structured XML is essential for defining patches and configurations. Use clear element and attribute names to increase readability and maintainability.

## XML Integration
The mod utilizes XML files primarily for patching purposes:
- **BetterSunLamp.xml**: Defines various patch configurations that enhance the sun lamp functionalities.
- **About.xml**: Contains metadata about the mod, which is essential for mod identification and versioning.

Ensure XML files are placed in appropriate directories and maintain proper schema structures. Copilot can assist in generating XML structures by providing suggestions based on defined tags and attributes.

## Harmony Patching
The mod relies on Harmony for runtime patching:
- **Harmony Library**: Used to apply patches dynamically during game runtime. This allows modification of existing game methods without directly altering the game's source code.
- **Postfix Method**: In `Plant_Resting.cs`, a postfix method is used to modify plant resting behavior, allowing plants to continue growing at night.

For reliable patching:
- Use clear and unique patch IDs.
- Ensure patches are applied to the correct methods by double-checking method signatures.

## Suggestions for Copilot
- **Code Completion**: When writing or updating methods, Copilot can assist by suggesting method signatures, especially for implementing Harmony patches.
- **XML Tags**: When creating or modifying XML configurations, rely on Copilot for auto-completing elements and attributes due to its extensive understanding of XML structures.
- **Refactoring Assistance**: Use Copilot's refactoring suggestions to improve existing code readability and performance.

By following these structured guidelines and leveraging GitHub Copilot effectively, developers can enhance the Sun Lamp+ mod’s functionality and maintain its compatibility within the RimWorld modding ecosystem.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

