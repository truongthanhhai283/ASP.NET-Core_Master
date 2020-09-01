# ASP.NET-Core_Master\

Tips
	Icon: https://www.flaticon.com/free-icon/chili_687851?term=spicy&page=1&position=9
	
	Breadcrumb snippet
	
	ConvertToRawHtml
		public static string ConvertToRawHtml(string source)
		{
		char[] array = new char[source.Length];
		int arrayIndex = 0;
		bool inside = false;

		for (int i = 0; i < source.Length; i++)
		{
			char let = source[i];
			if (let == '<')
			{
				inside = true;
				continue;
			}
			if (let == '>')
			{
				inside = false;
				continue;
			}
			if (!inside)
			{
				array[arrayIndex] = let;
				arrayIndex++;
			}
		}
			return new string(array, 0, arrayIndex);
		}

	Stripe: https://dashboard.stripe.com/test/apikeys, https://stripe.com/docs/testing
	
	jQuery Modal

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
			
		Solution:  services.AddDefaultIdentity<IdentityUser>() -> services.AddDefaultIdentity<IdentityUser>().AddRoles<IdentityRole>()44
		
	7. 	An unhandled exception occurred while processing the request.
		InvalidOperationException: Session has not been configured for this application or request.
		Microsoft.AspNetCore.Http.DefaultHttpContext.get_Session()
		
		b. solution
			add app.UseSession();
			add 
			services.AddSession(options => {
				options.Cookie.IsEssential = true;
                options.IdleTimeout = TimeSpan.FromMinutes(30);
                options.Cookie.HttpOnly = true;
            });
		
	8. An unhandled exception occurred while processing the request.
		NullReferenceException: Object reference not set to an instance of an object.
		
		Solution: change method post -> get

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
	
	5. Details View Part 2
	
	6. Details POST Action
	
	7. Configure Sessions
	
	8. Sessions Part 1
	
	9. Sessions Part 2
	
12. Order
	1. Introduction
	
	2. Order Header Model
		Create OrderHeader Model
		
	3. Order Details Model
		add-migration and update Order And OrderDetails Table Into Database
		
	4. Order Details Cart View Model
		Create Order Details Cart View Model
		
	5. Cart Controller Index Action
	
	6. Shopping Cart Index Part 1
	
	7. Shopping Cart Index Part 2
	
	8. Shopping Cart Index Part 3
	
	9. Apply Coupon
	
	10. Remove Coupon
	
	11. Shopping Cart Count
	
	12. Cart Summary Action Method
	
	13. Order Summary View Part 1
	
	14. Date Picker
	
	15. Add Time Picker
	
	16. Date and Time Relation
	
	17. Order Summary Validations
	
	18. Order Summary Post Part 1
	
	20. Adding Stripe to Project: install nuget Stripe.net
	
	21. Stripe UI
	
	22. Stripe Payment Posting
	
13. Manage Order
	1. Introduction
	
	2. Order Confirm GET Action
	
	3. Order Confirm View
	
	4. Individual Order Details Part 1
	
	5. Individual Order Details Part 2
	
	6. Order History Action Method
	
	7. Order History View Part 1
	
	8. Get Order Details Action (Returns Partial View)
	
	9. Order History View Part 2
	
	10. Order History View Part 3
	
	11. PagingInfo Model
	
	12. PageLinkTagHelper
	
	13. Modify Order History Get Method for Pagination
	
	14. Consume Paging Tag Helper
	
	15. Assignment 5 - Step 1 - Create button Order status Details in order history
	
	16. Assignment 5 - Step 2 - Order status Details tracking on Order History Page
		- create Orderstatuspartial image
		  + Based on the order status displaying its correctspongding images
		  + Add constants image sd
		- Create action GetOrderStatus in orderController that will return partial view _orderStatus
		_ Add new modal orderstatus Popup Like OrderDetail
		
	17. Manage Order Action Method
	
	18. Manage Order View Part 1
	
	19. Manage Order View Part 2
	
	20. Manage Order Status Actions

14. Order Pickup
	1. Introduction
	
	2. Order Pickup Get Action Method
	
	3. Order Pickup View Part 1
	
	4. Order Pickup View Part 2
	
	5. Order Pickup Button
	
	6. Order Pickup Completed
	
	7. Roles Login Check
	
	8. Order Pickup cancelled
	
15. Social Logins
	1. Introduction
	
	2. Facebook Login NuGet
		Microsoft.AspNetCore.Authentication.Facebook
		Microsoft.AspNetCore.Authentication.google

	3. Add facebook login to project
		https://developers.facebook.com/apps

			
		
	