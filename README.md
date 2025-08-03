# teach.todo.mvc
This repository was created to teach ASP.NET MVC app development basics.

INITIAL PROJECT SETUP

This will be a Model-View-Controller project. MVC is a design pattern that isolates code by responsibility and is a relatively traditional architecture for ASP.NET applications.

STEP 1: Install Visual Studio Community  
STEP 2: Install Git (https://github.com/git-for-windows/git/releases/download/v2.50.1.windows.1/Git-2.50.1-64-bit.exe)  
STEP 3: Create a Repository in Github named teach.todo.mvc  
STEP 4: Locate the green "Code" button and copy the URL there.  
STEP 5: Open visual studio and select "clone repository". Enter the URL copied from the prior step.  
STEP 6: In Visual Studio, click File > New > Project (ASP.NET Core Web App Model-View-Controller) (make sure you see C# at the bottom) 
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

Once we've designed our database and produced an Entity Relationship Diagram, we can code our database to that specification. We start with a class that represents the database entity we want to model. A class is a definition of something. For example, a class of car may be defined to have attributes like Make, Model, Year, Color etc. Those attibutes each have a type. For example, Make may be a string to store something like "Ford". Year might be an integer to store something like 2025. A class is a blueprint that defines the structure and behavior of something, while an instance is an actual object created from that blueprint with its own data. You can think of the class as the recipe and the instance as the finished dish. Or a description of what any car MAY have vs an actual car object and what that specific car DOES have. A car class has an attribute of name. A car instance has an attribute name set to "Mustang".

STEP 1: With our "add-model" branch still checked out, view the Solution Explorer pane, right click "Models" and click Add > New Item. Name it TodoItem.cs  
STEP 2: You now have an Empty class... let's flesh it out. Inside the ToDoItem braces, let's add some attributes/properties/members (these words are often used somewhat interchangeably - you'll learn the nuances later):

    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public bool IsComplete { get; set; }

STEP 3: Click save. Go to the Git Changes pane, enter a commit message "Added TodoItem model" and click commit.  
STEP 4: Push to the remote repo (look for the button at the top)

PULLING AND MERGING

Now, the changes in our branch exist locally and on the server. Now we need to integrate them into the main branch.

STEP 1: In the status bar at the bottom, checkout the main branch (it currently shows "add-model", select "main").  
STEP 2: Now that we have the main branch checked out, go to solution explorer, look in the Models folder and notice there is no "TodoItem.cs".  
STEP 3: Go to the Git Changes pane, and PULL the latest main, by clicking the PULL botton at the top. If another developer got their changes into main before us, we now have their changes in our local copy of main. We need to get those changes into our branch, so we will do a MERGE.   
STEP 4: Checkout "add-model" from the bottom status bar.  
STEP 5: Once, checkedout, click "add-model" from the status bar again and right click on the main branch. Select "Merge into current branch." If there are no conflicts, it will automatically merge the changes in main into the add-model branch. add-model now has everything.  
STEP 6: At this point you'd test to make sure everything you've built still works and fix anything broken by integrating main into add-model. We don't have anything to do this time.

CREATE A PULL REQUEST

Now that our code is good to go, we want to get our changes into the main branch. The main branch is controlled and often we have to pass review to merge our changes in. So we have to request that main PULL our add-model branch in. We can do this in Visual Studio or GitHub. Here we'll do the Github way.

STEP 1: Go to the repository in GitHub and click the Pull Requests tab.  
STEP 2: GitHub usually shows a banner: "Compare & pull request". Click it, or go to Pull Requests >New Pull Request. Notice it shows you what changed.  
STEP 3: Add a title and description and click "Create Pull Reqeust".

CODE REVIEW AND MERGE PULL REQUEST

STEP 1: Go to the Pull Request (PR) in GitHub, then the Files Changed tab.  
STEP 2: Browse the changes, leave comments.  
STEP 3: Click Review Changes and choose "Approve" or "Request Changes"  

MAKE CHANGES (OPTIONAL)

If requested to make changes, you do it in your local branch (add-model).

STEP 1: Update the code in the add-model branch.  
STEP 2: Commit with a message "fixed thing"  
STEP 3: Push the changes to the server.  

The PR updates automatically.

APPROVAL

STEP 1: Upon a approval, we click "Merge Pull Request"  
STEP 2: Delete the feature branch (add-model) if no longer needed.  
