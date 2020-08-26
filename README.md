# ASP.NET-Core_Master\

Tip
	Icon: https://www.flaticon.com/free-icon/chili_687851?term=spicy&page=1&position=9

Fix: 
	1. 
		a. An unhandled exception occurred while processing the request.
		InvalidOperationException: The model item passed into the ViewDataDictionary is of type 'System.Collections.Generic.List`1[ASP.NET_Core_Spice.Models.Category]',
		but this ViewDataDictionary instance requires a model item of type 'System.Int32'.
		
		b. Error info: Model.Id (int) - Add partial and Not found in the partial tag
		c. Solution: declare model="@item.Id" int partial tag
	

2. Section 2 Fundamentals and Security
	1. Create a new project
	2. Csproj file
	3. Launchsettings.json New
	4. wwwroot
	5. Razor Pages
	6. Pages Folder
	7. Routing in Razor Pages
	8. Tag Helpers
	9. Action Result in Razor
	10. Main Method
	11. Startup 1
	12. Startup 2
	13. Middlewares
	14. AppSettings
	15. SQL injection
	16. Dependency Injection
	17. Cross-site scripting
	18. Open redirect attacks
	19. Cross- Site Request Forgery
	

3. Project 1 - Book List Razor
	1. Introduction
	2. Project
	3. Runtime Razor Package : install Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation
	4. Create Book Model
	5. Add Connection String and Packages: install EntityFrameworkCore/.SQLserver/Tools
	6. Add Book Table to Database: Migration and update Book into DB
	7. Book Index Get Handler: Add razorpage index.cshtml
	8. Designing Book Index Page
	9. Designing Book Index Page Part 2
	10. Create Book Page Model: Migration and update ISBNBook into DB
	11. Create Book Page UI
	12. Create Book and Validations
	13. Client Side Validations
	14. Edit Book Get Handler
	15. Edit Book UI
	16. Edit Post Handler
	17. Delete Book
	18. Book Get API
	19. DataTables
	20. Delete API Call
	21. Delete Book
	22. Upsert Page Handlers
	23. Upsert Page UI
	
4. Project 2- Spice
	1. Introduction
	2. Create New Project - Spice
	3. MVC architecture
	4. Routing in mvc
	5. Routing with Areas:
		Areas -> Identity/Admin(Controllers - View)/Customer(Controllers - View)
	6. Routing Differences 2.2 vs 3.0
		Routing 2.2
			app.UseMVC(route=>{
				routes.MapRoute{
					name:"Areas",
					template:"{area=Customer}/{Controller=Home}/{action=Index}/{id?}"
				}
			})
			
	7. MVC folders
		install nuget AspNetCore.MVC.Razor.Runtime.compilation
	
	8. Adding Areas to project
		Create 2 Areas Admin + Customer
		
	9. Moving files to make Area Work: 
		View + Controller Home -> Customer Area
		Modified ViewImport and ViewStart
		Delete Model & Data from Admin and Home area
		
	10. Add Database
		Update migration default into DB
		
	11. Startup.cs change in .net core 3.1
			Delelte options => options.SignIn.RequireConfirmedAccount = true
	12. Updating NavBar and Scaffolding Identity
	
	13. Adding Dropdown to NavBar
		added dropdown with bootstrap

5. Category
	1. Introduction
	2. Category Model: add-migration and update CategoryTable into Database
	3. Add Category Controller and Get Action Method
	4. Add Category Index View
	5. Add Background and Images
	6. Category Index View Part 1
	7. Create Button Partial View
		Created and using button partial view 
	8. Create Button Partial View Part 1
	9. Create Button Partial View Part 2
	10. Create and Back to List Button Partial View
	11. Create Category POST Action Method
	12. Table Button Partial View
		created _TableButtonPartial
	13. Edit Category Get Action
	14. Edit Category View
		created _EditAndBacktoListButtonPartial
	15. Edit and Back to List Button partial View
	16. Edit Category POST Action
	17. Delete Category Get Action
	18. Delete Category View
		created _DeleteAndBacktoListButtonPartialView