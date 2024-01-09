# LogMessage Utility for Unity

## Introduction
The `LogMessage` utility class is part of the `com.Klazapp.Utility` namespace, designed for Unity projects to simplify the logging process. It allows for an easy on/off switch to enable or disable all log messages in the app, eliminating the need to manually comment out or add log statements in each script.

## Features
- Easy toggling of log messages with a single switch.
- Methods for standard, error, and warning messages, each color-coded for clarity.
- Conditional compilation to ensure log calls are only included in builds where logging is enabled.

## Usage
To use `LogMessage`, first ensure it is correctly added to your Unity project. You can then call its methods in your scripts as follows:

```csharp
LogMessage.Debug("This is a debug message");
LogMessage.DebugError("This is an error message");
LogMessage.DebugWarning("This is a warning message");
```

To enable logging, define `ENABLE_LOGS` in your project's compilation symbols. When `ENABLE_LOGS` is not defined, calls to `LogMessage` methods will be ignored, reducing overhead in production builds.

## Installation
1. Clone or download this repository.
2. Copy the `LogMessage.cs` file into your Unity project, preferably in a folder reserved for utility scripts.
3. Ensure that your project's scripting define symbols include `ENABLE_LOGS` if you want to enable logging.

## Contributing
Contributions to the `LogMessage` utility are welcome. Please feel free to fork this repository, make your changes, and submit a pull request.

## License
This utility is released under the [MIT License](LICENSE).

---

This structure uses Markdown syntax for GitHub, which includes `#` for headers, triple backticks ``` for code blocks, and standard list formatting. Replace `[LICENSE]` with the actual link to your license file. You can add more sections as needed, such as `Requirements`, `Version Compatibility`, `Screenshots`, and `Contact Information`.
