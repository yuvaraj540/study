🧾 C# (.NET) CLI Command Reference
🏗️ Create a New Console Project
dotnet new console -n <ProjectName>

Command Details:

dotnet new → Generates a new project using a specified template.

console → Defines the project type as a Console Application.

-n → Assigns a name to the project and creates a folder with that name.

📁 Navigate to Project Folder
cd <ProjectName>

Command Details:

cd → Changes the current working directory to the project directory.

▶️ Run the Application
dotnet run

Command Details:

Builds the project automatically if needed.

Executes the compiled application.

Used for normal development execution.

🔄 Run with Live Hot Reload
dotnet watch run

Command Details:

Monitors project files for changes.

Automatically rebuilds and restarts the application on save.

Speeds up development workflow.

🧱 Build the Project
dotnet build

Command Details:

Compiles the application source code.

Produces output files inside the bin directory.

Does not execute the program.

🧹 Clean Build Artifacts
dotnet clean

Command Details:

Removes compiled files.

Deletes bin and obj folders.

Useful for resetting the project state.

🔍 Check Installed .NET Version
dotnet --version

Command Details:

Displays the installed .NET SDK version.

Confirms proper SDK installation.

⚙️ Requirement

Ensure the .NET SDK is installed and correctly configured in your system environment variables before executing these commands.