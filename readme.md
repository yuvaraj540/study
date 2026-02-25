# 🧾 C# (.NET) CLI Command Reference

---

## 🏗️ Create a New Console Project

```bash
dotnet new console -n <ProjectName>
```

### 🔎 Command Details

- `dotnet new` → Generates a new project using a specified template.
- `console` → Specifies the project type as a Console Application.
- `-n` → Assigns a name to the project and creates a folder with that name.

---

## 📁 Navigate to Project Directory

```bash
cd <ProjectName>
```

### 🔎 Command Details

- `cd` → Changes the current working directory to the specified project folder.

---

## ▶️ Run the Application

```bash
dotnet run
```

### 🔎 Command Details

- Builds the project automatically if required.
- Executes the compiled application.
- Used for normal development execution.

---

## 🔄 Run with Live Hot Reload

```bash
dotnet watch run
```

### 🔎 Command Details

- Watches project files for changes.
- Automatically rebuilds and reruns the application when files are saved.
- Improves development workflow speed.

---

## 🧱 Build the Project

```bash
dotnet build
```

### 🔎 Command Details

- Compiles the source code.
- Generates output files inside the `bin` directory.
- Does not execute the application.

---

## 🧹 Clean the Project

```bash
dotnet clean
```

### 🔎 Command Details

- Removes compiled output files.
- Deletes `bin` and `obj` folders.
- Useful for resetting build artifacts.

---

## 🔍 Check Installed .NET Version

```bash
dotnet --version
```

### 🔎 Command Details

- Displays the installed .NET SDK version.
- Used to verify environment setup.

---

## ⚙️ Requirement

Ensure the .NET SDK is installed and properly configured in your system PATH before running these commands.