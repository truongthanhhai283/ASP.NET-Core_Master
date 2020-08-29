# ASP.NET-Core_Master\

Tip
	Icon: https://www.flaticon.com/free-icon/chili_687851?term=spicy&page=1&position=9
	
	Breadcrumb snippet

Fix: 
	1. 
		a. An unhandled exception occurred while processing the request.
		InvalidOperationException: The model item passed into the ViewDataDictionary is of type 'System.Collections.Generic.List`1[ASP.NET_Core_Spice.Models.Category]',
		but this ViewDataDictionary instance requires a model item of type 'System.Int32'.
		
		b. Error info: Model.Id (int) - Add partial and Not found in the partial tag
		c. Solution: declare model="@item.Id" int partial tag
	
	2. 
		a. An unhandled exception occurred while processing the request.
			NullReferenceException: Object reference not set to an instance of an object.
			ASP.NET_Core_Spice.Areas.Admin.Controllers.SubCategoryController.Edit(int id, SubCategoryAndCategoryViewModel model) in SubCategoryController.cs, line 134

			Stack Query Cookies Headers Routing
			NullReferenceException: Object reference not set to an instance of an object.
			ASP.NET_Core_Spice.Areas.Admin.Controllers.SubCategoryController.Edit(int id, SubCategoryAndCategoryViewModel model) in SubCategoryController.cs
			
			subCatFromDb.Name = model.SubCategory.Name;
		b. Solution: Edit POST Error Debugging
	
	3.	a. Work to enum: Severity	Code	Description	Project	File	Line	Suppression State
			Error	CS1014	A get or set accessor expected	ASP.NET_Core_Spice	D:\Project\ASP.NET-Core_Master\ASP.NET_Core_Spice\ASP.NET_Core_Spice\Models\MenuItem.cs	20	Active
		
		b. Solution: convert Enum -> enum
		
	4.  Migration:
		Introducing FOREIGN KEY constraint 'FK_MenuItem_SubCategory_SubCategoryId' on table 'MenuItem' may cause cycles or multiple cascade paths. Specify ON DELETE NO ACTION or ON UPDATE NO ACTION, or modify other FOREIGN KEY constraints.
		Could not create constraint or index. See previous errors.
		
		b. Solution: Dbcontext migration ->  onDelete: ReferentialAction.Cascade); -> onDelete: ReferentialAction.NoAction (ID
		
	5. An unhandled exception occurred while processing the request.
		ArgumentNullException: Value cannot be null. (Parameter 'source')
	
		b. Solution: add ActionName
		
	6. InvalidOperationException: Unable to resolve service for type 'Microsoft.AspNetCore.Identity.RoleManager`1[Microsoft.AspNetCore.Identity.IdentityRole]' 
		while attempting to activate 'ASP.NET_Core_Spice.Areas.Identity.Pages.Account.RegisterModel'.
			
		Solution:  services.AddDefaultIdentity<IdentityUser>() -> services.AddDefaultIdentity<IdentityUser>().AddRoles<IdentityRole>()
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
	19. Delete Category POST Action
	
	20.	Details Category Get Action
	21. Details Category View
	22. Details Category View Partial
		created _DetailsAndBacktoListButtonPartialView
	
6. Sub Category
	1. Introduction
	
	2. Add Sub Category Model
		add-migration and update SubCategoryTable into Database
		
	3. Add Sub Category Index Action Action Method
	
	4. SubCategory Index View
	
	5. SubCategory and Category View Model
		Created ViewModel Folder
		
	6. SubCategory Create GET Action
	
	7. Extension Methods
		Created new folder name Extensions -> createed class IEnumerableExtension + ReflectionExtension
		
	8. SubCategory  Create View Part 1
		Created view create view + dropdown items
		
	9. SubCategory  Create POST Part 1
		
	10. TempData : Error
	
	11. Get Sub Category Action
	
	12. SubCategory Create View Part 2
		updateSubCategoryList
		
	13. SubCategory Edit Get Action
	
	14. SubCategory Edit View
	
	15. Edit Category POST Action
	
	16. Edit POST Error Debugging
	
	17. Assignment 2 - Part 1 - SubCategory Details Get Action 
	
	18. Assignment 2 - Part 2 - SubCategory Delete Get/Post Action + View
	
7. Menu item
	1. Introduction   to Section
	
	2. Add MenuItem Model
		add and update MenuItem into Database
	
	3. Add MenuItem Index Action: IHostingEnvironment -> IWebHosEnvironment
		changed IWebHosEnvironment (startup) -> IHostingEnvironment
	
	4. MenuItem Index View
	
	5. MeniItem View Model and Create GET
	
	6. MenuItem Create View Part 1
	
	7. MenuItem TinyMce Plugin
		https://www.tiny.cloud/my-account/dashboard/
	
	8. MenuItem Create View Part 2
		
	9. MenuItem Create POST Part 1
	
	10. MenuItem Create POST Part 2
	
	11. MenuItem Edit GET Action
	
	12. MenuItem Edit View
	
	13. MenuItem Edit POST Action Method
	
	14. Assignment 3 - Part 1 -  MenuItem Details
	
	15. Assignment 3 - Part 2 -  MenuItem Delete
	
	16. Reviews
	
8. Coupon
	1. Introduction
	
	2. Add coupon Model
		add-migration and update addCouponTableIntoDatabase
	
	3. Coupon Index View and Actions
	
	4. Coupon Create View and GET Action
	
	5. Coupon Create POST Action Method - savine image into database
		multipe selection image saving into database
		
	6. Assignment 4 - Part 1 - Edit Get action
	
	7. Assignment 4 - Part 2 - Edit POST action
	
	8. Assignment 4 - Part 3 - Details action
	
	9. Assignment 4 - Part 4 - Delete action
	
	10. Assignment 4 - Part 5 - Fix Something in MeniItem part
	
9. Landing Page
	1. Introduction
	
	2. Index View Model
	
	3. Home Index Action
	
	4. Home Page
	
	5. Home View Designing Part 1
	
	6. Home View Designing Part 2
	
	7. Home View Designing Part 3
	
	8. Home View Designing Part 4
	
	9. Home View Designing Part 5
	
	10. Home View Designing Part 6
	
10. Users Registration
	1. Introduction
	
	2. Add Properties to Identity User
		add-migration addApplicationUserTableIntoDatabase
		Modified Register.cshtml.cs
		
	3. Changes To Register Page
	
	4. Register Page POST Handler Part 1
	
	6. Register Page POST Handler Part 2
		
	7. LoginRegister Page Error
	
	8. Users Controller
	
	9. Users Index Action and View
	
	10. Radio Buttons for Roles
	
	11. Register Employee Accounts
	
	12. Lock and Unlock Users
	
	13. Authorization Update
	
	14. Authorization
	
	15. Modifying Display NavBar
	
11. Shopping Cart
	1. Introduction
	
	2. Add Shopping Cart Model
		add-migration and update addShoppingCartTableIntoDatabase
	
	3. Add Details Get Action Method
	
	4. Details View Part 1