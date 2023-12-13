1. Remove request/approval functionality from Branch9 (https://github.com/felipeabajo/ClasesdeskatecomBlazorServer). Comment every reference to Approved/Unapproved Firstname/Lastname. Revert changes in ApplicationUser. Comment every reference to Requests. Bind SfText to user."Properties". Remove variables for properties.
2. Check publicProfile availability on filling the last missing required field (it should become available) without having to refresh the page. Add logic that sets publicProfile to false if any of the requirements is not met. How to do it? I could do it directly on AreRequiredFieldsRequestFilled, in case false,  user.PublicProfile = false. UpdateContext(user).
3. Clean-up in PersonalInformation: remove commented code, remove username,remove functionality other than updating user for lastname, remove call this.OnAfterRenderAsync(true) for firstname and lastname, remove teacherNeverPublicAlert.Refresh(); in every reference except PublicProfileValueChangeHandler. Change alignment of formfields.
4. Clean-up comments. Catch up implementation in Image.
5. Remove UploadStart Event for Setting userId (done with BeforeUpload).
6. Clean-up IsUserImagePathURLNull in ImagePersonalController. Comment references to requests in PersonalInformation.
7. Change name of changeInRequiredFields and areRequiredFieldsFilled for variable and methods.
8. Restore IsUserImagePathURLNull method in ImagePersonalController (since in reality it's used).
9. Info icon por price per hour.
10. Check behaviour when a user removes information from Personal Information. There're probably better UX than this, but for now, it's allowed to remove it, making sure that if the fields are empty, behaviouris as null. Check no longer happening: problem with firstname Field on Edge only, that when focus out (spotted when focused via mouse), it appears a strange shadow. I think it has to do with the box with the suggestions.
11. Change place of info-icon for image (now it's hidden and only displayed if user edits). Included as plain text in Dialog template and icon without hover functionality.
12. NET SDK's Secret Manager tool setup. Secure keys in appsetting with Azure KeyVault. In Project setup - Blazor Server Azure there's a reference to AKV in section Stripe, which is before the next reference to AKV in Keyvault setup section. IDK if I should start by enabling Remote debug (immediatelly before Keyvault Setup) on Azure App Service or I should restore Services/IAKV Service and reference in program.cs. I take a look at this video https://www.youtube.com/watch?v=Czh9cGLVRNA (I used this I think). I think this video tutorial is more complex than what I need. I launch portal.azure.com with my info@felipeabajo.com account for checking billing and status. Try to create a free Azure account. I am not eligible for free account. I create account as new customer (New customers are those who have not previously had an Azure 
account and received 12 months of free services.) I start here: https://learn.microsoft.com/en-us/shows/on-net/secretless-apps-with-net-and-azure-key-vault. SmtpSettings.Password = null in appsettings. Open Secrets manager by right clicking on project and Manage Secrets Manager. Create the JSON object writing the key that was set to null. It does not need any additional config.
13. Feedback for emails sent through Help page added.
14. Add email format constraint to ToEmail in MailRequest. Tried to replicate what there is in InputModel of Register.cshtml.cs [EmailAddress]and the same structure I used for Price of ApplicationUser. It does not show anything, either with or without applying Migration.  I also try putting [Required] [EmailAddress] [Display(Name = "Email")] and the same,
it does not show anything, either with or without applying Migration. 
I try also including [DataType(DataType.EmailAddress)] and [EmailAddress (ErrorMessage = "Invalid email address")]. None of them work.  Fxck. It was because of DataAnnotationsValidator. I am not sure whether migration is required or not, just in case, I apply it. The behaviour is strange, it seems that the message it only appears when the user types and then deletes. Change hide class for hide-message and moved to site.css. Functionality for enabling/disabling Send button added. Add required constraint to every field of MailRequest.
15. InformationMessage and WarningMessage removed since they are not working properly (Enter key input on AutoComplete makes them disappear). TeacherProfileRequestAlert removed. TeacherProfileRequest functionality removed.
16. Review everything that is not used in PersonalInformation.
17. If [Required] is not declared in ApplicationUser, the green appears when Firstname is not null, even though is empty. If [Required] is declared in ApplicationUser, the green appears when Firstname is a non empty string, without migration being required. Fix colors of form fields (e-success class) by using Data Annotations (Required) for fields that are either visible only to teachers or required for both roles. When applied to a field that is null, I get an error suggesting to use IsDBNull, error is fixed by removing the ?, standing for nullable, in the fields. This does not work for the register process of new users. I try to include Firstname in the process of registering a new user, even though, there's no field for Firstname, by including an empty string to Firstname, but the process does not work. When registering the user, the screen just refreshes, removing password and that's all (the problem is adding [Required] to firstname in InputModel and not entering information for that field). If I include nullable to the property of ApplicationUser, the registration process works, then I guess the problem of register process not working is due to whether nullable is declared or not, rather than the usage of DataAnnotations. Then I infere that, to avoid the first exception (IsDBNull) I need the fields not being null, in this case, the cause it is the [Required]. I change Null for an empty string directly in DB and it works. And now, when there're some chars is green, when there are no chars is red.
18. Required added also to Province, Speciality and Price. The only problem (little) that I see has to do with the range of numbers. Even though I put 0 in Register.cshtml.cs automatically gets 1 as a value. I change it to 1 and continue.
19. Fix every await that is suggested in Personal Information. Error about [Required] implementation. Add-Migration and it seems to be fixed.
20. Improve system for gathering Provinces and Specialities. Requirements: provinces and specialities available for editing Personal Information and also for searching teachers. Solution: (simplest I can figure out) put that info into separate classes, using public static list for gathering elements.
21. Province and Speciality refered to common classes in Teacher Search page.
22. Comments removed from Teacher Search page.
23. Create Search bar with two fields: Speciality and Province. Should I create common code for page and bar for Teacher Search? Given that HTML will be different in these two sections, I need to identify the point up to they can share code, .col.form-group is the point. I think could create components for each variable, one for province, one for speciality, instead of doing the changes on the list element of the page I pass a list as a parameter and return a list. In the page, the parameter (list) needs to keep track of filters already applied, thus, I pass the list of selected teachers as a paramater, so the selection gets more specific. I see that I need to update the selectedUserList from child to parent. Tried to do it with CascadingValue but it does not work. I see there's EventCallBack for that and I test that in a separate solution TestPassingValuesFromChildToParentEventCallBack. I left Draft2 with the above mentioned try. Then I create a copy of last push as Draft3 for implementing Child To Parent.
I get to create SpecialitySelector in Draft3, but I realize the functionality is not working properly because the logic for the joints is not correct. I think, write and draw about the process until I get to conclussion that I need to filter from scratch everytime a new filter is applied, I think of doing it through strings. However, I realize that way has a limitation: what happens if the filter is not an string, for example, rating or, price. Then, father tells me I should try list intersections and I think I can get the desired result by assigning one list to each filter and the list that will be shown to the intersection of every list that's associated to a filter. Then, I create a new Draft(4) for trying to get this, without parent-child relationship. I think of having three types of list: RawUsersList (with compulsory and permanent filters:  Role: Teacher, PublicProfile: Public), SelectedUsersList (intersection of lists associated to filters) and FILTERAppliedUsersList. Done.
24. Parent-child relationship for Speciality added.
25. I get to achieve parent-child relationship for both criteria in Draft4. However, when testing I see few problems: 
- When I add parent-child relationship for Province I see that when I select Alicante, it keeps on appearing a user and it should not, and when I remove that filter, it does not appear and it should appear. I decide to go back to previous commits, and I see another problem:
- When I select Spanish and Badajoz it works well (one teacher appears), when I select Spanish and Alicante it also works well (no teacher appears), but when I remove Alicante, it does not work well because one teacher should appear but it does not. I think this problem is due to the conditional if Value not null, otherwise the list does not get updated. This is related but removing the if does not fix the problem (now the code that updates the list is executed but there must be something else). Probably... the filter is entering "" as a filter and of course, there's no teacher with that as a Provice. Fixed. Now I want to commit, but it will override commit in which I added parent-child relationship for Speciality. No worries about the source code because I have it in Draft4. I have a problem, I don't have repository available and IDK how to set up the remote. Quick fix: keep using Draft4 and get the code of Draft4 in Draft6. Replace code of TeacherSearch and remove SpecialitySelector and ProvinceSelector.
26. Restore parent-child relationship for both filters. I detect the problem is that RefreshSelectedUsers List method does not reflect changes to UI immediatelly, but at the next interaction. And when I use StateHasChanged either in RefreshSelectedUsers or directly on OnAfterRenderAsync, that creates an infinite loop. I think the reason for having an infinite loop is using StateHasChanged in the context of 
OnAfterRenderAsync. I need to avoid StateHasChanged calling OnAfterRenderAsync... that's impossible I think. So I figure out different options:
- Given the hint that OnAfterRenderAsync tells about Task (does not re-render on return of tasks), 
make RefreshSelectedUsers an Async method. ❌. This does not avoid the infinite loop.
- Using await for StateHasChanged. ❌. Error.
- Use OnAfterRender instead of OnAfterRenderAsync. ❌. This does not avoid the infinite loop. If I use OnAfterRender and StateHasChanged directly on this method, when I put a filter that does not contain teachers, it works, but the infinite loop keeps happening then I am not sure if the reason is because it's working or the infinite loop itself. Apart from that, when I remove filter, no teachers are displayed. The same if I put the StateHasChanged in RefreshSelectedUsers. This is the  same regardless of whether RefreshSelectedUsers is async or not, as long as it has StateHasChanged both with OnAfterRender and OnAfterRenderAsync. 
- Calling a method from children components instead of using RefreshSelectedUsers OnAfterRenderAsync
(For that I have to search how to use two EventCallBacks in a component). I am using OnAfterRender because I was not able to call two methods from children components. The Error I had is editContext not set, but I guess something else is happening on the background. 
- Calling StateHasChanged from the children components (I don't think this will work because I need StateHasChanged after selectedUsersList has been updated - probably this could work if I bind selectedUsersList also to children Components... IDK). I try to call StateHasChanged after InvokeAsync from Children. I don't get it, when I try to implement the method EventCallBack on TeacherSearch it says it's used two or more times because that's auto-generated by bind... I don't get it... I leave Draft4 with attemps and continue on Draft7.
27. Enable TeacherSearch without being logged in (when this is ready). EditContext uses user, thus, it only works if user is signed in. Try to change this. Options:
- EditContext without user. ✔ (using this)
- Model: Create a class with the required info.
28. TestToastMessage deleted.
29. Get ready Personal Information valid for Users and Teachers. Add Personal Information to Navigation. Hide SfIcon (intended for teachers since it talks about publicProfiles).
30. UI for deleting account created in settings. Remove commented code from PersonalInformation. Remove commented code from site.css.
31. Rename PersonalInformation elements of Dialog, remove this from Edit.
32. Fix UX for Firstname for Users because there's the red color but (required) but not intended to be required. QuickFix: Enter a different Icon saying it's required... but how can I really prove it or hide functionality for that? Options:
- Hide Personal Information (MVP only because UX not very good)
- Separate classes... huge impact. 
- Remove Required from ApplicationUser and try to apply only in PersonalInformation by creating a subclass of ApplicationUser?
33. Put more things in settings page: New box for password, download user data.
34. Fix exception thrown when using  NavigateToCsHtmlPage(Microsoft.JSInterop.JSException). See if I can hide it by commenting throw... attention to Exception box that appears in browser. That's the limit I cannot pass. If the exception is invisible to user.. Go ahead. Easy fixed by removing //await JSRuntime.InvokeAsync<object>("open", page, "_self"); //also valid with other a[target] values and replaced for await JSRuntime.InvokeVoidAsync("open", page, "_self");
35. Remove commented code from LoginDisplay. Inspiration: 
- From AirBnb I like the Search button that expands when user put focus on any of the fields.
- From GitHub when I click on magnifyer and there is no query introduced, focus to form field. and more behaviours but focus on that point. This could be useful for improving UX instead of button disabled. 
Build TeacherSearch bar. It is a form (inline) with two fields (Autocomplete). When user enters query, /teacher-search opens with the results of query. First milestone is building UI of the form. 
I find a navigational problem caused by the decision of the navigation I used. Because the SfAppBar is narrow when user is logged in using big screens, the functionality of searching being logged in with wide devices is not going to have a good UX. QuickFix could be to put just a button with magnifyer icon in these cases that either leads to TeacherSearch page or opens a dialog the way AirBnb unfolds each field. Ignore this case for now and focus on not logged in. UI Scaffold done.
36. Getting query and show teachers in TeachersSearch. //How can I pass search query to that page? I see AutoComplete value is not removed, then I can take it directly from there...
First thing: Access to LoginDisplay.SpecialityAutoComplete.Value and LoginDisplay.ProvinceAutoComplete.Value from TeacherSearch. 
Options:
- Using public static properties in LoginDisplay ✔ It works.
The problem with this is that if navigation is already at /teacher-search, NavigateTo works but the selectedUsers is not updated because OnInitialized does not get executed. Solutions for this:
- Move what's in OnInitialized to OnAfterRender.
It could be a good solution but again I find the problem that I need StateHasChanged and that create and endless loop. 
- Hide Search functionality in AppBAR (not good at all for UX). ✔ Para adelante
- Calling a method from LoginDisplay that starts the logic. I try but I don't really know how to call it. Parent-child relationship through EventCallBacks (ñi - I don't have that relationship currently).
37. Change names AutocompleteObj in TeacherSearch. Add text for TeacherSearch when there are no teachers available for a query.
38. Remove icons from LoginDisplay (help, register and login). Include responsiveness for SearchBar.Quick implementation: hide AutoComplete fields for small screens. Problem: if they are null, the button will not take the user to the correct place. Try to make space by removing letters from every element of AppBar that have icons and remove non-essential elements, see next step. Also hide Login and register buttons.
39. Remove commented code on UserCard. New iteration on UserCard.
40. Restore LikeTeacher functionality.
41. Avoid users saving if they are not logged ideally by conditionally opening a dialog inviting users to register or login in case they are not. For now, just hiding button if not logged in. Enable access to Teacher Search for logged in users by including a link to /teacher search in NavMenu
