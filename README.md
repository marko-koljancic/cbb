# Circle's BIM Blog

An Autodesk Revit plugin developed as part of a comprehensive video tutorial series on BIM development and automation.

[![YouTube Channel](https://img.shields.io/badge/YouTube-Channel-red)](https://www.youtube.com/channel/UCuOg2xqPGssctOte5TWrW5g?view_as=subscriber)
[![Trello Roadmap](https://img.shields.io/badge/Trello-Roadmap-blue)](https://trello.com/b/JjstvevR/circles-bim-blog-cbb)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

## Overview

Circle's BIM Blog is an open-source Revit plugin that showcases various commands and features developed through educational video tutorials. The plugin demonstrates best practices in Revit API development, WPF UI design, and MVVM architecture implementation.

**Key Features:**
- Family Manager with intuitive UI
- Wall layer tagging automation
- Selection filtering by category
- Custom annotation tools

This repository is public and can be used in accordance with the MIT license provided in the repository root directory.

## Quick Start

### Prerequisites

- **Microsoft Visual Studio 2019+** (Community, Professional, or Enterprise)
- **.NET Framework 4.7.1** or higher
- **Autodesk Revit 2019+** ([Download Education License](https://goo.gl/mWBrmQ))

### Installation

**Option 1: Download Pre-built Binary**
1. Download the latest build from [Dropbox](https://www.dropbox.com/sh/31fds7cfi3oml7h/AAAUkQrw0zGaQTygBjAH07Fja?dl=0)
2. Copy the `.addin` file and assemblies to your Revit addins folder:
   - Windows: `%APPDATA%\Autodesk\Revit\Addins\2019`
3. Restart Revit

**Option 2: Build from Source**
1. Clone the repository:
   ```bash
   git clone https://github.com/marko-koljancic/cbb.git
   cd cbb
   ```
2. Open `cbb.sln` in Visual Studio
3. Restore NuGet packages
4. Build the solution (F6 or Ctrl+Shift+B)
5. The compiled plugin will be available in the output directory

## Repository Structure

```
cbb/
├── addin/          # Revit addin manifest files
├── dat/            # Sample Revit family files (.rfa)
│   └── family/     # Example families for testing
├── ext/            # External libraries and dependencies
├── mat/            # Material resources (themes, colors)
├── src/            # Source code
│   ├── cbb/                # Main entry point assembly
│   ├── cbb.core/           # Core plugin logic and commands
│   │   ├── Commands/       # Revit command implementations
│   │   ├── DataModels/     # Data models and entities
│   │   ├── Helpers/        # Utility helpers
│   │   ├── ViewModels/     # MVVM view models
│   │   └── Type/           # Type definitions and enums
│   ├── cbb.res/            # Resource assembly (images, fonts)
│   └── cbb.ui/             # WPF UI components and styles
│       ├── Pages/          # UI pages
│       ├── Controls/       # Reusable UI controls
│       └── Styles/         # XAML styles and themes
└── README.md       # This file
```

## Project Architecture

The solution is organized into four main assemblies:

| Assembly | Purpose |
|----------|---------|
| `cbb` | Main entry point and Revit external application |
| `cbb.core` | Core business logic, commands, and view models |
| `cbb.res` | Resources including images, icons, and fonts |
| `cbb.ui` | WPF user interface components and styles |

## Development

### Technology Stack

- **Language:** C# (.NET Framework 4.7.1)
- **UI Framework:** WPF (Windows Presentation Foundation)
- **Architecture:** MVVM (Model-View-ViewModel)
- **Target Platform:** Autodesk Revit 2019+
- **Build Tool:** MSBuild (Visual Studio)

### Key Components

- **Family Manager:** Browse and manage Revit families with a custom UI
- **Tag Wall Layers:** Automated tagging for wall layer annotations
- **Selection Filters:** Advanced element selection by category
- **Custom Commands:** Various utility commands for Revit workflows

## Roadmap

Track project progress and upcoming features on our [Trello Board](https://trello.com/b/JjstvevR/circles-bim-blog-cbb).

## Contributing

We welcome contributions from the community! To contribute:

1. Fork the repository
2. Create your feature branch: `git checkout -b feature/amazing-feature`
3. Commit your changes: `git commit -m 'Add some amazing feature'`
4. Push to the branch: `git push origin feature/amazing-feature`
5. Open a Pull Request

Please ensure your code follows the existing style and includes appropriate documentation.

## Resources

- **YouTube Channel:** [Circle's BIM Blog](https://www.youtube.com/channel/UCuOg2xqPGssctOte5TWrW5g?view_as=subscriber)
- **Latest Builds:** [Dropbox Folder](https://www.dropbox.com/sh/31fds7cfi3oml7h/AAAUkQrw0zGaQTygBjAH07Fja?dl=0)
- **Project Roadmap:** [Trello Board](https://trello.com/b/JjstvevR/circles-bim-blog-cbb)

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Contact

**Marko Koljancic**  
Website: [koljam.com](https://koljam.com/)

---

*If you find this project helpful, please consider subscribing to the YouTube channel and starring the repository!*
