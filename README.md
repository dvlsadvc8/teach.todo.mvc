# teach.todo.mvc
This repository was created to teach ASP.NET MVC app development basics.

INITIAL PROJECT SETUP

STEP 1: Install Visual Studio Community  
STEP 2: Install Git (https://github.com/git-for-windows/git/releases/download/v2.50.1.windows.1/Git-2.50.1-64-bit.exe)  
STEP 3: Create a Repository in Github named teach.todo.mvc  
STEP 4: Locate the green "Code" button and copy the URL there.  
STEP 5: Open visual studio and select "clone repository". Enter the URL copied from the prior step.  
STEP 6: In Visual Studio, click File > New > Project  
STEP 7: In the "Git Changes" panel, click the + symbol next to "Changes" to "Stage All"  
STEP 8: Type a commit message like "Initial commit - new mvc project". Click commit. (say yes to any prompt asking to save)

ADD ENTITY FRAMEWORK CORE

STEP 1: In Visual Studio, go to Tools > Nuget Package Manager > Manage Nuget Packages for Solution  
STEP 2: Under "Browse", search for EntityFrameworkCore.SqlServer, click on it and on the right hand side check the project and click Install. Approve and agree to any prompts.  
STEP 3: Search for EntityFrameworkCore.Tools, select it and check the box for the project and click install. Approve and agree to any prompts.  
STEP 4: In the Git Changes panel, click + next to Changes to Stage ALL.  
STEP 5: Type a commit message like "Added Entity Framework Core". Click commit. (say yes to any prompt asking to save)
At this point, we cloned the remote repository (Github) and now have a local repository (on your machine). We also have two local commits. The remote repository doesn't know anything about them yet however.

PUSH COMMITS TO THE REMOTE REPO

STEP 1: In the Git Changes panel, at the top click "Push" (Looks like a line at the bottom with an arrow going up). You are pushing the commits to the remote repository.

BRANCHING

It is often helpful to work in separate branches while working in a team.
