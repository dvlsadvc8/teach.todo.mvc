# teach.todo.mvc
This repository was created to teach ASP.NET MVC app development basics.

INITIAL PROJECT SETUP

This will be a Model-View-Controller project. MVC is a design pattern that isolates code by responsibility and is a relatively traditional architecture for ASP.NET applications.

STEP 1: Install Visual Studio Community  
STEP 2: Install Git (https://github.com/git-for-windows/git/releases/download/v2.50.1.windows.1/Git-2.50.1-64-bit.exe)  
STEP 3: Create a Repository in Github named teach.todo.mvc  
STEP 4: Locate the green "Code" button and copy the URL there.  
STEP 5: Open visual studio and select "clone repository". Enter the URL copied from the prior step.  
STEP 6: In Visual Studio, click File > New > Project  
STEP 7: In the "Git Changes" panel, click the + symbol next to "Changes" to "Stage All"  
STEP 8: Type a commit message like "Initial commit - new mvc project". Click commit. (say yes to any prompt asking to save)

ADD ENTITY FRAMEWORK CORE

Entity Framework is an Object-Relational-Mapping (ORM) framework. Entity Classes map to tables in a database. Instances of classes map to rows in a database table. This allows us to write C# classes that create the structure of our database and hold the contents of our data records.

STEP 1: In Visual Studio, go to Tools > Nuget Package Manager > Manage Nuget Packages for Solution  
STEP 2: Under "Browse", search for EntityFrameworkCore.SqlServer, click on it and on the right hand side check the project and click Install. Approve and agree to any prompts.  
STEP 3: Search for EntityFrameworkCore.Tools, select it and check the box for the project and click install. Approve and agree to any prompts.  
STEP 4: In the Git Changes panel, click + next to Changes to Stage ALL.  
STEP 5: Type a commit message like "Added Entity Framework Core". Click commit. (say yes to any prompt asking to save)

You may close the Nuget Package manager window. At this point, we cloned the remote repository (Github) and now have a local repository (on your machine). We also have two local commits. The remote repository doesn't know anything about them yet however.

PUSH COMMITS TO THE REMOTE REPO

STEP 1: In the Git Changes panel, at the top click "Push" (Looks like a line at the bottom with an arrow going up). You are pushing the commits to the remote repository.

BRANCHING

It is often helpful to work in separate branches while working in a team. Lets create a branch so we can work in isolation.

STEP 1: In Visual Studio, in the bottom status bar, click where it currently says "main" (This shows you currently have the main branch checked out). Click "New Branch."
STEP 2: Enter a descriptive branch name (I usually use the title of the feature I'm working on with hyphens) like "add-models" (in real worl practice, a branch will like cover many tasks). This branch will be based on main and checkout branch is checked. Click Create. Notice the status bar now shows "add-models" branch is checked out. We can switch braches from there if we want.
STEP 3: The remote repository knows nothing about our new branch, so even though we haven't added anything yet, let's do a push so the remote server knows our branch exists.

ADD A MODEL CLASS

Once we've designed our database and produced an Entity Relationship Diagram, we can code our database to that specification. 




A class is a definition of something. For example, a class of car may be defined to have attributes like Make, Model, Year, Color etc. Those attibutes have a type. For example, Make may be a string like "Ford". Year might be an integer, like 2025.
