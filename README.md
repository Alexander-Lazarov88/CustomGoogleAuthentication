# GoogleAuthenticationWithScaffoldedIdentity
Authenticate server-side Blazor with Google and scaffolded Identity for customization.

This is a very basic project just to show how to use Google authentication and Microsoft Identity, but only the part you want.
The reason for this repository is that for other project I just want to have log in only from google and disable default identity logic and register form.

Credits to:
1. http://blazorhelpwebsite.com/Blog/tabid/61/EntryId/4356/Google-Authentication-in-Server-Side-Blazor.aspx
2. https://stackoverflow.com/questions/57662442/how-to-call-a-razor-page-from-a-blazor-component-in-a-server-side-blazor-applica

2.1 At this time I only use this: "remove Pages/_ViewStart.cshtml"
  
Important:
To use Environment variables you must set it and restrat Visual Studio.
I use Windows Environment variables editor.

You can use steps from blog post and when it comes to scaffold identity pick up the pages that you want to edit,
pass your DbContext and after that reproduce the steps from link to "StackOverflow"
(if you use .NET Core 3.0 or newer version, you just use action describe in 2.1 in this readme). In my case I edit
the "Register.cshtml", to remove default form and only use external providers.
You can extend Identity with your custom user class, but don't forget to replace "TUser" in "SignInManager" and "UserManager"
in every scaffolded page that you want to edit.
